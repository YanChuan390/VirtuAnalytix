using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public static class FileBasedPrefs
{
	private const string SaveFileName = "saveData.txt";

	private const bool ScrambleSaveData = true;

	private const string EncryptionCodeword = "CHANGE ME TO YOUR OWN RANDOM STRING";

	private const bool AutoSaveData = false;

	private static FileBasedPrefsSaveFileModel _latestData;

	private const string String_Empty = "";

	private static string UserSpecID = "";

	public static void InitUserSpecID(string UserID)
	{
		UserSpecID = "UID_" + UserID;
	}

	public static void SetString(string key, string value = "")
	{
		AddDataToSaveFile(UserSpecID + key, value);
	}

	public static string GetString(string key, string defaultValue = "")
	{
		return (string)GetDataFromSaveFile(UserSpecID + key, defaultValue);
	}

	public static void SetInt(string key, int value = 0)
	{
		AddDataToSaveFile(UserSpecID + key, value);
	}

	public static int GetInt(string key, int defaultValue = 0)
	{
		return (int)GetDataFromSaveFile(UserSpecID + key, defaultValue);
	}

	public static void SetFloat(string key, float value = 0f)
	{
		AddDataToSaveFile(UserSpecID + key, value);
	}

	public static float GetFloat(string key, float defaultValue = 0f)
	{
		return (float)GetDataFromSaveFile(UserSpecID + key, defaultValue);
	}

	public static void SetBool(string key, bool value = false)
	{
		AddDataToSaveFile(UserSpecID + key, value);
	}

	public static bool GetBool(string key, bool defaultValue = false)
	{
		return (bool)GetDataFromSaveFile(UserSpecID + key, defaultValue);
	}

	public static bool HasKey(string key)
	{
		return GetSaveFile().HasKey(UserSpecID + key);
	}

	public static bool HasKeyForString(string key)
	{
		return GetSaveFile().HasKeyFromObject(UserSpecID + key, string.Empty);
	}

	public static bool HasKeyForInt(string key)
	{
		return GetSaveFile().HasKeyFromObject(UserSpecID + key, 0);
	}

	public static bool HasKeyForFloat(string key)
	{
		return GetSaveFile().HasKeyFromObject(UserSpecID + key, 0f);
	}

	public static bool HasKeyForBool(string key)
	{
		return GetSaveFile().HasKeyFromObject(UserSpecID + key, false);
	}

	public static void DeleteKey(string key)
	{
		GetSaveFile().DeleteKey(UserSpecID + key);
		SaveSaveFile();
	}

	public static void DeleteString(string key)
	{
		GetSaveFile().DeleteString(UserSpecID + key);
		SaveSaveFile();
	}

	public static void DeleteInt(string key)
	{
		GetSaveFile().DeleteInt(UserSpecID + key);
		SaveSaveFile();
	}

	public static void DeleteFloat(string key)
	{
		GetSaveFile().DeleteFloat(UserSpecID + key);
		SaveSaveFile();
	}

	public static void DeleteBool(string key)
	{
		GetSaveFile().DeleteBool(UserSpecID + key);
		SaveSaveFile();
	}

	public static void DeleteAll()
	{
		WriteToSaveFile(JsonUtility.ToJson(new FileBasedPrefsSaveFileModel()));
		_latestData = new FileBasedPrefsSaveFileModel();
	}

	public static void OverwriteLocalSaveFile(string data)
	{
		WriteToSaveFile(data);
		_latestData = null;
	}

	private static FileBasedPrefsSaveFileModel GetSaveFile()
	{
		CheckSaveFileExists();
		if (_latestData == null)
		{
			string data = File.ReadAllText(GetSaveFilePath());
			data = DataScrambler(data);
			try
			{
				_latestData = JsonUtility.FromJson<FileBasedPrefsSaveFileModel>(data);
			}
			catch (ArgumentException ex)
			{
				UnityEngine.Debug.LogException(new Exception("SAVE FILE IN WRONG FORMAT, CREATING NEW SAVE FILE : " + ex.Message));
				DeleteAll();
			}
		}
		return _latestData;
	}

	public static string GetSaveFilePath()
	{
		return System.IO.Path.Combine(Application.persistentDataPath, "saveData.txt");
	}

	public static string GetSaveFileAsJson()
	{
		CheckSaveFileExists();
		return File.ReadAllText(GetSaveFilePath());
	}

	private static object GetDataFromSaveFile(string key, object defaultValue)
	{
		return GetSaveFile().GetValueFromKey(UserSpecID + key, defaultValue);
	}

	private static void AddDataToSaveFile(string key, object value)
	{
		GetSaveFile().UpdateOrAddData(UserSpecID + key, value);
		SaveSaveFile();
	}

	public static void ManualySave()
	{
		SaveSaveFile(manualSave: true);
	}

	public static void SaveSaveFile(bool manualSave = false)
	{
		if (manualSave)
		{
			WriteToSaveFile(JsonUtility.ToJson(GetSaveFile()));
		}
	}

	private static void WriteToSaveFile(string data)
	{
		StreamWriter streamWriter = new StreamWriter(GetSaveFilePath());
		data = DataScrambler(data);
		streamWriter.Write(data);
		streamWriter.Close();
	}

	private static void CheckSaveFileExists()
	{
		if (!DoesSaveFileExist())
		{
			CreateNewSaveFile();
		}
	}

	private static bool DoesSaveFileExist()
	{
		return File.Exists(GetSaveFilePath());
	}

	private static void CreateNewSaveFile()
	{
		WriteToSaveFile(JsonUtility.ToJson(new FileBasedPrefsSaveFileModel()));
	}

	private static string DataScrambler(string data)
	{
		string text = "";
		for (int i = 0; i < data.Length; i++)
		{
			text += (char)(data[i] ^ "CHANGE ME TO YOUR OWN RANDOM STRING"[i % "CHANGE ME TO YOUR OWN RANDOM STRING".Length]);
		}
		return text;
	}
}
[Serializable]
public class FileBasedPrefsSaveFileModel
{
	[Serializable]
	public class StringItem
	{
		public string Key;

		public string Value;

		public StringItem(string K, string V)
		{
			Key = K;
			Value = V;
		}
	}

	[Serializable]
	public class IntItem
	{
		public string Key;

		public int Value;

		public IntItem(string K, int V)
		{
			Key = K;
			Value = V;
		}
	}

	[Serializable]
	public class FloatItem
	{
		public string Key;

		public float Value;

		public FloatItem(string K, float V)
		{
			Key = K;
			Value = V;
		}
	}

	[Serializable]
	public class BoolItem
	{
		public string Key;

		public bool Value;

		public BoolItem(string K, bool V)
		{
			Key = K;
			Value = V;
		}
	}

	public StringItem[] StringData = new StringItem[0];

	public IntItem[] IntData = new IntItem[0];

	public FloatItem[] FloatData = new FloatItem[0];

	public BoolItem[] BoolData = new BoolItem[0];

	public object GetValueFromKey(string key, object defaultValue)
	{
		if (defaultValue is string)
		{
			for (int i = 0; i < StringData.Length; i++)
			{
				if (StringData[i].Key.Equals(key))
				{
					return StringData[i].Value;
				}
			}
		}
		if (defaultValue is int)
		{
			for (int j = 0; j < IntData.Length; j++)
			{
				if (IntData[j].Key.Equals(key))
				{
					return IntData[j].Value;
				}
			}
		}
		if (defaultValue is float)
		{
			for (int k = 0; k < FloatData.Length; k++)
			{
				if (FloatData[k].Key.Equals(key))
				{
					return FloatData[k].Value;
				}
			}
		}
		if (defaultValue is bool)
		{
			for (int l = 0; l < BoolData.Length; l++)
			{
				if (BoolData[l].Key.Equals(key))
				{
					return BoolData[l].Value;
				}
			}
		}
		return defaultValue;
	}

	public void UpdateOrAddData(string key, object value)
	{
		if (HasKeyFromObject(key, value))
		{
			SetValueForExistingKey(key, value);
		}
		else
		{
			SetValueForNewKey(key, value);
		}
	}

	private void SetValueForNewKey(string key, object value)
	{
		if (value is string)
		{
			List<StringItem> list = StringData.ToList();
			list.Add(new StringItem(key, (string)value));
			StringData = list.ToArray();
		}
		if (value is int)
		{
			List<IntItem> list2 = IntData.ToList();
			list2.Add(new IntItem(key, (int)value));
			IntData = list2.ToArray();
		}
		if (value is float)
		{
			List<FloatItem> list3 = FloatData.ToList();
			list3.Add(new FloatItem(key, (float)value));
			FloatData = list3.ToArray();
		}
		if (value is bool)
		{
			List<BoolItem> list4 = BoolData.ToList();
			list4.Add(new BoolItem(key, (bool)value));
			BoolData = list4.ToArray();
		}
	}

	private void SetValueForExistingKey(string key, object value)
	{
		if (value is string)
		{
			for (int i = 0; i < StringData.Length; i++)
			{
				if (StringData[i].Key.Equals(key))
				{
					StringData[i].Value = (string)value;
				}
			}
		}
		if (value is int)
		{
			for (int j = 0; j < IntData.Length; j++)
			{
				if (IntData[j].Key.Equals(key))
				{
					IntData[j].Value = (int)value;
				}
			}
		}
		if (value is float)
		{
			for (int k = 0; k < FloatData.Length; k++)
			{
				if (FloatData[k].Key.Equals(key))
				{
					FloatData[k].Value = (float)value;
				}
			}
		}
		if (!(value is bool))
		{
			return;
		}
		for (int l = 0; l < BoolData.Length; l++)
		{
			if (BoolData[l].Key.Equals(key))
			{
				BoolData[l].Value = (bool)value;
			}
		}
	}

	public bool HasKeyFromObject(string key, object value)
	{
		if (value is string)
		{
			for (int i = 0; i < StringData.Length; i++)
			{
				if (StringData[i].Key.Equals(key))
				{
					return true;
				}
			}
		}
		if (value is int)
		{
			for (int j = 0; j < IntData.Length; j++)
			{
				if (IntData[j].Key.Equals(key))
				{
					return true;
				}
			}
		}
		if (value is float)
		{
			for (int k = 0; k < FloatData.Length; k++)
			{
				if (FloatData[k].Key.Equals(key))
				{
					return true;
				}
			}
		}
		if (value is bool)
		{
			for (int l = 0; l < BoolData.Length; l++)
			{
				if (BoolData[l].Key.Equals(key))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void DeleteKey(string key)
	{
		for (int i = 0; i < StringData.Length; i++)
		{
			if (StringData[i].Key.Equals(key))
			{
				List<StringItem> list = StringData.ToList();
				list.RemoveAt(i);
				StringData = list.ToArray();
			}
		}
		for (int j = 0; j < IntData.Length; j++)
		{
			if (IntData[j].Key.Equals(key))
			{
				List<IntItem> list2 = IntData.ToList();
				list2.RemoveAt(j);
				IntData = list2.ToArray();
			}
		}
		for (int k = 0; k < FloatData.Length; k++)
		{
			if (FloatData[k].Key.Equals(key))
			{
				List<FloatItem> list3 = FloatData.ToList();
				list3.RemoveAt(k);
				FloatData = list3.ToArray();
			}
		}
		for (int l = 0; l < BoolData.Length; l++)
		{
			if (BoolData[l].Key.Equals(key))
			{
				List<BoolItem> list4 = BoolData.ToList();
				list4.RemoveAt(l);
				BoolData = list4.ToArray();
			}
		}
	}

	public void DeleteString(string key)
	{
		for (int i = 0; i < StringData.Length; i++)
		{
			if (StringData[i].Key.Equals(key))
			{
				List<StringItem> list = StringData.ToList();
				list.RemoveAt(i);
				StringData = list.ToArray();
			}
		}
	}

	public void DeleteInt(string key)
	{
		for (int i = 0; i < IntData.Length; i++)
		{
			if (IntData[i].Key.Equals(key))
			{
				List<IntItem> list = IntData.ToList();
				list.RemoveAt(i);
				IntData = list.ToArray();
			}
		}
	}

	public void DeleteFloat(string key)
	{
		for (int i = 0; i < FloatData.Length; i++)
		{
			if (FloatData[i].Key.Equals(key))
			{
				List<FloatItem> list = FloatData.ToList();
				list.RemoveAt(i);
				FloatData = list.ToArray();
			}
		}
	}

	public void DeleteBool(string key)
	{
		for (int i = 0; i < BoolData.Length; i++)
		{
			if (BoolData[i].Key.Equals(key))
			{
				List<BoolItem> list = BoolData.ToList();
				list.RemoveAt(i);
				BoolData = list.ToArray();
			}
		}
	}

	public bool HasKey(string key)
	{
		for (int i = 0; i < StringData.Length; i++)
		{
			if (StringData[i].Key.Equals(key))
			{
				return true;
			}
		}
		for (int j = 0; j < IntData.Length; j++)
		{
			if (IntData[j].Key.Equals(key))
			{
				return true;
			}
		}
		for (int k = 0; k < FloatData.Length; k++)
		{
			if (FloatData[k].Key.Equals(key))
			{
				return true;
			}
		}
		for (int l = 0; l < BoolData.Length; l++)
		{
			if (BoolData[l].Key.Equals(key))
			{
				return true;
			}
		}
		return false;
	}
}
public class Test : MonoBehaviour
{
	public bool SpeedTest;

	public bool DeleteAtStart;

	private void Start()
	{
		if (DeleteAtStart)
		{
			FileBasedPrefs.DeleteAll();
		}
		if (SpeedTest)
		{
			for (int i = 0; i < 10; i++)
			{
				FileBasedPrefs.SetString("SpeedTest" + i, "SpeedTest" + i);
			}
		}
		else
		{
			Invoke("StringTests", 0.25f);
			Invoke("IntTests", 0.5f);
			Invoke("FloatTests", 0.75f);
			Invoke("BoolTests", 1f);
			Invoke("GeneralTests", 1.25f);
		}
	}

	private void Update()
	{
		if (SpeedTest)
		{
			for (int i = 0; i < 10; i++)
			{
				FileBasedPrefs.SetString("SpeedTest" + i, "SpeedTest" + i);
			}
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			FileBasedPrefs.ManualySave();
		}
	}

	private void StringTests()
	{
		FileBasedPrefs.SetString("test", "test");
		if (!FileBasedPrefs.GetString("test").Equals("test"))
		{
			UnityEngine.Debug.LogException(new Exception("SetStringFailed"));
			return;
		}
		FileBasedPrefs.SetString("test", "test2");
		if (!FileBasedPrefs.GetString("test").Equals("test2"))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceStringFailed"));
			return;
		}
		if (!FileBasedPrefs.HasKeyForString("test"))
		{
			UnityEngine.Debug.LogException(new Exception("HasKeyForStringFailed"));
			return;
		}
		FileBasedPrefs.DeleteString("test");
		if (!FileBasedPrefs.GetString("test").Equals(""))
		{
			UnityEngine.Debug.LogException(new Exception("DeleteStringFailed"));
			return;
		}
		FileBasedPrefs.SetString("test", "test33");
		if (!FileBasedPrefs.GetString("test").Equals("test33"))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceStringFailed"));
		}
		else
		{
			UnityEngine.Debug.Log("String Tests Passed");
		}
	}

	private void IntTests()
	{
		FileBasedPrefs.SetInt("test", 1);
		if (!FileBasedPrefs.GetInt("test").Equals(1))
		{
			UnityEngine.Debug.LogException(new Exception("SetIntFailed"));
			return;
		}
		FileBasedPrefs.SetInt("test", 2);
		if (!FileBasedPrefs.GetInt("test").Equals(2))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceIntFailed"));
			return;
		}
		if (!FileBasedPrefs.HasKeyForInt("test"))
		{
			UnityEngine.Debug.LogException(new Exception("HasKeyForIntFailed"));
			return;
		}
		FileBasedPrefs.DeleteInt("test");
		if (!FileBasedPrefs.GetInt("test").Equals(0))
		{
			UnityEngine.Debug.LogException(new Exception("DeleteIntFailed"));
			return;
		}
		FileBasedPrefs.SetInt("test", 333);
		if (!FileBasedPrefs.GetInt("test").Equals(333))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceIntFailed"));
		}
		else
		{
			UnityEngine.Debug.Log("Int Tests Passed");
		}
	}

	private void FloatTests()
	{
		FileBasedPrefs.SetFloat("test", 1f);
		if (!FileBasedPrefs.GetFloat("test").Equals(1f))
		{
			UnityEngine.Debug.LogException(new Exception("SetFloatFailed"));
			return;
		}
		FileBasedPrefs.SetFloat("test", 2f);
		if (!FileBasedPrefs.GetFloat("test").Equals(2f))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceFloatFailed"));
			return;
		}
		if (!FileBasedPrefs.HasKeyForFloat("test"))
		{
			UnityEngine.Debug.LogException(new Exception("HasKeyForFloatFailed"));
			return;
		}
		FileBasedPrefs.DeleteFloat("test");
		if (!FileBasedPrefs.GetFloat("test").Equals(0f))
		{
			UnityEngine.Debug.LogException(new Exception("DeleteFloatFailed"));
			return;
		}
		FileBasedPrefs.SetFloat("test", 333.333f);
		if (!FileBasedPrefs.GetFloat("test").Equals(333.333f))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceFloatFailed"));
		}
		else
		{
			UnityEngine.Debug.Log("Float Tests Passed");
		}
	}

	private void BoolTests()
	{
		FileBasedPrefs.SetBool("test", value: true);
		if (!FileBasedPrefs.GetBool("test").Equals(obj: true))
		{
			UnityEngine.Debug.LogException(new Exception("SetBoolFailed"));
			return;
		}
		FileBasedPrefs.SetBool("test", value: true);
		if (!FileBasedPrefs.GetBool("test").Equals(obj: true))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceBoolFailed"));
			return;
		}
		if (!FileBasedPrefs.HasKeyForBool("test"))
		{
			UnityEngine.Debug.LogException(new Exception("HasKeyForBoolFailed"));
			return;
		}
		FileBasedPrefs.DeleteBool("test");
		if (!FileBasedPrefs.GetBool("test").Equals(obj: false))
		{
			UnityEngine.Debug.LogException(new Exception("DeleteBoolFailed"));
			return;
		}
		FileBasedPrefs.SetBool("test", value: true);
		if (!FileBasedPrefs.GetBool("test").Equals(obj: true))
		{
			UnityEngine.Debug.LogException(new Exception("ReplaceBoolFailed"));
		}
		else
		{
			UnityEngine.Debug.Log("Bool Tests Passed");
		}
	}

	private void GeneralTests()
	{
		FileBasedPrefs.SetString("test", "test");
		if (!FileBasedPrefs.HasKey("test"))
		{
			UnityEngine.Debug.LogException(new Exception("HasKeyFailed"));
		}
		else
		{
			UnityEngine.Debug.Log("General Tests Passed");
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public Color bloomThresholdColor = Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((from == to) ? null : from, to, screenBlend, (from == to) ? 7 : 3);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture obj = ((i == 0) ? temporary3 : temporary2);
				Graphics.Blit(obj, temporary4, separableBlurMaterial);
				obj.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution == Resolution.Low) ? 4 : 2);
			float num2 = ((resolution == Resolution.Low) ? 0.5f : 1f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Range(0f, 10f)]
		public int iterations = 3;

		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(blurShader);
					m_Material.hideFlags = HideFlags.DontSave;
				}
				return m_Material;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!blurShader || !material.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
			float num = 0.5f + (float)iteration * blurSpread;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
			float num = 1f;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int width = source.width / 4;
			int height = source.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			DownSample4x(source, renderTexture);
			for (int i = 0; i < iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4[] currentStereoViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private Matrix4x4[] prevStereoViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
			if (_camera.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = _camera.GetStereoViewMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 stereoProjectionMatrix = _camera.GetStereoProjectionMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					stereoProjectionMatrix = GL.GetGPUProjectionMatrix(stereoProjectionMatrix, renderIntoTexture: true);
					currentStereoViewProjMat[i] = stereoProjectionMatrix * stereoViewMatrix;
				}
			}
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			currentStereoViewProjMat = new Matrix4x4[2];
			prevStereoViewProjMat = new Matrix4x4[2];
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			if (_camera.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2]
				{
					Matrix4x4.Inverse(currentStereoViewProjMat[0]),
					Matrix4x4.Inverse(currentStereoViewProjMat[1])
				};
				Matrix4x4 value = prevStereoViewProjMat[0] * array[0];
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined0", value);
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined1", prevStereoViewProjMat[1] * array[1]);
			}
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, "");
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
			prevStereoViewProjMat[0] = currentStereoViewProjMat[0];
			prevStereoViewProjMat[1] = currentStereoViewProjMat[1];
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public Color selectiveFromColor = Color.white;

		public Color selectiveToColor = Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = "";

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = "";
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			if (tex2d.height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					UnityEngine.Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = "";
					return;
				}
				Color[] pixels = temp2DTex.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				UnityEngine.Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		[Range(0f, 0.999f)]
		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		[Range(0f, 1f)]
		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		private RenderTexture[] adaptRenderTex = new RenderTexture[2];

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				if (m_materialLum == null)
				{
					m_materialLum = new Material(shaderLum);
					m_materialLum.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialLum;
			}
		}

		protected Material materialReduce
		{
			get
			{
				if (m_materialReduce == null)
				{
					m_materialReduce = new Material(shaderReduce);
					m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialReduce;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				if (m_materialAdapt == null)
				{
					m_materialAdapt = new Material(shaderAdapt);
					m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialAdapt;
			}
		}

		protected Material materialApply
		{
			get
			{
				if (m_materialApply == null)
				{
					m_materialApply = new Material(shaderApply);
					m_materialApply.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialApply;
			}
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
			{
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!adaptRenderTex[i])
				{
					adaptRenderTex[i] = new RenderTexture(1, 1, 0);
					adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
				adaptRenderTex[i] = null;
			}
			if ((bool)m_materialLum)
			{
				UnityEngine.Object.DestroyImmediate(m_materialLum);
			}
			if ((bool)m_materialReduce)
			{
				UnityEngine.Object.DestroyImmediate(m_materialReduce);
			}
			if ((bool)m_materialAdapt)
			{
				UnityEngine.Object.DestroyImmediate(m_materialAdapt);
			}
			if ((bool)m_materialApply)
			{
				UnityEngine.Object.DestroyImmediate(m_materialApply);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / 1, source.height / 1);
			Graphics.Blit(source, renderTexture, materialLum);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, materialReduce);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			CalculateAdaptation(renderTexture);
			materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
			Graphics.Blit(source, destination, materialApply);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void CalculateAdaptation(Texture curTexture)
		{
			int num = curAdaptIndex;
			curAdaptIndex = (curAdaptIndex + 1) % 2;
			float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
			value = Mathf.Clamp(value, 0.01f, 1f);
			materialAdapt.SetTexture("_CurTex", curTexture);
			materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
			Graphics.SetRenderTarget(adaptRenderTex[curAdaptIndex]);
			GL.Clear(clearDepth: false, clearColor: true, Color.black);
			Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 0.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		private Camera cachedCamera;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			cachedCamera = GetComponent<Camera>();
			cachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return cachedCamera.WorldToViewportPoint((worldDist - cachedCamera.nearClipPlane) * cachedCamera.transform.forward + cachedCamera.transform.position).z / (cachedCamera.farClipPlane - cachedCamera.nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = (focalTransform ? (cachedCamera.WorldToViewportPoint(focalTransform.position).z / cachedCamera.farClipPlane) : FocalDistance01(focalLength));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, 1f / (1f - aperture) - 1f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((internalBlurWidth < 0.1f) ? 0.1f : internalBlurWidth);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", nearBlur ? renderTexture4 : null);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount == BlurSampleCount.High || blurSampleCount == BlurSampleCount.Medium) ? 17 : 11);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount == BlurSampleCount.High) ? 18 : 12);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = (bokeh ? BOKEH_EXTRA_BLUR : 1f);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = (objectFocus ? (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane) : FocalDistance01(focalPoint));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4(simpleTweakMode ? (1f / focalStartCurve) : focalStartCurve, simpleTweakMode ? (1f / focalEndCurve) : focalEndCurve, num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, flag ? foregroundTexture : destination, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public Color edgesOnlyBgColor = Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform obj = component.transform;
			Vector3[] array = new Vector3[4];
			component.CalculateFrustumCorners(new Rect(0f, 0f, 1f, 1f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 vector = obj.TransformVector(array[0]);
			Vector3 vector2 = obj.TransformVector(array[1]);
			Vector3 vector3 = obj.TransformVector(array[2]);
			Vector3 vector4 = obj.TransformVector(array[3]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector2);
			identity.SetRow(3, vector3);
			Vector3 position = obj.position;
			float num = position.y - height;
			float z = ((num <= 0f) ? 1f : 0f);
			float y = (excludeFarPixels ? 1f : 2f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = (flag ? (fogEndDistance - fogStartDistance) : 0f);
			float num3 = ((Mathf.Abs(num2) > 0.0001f) ? (1f / num2) : 0f);
			Vector4 value = default(Vector4);
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = (flag ? (0f - num3) : 0f);
			value.w = (flag ? (fogEndDistance * num3) : 0f);
			fogMaterial.SetVector("_SceneFogParams", value);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num4 = 0;
			Graphics.Blit(pass: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, mat: fogMaterial);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		[Range(-1f, 1f)]
		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			base.material.SetFloat("_RampOffset", rampOffset);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(shader);
					m_Material.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_Material;
			}
		}

		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shader || !shader.isSupported)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}
	}
	[AddComponentMenu("")]
	public class ImageEffects
	{
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
			if (source.texelSize.y < 0f)
			{
				center.y = 1f - center.y;
				angle = 0f - angle;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
			material.SetMatrix("_RotationMatrix", value);
			material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
			material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
			Graphics.Blit(source, destination, material);
		}

		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest);
		}

		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest, material);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[RequireComponent(typeof(Camera))]
	public class MotionBlur : ImageEffectBase
	{
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
			base.Start();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(accumTexture);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
			{
				UnityEngine.Object.DestroyImmediate(accumTexture);
				accumTexture = new RenderTexture(source.width, source.height, 0);
				accumTexture.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(source, accumTexture);
			}
			if (extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
				accumTexture.MarkRestoreExpected();
				Graphics.Blit(accumTexture, temporary);
				Graphics.Blit(temporary, accumTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
			base.material.SetTexture("_MainTex", accumTexture);
			base.material.SetFloat("_AccumOrig", 1f - blurAmount);
			accumTexture.MarkRestoreExpected();
			Graphics.Blit(source, accumTexture, base.material);
			Graphics.Blit(accumTexture, destination);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					UnityEngine.Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, monochrome ? 3 : 2);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", monochrome ? (Vector3.one * monochromeTiling) : tiling);
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		public bool monochrome = true;

		private bool rgbFallback;

		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		public Texture grainTexture;

		public Texture scratchTexture;

		public Shader shaderRGB;

		public Shader shaderYUV;

		private Material m_MaterialRGB;

		private Material m_MaterialYUV;

		private float scratchTimeLeft;

		private float scratchX;

		private float scratchY;

		protected Material material
		{
			get
			{
				if (m_MaterialRGB == null)
				{
					m_MaterialRGB = new Material(shaderRGB);
					m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (m_MaterialYUV == null && !rgbFallback)
				{
					m_MaterialYUV = new Material(shaderYUV);
					m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				if (rgbFallback || monochrome)
				{
					return m_MaterialRGB;
				}
				return m_MaterialYUV;
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (shaderRGB == null || shaderYUV == null)
			{
				UnityEngine.Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!shaderYUV.isSupported)
			{
				rgbFallback = true;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
			}
			if ((bool)m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
			}
		}

		private void SanitizeParameters()
		{
			grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
			grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
			scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
			scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
			scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
			scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
			grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			SanitizeParameters();
			if (scratchTimeLeft <= 0f)
			{
				scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
				scratchX = UnityEngine.Random.value;
				scratchY = UnityEngine.Random.value;
			}
			scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", grainTexture);
			material.SetTexture("_ScratchTex", scratchTexture);
			float num = 1f / grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		private List<Material> createdMaterials = new List<Material>();

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		private void OnDestroy()
		{
			RemoveCreatedMaterials();
		}

		private void RemoveCreatedMaterials()
		{
			while (createdMaterials.Count > 0)
			{
				Material obj = createdMaterials[0];
				createdMaterials.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			UnityEngine.Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			UnityEngine.Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			UnityEngine.Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				array[num + 3] = (array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f))));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array2[num + 3] = new Vector2(1f, 1f);
				array3[num] = new Vector2(num4, num5);
				array3[num + 1] = new Vector2(num4, num5);
				array3[num + 2] = new Vector2(num4, num5);
				array3[num + 3] = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", value);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / projectionMatrix[0, 0], -2f / projectionMatrix[1, 1], (1f - projectionMatrix[0, 2]) / projectionMatrix[0, 0], (1f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(-2f / stereoProjectionMatrix[0, 0], -2f / stereoProjectionMatrix[1, 1], (1f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[0, 0], (1f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 1]);
				Vector4 value3 = new Vector4(-2f / stereoProjectionMatrix2[0, 0], -2f / stereoProjectionMatrix2[1, 1], (1f - stereoProjectionMatrix2[0, 2]) / stereoProjectionMatrix2[0, 0], (1f + stereoProjectionMatrix2[1, 2]) / stereoProjectionMatrix2[1, 1]);
				aoMaterial.SetVector("_ProjInfoLeft", value2);
				aoMaterial.SetVector("_ProjInfoRight", value3);
			}
			aoMaterial.SetVector("_ProjInfo", value);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			Low,
			Medium,
			High
		}

		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		public SSAOSamples m_SampleCount = SSAOSamples.Medium;

		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		[Range(0f, 4f)]
		public int m_Blur = 2;

		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		public Shader m_SSAOShader;

		private Material m_SSAOMaterial;

		public Texture2D m_RandomTexture;

		private bool m_Supported;

		private static Material CreateMaterial(Shader shader)
		{
			if (!shader)
			{
				return null;
			}
			return new Material(shader)
			{
				hideFlags = HideFlags.HideAndDontSave
			};
		}

		private static void DestroyMaterial(Material mat)
		{
			if ((bool)mat)
			{
				UnityEngine.Object.DestroyImmediate(mat);
				mat = null;
			}
		}

		private void OnDisable()
		{
			DestroyMaterial(m_SSAOMaterial);
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				m_Supported = false;
				base.enabled = false;
				return;
			}
			CreateMaterials();
			if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
			{
				m_Supported = false;
				base.enabled = false;
			}
			else
			{
				m_Supported = true;
			}
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		private void CreateMaterials()
		{
			if (!m_SSAOMaterial && m_SSAOShader.isSupported)
			{
				m_SSAOMaterial = CreateMaterial(m_SSAOShader);
				m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!m_Supported || !m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			CreateMaterials();
			m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
			m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
			m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
			m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
			m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
			m_Blur = Mathf.Clamp(m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
			float fieldOfView = GetComponent<Camera>().fieldOfView;
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
			float x = num * GetComponent<Camera>().aspect;
			m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if ((bool)m_RandomTexture)
			{
				num2 = m_RandomTexture.width;
				num3 = m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
			bool num4 = m_Blur > 0;
			Graphics.Blit(num4 ? null : source, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
			if (num4)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", temporary);
				Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(source, destination, m_SSAOMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public Color sunColor = Color.white;

		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = (GetComponent<Camera>().allowHDR ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Low,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (maxBlurSize < 0f) ? 0f : maxBlurSize);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode == TiltShiftMode.TiltShiftMode) ? num : (num + 1));
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 8);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((exposureAdjustment < 0.001f) ? 0.001f : exposureAdjustment);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((adaptionSpeed < 0.001f) ? 0.001f : adaptionSpeed);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, flag ? 3 : 2);
			middleGrey = ((middleGrey < 0.001f) ? 0.001f : middleGrey);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				UnityEngine.Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f)));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array3[num] = new Vector2(num3, num4);
				array3[num + 1] = new Vector2(num3, num4);
				array3[num + 2] = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		[Range(0f, 360f)]
		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.036f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - intensity) - 1f);
				m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - blur) - 1f);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : source, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.4f, 0.4f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
}
namespace RootMotion
{
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		public enum UpdateMode
		{
			Update,
			FixedUpdate,
			LateUpdate,
			FixedLateUpdate
		}

		public Transform target;

		public Transform rotationSpace;

		public UpdateMode updateMode = UpdateMode.LateUpdate;

		public bool lockCursor = true;

		[Header("Position")]
		public bool smoothFollow;

		public Vector3 offset = new Vector3(0f, 1.5f, 0.5f);

		public float followSpeed = 10f;

		[Header("Rotation")]
		public float rotationSensitivity = 3.5f;

		public float yMinLimit = -20f;

		public float yMaxLimit = 80f;

		public bool rotateAlways = true;

		public bool rotateOnLeftButton;

		public bool rotateOnRightButton;

		public bool rotateOnMiddleButton;

		[Header("Distance")]
		public float distance = 10f;

		public float minDistance = 4f;

		public float maxDistance = 10f;

		public float zoomSpeed = 10f;

		public float zoomSensitivity = 1f;

		[Header("Blocking")]
		public LayerMask blockingLayers;

		public float blockingRadius = 1f;

		public float blockingSmoothTime = 0.1f;

		[Range(0f, 1f)]
		public float blockedOffset = 0.5f;

		private Vector3 targetDistance;

		private Vector3 position;

		private Quaternion rotation = Quaternion.identity;

		private Vector3 smoothPosition;

		private Camera cam;

		private bool fixedFrame;

		private float fixedDeltaTime;

		private Quaternion r = Quaternion.identity;

		private Vector3 lastUp;

		private float blockedDistance = 10f;

		private float blockedDistanceV;

		public float x { get; private set; }

		public float y { get; private set; }

		public float distanceTarget { get; private set; }

		private float zoomAdd
		{
			get
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis > 0f)
				{
					return 0f - zoomSensitivity;
				}
				if (axis < 0f)
				{
					return zoomSensitivity;
				}
				return 0f;
			}
		}

		protected virtual void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			x = eulerAngles.y;
			y = eulerAngles.x;
			distanceTarget = distance;
			smoothPosition = base.transform.position;
			cam = GetComponent<Camera>();
			lastUp = ((rotationSpace != null) ? rotationSpace.up : Vector3.up);
		}

		protected virtual void Update()
		{
			if (updateMode == UpdateMode.Update)
			{
				UpdateTransform();
			}
		}

		protected virtual void FixedUpdate()
		{
			fixedFrame = true;
			fixedDeltaTime += Time.deltaTime;
			if (updateMode == UpdateMode.FixedUpdate)
			{
				UpdateTransform();
			}
		}

		protected virtual void LateUpdate()
		{
			UpdateInput();
			if (updateMode == UpdateMode.LateUpdate)
			{
				UpdateTransform();
			}
			if (updateMode == UpdateMode.FixedLateUpdate && fixedFrame)
			{
				UpdateTransform(fixedDeltaTime);
				fixedDeltaTime = 0f;
				fixedFrame = false;
			}
		}

		public void UpdateInput()
		{
			if (cam.enabled)
			{
				Cursor.lockState = (lockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !lockCursor;
				if (rotateAlways || (rotateOnLeftButton && Input.GetMouseButton(0)) || (rotateOnRightButton && Input.GetMouseButton(1)) || (rotateOnMiddleButton && Input.GetMouseButton(2)))
				{
					x += Input.GetAxis("Mouse X") * rotationSensitivity;
					y = ClampAngle(y - Input.GetAxis("Mouse Y") * rotationSensitivity, yMinLimit, yMaxLimit);
				}
				distanceTarget = Mathf.Clamp(distanceTarget + zoomAdd, minDistance, maxDistance);
			}
		}

		public void UpdateTransform()
		{
			UpdateTransform(Time.deltaTime);
		}

		public void UpdateTransform(float deltaTime)
		{
			if (!cam.enabled)
			{
				return;
			}
			rotation = Quaternion.AngleAxis(x, Vector3.up) * Quaternion.AngleAxis(y, Vector3.right);
			if (rotationSpace != null)
			{
				r = Quaternion.FromToRotation(lastUp, rotationSpace.up) * r;
				rotation = r * rotation;
				lastUp = rotationSpace.up;
			}
			if (target != null)
			{
				distance += (distanceTarget - distance) * zoomSpeed * deltaTime;
				if (!smoothFollow)
				{
					smoothPosition = target.position;
				}
				else
				{
					smoothPosition = Vector3.Lerp(smoothPosition, target.position, deltaTime * followSpeed);
				}
				Vector3 vector = smoothPosition + rotation * offset;
				Vector3 vector2 = rotation * -Vector3.forward;
				if ((int)blockingLayers != -1)
				{
					if (Physics.SphereCast(vector, blockingRadius, vector2, out var hitInfo, distanceTarget - blockingRadius, blockingLayers))
					{
						blockedDistance = Mathf.SmoothDamp(blockedDistance, hitInfo.distance + blockingRadius * (1f - blockedOffset), ref blockedDistanceV, blockingSmoothTime);
					}
					else
					{
						blockedDistance = distanceTarget;
					}
					distance = Mathf.Min(distance, blockedDistance);
				}
				position = vector + vector2 * distance;
				base.transform.position = position;
			}
			base.transform.rotation = rotation;
		}

		private float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360f)
			{
				angle += 360f;
			}
			if (angle > 360f)
			{
				angle -= 360f;
			}
			return Mathf.Clamp(angle, min, max);
		}
	}
	public class CameraControllerFPS : MonoBehaviour
	{
		public float rotationSensitivity = 3f;

		public float yMinLimit = -89f;

		public float yMaxLimit = 89f;

		private float x;

		private float y;

		private void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			x = eulerAngles.y;
			y = eulerAngles.x;
		}

		public void LateUpdate()
		{
			Cursor.lockState = CursorLockMode.Locked;
			x += Input.GetAxis("Mouse X") * rotationSensitivity;
			y = ClampAngle(y - Input.GetAxis("Mouse Y") * rotationSensitivity, yMinLimit, yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(x, Vector3.up) * Quaternion.AngleAxis(y, Vector3.right);
		}

		private float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360f)
			{
				angle += 360f;
			}
			if (angle > 360f)
			{
				angle -= 360f;
			}
			return Mathf.Clamp(angle, min, max);
		}
	}
	[Serializable]
	public enum Axis
	{
		X,
		Y,
		Z
	}
	public class AxisTools
	{
		public static Vector3 ToVector3(Axis axis)
		{
			return axis switch
			{
				Axis.X => Vector3.right, 
				Axis.Y => Vector3.up, 
				_ => Vector3.forward, 
			};
		}

		public static Axis ToAxis(Vector3 v)
		{
			float num = Mathf.Abs(v.x);
			float num2 = Mathf.Abs(v.y);
			float num3 = Mathf.Abs(v.z);
			Axis result = Axis.X;
			if (num2 > num && num2 > num3)
			{
				result = Axis.Y;
			}
			if (num3 > num && num3 > num2)
			{
				result = Axis.Z;
			}
			return result;
		}

		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			Vector3 axisVectorToPoint = GetAxisVectorToPoint(t, worldPosition);
			if (axisVectorToPoint == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToPoint == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			Vector3 axisVectorToDirection = GetAxisVectorToDirection(t, direction);
			if (axisVectorToDirection == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToDirection == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return GetAxisVectorToDirection(t, worldPosition - t.position);
		}

		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			direction = direction.normalized;
			Vector3 result = Vector3.right;
			float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.right), direction));
			float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.up), direction));
			if (num2 > num)
			{
				result = Vector3.up;
			}
			float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.forward), direction));
			if (num3 > num && num3 > num2)
			{
				result = Vector3.forward;
			}
			return result;
		}
	}
	[Serializable]
	public class BipedLimbOrientations
	{
		[Serializable]
		public class LimbOrientation
		{
			public Vector3 upperBoneForwardAxis;

			public Vector3 lowerBoneForwardAxis;

			public Vector3 lastBoneLeftAxis;

			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
				this.upperBoneForwardAxis = upperBoneForwardAxis;
				this.lowerBoneForwardAxis = lowerBoneForwardAxis;
				this.lastBoneLeftAxis = lastBoneLeftAxis;
			}
		}

		public LimbOrientation leftArm;

		public LimbOrientation rightArm;

		public LimbOrientation leftLeg;

		public LimbOrientation rightLeg;

		public static BipedLimbOrientations UMA => new BipedLimbOrientations(new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));

		public static BipedLimbOrientations MaxBiped => new BipedLimbOrientations(new LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new LimbOrientation(Vector3.up, Vector3.up, Vector3.back));

		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
			this.leftArm = leftArm;
			this.rightArm = rightArm;
			this.leftLeg = leftLeg;
			this.rightLeg = rightLeg;
		}
	}
	public static class BipedNaming
	{
		[Serializable]
		public enum BoneType
		{
			Unassigned,
			Spine,
			Head,
			Arm,
			Leg,
			Tail,
			Eye
		}

		[Serializable]
		public enum BoneSide
		{
			Center,
			Left,
			Right
		}

		public static string[] typeLeft = new string[9] { " L ", "_L_", "-L-", " l ", "_l_", "-l-", "Left", "left", "CATRigL" };

		public static string[] typeRight = new string[9] { " R ", "_R_", "-R-", " r ", "_r_", "-r-", "Right", "right", "CATRigR" };

		public static string[] typeSpine = new string[16]
		{
			"Spine", "spine", "Pelvis", "pelvis", "Root", "root", "Torso", "torso", "Body", "body",
			"Hips", "hips", "Neck", "neck", "Chest", "chest"
		};

		public static string[] typeHead = new string[2] { "Head", "head" };

		public static string[] typeArm = new string[10] { "Arm", "arm", "Hand", "hand", "Wrist", "Wrist", "Elbow", "elbow", "Palm", "palm" };

		public static string[] typeLeg = new string[16]
		{
			"Leg", "leg", "Thigh", "thigh", "Calf", "calf", "Femur", "femur", "Knee", "knee",
			"Foot", "foot", "Ankle", "ankle", "Hip", "hip"
		};

		public static string[] typeTail = new string[2] { "Tail", "tail" };

		public static string[] typeEye = new string[2] { "Eye", "eye" };

		public static string[] typeExclude = new string[6] { "Nub", "Dummy", "dummy", "Tip", "IK", "Mesh" };

		public static string[] typeExcludeSpine = new string[2] { "Head", "head" };

		public static string[] typeExcludeHead = new string[2] { "Top", "End" };

		public static string[] typeExcludeArm = new string[19]
		{
			"Collar", "collar", "Clavicle", "clavicle", "Finger", "finger", "Index", "index", "Mid", "mid",
			"Pinky", "pinky", "Ring", "Thumb", "thumb", "Adjust", "adjust", "Twist", "twist"
		};

		public static string[] typeExcludeLeg = new string[7] { "Toe", "toe", "Platform", "Adjust", "adjust", "Twist", "twist" };

		public static string[] typeExcludeTail = new string[0];

		public static string[] typeExcludeEye = new string[6] { "Lid", "lid", "Brow", "brow", "Lash", "lash" };

		public static string[] pelvis = new string[4] { "Pelvis", "pelvis", "Hip", "hip" };

		public static string[] hand = new string[6] { "Hand", "hand", "Wrist", "wrist", "Palm", "palm" };

		public static string[] foot = new string[4] { "Foot", "foot", "Ankle", "ankle" };

		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && GetBoneType(transform.name) == boneType)
				{
					Array.Resize(ref array, array.Length + 1);
					array[^1] = transform;
				}
			}
			return array;
		}

		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && GetBoneSide(transform.name) == boneSide)
				{
					Array.Resize(ref array, array.Length + 1);
					array[^1] = transform;
				}
			}
			return array;
		}

		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfType = GetBonesOfType(boneType, bones);
			return GetBonesOfSide(boneSide, bonesOfType);
		}

		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfTypeAndSide = GetBonesOfTypeAndSide(boneType, boneSide, bones);
			if (bonesOfTypeAndSide.Length == 0)
			{
				return null;
			}
			return bonesOfTypeAndSide[0];
		}

		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			foreach (Transform transform in transforms)
			{
				bool flag = true;
				foreach (string[] namingConvention in namings)
				{
					if (!matchesNaming(transform.name, namingConvention))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return transform;
				}
			}
			return null;
		}

		public static BoneType GetBoneType(string boneName)
		{
			if (isSpine(boneName))
			{
				return BoneType.Spine;
			}
			if (isHead(boneName))
			{
				return BoneType.Head;
			}
			if (isArm(boneName))
			{
				return BoneType.Arm;
			}
			if (isLeg(boneName))
			{
				return BoneType.Leg;
			}
			if (isTail(boneName))
			{
				return BoneType.Tail;
			}
			if (isEye(boneName))
			{
				return BoneType.Eye;
			}
			return BoneType.Unassigned;
		}

		public static BoneSide GetBoneSide(string boneName)
		{
			if (isLeft(boneName))
			{
				return BoneSide.Left;
			}
			if (isRight(boneName))
			{
				return BoneSide.Right;
			}
			return BoneSide.Center;
		}

		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return GetNamingMatch(GetBonesOfTypeAndSide(boneType, boneSide, transforms), namings);
		}

		private static bool isLeft(string boneName)
		{
			if (!matchesNaming(boneName, typeLeft) && !(lastLetter(boneName) == "L"))
			{
				return firstLetter(boneName) == "L";
			}
			return true;
		}

		private static bool isRight(string boneName)
		{
			if (!matchesNaming(boneName, typeRight) && !(lastLetter(boneName) == "R"))
			{
				return firstLetter(boneName) == "R";
			}
			return true;
		}

		private static bool isSpine(string boneName)
		{
			if (matchesNaming(boneName, typeSpine))
			{
				return !excludesNaming(boneName, typeExcludeSpine);
			}
			return false;
		}

		private static bool isHead(string boneName)
		{
			if (matchesNaming(boneName, typeHead))
			{
				return !excludesNaming(boneName, typeExcludeHead);
			}
			return false;
		}

		private static bool isArm(string boneName)
		{
			if (matchesNaming(boneName, typeArm))
			{
				return !excludesNaming(boneName, typeExcludeArm);
			}
			return false;
		}

		private static bool isLeg(string boneName)
		{
			if (matchesNaming(boneName, typeLeg))
			{
				return !excludesNaming(boneName, typeExcludeLeg);
			}
			return false;
		}

		private static bool isTail(string boneName)
		{
			if (matchesNaming(boneName, typeTail))
			{
				return !excludesNaming(boneName, typeExcludeTail);
			}
			return false;
		}

		private static bool isEye(string boneName)
		{
			if (matchesNaming(boneName, typeEye))
			{
				return !excludesNaming(boneName, typeExcludeEye);
			}
			return false;
		}

		private static bool isTypeExclude(string boneName)
		{
			return matchesNaming(boneName, typeExclude);
		}

		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			if (excludesNaming(boneName, typeExclude))
			{
				return false;
			}
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			foreach (string letter in namingConvention)
			{
				if (LastLetterIs(boneName, letter))
				{
					return true;
				}
			}
			return false;
		}

		private static bool LastLetterIs(string boneName, string letter)
		{
			return boneName.Substring(boneName.Length - 1, 1) == letter;
		}

		private static string firstLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(0, 1);
			}
			return "";
		}

		private static string lastLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(boneName.Length - 1, 1);
			}
			return "";
		}
	}
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			public bool legsParentInSpine;

			public bool includeEyes;

			public static AutoDetectParams Default => new AutoDetectParams(legsParentInSpine: true, includeEyes: true);

			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
				this.legsParentInSpine = legsParentInSpine;
				this.includeEyes = includeEyes;
			}
		}

		public Transform root;

		public Transform pelvis;

		public Transform leftThigh;

		public Transform leftCalf;

		public Transform leftFoot;

		public Transform rightThigh;

		public Transform rightCalf;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftForearm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightForearm;

		public Transform rightHand;

		public Transform head;

		public Transform[] spine = new Transform[0];

		public Transform[] eyes = new Transform[0];

		public virtual bool isFilled
		{
			get
			{
				if (root == null)
				{
					return false;
				}
				if (pelvis == null)
				{
					return false;
				}
				if (leftThigh == null || leftCalf == null || leftFoot == null)
				{
					return false;
				}
				if (rightThigh == null || rightCalf == null || rightFoot == null)
				{
					return false;
				}
				if (leftUpperArm == null || leftForearm == null || leftHand == null)
				{
					return false;
				}
				if (rightUpperArm == null || rightForearm == null || rightHand == null)
				{
					return false;
				}
				Transform[] array = spine;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				array = eyes;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		public bool isEmpty => IsEmpty(includeRoot: true);

		public virtual bool IsEmpty(bool includeRoot)
		{
			if (includeRoot && root != null)
			{
				return false;
			}
			if (pelvis != null || head != null)
			{
				return false;
			}
			if (leftThigh != null || leftCalf != null || leftFoot != null)
			{
				return false;
			}
			if (rightThigh != null || rightCalf != null || rightFoot != null)
			{
				return false;
			}
			if (leftUpperArm != null || leftForearm != null || leftHand != null)
			{
				return false;
			}
			if (rightUpperArm != null || rightForearm != null || rightHand != null)
			{
				return false;
			}
			Transform[] array = spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			return true;
		}

		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			if (!ignoreRoot && root == t)
			{
				return true;
			}
			if (pelvis == t)
			{
				return true;
			}
			if (leftThigh == t)
			{
				return true;
			}
			if (leftCalf == t)
			{
				return true;
			}
			if (leftFoot == t)
			{
				return true;
			}
			if (rightThigh == t)
			{
				return true;
			}
			if (rightCalf == t)
			{
				return true;
			}
			if (rightFoot == t)
			{
				return true;
			}
			if (leftUpperArm == t)
			{
				return true;
			}
			if (leftForearm == t)
			{
				return true;
			}
			if (leftHand == t)
			{
				return true;
			}
			if (rightUpperArm == t)
			{
				return true;
			}
			if (rightForearm == t)
			{
				return true;
			}
			if (rightHand == t)
			{
				return true;
			}
			if (head == t)
			{
				return true;
			}
			Transform[] array = spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == t)
				{
					return true;
				}
			}
			array = eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == t)
				{
					return true;
				}
			}
			return false;
		}

		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			references.root = root;
			Animator component = root.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				AssignHumanoidReferences(ref references, component, autoDetectParams);
				return true;
			}
			DetectReferencesByNaming(ref references, root, autoDetectParams);
			Warning.logged = false;
			if (!references.isFilled)
			{
				Warning.Log("BipedReferences contains one or more missing Transforms.", root, logInEditMode: true);
				return false;
			}
			string errorMessage = "";
			if (SetupError(references, ref errorMessage))
			{
				Warning.Log(errorMessage, references.root, logInEditMode: true);
				return false;
			}
			if (SetupWarning(references, ref errorMessage))
			{
				Warning.Log(errorMessage, references.root, logInEditMode: true);
			}
			return true;
		}

		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			Transform[] componentsInChildren = root.GetComponentsInChildren<Transform>();
			DetectLimb(BipedNaming.BoneType.Arm, BipedNaming.BoneSide.Left, ref references.leftUpperArm, ref references.leftForearm, ref references.leftHand, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Arm, BipedNaming.BoneSide.Right, ref references.rightUpperArm, ref references.rightForearm, ref references.rightHand, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Leg, BipedNaming.BoneSide.Left, ref references.leftThigh, ref references.leftCalf, ref references.leftFoot, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Leg, BipedNaming.BoneSide.Right, ref references.rightThigh, ref references.rightCalf, ref references.rightFoot, componentsInChildren);
			references.head = BipedNaming.GetBone(componentsInChildren, BipedNaming.BoneType.Head, BipedNaming.BoneSide.Center);
			references.pelvis = BipedNaming.GetNamingMatch(componentsInChildren, BipedNaming.pelvis);
			if ((references.pelvis == null || !Hierarchy.IsAncestor(references.leftThigh, references.pelvis)) && references.leftThigh != null)
			{
				references.pelvis = references.leftThigh.parent;
			}
			if (references.leftUpperArm != null && references.rightUpperArm != null && references.pelvis != null && references.leftThigh != null)
			{
				Transform firstCommonAncestor = Hierarchy.GetFirstCommonAncestor(references.leftUpperArm, references.rightUpperArm);
				if (firstCommonAncestor != null)
				{
					Transform[] array = new Transform[1] { firstCommonAncestor };
					Hierarchy.AddAncestors(array[0], references.pelvis, ref array);
					references.spine = new Transform[0];
					for (int num = array.Length - 1; num > -1; num--)
					{
						if (AddBoneToSpine(array[num], ref references, autoDetectParams))
						{
							Array.Resize(ref references.spine, references.spine.Length + 1);
							references.spine[references.spine.Length - 1] = array[num];
						}
					}
					if (references.head == null)
					{
						for (int i = 0; i < firstCommonAncestor.childCount; i++)
						{
							Transform child = firstCommonAncestor.GetChild(i);
							if (!Hierarchy.ContainsChild(child, references.leftUpperArm) && !Hierarchy.ContainsChild(child, references.rightUpperArm))
							{
								references.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] bonesOfType = BipedNaming.GetBonesOfType(BipedNaming.BoneType.Eye, componentsInChildren);
			references.eyes = new Transform[0];
			if (!autoDetectParams.includeEyes)
			{
				return;
			}
			for (int j = 0; j < bonesOfType.Length; j++)
			{
				if (AddBoneToEyes(bonesOfType[j], ref references, autoDetectParams))
				{
					Array.Resize(ref references.eyes, references.eyes.Length + 1);
					references.eyes[references.eyes.Length - 1] = bonesOfType[j];
				}
			}
		}

		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			if (!(animator == null) && animator.isHuman)
			{
				references.spine = new Transform[0];
				references.eyes = new Transform[0];
				references.head = animator.GetBoneTransform(HumanBodyBones.Head);
				references.leftThigh = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				references.leftCalf = animator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				references.leftFoot = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
				references.rightThigh = animator.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				references.rightCalf = animator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				references.rightFoot = animator.GetBoneTransform(HumanBodyBones.RightFoot);
				references.leftUpperArm = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				references.leftForearm = animator.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				references.leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
				references.rightUpperArm = animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
				references.rightForearm = animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
				references.rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
				references.pelvis = animator.GetBoneTransform(HumanBodyBones.Hips);
				AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Spine));
				AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Chest));
				if (references.leftUpperArm != null && !IsNeckBone(animator.GetBoneTransform(HumanBodyBones.Neck), references.leftUpperArm))
				{
					AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Neck));
				}
				if (autoDetectParams.includeEyes)
				{
					AddBoneToHierarchy(ref references.eyes, animator.GetBoneTransform(HumanBodyBones.LeftEye));
					AddBoneToHierarchy(ref references.eyes, animator.GetBoneTransform(HumanBodyBones.RightEye));
				}
			}
		}

		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			if (!references.isFilled)
			{
				errorMessage = "BipedReferences contains one or more missing Transforms.";
				return true;
			}
			if (LimbError(references.leftThigh, references.leftCalf, references.leftFoot, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.rightThigh, references.rightCalf, references.rightFoot, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.leftUpperArm, references.leftForearm, references.leftHand, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.rightUpperArm, references.rightForearm, references.rightHand, ref errorMessage))
			{
				return true;
			}
			if (SpineError(references, ref errorMessage))
			{
				return true;
			}
			if (EyesError(references, ref errorMessage))
			{
				return true;
			}
			return false;
		}

		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			if (LimbWarning(references.leftThigh, references.leftCalf, references.leftFoot, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.rightThigh, references.rightCalf, references.rightFoot, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.leftUpperArm, references.leftForearm, references.leftHand, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.rightUpperArm, references.rightForearm, references.rightHand, ref warningMessage))
			{
				return true;
			}
			if (SpineWarning(references, ref warningMessage))
			{
				return true;
			}
			if (EyesWarning(references, ref warningMessage))
			{
				return true;
			}
			if (RootHeightWarning(references, ref warningMessage))
			{
				return true;
			}
			if (FacingAxisWarning(references, ref warningMessage))
			{
				return true;
			}
			return false;
		}

		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			if (leftUpperArm.parent != null && leftUpperArm.parent == bone)
			{
				return false;
			}
			if (Hierarchy.IsAncestor(leftUpperArm, bone))
			{
				return false;
			}
			return true;
		}

		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			if (references.head != null && !Hierarchy.IsAncestor(bone, references.head))
			{
				return false;
			}
			if (bone.GetComponent<SkinnedMeshRenderer>() != null)
			{
				return false;
			}
			return true;
		}

		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			if (bone == references.root)
			{
				return false;
			}
			if (bone == references.leftThigh.parent && !autoDetectParams.legsParentInSpine)
			{
				return false;
			}
			if (references.pelvis != null)
			{
				if (bone == references.pelvis)
				{
					return false;
				}
				if (Hierarchy.IsAncestor(references.pelvis, bone))
				{
					return false;
				}
			}
			return true;
		}

		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
			Transform[] bonesOfTypeAndSide = BipedNaming.GetBonesOfTypeAndSide(boneType, boneSide, transforms);
			if (bonesOfTypeAndSide.Length >= 3)
			{
				if (bonesOfTypeAndSide.Length == 3)
				{
					firstBone = bonesOfTypeAndSide[0];
					secondBone = bonesOfTypeAndSide[1];
					lastBone = bonesOfTypeAndSide[2];
				}
				if (bonesOfTypeAndSide.Length > 3)
				{
					firstBone = bonesOfTypeAndSide[0];
					secondBone = bonesOfTypeAndSide[2];
					lastBone = bonesOfTypeAndSide[^1];
				}
			}
		}

		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
			if (!(transform == null))
			{
				Array.Resize(ref bones, bones.Length + 1);
				bones[bones.Length - 1] = transform;
			}
		}

		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			if (bone1 == null)
			{
				errorMessage = "Bone 1 of a BipedReferences limb is null.";
				return true;
			}
			if (bone2 == null)
			{
				errorMessage = "Bone 2 of a BipedReferences limb is null.";
				return true;
			}
			if (bone3 == null)
			{
				errorMessage = "Bone 3 of a BipedReferences limb is null.";
				return true;
			}
			UnityEngine.Object[] objects = new Transform[3] { bone1, bone2, bone3 };
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in the same BipedReferences limb.";
				return true;
			}
			if (bone2.position == bone1.position)
			{
				errorMessage = "Second bone's position equals first bone's position in the biped's limb.";
				return true;
			}
			if (bone3.position == bone2.position)
			{
				errorMessage = "Third bone's position equals second bone's position in the biped's limb.";
				return true;
			}
			if (!Hierarchy.HierarchyIsValid(new Transform[3] { bone1, bone2, bone3 }))
			{
				errorMessage = "BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: " + bone1.name + ", " + bone2.name + ", " + bone3.name;
				return true;
			}
			return false;
		}

		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			if (Vector3.Cross(bone2.position - bone1.position, bone3.position - bone1.position) == Vector3.zero)
			{
				warningMessage = "BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: " + bone1.name + ", second bone: " + bone2.name + ".";
				return true;
			}
			return false;
		}

		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			if (references.spine.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < references.spine.Length; i++)
			{
				if (references.spine[i] == null)
				{
					errorMessage = "BipedReferences spine bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] objects = references.spine;
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in BipedReferences spine.";
				return true;
			}
			if (!Hierarchy.HierarchyIsValid(references.spine))
			{
				errorMessage = "BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.";
				return true;
			}
			for (int j = 0; j < references.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && references.spine[j].position == references.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && references.spine.Length > 1 && references.spine[j].position == references.spine[j - 1].position)
				{
					flag = true;
				}
				if (flag)
				{
					errorMessage = "Biped's spine bone nr " + j + " position is the same as it's parent spine/pelvis bone's position. Please remove this bone from the spine.";
					return true;
				}
			}
			return false;
		}

		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			if (references.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < references.eyes.Length; i++)
			{
				if (references.eyes[i] == null)
				{
					errorMessage = "BipedReferences eye bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] objects = references.eyes;
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in BipedReferences eyes.";
				return true;
			}
			return false;
		}

		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			if (references.head == null)
			{
				return false;
			}
			float verticalOffset = GetVerticalOffset(references.head.position, references.leftFoot.position, references.root.rotation);
			if (GetVerticalOffset(references.root.position, references.leftFoot.position, references.root.rotation) / verticalOffset > 0.2f)
			{
				warningMessage = "Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).";
				return true;
			}
			return false;
		}

		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			Vector3 vector = references.rightHand.position - references.leftHand.position;
			Vector3 vector2 = references.rightFoot.position - references.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, references.root.right);
			float num2 = Vector3.Dot(vector2.normalized, references.root.right);
			if (num < 0f || num2 < 0f)
			{
				warningMessage = "Biped does not seem to be facing it's forward axis. Please make sure that in the initial pose the character is facing towards the positive Z axis of the Biped root gameobject.";
				return true;
			}
			return false;
		}

		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return (Quaternion.Inverse(rotation) * (p1 - p2)).y;
		}
	}
	public class Comments : MonoBehaviour
	{
		[Multiline]
		public string text;
	}
	public class DemoGUIMessage : MonoBehaviour
	{
		public string text;

		public Color color = Color.white;

		private void OnGUI()
		{
			GUI.color = color;
			GUILayout.Label(text);
			GUI.color = Color.white;
		}
	}
	public class Hierarchy
	{
		public static bool HierarchyIsValid(Transform[] bones)
		{
			for (int i = 1; i < bones.Length; i++)
			{
				if (!IsAncestor(bones[i], bones[i - 1]))
				{
					return false;
				}
			}
			return true;
		}

		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			for (int i = 0; i < objects.Length; i++)
			{
				for (int j = 0; j < objects.Length; j++)
				{
					if (i != j && objects[i] == objects[j])
					{
						return objects[i];
					}
				}
			}
			return null;
		}

		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			if (transform == null)
			{
				return true;
			}
			if (ancestor == null)
			{
				return true;
			}
			if (transform.parent == null)
			{
				return false;
			}
			if (transform.parent == ancestor)
			{
				return true;
			}
			return IsAncestor(transform.parent, ancestor);
		}

		public static bool ContainsChild(Transform transform, Transform child)
		{
			if (transform == child)
			{
				return true;
			}
			Transform[] componentsInChildren = transform.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i] == child)
				{
					return true;
				}
			}
			return false;
		}

		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
			if (transform.parent != null && transform.parent != blocker)
			{
				if (transform.parent.position != transform.position && transform.parent.position != blocker.position)
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = transform.parent;
				}
				AddAncestors(transform.parent, blocker, ref array);
			}
		}

		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			if (transform == null)
			{
				return null;
			}
			if (transform.parent != null)
			{
				if (transform.parent.childCount >= minChildCount)
				{
					return transform.parent;
				}
				return GetAncestor(transform.parent, minChildCount);
			}
			return null;
		}

		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			if (t1 == null)
			{
				return null;
			}
			if (t2 == null)
			{
				return null;
			}
			if (t1.parent == null)
			{
				return null;
			}
			if (t2.parent == null)
			{
				return null;
			}
			if (IsAncestor(t2, t1.parent))
			{
				return t1.parent;
			}
			return GetFirstCommonAncestor(t1.parent, t2);
		}

		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			if (transforms == null)
			{
				UnityEngine.Debug.LogWarning("Transforms is null.");
				return null;
			}
			if (transforms.Length == 0)
			{
				UnityEngine.Debug.LogWarning("Transforms.Length is 0.");
				return null;
			}
			for (int i = 0; i < transforms.Length; i++)
			{
				if (transforms[i] == null)
				{
					return null;
				}
				if (IsCommonAncestor(transforms[i], transforms))
				{
					return transforms[i];
				}
			}
			return GetFirstCommonAncestorRecursive(transforms[0], transforms);
		}

		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			if (transform == null)
			{
				UnityEngine.Debug.LogWarning("Transform is null.");
				return null;
			}
			if (transforms == null)
			{
				UnityEngine.Debug.LogWarning("Transforms is null.");
				return null;
			}
			if (transforms.Length == 0)
			{
				UnityEngine.Debug.LogWarning("Transforms.Length is 0.");
				return null;
			}
			if (IsCommonAncestor(transform, transforms))
			{
				return transform;
			}
			if (transform.parent == null)
			{
				return null;
			}
			return GetFirstCommonAncestorRecursive(transform.parent, transforms);
		}

		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			if (transform == null)
			{
				UnityEngine.Debug.LogWarning("Transform is null.");
				return false;
			}
			for (int i = 0; i < transforms.Length; i++)
			{
				if (transforms[i] == null)
				{
					UnityEngine.Debug.Log("Transforms[" + i + "] is null.");
					return false;
				}
				if (!IsAncestor(transforms[i], transform) && transforms[i] != transform)
				{
					return false;
				}
			}
			return true;
		}
	}
	public class InspectorComment : PropertyAttribute
	{
		public string name;

		public string color = "white";

		public InspectorComment(string name)
		{
			this.name = name;
			color = "white";
		}

		public InspectorComment(string name, string color)
		{
			this.name = name;
			this.color = color;
		}
	}
	[Serializable]
	public enum InterpolationMode
	{
		None,
		InOutCubic,
		InOutQuintic,
		InOutSine,
		InQuintic,
		InQuartic,
		InCubic,
		InQuadratic,
		InElastic,
		InElasticSmall,
		InElasticBig,
		InSine,
		InBack,
		OutQuintic,
		OutQuartic,
		OutCubic,
		OutInCubic,
		OutInQuartic,
		OutElastic,
		OutElasticSmall,
		OutElasticBig,
		OutSine,
		OutBack,
		OutBackCubic,
		OutBackQuartic,
		BackInCubic,
		BackInQuartic
	}
	public class Interp
	{
		public static float Float(float t, InterpolationMode mode)
		{
			float num = 0f;
			return mode switch
			{
				InterpolationMode.None => None(t, 0f, 1f), 
				InterpolationMode.InOutCubic => InOutCubic(t, 0f, 1f), 
				InterpolationMode.InOutQuintic => InOutQuintic(t, 0f, 1f), 
				InterpolationMode.InQuintic => InQuintic(t, 0f, 1f), 
				InterpolationMode.InQuartic => InQuartic(t, 0f, 1f), 
				InterpolationMode.InCubic => InCubic(t, 0f, 1f), 
				InterpolationMode.InQuadratic => InQuadratic(t, 0f, 1f), 
				InterpolationMode.OutQuintic => OutQuintic(t, 0f, 1f), 
				InterpolationMode.OutQuartic => OutQuartic(t, 0f, 1f), 
				InterpolationMode.OutCubic => OutCubic(t, 0f, 1f), 
				InterpolationMode.OutInCubic => OutInCubic(t, 0f, 1f), 
				InterpolationMode.OutInQuartic => OutInCubic(t, 0f, 1f), 
				InterpolationMode.BackInCubic => BackInCubic(t, 0f, 1f), 
				InterpolationMode.BackInQuartic => BackInQuartic(t, 0f, 1f), 
				InterpolationMode.OutBackCubic => OutBackCubic(t, 0f, 1f), 
				InterpolationMode.OutBackQuartic => OutBackQuartic(t, 0f, 1f), 
				InterpolationMode.OutElasticSmall => OutElasticSmall(t, 0f, 1f), 
				InterpolationMode.OutElasticBig => OutElasticBig(t, 0f, 1f), 
				InterpolationMode.InElasticSmall => InElasticSmall(t, 0f, 1f), 
				InterpolationMode.InElasticBig => InElasticBig(t, 0f, 1f), 
				InterpolationMode.InSine => InSine(t, 0f, 1f), 
				InterpolationMode.OutSine => OutSine(t, 0f, 1f), 
				InterpolationMode.InOutSine => InOutSine(t, 0f, 1f), 
				InterpolationMode.InElastic => OutElastic(t, 0f, 1f), 
				InterpolationMode.OutElastic => OutElastic(t, 0f, 1f), 
				InterpolationMode.InBack => InBack(t, 0f, 1f), 
				InterpolationMode.OutBack => OutBack(t, 0f, 1f), 
				_ => 0f, 
			};
		}

		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			float num = Float(t, mode);
			return (1f - num) * v1 + num * v2;
		}

		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			if (value == target)
			{
				return target;
			}
			if (value < target)
			{
				return Mathf.Clamp(value + Time.deltaTime * increaseSpeed, float.NegativeInfinity, target);
			}
			return Mathf.Clamp(value - Time.deltaTime * decreaseSpeed, target, float.PositiveInfinity);
		}

		private static float None(float t, float b, float c)
		{
			return b + c * t;
		}

		private static float InOutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num2 + 3f * num);
		}

		private static float InOutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 * num + -15f * num * num + 10f * num2);
		}

		private static float InQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num);
		}

		private static float InQuartic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * (num * num);
		}

		private static float InCubic(float t, float b, float c)
		{
			float num = t * t * t;
			return b + c * num;
		}

		private static float InQuadratic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * num;
		}

		private static float OutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num + -5f * num * num + 10f * num2 + -10f * num + 5f * t);
		}

		private static float OutQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-1f * num * num + 4f * num2 + -6f * num + 4f * t);
		}

		private static float OutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 + -3f * num + 3f * t);
		}

		private static float OutInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -6f * num + 3f * t);
		}

		private static float OutInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 + -9f * num + 4f * t);
		}

		private static float BackInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -3f * num);
		}

		private static float BackInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (2f * num * num + 2f * num2 + -3f * num);
		}

		private static float OutBackCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -9f * num + 6f * t);
		}

		private static float OutBackQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num * num + 10f * num2 + -15f * num + 8f * t);
		}

		private static float OutElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -106f * num * num + 126f * num2 + -67f * num + 15f * t);
		}

		private static float OutElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -175f * num * num + 200f * num2 + -100f * num + 20f * t);
		}

		private static float InElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -59f * num * num + 32f * num2 + -5f * num);
		}

		private static float InElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -105f * num * num + 60f * num2 + -10f * num);
		}

		private static float InSine(float t, float b, float c)
		{
			c -= b;
			return (0f - c) * Mathf.Cos(t / 1f * ((float)Math.PI / 2f)) + c + b;
		}

		private static float OutSine(float t, float b, float c)
		{
			c -= b;
			return c * Mathf.Sin(t / 1f * ((float)Math.PI / 2f)) + b;
		}

		private static float InOutSine(float t, float b, float c)
		{
			c -= b;
			return (0f - c) / 2f * (Mathf.Cos((float)Math.PI * t / 1f) - 1f) + b;
		}

		private static float InElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			float num4 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			if (num4 == 0f || num4 < Mathf.Abs(c))
			{
				num4 = c;
				num3 = num2 / 4f;
			}
			else
			{
				num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(c / num4);
			}
			return 0f - num4 * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * num - num3) * ((float)Math.PI * 2f) / num2) + b;
		}

		private static float OutElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			float num4 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			if (num4 == 0f || num4 < Mathf.Abs(c))
			{
				num4 = c;
				num3 = num2 / 4f;
			}
			else
			{
				num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(c / num4);
			}
			return num4 * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * num - num3) * ((float)Math.PI * 2f) / num2) + c + b;
		}

		private static float InBack(float t, float b, float c)
		{
			c -= b;
			t /= 1f;
			float num = 1.70158f;
			return c * t * t * ((num + 1f) * t - num) + b;
		}

		private static float OutBack(float t, float b, float c)
		{
			float num = 1.70158f;
			c -= b;
			t = t / 1f - 1f;
			return c * (t * t * ((num + 1f) * t + num) + 1f) + b;
		}
	}
	public class LargeHeader : PropertyAttribute
	{
		public string name;

		public string color = "white";

		public LargeHeader(string name)
		{
			this.name = name;
			color = "white";
		}

		public LargeHeader(string name, string color)
		{
			this.name = name;
			this.color = color;
		}
	}
	public static class LayerMaskExtensions
	{
		public static bool Contains(LayerMask mask, int layer)
		{
			return (int)mask == ((int)mask | (1 << layer));
		}

		public static LayerMask Create(params string[] layerNames)
		{
			return NamesToMask(layerNames);
		}

		public static LayerMask Create(params int[] layerNumbers)
		{
			return LayerNumbersToMask(layerNumbers);
		}

		public static LayerMask NamesToMask(params string[] layerNames)
		{
			LayerMask layerMask = 0;
			foreach (string layerName in layerNames)
			{
				layerMask = (int)layerMask | (1 << LayerMask.NameToLayer(layerName));
			}
			return layerMask;
		}

		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			LayerMask layerMask = 0;
			foreach (int num in layerNumbers)
			{
				layerMask = (int)layerMask | (1 << num);
			}
			return layerMask;
		}

		public static LayerMask Inverse(this LayerMask original)
		{
			return ~(int)original;
		}

		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return (int)original | (int)NamesToMask(layerNames);
		}

		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return ~((int)(LayerMask)(~(int)original) | (int)NamesToMask(layerNames));
		}

		public static string[] MaskToNames(this LayerMask original)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if (((int)original & num) == num)
				{
					string text = LayerMask.LayerToName(i);
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
			}
			return list.ToArray();
		}

		public static int[] MaskToNumbers(this LayerMask original)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if (((int)original & num) == num)
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}

		public static string MaskToString(this LayerMask original)
		{
			return original.MaskToString(", ");
		}

		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return string.Join(delimiter, original.MaskToNames());
		}
	}
	public static class QuaTools
	{
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Lerp(fromRotation, toRotation, weight);
		}

		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Slerp(fromRotation, toRotation, weight);
		}

		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Lerp(Quaternion.identity, q, weight);
		}

		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Slerp(Quaternion.identity, q, weight);
		}

		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
			float angle = 0f;
			Vector3 axis2 = Vector3.zero;
			quaternion.ToAngleAxis(out angle, out axis2);
			if (Vector3.Dot(axis2, axis) < 0f)
			{
				angle = 0f - angle;
			}
			return Quaternion.AngleAxis(angle, axis);
		}

		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return Quaternion.Inverse(Quaternion.Inverse(space) * rotation);
		}

		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			if (to == from)
			{
				return Quaternion.identity;
			}
			return to * Quaternion.Inverse(from);
		}

		public static Vector3 GetAxis(Vector3 v)
		{
			Vector3 vector = Vector3.right;
			bool flag = false;
			float num = Vector3.Dot(v, Vector3.right);
			float num2 = Mathf.Abs(num);
			if (num < 0f)
			{
				flag = true;
			}
			float num3 = Vector3.Dot(v, Vector3.up);
			float num4 = Mathf.Abs(num3);
			if (num4 > num2)
			{
				num2 = num4;
				vector = Vector3.up;
				flag = num3 < 0f;
			}
			float num5 = Vector3.Dot(v, Vector3.forward);
			num4 = Mathf.Abs(num5);
			if (num4 > num2)
			{
				vector = Vector3.forward;
				flag = num5 < 0f;
			}
			if (flag)
			{
				vector = -vector;
			}
			return vector;
		}

		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return Quaternion.identity;
			}
			if (clampWeight <= 0f)
			{
				return rotation;
			}
			float num = Quaternion.Angle(Quaternion.identity, rotation);
			float num2 = 1f - num / 180f;
			float num3 = Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f);
			float num4 = Mathf.Clamp(num2 / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return Quaternion.Slerp(Quaternion.identity, rotation, num4 * num3);
		}

		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return 0f;
			}
			if (clampWeight <= 0f)
			{
				return angle;
			}
			float num = 1f - Mathf.Abs(angle) / 180f;
			float num2 = Mathf.Clamp(1f - (clampWeight - num) / (1f - num), 0f, 1f);
			float num3 = Mathf.Clamp(num / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num3 = Mathf.Sin(num3 * (float)Math.PI * 0.5f);
			}
			return Mathf.Lerp(0f, angle, num3 * num2);
		}

		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			Quaternion rotation = Quaternion.LookRotation(forwardAxis, upAxis);
			Quaternion quaternion = Quaternion.LookRotation(targetforwardAxis, targetUpAxis);
			return targetRotation * quaternion * Quaternion.Inverse(rotation);
		}
	}
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static T sInstance;

		public static T instance => sInstance;

		protected virtual void Awake()
		{
			if (sInstance != null)
			{
				UnityEngine.Debug.LogError(base.name + "error: already initialized", this);
			}
			sInstance = (T)this;
		}
	}
	public class SolverManager : MonoBehaviour
	{
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms = true;

		private Animator animator;

		private Animation legacy;

		private bool updateFrame;

		private bool componentInitiated;

		private bool skipSolverUpdate;

		private bool animatePhysics
		{
			get
			{
				if (animator != null)
				{
					return animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
				}
				if (legacy != null)
				{
					return legacy.animatePhysics;
				}
				return false;
			}
		}

		private bool isAnimated
		{
			get
			{
				if (!(animator != null))
				{
					return legacy != null;
				}
				return true;
			}
		}

		public void Disable()
		{
			UnityEngine.Debug.Log("IK.Disable() is deprecated. Use enabled = false instead", base.transform);
			base.enabled = false;
		}

		protected virtual void InitiateSolver()
		{
		}

		protected virtual void UpdateSolver()
		{
		}

		protected virtual void FixTransforms()
		{
		}

		private void OnDisable()
		{
			if (Application.isPlaying)
			{
				Initiate();
			}
		}

		private void Start()
		{
			Initiate();
		}

		private void Initiate()
		{
			if (!componentInitiated)
			{
				FindAnimatorRecursive(base.transform, findInChildren: true);
				InitiateSolver();
				componentInitiated = true;
			}
		}

		private void Update()
		{
			if (!skipSolverUpdate && !animatePhysics && fixTransforms)
			{
				FixTransforms();
			}
		}

		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
			if (isAnimated)
			{
				return;
			}
			animator = t.GetComponent<Animator>();
			legacy = t.GetComponent<Animation>();
			if (!isAnimated)
			{
				if (animator == null && findInChildren)
				{
					animator = t.GetComponentInChildren<Animator>();
				}
				if (legacy == null && findInChildren)
				{
					legacy = t.GetComponentInChildren<Animation>();
				}
				if (!isAnimated && t.parent != null)
				{
					FindAnimatorRecursive(t.parent, findInChildren: false);
				}
			}
		}

		private void FixedUpdate()
		{
			if (skipSolverUpdate)
			{
				skipSolverUpdate = false;
			}
			updateFrame = true;
			if (animatePhysics && fixTransforms)
			{
				FixTransforms();
			}
		}

		private void LateUpdate()
		{
			if (!skipSolverUpdate)
			{
				if (!animatePhysics)
				{
					updateFrame = true;
				}
				if (updateFrame)
				{
					updateFrame = false;
					UpdateSolver();
				}
			}
		}

		public void UpdateSolverExternal()
		{
			if (base.enabled)
			{
				skipSolverUpdate = true;
				UpdateSolver();
			}
		}
	}
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		public GameObject target;

		private void OnTriggerEnter(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerEnter", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		private void OnTriggerStay(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerStay", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		private void OnTriggerExit(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerExit", collider, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	public static class V3Tools
	{
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Lerp(fromVector, toVector, weight);
		}

		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Slerp(fromVector, toVector, weight);
		}

		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			if (weight == 0f)
			{
				return Vector3.zero;
			}
			return Vector3.Project(v, verticalAxis) * weight;
		}

		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			if (weight == 0f)
			{
				return Vector3.zero;
			}
			Vector3 tangent = v;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return Vector3.Project(v, tangent) * weight;
		}

		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			changed = false;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				changed = true;
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				return direction;
			}
			changed = true;
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return Vector3.Slerp(normalDirection, direction, num4 * num3);
		}

		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			clampValue = 1f;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				clampValue = 0f;
				return direction;
			}
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			float num5 = num4 * num3;
			clampValue = 1f - num5;
			return Vector3.Slerp(normalDirection, direction, num5);
		}

		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			float num = Vector3.Dot(planePoint - origin, planeNormal);
			float num2 = Vector3.Dot(direction, planeNormal);
			if (num2 == 0f)
			{
				return Vector3.zero;
			}
			float num3 = num / num2;
			return origin + direction.normalized * num3;
		}

		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			if (planeNormal == Vector3.up)
			{
				return new Vector3(point.x, planePosition.y, point.z);
			}
			Vector3 tangent = point - planePosition;
			Vector3 normal = planeNormal;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return planePosition + Vector3.Project(point - planePosition, tangent);
		}
	}
	public static class Warning
	{
		public delegate void Logger(string message);

		public static bool logged;

		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
			if ((logInEditMode || Application.isPlaying) && !logged)
			{
				logger?.Invoke(message);
				logged = true;
			}
		}

		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
			if ((logInEditMode || Application.isPlaying) && !logged)
			{
				UnityEngine.Debug.LogWarning(message, context);
				logged = true;
			}
		}
	}
}
namespace RootMotion.Demos
{
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		public bool smoothFollow = true;

		public float smoothFollowSpeed = 20f;

		protected bool animatePhysics;

		private Vector3 lastPosition;

		private Vector3 localPosition;

		private Quaternion localRotation;

		private Quaternion lastRotation;

		public virtual bool animationGrounded => true;

		public virtual Vector3 GetPivotPoint()
		{
			return base.transform.position;
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		protected virtual void Start()
		{
			if (base.transform.parent.GetComponent<CharacterBase>() == null)
			{
				UnityEngine.Debug.LogWarning("Animation controllers should be parented to character controllers!", base.transform);
			}
			lastPosition = base.transform.position;
			localPosition = base.transform.parent.InverseTransformPoint(base.transform.position);
			lastRotation = base.transform.rotation;
			localRotation = Quaternion.Inverse(base.transform.parent.rotation) * base.transform.rotation;
		}

		protected virtual void LateUpdate()
		{
			if (!animatePhysics)
			{
				SmoothFollow();
			}
		}

		protected virtual void FixedUpdate()
		{
			if (animatePhysics)
			{
				SmoothFollow();
			}
		}

		private void SmoothFollow()
		{
			if (smoothFollow)
			{
				base.transform.position = Vector3.Lerp(lastPosition, base.transform.parent.TransformPoint(localPosition), Time.deltaTime * smoothFollowSpeed);
				base.transform.rotation = Quaternion.Lerp(lastRotation, base.transform.parent.rotation * localRotation, Time.deltaTime * smoothFollowSpeed);
			}
			lastPosition = base.transform.position;
			lastRotation = base.transform.rotation;
		}
	}
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[SerializeField]
		private CharacterThirdPerson characterController;

		[SerializeField]
		private float pivotOffset;

		[SerializeField]
		private AnimationCurve moveSpeed;

		private Animator animator;

		protected override void Start()
		{
			base.Start();
			animator = GetComponentInChildren<Animator>();
		}

		public override Vector3 GetPivotPoint()
		{
			if (pivotOffset == 0f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * pivotOffset;
		}

		private void Update()
		{
			float num = moveSpeed.Evaluate(characterController.animState.moveDirection.z);
			animator.SetFloat("Speed", num);
			characterController.Move(characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}
	}
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		public CharacterThirdPerson characterController;

		[SerializeField]
		private float turnSensitivity = 0.2f;

		[SerializeField]
		private float turnSpeed = 5f;

		[SerializeField]
		private float runCycleLegOffset = 0.2f;

		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier = 1f;

		protected Animator animator;

		private Vector3 lastForward;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private float deltaAngle;

		public override bool animationGrounded
		{
			get
			{
				if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Directional"))
				{
					return animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Strafe");
				}
				return true;
			}
		}

		protected override void Start()
		{
			base.Start();
			animator = GetComponent<Animator>();
			lastForward = base.transform.forward;
		}

		public override Vector3 GetPivotPoint()
		{
			return animator.pivotPosition;
		}

		protected virtual void Update()
		{
			if (Time.deltaTime != 0f)
			{
				animatePhysics = animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
				if (characterController.animState.jump)
				{
					float value = (float)((Mathf.Repeat(animator.GetCurrentAnimatorStateInfo(0).normalizedTime + runCycleLegOffset, 1f) < 0f) ? 1 : (-1)) * characterController.animState.moveDirection.z;
					animator.SetFloat("JumpLeg", value);
				}
				float num = 0f - GetAngleFromForward(lastForward) - deltaAngle;
				deltaAngle = 0f;
				lastForward = base.transform.forward;
				num *= turnSensitivity * 0.01f;
				num = Mathf.Clamp(num / Time.deltaTime, -1f, 1f);
				animator.SetFloat("Turn", Mathf.Lerp(animator.GetFloat("Turn"), num, Time.deltaTime * turnSpeed));
				animator.SetFloat("Forward", characterController.animState.moveDirection.z);
				animator.SetFloat("Right", characterController.animState.moveDirection.x);
				animator.SetBool("Crouch", characterController.animState.crouch);
				animator.SetBool("OnGround", characterController.animState.onGround);
				animator.SetBool("IsStrafing", characterController.animState.isStrafing);
				if (!characterController.animState.onGround)
				{
					animator.SetFloat("Jump", characterController.animState.yVelocity);
				}
				if (characterController.doubleJumpEnabled)
				{
					animator.SetBool("DoubleJump", characterController.animState.doubleJump);
				}
				characterController.animState.doubleJump = false;
				if (characterController.animState.onGround && characterController.animState.moveDirection.z > 0f)
				{
					animator.speed = animSpeedMultiplier;
				}
				else
				{
					animator.speed = 1f;
				}
			}
		}

		private void OnAnimatorMove()
		{
			Vector3 vector = animator.deltaRotation * Vector3.forward;
			deltaAngle += Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			characterController.Move(animator.deltaPosition, animator.deltaRotation);
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		[SerializeField]
		protected float gravityMultiplier = 2f;

		[SerializeField]
		protected float airborneThreshold = 0.6f;

		[SerializeField]
		private float slopeStartAngle = 50f;

		[SerializeField]
		private float slopeEndAngle = 85f;

		[SerializeField]
		private float spherecastRadius = 0.1f;

		[SerializeField]
		private LayerMask groundLayers;

		private PhysicMaterial zeroFrictionMaterial;

		private PhysicMaterial highFrictionMaterial;

		protected Rigidbody r;

		protected const float half = 0.5f;

		protected float originalHeight;

		protected Vector3 originalCenter;

		protected CapsuleCollider capsule;

		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		protected Vector3 GetGravity()
		{
			if (gravityTarget != null)
			{
				return (gravityTarget.position - base.transform.position).normalized * Physics.gravity.magnitude;
			}
			return Physics.gravity;
		}

		protected virtual void Start()
		{
			capsule = GetComponent<Collider>() as CapsuleCollider;
			r = GetComponent<Rigidbody>();
			originalHeight = capsule.height;
			originalCenter = capsule.center;
			zeroFrictionMaterial = new PhysicMaterial();
			zeroFrictionMaterial.dynamicFriction = 0f;
			zeroFrictionMaterial.staticFriction = 0f;
			zeroFrictionMaterial.frictionCombine = PhysicMaterialCombine.Minimum;
			zeroFrictionMaterial.bounciness = 0f;
			zeroFrictionMaterial.bounceCombine = PhysicMaterialCombine.Minimum;
			highFrictionMaterial = new PhysicMaterial();
			r.constraints = RigidbodyConstraints.FreezeRotation;
		}

		protected virtual RaycastHit GetSpherecastHit()
		{
			Vector3 up = base.transform.up;
			Ray ray = new Ray(r.position + up * airborneThreshold, -up);
			RaycastHit hitInfo = new RaycastHit
			{
				point = base.transform.position - base.transform.transform.up * airborneThreshold,
				normal = base.transform.up
			};
			Physics.SphereCast(ray, spherecastRadius, out hitInfo, airborneThreshold * 2f, groundLayers);
			return hitInfo;
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 vector = base.transform.position - point;
			r.MovePosition(point + quaternion * vector);
			r.MoveRotation(quaternion * base.transform.rotation);
		}

		protected void ScaleCapsule(float mlp)
		{
			if (capsule.height != originalHeight * mlp)
			{
				capsule.height = Mathf.MoveTowards(capsule.height, originalHeight * mlp, Time.deltaTime * 4f);
				capsule.center = Vector3.MoveTowards(capsule.center, originalCenter * mlp, Time.deltaTime * 2f);
			}
		}

		protected void HighFriction()
		{
			capsule.material = highFrictionMaterial;
		}

		protected void ZeroFriction()
		{
			capsule.material = zeroFrictionMaterial;
		}

		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			float num = 90f - Vector3.Angle(velocity, groundNormal);
			num -= slopeStartAngle;
			float num2 = slopeEndAngle - slopeStartAngle;
			return 1f - Mathf.Clamp(num / num2, 0f, 1f);
		}
	}
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		public enum MoveMode
		{
			Directional,
			Strafe
		}

		public struct AnimState
		{
			public Vector3 moveDirection;

			public bool jump;

			public bool crouch;

			public bool onGround;

			public bool isStrafing;

			public float yVelocity;

			public bool doubleJump;
		}

		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		public UserControlThirdPerson userControl;

		public CameraController cam;

		[Header("Movement")]
		public MoveMode moveMode;

		public bool smoothPhysics = true;

		public float smoothAccelerationTime = 0.2f;

		public float linearAccelerationSpeed = 3f;

		public float platformFriction = 7f;

		public float groundStickyEffect = 4f;

		public float maxVerticalVelocityOnGround = 3f;

		public float velocityToGroundTangentWeight;

		[Header("Rotation")]
		public bool lookInCameraDirection;

		public float turnSpeed = 5f;

		public float stationaryTurnSpeedMlp = 1f;

		[Header("Jumping and Falling")]
		public float airSpeed = 6f;

		public float airControl = 2f;

		public float jumpPower = 12f;

		public float jumpRepeatDelayTime;

		public bool doubleJumpEnabled;

		public float doubleJumpPowerMlp = 1f;

		[Header("Wall Running")]
		[SerializeField]
		private LayerMask wallRunLayers;

		public float wallRunMaxLength = 1f;

		public float wallRunMinMoveMag = 0.6f;

		public float wallRunMinVelocityY = -1f;

		public float wallRunRotationSpeed = 1.5f;

		public float wallRunMaxRotationAngle = 70f;

		public float wallRunWeightSpeed = 5f;

		[Header("Crouching")]
		public float crouchCapsuleScaleMlp = 0.6f;

		public AnimState animState;

		protected Vector3 moveDirection;

		private Animator animator;

		private Vector3 normal;

		private Vector3 platformVelocity;

		private Vector3 platformAngularVelocity;

		private RaycastHit hit;

		private float jumpLeg;

		private float jumpEndTime;

		private float forwardMlp;

		private float groundDistance;

		private float lastAirTime;

		private float stickyForce;

		private Vector3 wallNormal = Vector3.up;

		private Vector3 moveDirectionVelocity;

		private float wallRunWeight;

		private float lastWallRunWeight;

		private Vector3 fixedDeltaPosition;

		private Quaternion fixedDeltaRotation = Quaternion.identity;

		private bool fixedFrame;

		private float wallRunEndTime;

		private Vector3 gravity;

		private Vector3 verticalVelocity;

		private float velocityY;

		private bool doubleJumped;

		private bool jumpReleased;

		public bool onGround { get; private set; }

		protected override void Start()
		{
			base.Start();
			animator = GetComponent<Animator>();
			if (animator == null)
			{
				animator = characterAnimation.GetComponent<Animator>();
			}
			wallNormal = -gravity.normalized;
			onGround = true;
			animState.onGround = true;
			if (cam != null)
			{
				cam.enabled = false;
			}
		}

		private void OnAnimatorMove()
		{
			Move(animator.deltaPosition, animator.deltaRotation);
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
			fixedDeltaPosition += deltaPosition;
			fixedDeltaRotation *= deltaRotation;
		}

		private void FixedUpdate()
		{
			gravity = GetGravity();
			verticalVelocity = V3Tools.ExtractVertical(r.velocity, gravity, 1f);
			velocityY = verticalVelocity.magnitude;
			if (Vector3.Dot(verticalVelocity, gravity) > 0f)
			{
				velocityY = 0f - velocityY;
			}
			r.interpolation = (smoothPhysics ? RigidbodyInterpolation.Interpolate : RigidbodyInterpolation.None);
			characterAnimation.smoothFollow = smoothPhysics;
			MoveFixed(fixedDeltaPosition);
			fixedDeltaPosition = Vector3.zero;
			r.MoveRotation(base.transform.rotation * fixedDeltaRotation);
			fixedDeltaRotation = Quaternion.identity;
			Rotate();
			GroundCheck();
			if (userControl.state.move == Vector3.zero && groundDistance < airborneThreshold * 0.5f)
			{
				HighFriction();
			}
			else
			{
				ZeroFriction();
			}
			bool flag = onGround && userControl.state.move == Vector3.zero && r.velocity.magnitude < 0.5f && groundDistance < airborneThreshold * 0.5f;
			if (gravityTarget != null)
			{
				r.useGravity = false;
				if (!flag)
				{
					r.AddForce(gravity);
				}
			}
			if (flag)
			{
				r.useGravity = false;
				r.velocity = Vector3.zero;
			}
			else if (gravityTarget == null)
			{
				r.useGravity = true;
			}
			if (onGround)
			{
				animState.jump = Jump();
				jumpReleased = false;
				doubleJumped = false;
			}
			else
			{
				if (!userControl.state.jump)
				{
					jumpReleased = true;
				}
				if (jumpReleased && userControl.state.jump && !doubleJumped && doubleJumpEnabled)
				{
					jumpEndTime = Time.time + 0.1f;
					animState.doubleJump = true;
					Vector3 velocity = userControl.state.move * airSpeed;
					r.velocity = velocity;
					r.velocity += base.transform.up * jumpPower * doubleJumpPowerMlp;
					doubleJumped = true;
				}
			}
			ScaleCapsule(userControl.state.crouch ? crouchCapsuleScaleMlp : 1f);
			fixedFrame = true;
		}

		protected virtual void Update()
		{
			animState.onGround = onGround;
			animState.moveDirection = GetMoveDirection();
			animState.yVelocity = Mathf.Lerp(animState.yVelocity, velocityY, Time.deltaTime * 10f);
			animState.crouch = userControl.state.crouch;
			animState.isStrafing = moveMode == MoveMode.Strafe;
		}

		protected virtual void LateUpdate()
		{
			if (!(cam == null))
			{
				cam.UpdateInput();
				if (fixedFrame || r.interpolation != 0)
				{
					cam.UpdateTransform((r.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
					fixedFrame = false;
				}
			}
		}

		private void MoveFixed(Vector3 deltaPosition)
		{
			WallRun();
			Vector3 vector = deltaPosition / Time.deltaTime;
			vector += V3Tools.ExtractHorizontal(platformVelocity, gravity, 1f);
			if (onGround)
			{
				if (velocityToGroundTangentWeight > 0f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, normal);
					vector = Quaternion.Lerp(Quaternion.identity, b, velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = V3Tools.ExtractHorizontal(userControl.state.move * airSpeed, gravity, 1f);
				vector = Vector3.Lerp(r.velocity, b2, Time.deltaTime * airControl);
			}
			if (onGround && Time.time > jumpEndTime)
			{
				r.velocity -= base.transform.up * stickyForce * Time.deltaTime;
			}
			Vector3 vector2 = V3Tools.ExtractVertical(r.velocity, gravity, 1f);
			Vector3 vector3 = V3Tools.ExtractHorizontal(vector, gravity, 1f);
			if (onGround && Vector3.Dot(vector2, gravity) < 0f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, maxVerticalVelocityOnGround);
			}
			r.velocity = vector3 + vector2;
			forwardMlp = 1f;
		}

		private void WallRun()
		{
			bool flag = CanWallRun();
			if (wallRunWeight > 0f && !flag)
			{
				wallRunEndTime = Time.time;
			}
			if (Time.time < wallRunEndTime + 0.5f)
			{
				flag = false;
			}
			wallRunWeight = Mathf.MoveTowards(wallRunWeight, flag ? 1f : 0f, Time.deltaTime * wallRunWeightSpeed);
			if (wallRunWeight <= 0f && lastWallRunWeight > 0f)
			{
				Vector3 forward = V3Tools.ExtractHorizontal(base.transform.forward, gravity, 1f);
				base.transform.rotation = Quaternion.LookRotation(forward, -gravity);
				wallNormal = -gravity.normalized;
			}
			lastWallRunWeight = wallRunWeight;
			if (!(wallRunWeight <= 0f))
			{
				if (onGround && velocityY < 0f)
				{
					r.velocity = V3Tools.ExtractHorizontal(r.velocity, gravity, 1f);
				}
				Vector3 vector = V3Tools.ExtractHorizontal(base.transform.forward, gravity, 1f);
				RaycastHit hitInfo = default(RaycastHit);
				hitInfo.normal = -gravity.normalized;
				Physics.Raycast(onGround ? base.transform.position : capsule.bounds.center, vector, out hitInfo, 3f, wallRunLayers);
				wallNormal = Vector3.Lerp(wallNormal, hitInfo.normal, Time.deltaTime * wallRunRotationSpeed);
				wallNormal = Vector3.RotateTowards(-gravity.normalized, wallNormal, wallRunMaxRotationAngle * ((float)Math.PI / 180f), 0f);
				Vector3 tangent = base.transform.forward;
				Vector3 vector2 = wallNormal;
				Vector3.OrthoNormalize(ref vector2, ref tangent);
				base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -gravity), Quaternion.LookRotation(tangent, wallNormal), wallRunWeight);
			}
		}

		private bool CanWallRun()
		{
			if (Time.time < jumpEndTime - 0.1f)
			{
				return false;
			}
			if (Time.time > jumpEndTime - 0.1f + wallRunMaxLength)
			{
				return false;
			}
			if (velocityY < wallRunMinVelocityY)
			{
				return false;
			}
			if (userControl.state.move.magnitude < wallRunMinMoveMag)
			{
				return false;
			}
			return true;
		}

		private Vector3 GetMoveDirection()
		{
			switch (moveMode)
			{
			case MoveMode.Directional:
				moveDirection = Vector3.SmoothDamp(moveDirection, new Vector3(0f, 0f, userControl.state.move.magnitude), ref moveDirectionVelocity, smoothAccelerationTime);
				moveDirection = Vector3.MoveTowards(moveDirection, new Vector3(0f, 0f, userControl.state.move.magnitude), Time.deltaTime * linearAccelerationSpeed);
				return moveDirection * forwardMlp;
			case MoveMode.Strafe:
				moveDirection = Vector3.SmoothDamp(moveDirection, userControl.state.move, ref moveDirectionVelocity, smoothAccelerationTime);
				moveDirection = Vector3.MoveTowards(moveDirection, userControl.state.move, Time.deltaTime * linearAccelerationSpeed);
				return base.transform.InverseTransformDirection(moveDirection);
			default:
				return Vector3.zero;
			}
		}

		protected virtual void Rotate()
		{
			if (gravityTarget != null)
			{
				r.MoveRotation(Quaternion.FromToRotation(base.transform.up, base.transform.position - gravityTarget.position) * base.transform.rotation);
			}
			if (platformAngularVelocity != Vector3.zero)
			{
				r.MoveRotation(Quaternion.Euler(platformAngularVelocity) * base.transform.rotation);
			}
			float num = GetAngleFromForward(GetForwardDirection());
			if (userControl.state.move == Vector3.zero)
			{
				num *= (1.01f - Mathf.Abs(num) / 180f) * stationaryTurnSpeedMlp;
			}
			r.MoveRotation(Quaternion.AngleAxis(num * Time.deltaTime * turnSpeed, base.transform.up) * r.rotation);
		}

		private Vector3 GetForwardDirection()
		{
			bool flag = userControl.state.move != Vector3.zero;
			switch (moveMode)
			{
			case MoveMode.Directional:
				if (flag)
				{
					return userControl.state.move;
				}
				if (!lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return userControl.state.lookPos - r.position;
			case MoveMode.Strafe:
				if (flag)
				{
					return userControl.state.lookPos - r.position;
				}
				if (!lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return userControl.state.lookPos - r.position;
			default:
				return Vector3.zero;
			}
		}

		protected virtual bool Jump()
		{
			if (!userControl.state.jump)
			{
				return false;
			}
			if (userControl.state.crouch)
			{
				return false;
			}
			if (!characterAnimation.animationGrounded)
			{
				return false;
			}
			if (Time.time < lastAirTime + jumpRepeatDelayTime)
			{
				return false;
			}
			onGround = false;
			jumpEndTime = Time.time + 0.1f;
			Vector3 velocity = userControl.state.move * airSpeed;
			r.velocity = velocity;
			r.velocity += base.transform.up * jumpPower;
			return true;
		}

		private void GroundCheck()
		{
			Vector3 b = Vector3.zero;
			platformAngularVelocity = Vector3.zero;
			float num = 0f;
			hit = GetSpherecastHit();
			normal = base.transform.up;
			groundDistance = Vector3.Project(r.position - hit.point, base.transform.up).magnitude;
			if (Time.time > jumpEndTime && velocityY < jumpPower * 0.5f)
			{
				bool num2 = onGround;
				onGround = false;
				float num3 = ((!num2) ? (airborneThreshold * 0.5f) : airborneThreshold);
				float magnitude = V3Tools.ExtractHorizontal(r.velocity, gravity, 1f).magnitude;
				if (groundDistance < num3)
				{
					num = groundStickyEffect * magnitude * num3;
					if (hit.rigidbody != null)
					{
						b = hit.rigidbody.GetPointVelocity(hit.point);
						platformAngularVelocity = Vector3.Project(hit.rigidbody.angularVelocity, base.transform.up);
					}
					onGround = true;
				}
			}
			platformVelocity = Vector3.Lerp(platformVelocity, b, Time.deltaTime * platformFriction);
			stickyForce = num;
			if (!onGround)
			{
				lastAirTime = Time.time;
			}
		}
	}
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			Smooth,
			Linear
		}

		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime = 0.2f;

		[Tooltip("Turning speed.")]
		[SerializeField]
		private float turnTime = 0.2f;

		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault = true;

		[Tooltip("Smooth or linear rotation.")]
		[SerializeField]
		private RotationMode rotationMode;

		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed = 3f;

		private Animator animator;

		private float speed;

		private float angleVel;

		private float speedVel;

		private Vector3 linearTargetDirection;

		private CharacterController characterController;

		public bool isGrounded { get; private set; }

		private void Start()
		{
			animator = GetComponent<Animator>();
			characterController = GetComponent<CharacterController>();
			cameraController.enabled = false;
		}

		private void Update()
		{
			isGrounded = base.transform.position.y < 0.1f;
			Rotate();
			Move();
		}

		private void LateUpdate()
		{
			cameraController.UpdateInput();
			cameraController.UpdateTransform();
		}

		private void Rotate()
		{
			if (!isGrounded)
			{
				return;
			}
			Vector3 inputVector = GetInputVector();
			if (inputVector == Vector3.zero)
			{
				return;
			}
			Vector3 forward = base.transform.forward;
			switch (rotationMode)
			{
			case RotationMode.Smooth:
			{
				Vector3 vector = cameraController.transform.rotation * inputVector;
				float current = Mathf.Atan2(forward.x, forward.z) * 57.29578f;
				float target = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float angle = Mathf.SmoothDampAngle(current, target, ref angleVel, turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				break;
			}
			case RotationMode.Linear:
			{
				Vector3 inputVectorRaw = GetInputVectorRaw();
				if (inputVectorRaw != Vector3.zero)
				{
					linearTargetDirection = cameraController.transform.rotation * inputVectorRaw;
				}
				forward = Vector3.RotateTowards(forward, linearTargetDirection, Time.deltaTime * (1f / turnTime), 1f);
				forward.y = 0f;
				base.transform.rotation = Quaternion.LookRotation(forward);
				break;
			}
			}
		}

		private void Move()
		{
			float target = ((!walkByDefault) ? (Input.GetKey(KeyCode.LeftShift) ? 0.5f : 1f) : (Input.GetKey(KeyCode.LeftShift) ? 1f : 0.5f));
			speed = Mathf.SmoothDamp(speed, target, ref speedVel, accelerationTime);
			float num = GetInputVector().magnitude * speed;
			animator.SetFloat("Speed", num);
			if (!animator.hasRootMotion && isGrounded)
			{
				Vector3 vector = base.transform.forward * num * moveSpeed;
				if (characterController != null)
				{
					characterController.SimpleMove(vector);
				}
				else
				{
					base.transform.position += vector * Time.deltaTime;
				}
			}
		}

		private Vector3 GetInputVector()
		{
			Vector3 result = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			result.z += Mathf.Abs(result.x) * 0.05f;
			result.x -= Mathf.Abs(result.z) * 0.05f;
			return result;
		}

		private Vector3 GetInputVectorRaw()
		{
			return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		}
	}
	public class UserControlAI : UserControlThirdPerson
	{
		public Transform moveTarget;

		public float stoppingDistance = 0.5f;

		public float stoppingThreshold = 1.5f;

		public Navigator navigator;

		protected override void Start()
		{
			base.Start();
			navigator.Initiate(base.transform);
		}

		protected override void Update()
		{
			float num = (walkByDefault ? 0.5f : 1f);
			if (navigator.activeTargetSeeking)
			{
				navigator.Update(moveTarget.position);
				state.move = navigator.normalizedDeltaPosition * num;
				return;
			}
			Vector3 tangent = moveTarget.position - base.transform.position;
			float magnitude = tangent.magnitude;
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			float num2 = ((state.move != Vector3.zero) ? stoppingDistance : (stoppingDistance * stoppingThreshold));
			state.move = ((magnitude > num2) ? (tangent * num) : Vector3.zero);
			state.lookPos = moveTarget.position;
		}

		private void OnDrawGizmos()
		{
			if (navigator.activeTargetSeeking)
			{
				navigator.Visualize();
			}
		}
	}
	public class UserControlThirdPerson : MonoBehaviour
	{
		public struct State
		{
			public Vector3 move;

			public Vector3 lookPos;

			public bool crouch;

			public bool jump;

			public int actionIndex;
		}

		public bool walkByDefault;

		public bool canCrouch = true;

		public bool canJump = true;

		public State state;

		protected Transform cam;

		protected virtual void Start()
		{
			cam = Camera.main.transform;
		}

		protected virtual void Update()
		{
			state.crouch = canCrouch && Input.GetKey(KeyCode.C);
			state.jump = canJump && Input.GetButton("Jump");
			float axisRaw = Input.GetAxisRaw("Horizontal");
			float axisRaw2 = Input.GetAxisRaw("Vertical");
			Vector3 tangent = cam.rotation * new Vector3(axisRaw, 0f, axisRaw2).normalized;
			if (tangent != Vector3.zero)
			{
				Vector3 normal = base.transform.up;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				state.move = tangent;
			}
			else
			{
				state.move = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.LeftShift);
			float num = ((!walkByDefault) ? (key ? 0.5f : 1f) : (key ? 1f : 0.5f));
			state.move *= num;
			state.lookPos = base.transform.position + cam.forward * 100f;
		}
	}
	public class ApplicationQuit : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
		}
	}
	public class SlowMo : MonoBehaviour
	{
		[SerializeField]
		private KeyCode[] keyCodes;

		[SerializeField]
		private bool mouse0;

		[SerializeField]
		private bool mouse1;

		[SerializeField]
		private float slowMoTimeScale = 0.3f;

		private void Update()
		{
			Time.timeScale = (IsSlowMotion() ? slowMoTimeScale : 1f);
		}

		private bool IsSlowMotion()
		{
			if (mouse0 && Input.GetMouseButton(0))
			{
				return true;
			}
			if (mouse1 && Input.GetMouseButton(1))
			{
				return true;
			}
			for (int i = 0; i < keyCodes.Length; i++)
			{
				if (Input.GetKey(keyCodes[i]))
				{
					return true;
				}
			}
			return false;
		}
	}
	[Serializable]
	public class Navigator
	{
		public enum State
		{
			Idle,
			Seeking,
			OnPath
		}

		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius = 0.5f;

		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance = 1f;

		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance = 5f;

		[Tooltip("Interval of updating the path")]
		public float nextPathInterval = 3f;

		private Transform transform;

		private int cornerIndex;

		private Vector3[] corners = new Vector3[0];

		private NavMeshPath path;

		private Vector3 lastTargetPosition;

		private bool initiated;

		private float nextPathTime;

		public Vector3 normalizedDeltaPosition { get; private set; }

		public State state { get; private set; }

		public void Initiate(Transform transform)
		{
			this.transform = transform;
			path = new NavMeshPath();
			initiated = true;
			cornerIndex = 0;
			corners = new Vector3[0];
			state = State.Idle;
			lastTargetPosition = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
		}

		public void Update(Vector3 targetPosition)
		{
			if (!initiated)
			{
				UnityEngine.Debug.LogError("Trying to update an uninitiated Navigator.");
				return;
			}
			switch (state)
			{
			case State.Seeking:
				normalizedDeltaPosition = Vector3.zero;
				if (path.status == NavMeshPathStatus.PathComplete)
				{
					corners = path.corners;
					cornerIndex = 0;
					if (corners.Length == 0)
					{
						UnityEngine.Debug.LogWarning("Zero Corner Path", transform);
						Stop();
					}
					else
					{
						state = State.OnPath;
					}
				}
				if (path.status == NavMeshPathStatus.PathPartial)
				{
					UnityEngine.Debug.LogWarning("Path Partial", transform);
				}
				if (path.status == NavMeshPathStatus.PathInvalid)
				{
					UnityEngine.Debug.LogWarning("Path Invalid", transform);
				}
				break;
			case State.OnPath:
				if (activeTargetSeeking && Time.time > nextPathTime && HorDistance(targetPosition, lastTargetPosition) > recalculateOnPathDistance)
				{
					CalculatePath(targetPosition);
				}
				else
				{
					if (cornerIndex >= corners.Length)
					{
						break;
					}
					Vector3 vector = corners[cornerIndex] - transform.position;
					vector.y = 0f;
					float magnitude = vector.magnitude;
					if (magnitude > 0f)
					{
						normalizedDeltaPosition = vector / vector.magnitude;
					}
					else
					{
						normalizedDeltaPosition = Vector3.zero;
					}
					if (magnitude < cornerRadius)
					{
						cornerIndex++;
						if (cornerIndex >= corners.Length)
						{
							Stop();
						}
					}
				}
				break;
			case State.Idle:
				if (activeTargetSeeking && Time.time > nextPathTime)
				{
					CalculatePath(targetPosition);
				}
				break;
			}
		}

		private void CalculatePath(Vector3 targetPosition)
		{
			if (Find(targetPosition))
			{
				lastTargetPosition = targetPosition;
				state = State.Seeking;
			}
			else
			{
				Stop();
			}
			nextPathTime = Time.time + nextPathInterval;
		}

		private bool Find(Vector3 targetPosition)
		{
			if (HorDistance(transform.position, targetPosition) < cornerRadius * 2f)
			{
				return false;
			}
			if (NavMesh.CalculatePath(transform.position, targetPosition, -1, path))
			{
				return true;
			}
			NavMeshHit hit = default(NavMeshHit);
			if (NavMesh.SamplePosition(targetPosition, out hit, maxSampleDistance, -1) && NavMesh.CalculatePath(transform.position, hit.position, -1, path))
			{
				return true;
			}
			return false;
		}

		private void Stop()
		{
			state = State.Idle;
			normalizedDeltaPosition = Vector3.zero;
		}

		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return Vector2.Distance(new Vector2(p1.x, p1.z), new Vector2(p2.x, p2.z));
		}

		public void Visualize()
		{
			if (state == State.Idle)
			{
				Gizmos.color = Color.gray;
			}
			if (state == State.Seeking)
			{
				Gizmos.color = Color.red;
			}
			if (state == State.OnPath)
			{
				Gizmos.color = Color.green;
			}
			if (corners.Length != 0 && state == State.OnPath && cornerIndex == 0)
			{
				Gizmos.DrawLine(transform.position, corners[0]);
			}
			for (int i = 0; i < corners.Length; i++)
			{
				Gizmos.DrawSphere(corners[i], 0.1f);
			}
			if (corners.Length > 1)
			{
				for (int j = 0; j < corners.Length - 1; j++)
				{
					Gizmos.DrawLine(corners[j], corners[j + 1]);
				}
			}
			Gizmos.color = Color.white;
		}
	}
}
namespace RootMotion.FinalIK
{
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		public BipedReferences references = new BipedReferences();

		public BipedIKSolvers solvers = new BipedIKSolvers();

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page2.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return GetGoalIK(goal).GetIKPositionWeight();
		}

		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return GetGoalIK(goal).GetIKRotationWeight();
		}

		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
			GetGoalIK(goal).SetIKPositionWeight(weight);
		}

		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
			GetGoalIK(goal).SetIKRotationWeight(weight);
		}

		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
			GetGoalIK(goal).SetIKPosition(IKPosition);
		}

		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
			GetGoalIK(goal).SetIKRotation(IKRotation);
		}

		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return GetGoalIK(goal).GetIKPosition();
		}

		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return GetGoalIK(goal).GetIKRotation();
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
			solvers.lookAt.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight, clampWeightHead, clampWeightEyes);
		}

		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			solvers.lookAt.SetIKPosition(lookAtPosition);
		}

		public void SetSpinePosition(Vector3 spinePosition)
		{
			solvers.spine.SetIKPosition(spinePosition);
		}

		public void SetSpineWeight(float weight)
		{
			solvers.spine.SetIKPositionWeight(weight);
		}

		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return goal switch
			{
				AvatarIKGoal.LeftFoot => solvers.leftFoot, 
				AvatarIKGoal.RightFoot => solvers.rightFoot, 
				AvatarIKGoal.LeftHand => solvers.leftHand, 
				AvatarIKGoal.RightHand => solvers.rightHand, 
				_ => null, 
			};
		}

		public void InitiateBipedIK()
		{
			InitiateSolver();
		}

		public void UpdateBipedIK()
		{
			UpdateSolver();
		}

		public void SetToDefaults()
		{
			IKSolverLimb[] limbs = solvers.limbs;
			foreach (IKSolverLimb obj in limbs)
			{
				obj.SetIKPositionWeight(0f);
				obj.SetIKRotationWeight(0f);
				obj.bendModifier = IKSolverLimb.BendModifier.Animation;
				obj.bendModifierWeight = 1f;
			}
			solvers.leftHand.maintainRotationWeight = 0f;
			solvers.rightHand.maintainRotationWeight = 0f;
			solvers.spine.SetIKPositionWeight(0f);
			solvers.spine.tolerance = 0f;
			solvers.spine.maxIterations = 2;
			solvers.spine.useRotationLimits = false;
			solvers.aim.SetIKPositionWeight(0f);
			solvers.aim.tolerance = 0f;
			solvers.aim.maxIterations = 2;
			SetLookAtWeight(0f, 0.5f, 1f, 1f, 0.5f, 0.7f, 0.5f);
		}

		protected override void FixTransforms()
		{
			solvers.lookAt.FixTransforms();
			for (int i = 0; i < solvers.limbs.Length; i++)
			{
				solvers.limbs[i].FixTransforms();
			}
		}

		protected override void InitiateSolver()
		{
			string errorMessage = "";
			if (BipedReferences.SetupError(references, ref errorMessage))
			{
				Warning.Log(errorMessage, references.root);
				return;
			}
			solvers.AssignReferences(references);
			if (solvers.spine.bones.Length > 1)
			{
				solvers.spine.Initiate(base.transform);
			}
			solvers.lookAt.Initiate(base.transform);
			solvers.aim.Initiate(base.transform);
			IKSolverLimb[] limbs = solvers.limbs;
			for (int i = 0; i < limbs.Length; i++)
			{
				limbs[i].Initiate(base.transform);
			}
			solvers.pelvis.Initiate(references.pelvis);
		}

		protected override void UpdateSolver()
		{
			for (int i = 0; i < solvers.limbs.Length; i++)
			{
				solvers.limbs[i].MaintainBend();
				solvers.limbs[i].MaintainRotation();
			}
			solvers.pelvis.Update();
			if (solvers.spine.bones.Length > 1)
			{
				solvers.spine.Update();
			}
			solvers.aim.Update();
			solvers.lookAt.Update();
			for (int j = 0; j < solvers.limbs.Length; j++)
			{
				solvers.limbs[j].Update();
			}
		}

		public void LogWarning(string message)
		{
			Warning.Log(message, base.transform);
		}
	}
	[Serializable]
	public class BipedIKSolvers
	{
		public IKSolverLimb leftFoot = new IKSolverLimb(AvatarIKGoal.LeftFoot);

		public IKSolverLimb rightFoot = new IKSolverLimb(AvatarIKGoal.RightFoot);

		public IKSolverLimb leftHand = new IKSolverLimb(AvatarIKGoal.LeftHand);

		public IKSolverLimb rightHand = new IKSolverLimb(AvatarIKGoal.RightHand);

		public IKSolverFABRIK spine = new IKSolverFABRIK();

		public IKSolverLookAt lookAt = new IKSolverLookAt();

		public IKSolverAim aim = new IKSolverAim();

		public Constraints pelvis = new Constraints();

		private IKSolverLimb[] _limbs;

		private IKSolver[] _ikSolvers;

		public IKSolverLimb[] limbs
		{
			get
			{
				if (_limbs == null || (_limbs != null && _limbs.Length != 4))
				{
					_limbs = new IKSolverLimb[4] { leftFoot, rightFoot, leftHand, rightHand };
				}
				return _limbs;
			}
		}

		public IKSolver[] ikSolvers
		{
			get
			{
				if (_ikSolvers == null || (_ikSolvers != null && _ikSolvers.Length != 7))
				{
					_ikSolvers = new IKSolver[7] { leftFoot, rightFoot, leftHand, rightHand, spine, lookAt, aim };
				}
				return _ikSolvers;
			}
		}

		public void AssignReferences(BipedReferences references)
		{
			leftHand.SetChain(references.leftUpperArm, references.leftForearm, references.leftHand, references.root);
			rightHand.SetChain(references.rightUpperArm, references.rightForearm, references.rightHand, references.root);
			leftFoot.SetChain(references.leftThigh, references.leftCalf, references.leftFoot, references.root);
			rightFoot.SetChain(references.rightThigh, references.rightCalf, references.rightFoot, references.root);
			spine.SetChain(references.spine, references.root);
			lookAt.SetChain(references.spine, references.head, references.eyes, references.root);
			aim.SetChain(references.spine, references.root);
			leftFoot.goal = AvatarIKGoal.LeftFoot;
			rightFoot.goal = AvatarIKGoal.RightFoot;
			leftHand.goal = AvatarIKGoal.LeftHand;
			rightHand.goal = AvatarIKGoal.RightHand;
		}
	}
	[Serializable]
	public abstract class Constraint
	{
		public Transform transform;

		public float weight;

		public bool isValid => transform != null;

		public abstract void UpdateConstraint();
	}
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		public Vector3 position;

		public override void UpdateConstraint()
		{
			if (!(weight <= 0f) && base.isValid)
			{
				transform.position = Vector3.Lerp(transform.position, position, weight);
			}
		}

		public ConstraintPosition()
		{
		}

		public ConstraintPosition(Transform transform)
		{
			base.transform = transform;
		}
	}
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		public Vector3 offset;

		private Vector3 defaultLocalPosition;

		private Vector3 lastLocalPosition;

		private bool initiated;

		private bool positionChanged => transform.localPosition != lastLocalPosition;

		public override void UpdateConstraint()
		{
			if (!(weight <= 0f) && base.isValid)
			{
				if (!initiated)
				{
					defaultLocalPosition = transform.localPosition;
					lastLocalPosition = transform.localPosition;
					initiated = true;
				}
				if (positionChanged)
				{
					defaultLocalPosition = transform.localPosition;
				}
				transform.localPosition = defaultLocalPosition;
				transform.position += offset * weight;
				lastLocalPosition = transform.localPosition;
			}
		}

		public ConstraintPositionOffset()
		{
		}

		public ConstraintPositionOffset(Transform transform)
		{
			base.transform = transform;
		}
	}
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		public Quaternion rotation;

		public override void UpdateConstraint()
		{
			if (!(weight <= 0f) && base.isValid)
			{
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, weight);
			}
		}

		public ConstraintRotation()
		{
		}

		public ConstraintRotation(Transform transform)
		{
			base.transform = transform;
		}
	}
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		public Quaternion offset;

		private Quaternion defaultRotation;

		private Quaternion defaultLocalRotation;

		private Quaternion lastLocalRotation;

		private Quaternion defaultTargetLocalRotation;

		private bool initiated;

		private bool rotationChanged => transform.localRotation != lastLocalRotation;

		public override void UpdateConstraint()
		{
			if (!(weight <= 0f) && base.isValid)
			{
				if (!initiated)
				{
					defaultLocalRotation = transform.localRotation;
					lastLocalRotation = transform.localRotation;
					initiated = true;
				}
				if (rotationChanged)
				{
					defaultLocalRotation = transform.localRotation;
				}
				transform.localRotation = defaultLocalRotation;
				transform.rotation = Quaternion.Slerp(transform.rotation, offset, weight);
				lastLocalRotation = transform.localRotation;
			}
		}

		public ConstraintRotationOffset()
		{
		}

		public ConstraintRotationOffset(Transform transform)
		{
			base.transform = transform;
		}
	}
	[Serializable]
	public class Constraints
	{
		public Transform transform;

		public Transform target;

		public Vector3 positionOffset;

		public Vector3 position;

		[Range(0f, 1f)]
		public float positionWeight;

		public Vector3 rotationOffset;

		public Vector3 rotation;

		[Range(0f, 1f)]
		public float rotationWeight;

		public bool IsValid()
		{
			return transform != null;
		}

		public void Initiate(Transform transform)
		{
			this.transform = transform;
			position = transform.position;
			rotation = transform.eulerAngles;
		}

		public void Update()
		{
			if (IsValid())
			{
				if (target != null)
				{
					position = target.position;
				}
				transform.position += positionOffset;
				if (positionWeight > 0f)
				{
					transform.position = Vector3.Lerp(transform.position, position, positionWeight);
				}
				if (target != null)
				{
					rotation = target.eulerAngles;
				}
				transform.rotation = Quaternion.Euler(rotationOffset) * transform.rotation;
				if (rotationWeight > 0f)
				{
					transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotation), rotationWeight);
				}
			}
		}
	}
	[Serializable]
	public class Finger
	{
		[Serializable]
		public enum DOF
		{
			One,
			Three
		}

		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight = 1f;

		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		private IKSolverLimb solver;

		private Quaternion bone3RelativeToTarget;

		private Vector3 bone3DefaultLocalPosition;

		private Quaternion bone3DefaultLocalRotation;

		private Vector3 bone1Axis;

		private Vector3 tipAxis;

		public bool initiated { get; private set; }

		public Vector3 IKPosition
		{
			get
			{
				return solver.IKPosition;
			}
			set
			{
				solver.IKPosition = value;
			}
		}

		public Quaternion IKRotation
		{
			get
			{
				return solver.IKRotation;
			}
			set
			{
				solver.IKRotation = value;
			}
		}

		public bool IsValid(ref string errorMessage)
		{
			if (bone1 == null || bone2 == null || tip == null)
			{
				errorMessage = "One of the bones in the Finger Rig is null, can not initiate solvers.";
				return false;
			}
			return true;
		}

		public void Initiate(Transform hand, int index)
		{
			initiated = false;
			string errorMessage = string.Empty;
			if (!IsValid(ref errorMessage))
			{
				Warning.Log(errorMessage, hand);
				return;
			}
			solver = new IKSolverLimb();
			solver.IKPositionWeight = weight;
			solver.bendModifier = IKSolverLimb.BendModifier.Target;
			solver.bendModifierWeight = 1f;
			Vector3 vector = Vector3.Cross(bone2.position - bone1.position, tip.position - bone1.position);
			bone1Axis = Quaternion.Inverse(bone1.rotation) * vector;
			tipAxis = Quaternion.Inverse(tip.rotation) * vector;
			IKPosition = tip.position;
			IKRotation = tip.rotation;
			if (bone3 != null)
			{
				bone3RelativeToTarget = Quaternion.Inverse(IKRotation) * bone3.rotation;
				bone3DefaultLocalPosition = bone3.localPosition;
				bone3DefaultLocalRotation = bone3.localRotation;
			}
			solver.SetChain(bone1, bone2, tip, hand);
			solver.Initiate(hand);
			initiated = true;
		}

		public void FixTransforms()
		{
			if (initiated && !(weight <= 0f))
			{
				solver.FixTransforms();
				if (bone3 != null)
				{
					bone3.localPosition = bone3DefaultLocalPosition;
					bone3.localRotation = bone3DefaultLocalRotation;
				}
			}
		}

		public void StoreDefaultLocalState()
		{
			if (initiated)
			{
				solver.StoreDefaultLocalState();
				if (bone3 != null)
				{
					bone3DefaultLocalPosition = bone3.localPosition;
					bone3DefaultLocalRotation = bone3.localRotation;
				}
			}
		}

		public void Update(float masterWeight)
		{
			if (!initiated)
			{
				return;
			}
			float num = weight * masterWeight;
			if (num <= 0f)
			{
				return;
			}
			solver.target = target;
			if (target != null)
			{
				IKPosition = target.position;
				IKRotation = target.rotation;
			}
			if (rotationDOF == DOF.One)
			{
				Quaternion quaternion = Quaternion.FromToRotation(IKRotation * tipAxis, bone1.rotation * bone1Axis);
				IKRotation = quaternion * IKRotation;
			}
			if (bone3 != null)
			{
				if (num * rotationWeight >= 1f)
				{
					bone3.rotation = IKRotation * bone3RelativeToTarget;
				}
				else
				{
					bone3.rotation = Quaternion.Lerp(bone3.rotation, IKRotation * bone3RelativeToTarget, num * rotationWeight);
				}
			}
			solver.IKPositionWeight = num;
			solver.IKRotationWeight = rotationWeight;
			solver.bendModifierWeight = rotationWeight;
			solver.Update();
		}
	}
	public class FingerRig : SolverManager
	{
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		public Finger[] fingers = new Finger[0];

		public bool initiated { get; private set; }

		public bool IsValid(ref string errorMessage)
		{
			Finger[] array = fingers;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].IsValid(ref errorMessage))
				{
					return false;
				}
			}
			return true;
		}

		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
			fingers = new Finger[0];
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Transform[] array = new Transform[0];
				AddChildrenRecursive(base.transform.GetChild(i), ref array);
				if (array.Length == 3 || array.Length == 4)
				{
					Finger finger = new Finger();
					finger.bone1 = array[0];
					finger.bone2 = array[1];
					if (array.Length == 3)
					{
						finger.tip = array[2];
					}
					else
					{
						finger.bone3 = array[2];
						finger.tip = array[3];
					}
					finger.weight = 1f;
					Array.Resize(ref fingers, fingers.Length + 1);
					fingers[fingers.Length - 1] = finger;
				}
			}
		}

		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null)
		{
			Finger finger = new Finger();
			finger.bone1 = bone1;
			finger.bone2 = bone2;
			finger.bone3 = bone3;
			finger.tip = tip;
			finger.target = target;
			Array.Resize(ref fingers, fingers.Length + 1);
			fingers[fingers.Length - 1] = finger;
			initiated = false;
			finger.Initiate(base.transform, fingers.Length - 1);
			if (fingers[fingers.Length - 1].initiated)
			{
				initiated = true;
			}
		}

		public void RemoveFinger(int index)
		{
			if ((float)index < 0f || index >= fingers.Length)
			{
				Warning.Log("RemoveFinger index out of bounds.", base.transform);
				return;
			}
			if (fingers.Length == 1)
			{
				fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[fingers.Length - 1];
			int num = 0;
			for (int i = 0; i < fingers.Length; i++)
			{
				if (i != index)
				{
					array[num] = fingers[i];
					num++;
				}
			}
			fingers = array;
		}

		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
			Array.Resize(ref array, array.Length + 1);
			array[array.Length - 1] = parent;
			if (parent.childCount == 1)
			{
				AddChildrenRecursive(parent.GetChild(0), ref array);
			}
		}

		protected override void InitiateSolver()
		{
			initiated = true;
			for (int i = 0; i < fingers.Length; i++)
			{
				fingers[i].Initiate(base.transform, i);
				if (!fingers[i].initiated)
				{
					initiated = false;
				}
			}
		}

		public void UpdateFingerSolvers()
		{
			Finger[] array = fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(weight);
			}
		}

		public void FixFingerTransforms()
		{
			if (!(weight <= 0f))
			{
				Finger[] array = fingers;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].FixTransforms();
				}
			}
		}

		public void StoreDefaultLocalState()
		{
			Finger[] array = fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].StoreDefaultLocalState();
			}
		}

		protected override void UpdateSolver()
		{
			UpdateFingerSolvers();
		}

		protected override void FixTransforms()
		{
			if (!(weight <= 0f))
			{
				FixFingerTransforms();
			}
		}
	}
	public abstract class Grounder : MonoBehaviour
	{
		public delegate void GrounderDelegate();

		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver = new Grounding();

		public GrounderDelegate OnPreGrounder;

		public GrounderDelegate OnPostGrounder;

		public bool initiated { get; protected set; }

		public abstract void ResetPosition();

		protected Vector3 GetSpineOffsetTarget()
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < solver.legs.Length; i++)
			{
				zero += GetLegSpineBendVector(solver.legs[i]);
			}
			return zero;
		}

		protected void LogWarning(string message)
		{
			Warning.Log(message, base.transform);
		}

		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			Vector3 legSpineTangent = GetLegSpineTangent(leg);
			float num = (Vector3.Dot(solver.root.forward, legSpineTangent.normalized) + 1f) * 0.5f;
			float magnitude = (leg.IKPosition - leg.transform.position).magnitude;
			return legSpineTangent * magnitude * num;
		}

		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			Vector3 tangent = leg.transform.position - solver.root.position;
			if (!solver.rotateSolver || solver.root.up == Vector3.up)
			{
				return new Vector3(tangent.x, 0f, tangent.z);
			}
			Vector3 normal = solver.root.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return tangent;
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 7f;

		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		private Transform[] feet = new Transform[2];

		private Quaternion[] footRotations = new Quaternion[2];

		private Vector3 animatedPelvisLocalPosition;

		private Vector3 solvedPelvisLocalPosition;

		private Vector3 spineOffset;

		private float lastWeight;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html");
		}

		public override void ResetPosition()
		{
			solver.Reset();
			spineOffset = Vector3.zero;
		}

		private bool IsReadyToInitiate()
		{
			if (ik == null)
			{
				return false;
			}
			if (!ik.solvers.leftFoot.initiated)
			{
				return false;
			}
			if (!ik.solvers.rightFoot.initiated)
			{
				return false;
			}
			return true;
		}

		private void Update()
		{
			weight = Mathf.Clamp(weight, 0f, 1f);
			if (!(weight <= 0f) && !base.initiated && IsReadyToInitiate())
			{
				Initiate();
			}
		}

		private void Initiate()
		{
			feet = new Transform[2];
			footRotations = new Quaternion[2];
			feet[0] = ik.references.leftFoot;
			feet[1] = ik.references.rightFoot;
			footRotations[0] = Quaternion.identity;
			footRotations[1] = Quaternion.identity;
			IKSolverFABRIK spine = ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(spine.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
			IKSolverLimb rightFoot = ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			animatedPelvisLocalPosition = ik.references.pelvis.localPosition;
			solver.Initiate(ik.references.root, feet);
			base.initiated = true;
		}

		private void OnDisable()
		{
			if (base.initiated)
			{
				ik.solvers.leftFoot.IKPositionWeight = 0f;
				ik.solvers.rightFoot.IKPositionWeight = 0f;
			}
		}

		private void OnSolverUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (weight <= 0f)
			{
				if (lastWeight <= 0f)
				{
					return;
				}
				OnDisable();
			}
			lastWeight = weight;
			if (OnPreGrounder != null)
			{
				OnPreGrounder();
			}
			if (ik.references.pelvis.localPosition != solvedPelvisLocalPosition)
			{
				animatedPelvisLocalPosition = ik.references.pelvis.localPosition;
			}
			else
			{
				ik.references.pelvis.localPosition = animatedPelvisLocalPosition;
			}
			solver.Update();
			ik.references.pelvis.position += solver.pelvis.IKOffset * weight;
			SetLegIK(ik.solvers.leftFoot, 0);
			SetLegIK(ik.solvers.rightFoot, 1);
			if (spineBend != 0f && ik.references.spine.Length != 0)
			{
				spineSpeed = Mathf.Clamp(spineSpeed, 0f, spineSpeed);
				Vector3 vector = GetSpineOffsetTarget() * weight;
				spineOffset = Vector3.Lerp(spineOffset, vector * spineBend, Time.deltaTime * spineSpeed);
				Quaternion rotation = ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = ik.references.rightUpperArm.rotation;
				Vector3 up = solver.up;
				Quaternion quaternion = Quaternion.FromToRotation(up, up + spineOffset);
				ik.references.spine[0].rotation = quaternion * ik.references.spine[0].rotation;
				ik.references.leftUpperArm.rotation = rotation;
				ik.references.rightUpperArm.rotation = rotation2;
			}
			if (OnPostGrounder != null)
			{
				OnPostGrounder();
			}
		}

		private void SetLegIK(IKSolverLimb limb, int index)
		{
			footRotations[index] = feet[index].rotation;
			limb.IKPosition = solver.legs[index].IKPosition;
			limb.IKPositionWeight = weight;
		}

		private void OnPostSolverUpdate()
		{
			if (!(weight <= 0f) && base.enabled)
			{
				for (int i = 0; i < feet.Length; i++)
				{
					feet[i].rotation = Quaternion.Slerp(Quaternion.identity, solver.legs[i].rotationOffset, weight) * footRotations[i];
				}
				solvedPelvisLocalPosition = ik.references.pelvis.localPosition;
			}
		}

		private void OnDestroy()
		{
			if (base.initiated && ik != null)
			{
				IKSolverFABRIK spine = ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(spine.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
				IKSolverLimb rightFoot = ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			}
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		public class SpineEffector
		{
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight = 1f;

			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			public SpineEffector()
			{
			}

			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
				this.effectorType = effectorType;
				this.horizontalWeight = horizontalWeight;
				this.verticalWeight = verticalWeight;
			}
		}

		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 2f;

		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		public SpineEffector[] spine = new SpineEffector[0];

		private Transform[] feet = new Transform[2];

		private Vector3 spineOffset;

		private bool firstSolve;

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html");
		}

		public override void ResetPosition()
		{
			solver.Reset();
			spineOffset = Vector3.zero;
		}

		private bool IsReadyToInitiate()
		{
			if (ik == null)
			{
				return false;
			}
			if (!ik.solver.initiated)
			{
				return false;
			}
			return true;
		}

		private void Update()
		{
			firstSolve = true;
			weight = Mathf.Clamp(weight, 0f, 1f);
			if (!(weight <= 0f) && !base.initiated && IsReadyToInitiate())
			{
				Initiate();
			}
		}

		private void FixedUpdate()
		{
			firstSolve = true;
		}

		private void LateUpdate()
		{
			firstSolve = true;
		}

		private void Initiate()
		{
			ik.solver.leftLegMapping.maintainRotationWeight = 1f;
			ik.solver.rightLegMapping.maintainRotationWeight = 1f;
			feet = new Transform[2];
			feet[0] = ik.solver.leftFootEffector.bone;
			feet[1] = ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped iKSolverFullBodyBiped = ik.solver;
			iKSolverFullBodyBiped.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolverFullBodyBiped.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
			solver.Initiate(ik.references.root, feet);
			base.initiated = true;
		}

		private void OnSolverUpdate()
		{
			if (!firstSolve)
			{
				return;
			}
			firstSolve = false;
			if (!base.enabled || weight <= 0f)
			{
				return;
			}
			if (OnPreGrounder != null)
			{
				OnPreGrounder();
			}
			solver.Update();
			ik.references.pelvis.position += solver.pelvis.IKOffset * weight;
			SetLegIK(ik.solver.leftFootEffector, solver.legs[0]);
			SetLegIK(ik.solver.rightFootEffector, solver.legs[1]);
			if (spineBend != 0f)
			{
				spineSpeed = Mathf.Clamp(spineSpeed, 0f, spineSpeed);
				Vector3 vector = GetSpineOffsetTarget() * weight;
				spineOffset = Vector3.Lerp(spineOffset, vector * spineBend, Time.deltaTime * spineSpeed);
				Vector3 vector2 = ik.references.root.up * spineOffset.magnitude;
				for (int i = 0; i < spine.Length; i++)
				{
					ik.solver.GetEffector(spine[i].effectorType).positionOffset += spineOffset * spine[i].horizontalWeight + vector2 * spine[i].verticalWeight;
				}
			}
			if (OnPostGrounder != null)
			{
				OnPostGrounder();
			}
		}

		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
			effector.positionOffset += (leg.IKPosition - effector.bone.position) * weight;
			effector.bone.rotation = Quaternion.Slerp(Quaternion.identity, leg.rotationOffset, weight) * effector.bone.rotation;
		}

		private void OnDrawGizmosSelected()
		{
			if (ik == null)
			{
				ik = GetComponent<FullBodyBipedIK>();
			}
			if (ik == null)
			{
				ik = GetComponentInParent<FullBodyBipedIK>();
			}
			if (ik == null)
			{
				ik = GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		private void OnDestroy()
		{
			if (base.initiated && ik != null)
			{
				IKSolverFullBodyBiped iKSolverFullBodyBiped = ik.solver;
				iKSolverFullBodyBiped.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolverFullBodyBiped.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
			}
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		public IK[] legs;

		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed = 5f;

		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle = 45f;

		private Transform[] feet = new Transform[0];

		private Quaternion[] footRotations = new Quaternion[0];

		private Vector3 animatedPelvisLocalPosition;

		private Vector3 solvedPelvisLocalPosition;

		private int solvedFeet;

		private bool solved;

		private float lastWeight;

		private Rigidbody characterRootRigidbody;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html");
		}

		public override void ResetPosition()
		{
			solver.Reset();
		}

		private bool IsReadyToInitiate()
		{
			if (pelvis == null)
			{
				return false;
			}
			if (legs.Length == 0)
			{
				return false;
			}
			IK[] array = legs;
			foreach (IK iK in array)
			{
				if (iK == null)
				{
					return false;
				}
				if (iK is FullBodyBipedIK)
				{
					LogWarning("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.");
					return false;
				}
				if (iK is FABRIKRoot)
				{
					LogWarning("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
				if (iK is AimIK)
				{
					LogWarning("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
			}
			return true;
		}

		private void OnDisable()
		{
			if (!base.initiated)
			{
				return;
			}
			for (int i = 0; i < legs.Length; i++)
			{
				if (legs[i] != null)
				{
					legs[i].GetIKSolver().IKPositionWeight = 0f;
				}
			}
		}

		private void Update()
		{
			weight = Mathf.Clamp(weight, 0f, 1f);
			if (weight <= 0f)
			{
				return;
			}
			solved = false;
			if (base.initiated)
			{
				rootRotationWeight = Mathf.Clamp(rootRotationWeight, 0f, 1f);
				rootRotationSpeed = Mathf.Clamp(rootRotationSpeed, 0f, rootRotationSpeed);
				if (characterRoot != null && rootRotationSpeed > 0f && rootRotationWeight > 0f)
				{
					Vector3 vector = solver.GetLegsPlaneNormal();
					if (rootRotationWeight < 1f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * characterRoot.rotation, maxRootRotationAngle);
					if (characterRootRigidbody == null)
					{
						characterRoot.rotation = Quaternion.Lerp(characterRoot.rotation, b, Time.deltaTime * rootRotationSpeed);
					}
					else
					{
						characterRootRigidbody.MoveRotation(Quaternion.Lerp(characterRoot.rotation, b, Time.deltaTime * rootRotationSpeed));
					}
				}
			}
			else if (IsReadyToInitiate())
			{
				Initiate();
			}
		}

		private void Initiate()
		{
			feet = new Transform[legs.Length];
			footRotations = new Quaternion[legs.Length];
			for (int i = 0; i < feet.Length; i++)
			{
				footRotations[i] = Quaternion.identity;
			}
			for (int j = 0; j < legs.Length; j++)
			{
				IKSolver.Point[] points = legs[j].GetIKSolver().GetPoints();
				feet[j] = points[^1].transform;
				IKSolver iKSolver = legs[j].GetIKSolver();
				iKSolver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
				IKSolver iKSolver2 = legs[j].GetIKSolver();
				iKSolver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			}
			animatedPelvisLocalPosition = pelvis.localPosition;
			solver.Initiate(base.transform, feet);
			for (int k = 0; k < legs.Length; k++)
			{
				if (legs[k] is LegIK)
				{
					solver.legs[k].invertFootCenter = true;
				}
			}
			characterRootRigidbody = characterRoot.GetComponent<Rigidbody>();
			base.initiated = true;
		}

		private void OnSolverUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (weight <= 0f)
			{
				if (lastWeight <= 0f)
				{
					return;
				}
				OnDisable();
			}
			lastWeight = weight;
			if (!solved)
			{
				if (OnPreGrounder != null)
				{
					OnPreGrounder();
				}
				if (pelvis.localPosition != solvedPelvisLocalPosition)
				{
					animatedPelvisLocalPosition = pelvis.localPosition;
				}
				else
				{
					pelvis.localPosition = animatedPelvisLocalPosition;
				}
				solver.Update();
				for (int i = 0; i < legs.Length; i++)
				{
					SetLegIK(i);
				}
				pelvis.position += solver.pelvis.IKOffset * weight;
				solved = true;
				solvedFeet = 0;
				if (OnPostGrounder != null)
				{
					OnPostGrounder();
				}
			}
		}

		private void SetLegIK(int index)
		{
			footRotations[index] = feet[index].rotation;
			if (legs[index] is LegIK)
			{
				(legs[index].GetIKSolver() as IKSolverLeg).IKRotation = Quaternion.Slerp(Quaternion.identity, solver.legs[index].rotationOffset, weight) * footRotations[index];
				(legs[index].GetIKSolver() as IKSolverLeg).IKRotationWeight = 1f;
			}
			legs[index].GetIKSolver().IKPosition = solver.legs[index].IKPosition;
			legs[index].GetIKSolver().IKPositionWeight = weight;
		}

		private void OnPostSolverUpdate()
		{
			if (weight <= 0f || !base.enabled)
			{
				return;
			}
			solvedFeet++;
			if (solvedFeet >= feet.Length)
			{
				for (int i = 0; i < feet.Length; i++)
				{
					feet[i].rotation = Quaternion.Slerp(Quaternion.identity, solver.legs[i].rotationOffset, weight) * footRotations[i];
				}
				solvedPelvisLocalPosition = pelvis.localPosition;
			}
		}

		private void OnDestroy()
		{
			if (!base.initiated)
			{
				return;
			}
			IK[] array = legs;
			foreach (IK iK in array)
			{
				if (iK != null)
				{
					IKSolver iKSolver = iK.GetIKSolver();
					iKSolver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
					IKSolver iKSolver2 = iK.GetIKSolver();
					iKSolver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
				}
			}
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		public struct Foot
		{
			public IKSolver solver;

			public Transform transform;

			public Quaternion rotation;

			public Grounding.Leg leg;

			public Foot(IKSolver solver, Transform transform)
			{
				this.solver = solver;
				this.transform = transform;
				leg = null;
				rotation = transform.rotation;
			}
		}

		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver = new Grounding();

		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight = 0.5f;

		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation = -25f;

		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation = 45f;

		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed = 5f;

		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset = 0.5f;

		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset = 0.5f;

		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight = 0.5f;

		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		public IK[] legs;

		public IK[] forelegs;

		[HideInInspector]
		public Vector3 gravity = Vector3.down;

		private Foot[] feet = new Foot[0];

		private Vector3 animatedPelvisLocalPosition;

		private Quaternion animatedPelvisLocalRotation;

		private Quaternion animatedHeadLocalRotation;

		private Vector3 solvedPelvisLocalPosition;

		private Quaternion solvedPelvisLocalRotation;

		private Quaternion solvedHeadLocalRotation;

		private int solvedFeet;

		private bool solved;

		private float angle;

		private Transform forefeetRoot;

		private Quaternion headRotation;

		private float lastWeight;

		private Rigidbody characterRootRigidbody;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html");
		}

		public override void ResetPosition()
		{
			solver.Reset();
			forelegSolver.Reset();
		}

		private bool IsReadyToInitiate()
		{
			if (pelvis == null)
			{
				return false;
			}
			if (lastSpineBone == null)
			{
				return false;
			}
			if (legs.Length == 0)
			{
				return false;
			}
			if (forelegs.Length == 0)
			{
				return false;
			}
			if (characterRoot == null)
			{
				return false;
			}
			if (!IsReadyToInitiateLegs(legs))
			{
				return false;
			}
			if (!IsReadyToInitiateLegs(forelegs))
			{
				return false;
			}
			return true;
		}

		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			foreach (IK iK in ikComponents)
			{
				if (iK == null)
				{
					return false;
				}
				if (iK is FullBodyBipedIK)
				{
					LogWarning("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.");
					return false;
				}
				if (iK is FABRIKRoot)
				{
					LogWarning("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
				if (iK is AimIK)
				{
					LogWarning("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
			}
			return true;
		}

		private void OnDisable()
		{
			if (!base.initiated)
			{
				return;
			}
			for (int i = 0; i < feet.Length; i++)
			{
				if (feet[i].solver != null)
				{
					feet[i].solver.IKPositionWeight = 0f;
				}
			}
		}

		private void Update()
		{
			weight = Mathf.Clamp(weight, 0f, 1f);
			if (!(weight <= 0f))
			{
				solved = false;
				if (!base.initiated && IsReadyToInitiate())
				{
					Initiate();
				}
			}
		}

		private void Initiate()
		{
			feet = new Foot[legs.Length + forelegs.Length];
			Transform[] array = InitiateFeet(legs, ref feet, 0);
			Transform[] array2 = InitiateFeet(forelegs, ref feet, legs.Length);
			animatedPelvisLocalPosition = pelvis.localPosition;
			animatedPelvisLocalRotation = pelvis.localRotation;
			if (head != null)
			{
				animatedHeadLocalRotation = head.localRotation;
			}
			forefeetRoot = new GameObject().transform;
			forefeetRoot.parent = base.transform;
			forefeetRoot.name = "Forefeet Root";
			solver.Initiate(base.transform, array);
			forelegSolver.Initiate(forefeetRoot, array2);
			for (int i = 0; i < array.Length; i++)
			{
				feet[i].leg = solver.legs[i];
			}
			for (int j = 0; j < array2.Length; j++)
			{
				feet[j + legs.Length].leg = forelegSolver.legs[j];
			}
			characterRootRigidbody = characterRoot.GetComponent<Rigidbody>();
			base.initiated = true;
		}

		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			Transform[] array = new Transform[ikComponents.Length];
			for (int i = 0; i < ikComponents.Length; i++)
			{
				IKSolver.Point[] points = ikComponents[i].GetIKSolver().GetPoints();
				f[i + indexOffset] = new Foot(ikComponents[i].GetIKSolver(), points[^1].transform);
				array[i] = f[i + indexOffset].transform;
				IKSolver iKSolver = f[i + indexOffset].solver;
				iKSolver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
				IKSolver iKSolver2 = f[i + indexOffset].solver;
				iKSolver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			}
			return array;
		}

		private void LateUpdate()
		{
			if (!(weight <= 0f))
			{
				rootRotationWeight = Mathf.Clamp(rootRotationWeight, 0f, 1f);
				minRootRotation = Mathf.Clamp(minRootRotation, -90f, maxRootRotation);
				maxRootRotation = Mathf.Clamp(maxRootRotation, minRootRotation, 90f);
				rootRotationSpeed = Mathf.Clamp(rootRotationSpeed, 0f, rootRotationSpeed);
				maxLegOffset = Mathf.Clamp(maxLegOffset, 0f, maxLegOffset);
				maxForeLegOffset = Mathf.Clamp(maxForeLegOffset, 0f, maxForeLegOffset);
				maintainHeadRotationWeight = Mathf.Clamp(maintainHeadRotationWeight, 0f, 1f);
				RootRotation();
			}
		}

		private void RootRotation()
		{
			if (!(rootRotationWeight <= 0f) && !(rootRotationSpeed <= 0f))
			{
				solver.rotateSolver = true;
				forelegSolver.rotateSolver = true;
				Vector3 tangent = characterRoot.forward;
				Vector3 normal = -gravity;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				Quaternion quaternion = Quaternion.LookRotation(tangent, -gravity);
				Vector3 vector = forelegSolver.rootHit.point - solver.rootHit.point;
				Vector3 vector2 = Quaternion.Inverse(quaternion) * vector;
				float num = Mathf.Atan2(vector2.y, vector2.z) * 57.29578f;
				num = Mathf.Clamp(num * rootRotationWeight, minRootRotation, maxRootRotation);
				angle = Mathf.Lerp(angle, num, Time.deltaTime * rootRotationSpeed);
				if (characterRootRigidbody == null)
				{
					characterRoot.rotation = Quaternion.Slerp(characterRoot.rotation, Quaternion.AngleAxis(0f - angle, characterRoot.right) * quaternion, weight);
				}
				else
				{
					characterRootRigidbody.MoveRotation(Quaternion.Slerp(characterRoot.rotation, Quaternion.AngleAxis(0f - angle, characterRoot.right) * quaternion, weight));
				}
			}
		}

		private void OnSolverUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (weight <= 0f)
			{
				if (lastWeight <= 0f)
				{
					return;
				}
				OnDisable();
			}
			lastWeight = weight;
			if (solved)
			{
				return;
			}
			if (OnPreGrounder != null)
			{
				OnPreGrounder();
			}
			if (pelvis.localPosition != solvedPelvisLocalPosition)
			{
				animatedPelvisLocalPosition = pelvis.localPosition;
			}
			else
			{
				pelvis.localPosition = animatedPelvisLocalPosition;
			}
			if (pelvis.localRotation != solvedPelvisLocalRotation)
			{
				animatedPelvisLocalRotation = pelvis.localRotation;
			}
			else
			{
				pelvis.localRotation = animatedPelvisLocalRotation;
			}
			if (head != null)
			{
				if (head.localRotation != solvedHeadLocalRotation)
				{
					animatedHeadLocalRotation = head.localRotation;
				}
				else
				{
					head.localRotation = animatedHeadLocalRotation;
				}
			}
			for (int i = 0; i < feet.Length; i++)
			{
				feet[i].rotation = feet[i].transform.rotation;
			}
			if (head != null)
			{
				headRotation = head.rotation;
			}
			UpdateForefeetRoot();
			solver.Update();
			forelegSolver.Update();
			pelvis.position += solver.pelvis.IKOffset * weight;
			Vector3 fromDirection = lastSpineBone.position - pelvis.position;
			Vector3 toDirection = lastSpineBone.position + forelegSolver.root.up * Mathf.Clamp(forelegSolver.pelvis.heightOffset, float.NegativeInfinity, 0f) - solver.root.up * solver.pelvis.heightOffset - pelvis.position;
			Quaternion b = Quaternion.FromToRotation(fromDirection, toDirection);
			pelvis.rotation = Quaternion.Slerp(Quaternion.identity, b, weight) * pelvis.rotation;
			for (int j = 0; j < feet.Length; j++)
			{
				SetFootIK(feet[j], (j < 2) ? maxLegOffset : maxForeLegOffset);
			}
			solved = true;
			solvedFeet = 0;
			if (OnPostGrounder != null)
			{
				OnPostGrounder();
			}
		}

		private void UpdateForefeetRoot()
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < forelegSolver.legs.Length; i++)
			{
				zero += forelegSolver.legs[i].transform.position;
			}
			zero /= (float)forelegs.Length;
			Vector3 vector = zero - base.transform.position;
			Vector3 normal = base.transform.up;
			Vector3 tangent = vector;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			forefeetRoot.position = base.transform.position + tangent.normalized * vector.magnitude;
		}

		private void SetFootIK(Foot foot, float maxOffset)
		{
			Vector3 vector = foot.leg.IKPosition - foot.transform.position;
			foot.solver.IKPosition = foot.transform.position + Vector3.ClampMagnitude(vector, maxOffset);
			foot.solver.IKPositionWeight = weight;
		}

		private void OnPostSolverUpdate()
		{
			if (weight <= 0f || !base.enabled)
			{
				return;
			}
			solvedFeet++;
			if (solvedFeet >= feet.Length)
			{
				for (int i = 0; i < feet.Length; i++)
				{
					feet[i].transform.rotation = Quaternion.Slerp(Quaternion.identity, feet[i].leg.rotationOffset, weight) * feet[i].rotation;
				}
				if (head != null)
				{
					head.rotation = Quaternion.Lerp(head.rotation, headRotation, maintainHeadRotationWeight * weight);
				}
				solvedPelvisLocalPosition = pelvis.localPosition;
				solvedPelvisLocalRotation = pelvis.localRotation;
				if (head != null)
				{
					solvedHeadLocalRotation = head.localRotation;
				}
			}
		}

		private void OnDestroy()
		{
			if (base.initiated)
			{
				DestroyLegs(legs);
				DestroyLegs(forelegs);
			}
		}

		private void DestroyLegs(IK[] ikComponents)
		{
			foreach (IK iK in ikComponents)
			{
				if (iK != null)
				{
					IKSolver iKSolver = iK.GetIKSolver();
					iKSolver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
					IKSolver iKSolver2 = iK.GetIKSolver();
					iKSolver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
				}
			}
		}
	}
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		private Transform[] feet = new Transform[2];

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		public override void ResetPosition()
		{
			solver.Reset();
		}

		private bool IsReadyToInitiate()
		{
			if (ik == null)
			{
				return false;
			}
			if (!ik.solver.initiated)
			{
				return false;
			}
			return true;
		}

		private void Update()
		{
			weight = Mathf.Clamp(weight, 0f, 1f);
			if (!(weight <= 0f) && !base.initiated && IsReadyToInitiate())
			{
				Initiate();
			}
		}

		private void Initiate()
		{
			feet = new Transform[2];
			feet[0] = ik.references.leftFoot;
			feet[1] = ik.references.rightFoot;
			IKSolverVR iKSolverVR = ik.solver;
			iKSolverVR.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolverVR.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
			IKSolverVR iKSolverVR2 = ik.solver;
			iKSolverVR2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolverVR2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			solver.Initiate(ik.references.root, feet);
			base.initiated = true;
		}

		private void OnSolverUpdate()
		{
			if (base.enabled && !(weight <= 0f))
			{
				if (OnPreGrounder != null)
				{
					OnPreGrounder();
				}
				solver.Update();
				ik.references.pelvis.position += solver.pelvis.IKOffset * weight;
				ik.solver.AddPositionOffset(IKSolverVR.PositionOffset.LeftFoot, (solver.legs[0].IKPosition - ik.references.leftFoot.position) * weight);
				ik.solver.AddPositionOffset(IKSolverVR.PositionOffset.RightFoot, (solver.legs[1].IKPosition - ik.references.rightFoot.position) * weight);
				if (OnPostGrounder != null)
				{
					OnPostGrounder();
				}
			}
		}

		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
			ik.solver.AddPositionOffset(positionOffset, (leg.IKPosition - bone.position) * weight);
		}

		private void OnPostSolverUpdate()
		{
			ik.references.leftFoot.rotation = Quaternion.Slerp(Quaternion.identity, solver.legs[0].rotationOffset, weight) * ik.references.leftFoot.rotation;
			ik.references.rightFoot.rotation = Quaternion.Slerp(Quaternion.identity, solver.legs[1].rotationOffset, weight) * ik.references.rightFoot.rotation;
		}

		private void OnDrawGizmosSelected()
		{
			if (ik == null)
			{
				ik = GetComponent<VRIK>();
			}
			if (ik == null)
			{
				ik = GetComponentInParent<VRIK>();
			}
			if (ik == null)
			{
				ik = GetComponentInChildren<VRIK>();
			}
		}

		private void OnDestroy()
		{
			if (base.initiated && ik != null)
			{
				IKSolverVR iKSolverVR = ik.solver;
				iKSolverVR.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolverVR.OnPreUpdate, new IKSolver.UpdateDelegate(OnSolverUpdate));
				IKSolverVR iKSolverVR2 = ik.solver;
				iKSolverVR2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolverVR2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostSolverUpdate));
			}
		}
	}
	[Serializable]
	public class Grounding
	{
		[Serializable]
		public enum Quality
		{
			Fastest,
			Simple,
			Best
		}

		public class Leg
		{
			public Quaternion rotationOffset = Quaternion.identity;

			public bool invertFootCenter;

			private Grounding grounding;

			private float lastTime;

			private float deltaTime;

			private Vector3 lastPosition;

			private Quaternion toHitNormal;

			private Quaternion r;

			private RaycastHit heelHit;

			private Vector3 up = Vector3.up;

			public bool isGrounded { get; private set; }

			public Vector3 IKPosition { get; private set; }

			public bool initiated { get; private set; }

			public float heightFromGround { get; private set; }

			public Vector3 velocity { get; private set; }

			public Transform transform { get; private set; }

			public float IKOffset { get; private set; }

			public float stepHeightFromGround => Mathf.Clamp(heightFromGround, 0f - grounding.maxStep, grounding.maxStep);

			private float rootYOffset => grounding.GetVerticalOffset(transform.position, grounding.root.position - up * grounding.heightOffset);

			public void Initiate(Grounding grounding, Transform transform)
			{
				initiated = false;
				this.grounding = grounding;
				this.transform = transform;
				up = Vector3.up;
				IKPosition = transform.position;
				rotationOffset = Quaternion.identity;
				initiated = true;
				OnEnable();
			}

			public void OnEnable()
			{
				if (initiated)
				{
					lastPosition = transform.position;
					lastTime = Time.deltaTime;
				}
			}

			public void Reset()
			{
				lastPosition = transform.position;
				lastTime = Time.deltaTime;
				IKOffset = 0f;
				IKPosition = transform.position;
				rotationOffset = Quaternion.identity;
			}

			public void Process()
			{
				if (!initiated || grounding.maxStep <= 0f)
				{
					return;
				}
				deltaTime = Time.time - lastTime;
				lastTime = Time.time;
				if (deltaTime == 0f)
				{
					return;
				}
				up = grounding.up;
				heightFromGround = float.PositiveInfinity;
				velocity = (transform.position - lastPosition) / deltaTime;
				velocity = grounding.Flatten(velocity);
				lastPosition = transform.position;
				Vector3 vector = velocity * grounding.prediction;
				if (grounding.footRadius <= 0f)
				{
					grounding.quality = Quality.Fastest;
				}
				switch (grounding.quality)
				{
				case Quality.Fastest:
				{
					RaycastHit raycastHit3 = GetRaycastHit(vector);
					SetFootToPoint(raycastHit3.normal, raycastHit3.point);
					break;
				}
				case Quality.Simple:
				{
					heelHit = GetRaycastHit(Vector3.zero);
					Vector3 vector2 = grounding.GetFootCenterOffset();
					if (invertFootCenter)
					{
						vector2 = -vector2;
					}
					RaycastHit raycastHit = GetRaycastHit(vector2 + vector);
					RaycastHit raycastHit2 = GetRaycastHit(grounding.root.right * grounding.footRadius * 0.5f);
					Vector3 vector3 = Vector3.Cross(raycastHit.point - heelHit.point, raycastHit2.point - heelHit.point).normalized;
					if (Vector3.Dot(vector3, up) < 0f)
					{
						vector3 = -vector3;
					}
					SetFootToPlane(vector3, heelHit.point, heelHit.point);
					break;
				}
				case Quality.Best:
				{
					heelHit = GetRaycastHit(invertFootCenter ? (-grounding.GetFootCenterOffset()) : Vector3.zero);
					RaycastHit capsuleHit = GetCapsuleHit(vector);
					SetFootToPlane(capsuleHit.normal, capsuleHit.point, heelHit.point);
					break;
				}
				}
				isGrounded = heightFromGround < grounding.maxStep;
				float num = stepHeightFromGround;
				if (!grounding.rootGrounded)
				{
					num = 0f;
				}
				IKOffset = Interp.LerpValue(IKOffset, num, grounding.footSpeed, grounding.footSpeed);
				IKOffset = Mathf.Lerp(IKOffset, num, deltaTime * grounding.footSpeed);
				float verticalOffset = grounding.GetVerticalOffset(transform.position, grounding.root.position);
				float num2 = Mathf.Clamp(grounding.maxStep - verticalOffset, 0f, grounding.maxStep);
				IKOffset = Mathf.Clamp(IKOffset, 0f - num2, IKOffset);
				RotateFoot();
				IKPosition = transform.position - up * IKOffset;
				float footRotationWeight = grounding.footRotationWeight;
				rotationOffset = ((footRotationWeight >= 1f) ? r : Quaternion.Slerp(Quaternion.identity, r, footRotationWeight));
			}

			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				RaycastHit hitInfo = default(RaycastHit);
				Vector3 vector = grounding.GetFootCenterOffset();
				if (invertFootCenter)
				{
					vector = -vector;
				}
				Vector3 vector2 = transform.position + vector;
				if (grounding.overstepFallsDown)
				{
					hitInfo.point = vector2 - up * grounding.maxStep * 2f;
				}
				else
				{
					hitInfo.point = new Vector3(transform.position.x, grounding.root.position.y, transform.position.z);
				}
				hitInfo.normal = up;
				Vector3 vector3 = vector2 + grounding.maxStep * up;
				Vector3 point = vector3 + offsetFromHeel;
				if (Physics.CapsuleCast(vector3, point, grounding.footRadius, -up, out hitInfo, grounding.maxStep * 3f, grounding.layers, QueryTriggerInteraction.Ignore) && float.IsNaN(hitInfo.point.x))
				{
					hitInfo.point = vector2 - up * grounding.maxStep * 2f;
					hitInfo.normal = up;
				}
				return hitInfo;
			}

			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				RaycastHit hitInfo = default(RaycastHit);
				Vector3 vector = transform.position + offsetFromHeel;
				if (grounding.overstepFallsDown)
				{
					hitInfo.point = vector - up * grounding.maxStep * 2f;
				}
				else
				{
					hitInfo.point = new Vector3(transform.position.x, grounding.root.position.y, transform.position.z);
				}
				hitInfo.normal = up;
				if (grounding.maxStep <= 0f)
				{
					return hitInfo;
				}
				Physics.Raycast(vector + grounding.maxStep * up, -up, out hitInfo, grounding.maxStep * 3f, grounding.layers, QueryTriggerInteraction.Ignore);
				return hitInfo;
			}

			private Vector3 RotateNormal(Vector3 normal)
			{
				if (grounding.quality == Quality.Best)
				{
					return normal;
				}
				return Vector3.RotateTowards(up, normal, grounding.maxFootRotationAngle * ((float)Math.PI / 180f), deltaTime);
			}

			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
				toHitNormal = Quaternion.FromToRotation(up, RotateNormal(normal));
				heightFromGround = GetHeightFromGround(point);
			}

			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
				planeNormal = RotateNormal(planeNormal);
				toHitNormal = Quaternion.FromToRotation(up, planeNormal);
				Vector3 hitPoint = V3Tools.LineToPlane(transform.position + up * grounding.maxStep, -up, planeNormal, planePoint);
				heightFromGround = GetHeightFromGround(hitPoint);
				float max = GetHeightFromGround(heelHitPoint);
				heightFromGround = Mathf.Clamp(heightFromGround, float.NegativeInfinity, max);
			}

			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return grounding.GetVerticalOffset(transform.position, hitPoint) - rootYOffset;
			}

			private void RotateFoot()
			{
				Quaternion rotationOffsetTarget = GetRotationOffsetTarget();
				r = Quaternion.Slerp(r, rotationOffsetTarget, deltaTime * grounding.footRotationSpeed);
			}

			private Quaternion GetRotationOffsetTarget()
			{
				if (grounding.maxFootRotationAngle <= 0f)
				{
					return Quaternion.identity;
				}
				if (grounding.maxFootRotationAngle >= 180f)
				{
					return toHitNormal;
				}
				return Quaternion.RotateTowards(Quaternion.identity, toHitNormal, grounding.maxFootRotationAngle);
			}
		}

		public class Pelvis
		{
			private Grounding grounding;

			private Vector3 lastRootPosition;

			private float damperF;

			private bool initiated;

			private float lastTime;

			public Vector3 IKOffset { get; private set; }

			public float heightOffset { get; private set; }

			public void Initiate(Grounding grounding)
			{
				this.grounding = grounding;
				initiated = true;
				OnEnable();
			}

			public void Reset()
			{
				lastRootPosition = grounding.root.transform.position;
				lastTime = Time.deltaTime;
				IKOffset = Vector3.zero;
				heightOffset = 0f;
			}

			public void OnEnable()
			{
				if (initiated)
				{
					lastRootPosition = grounding.root.transform.position;
					lastTime = Time.time;
				}
			}

			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
				if (!initiated)
				{
					return;
				}
				float num = Time.time - lastTime;
				lastTime = Time.time;
				if (!(num <= 0f))
				{
					float b = lowestOffset + highestOffset;
					if (!grounding.rootGrounded)
					{
						b = 0f;
					}
					heightOffset = Mathf.Lerp(heightOffset, b, num * grounding.pelvisSpeed);
					Vector3 p = grounding.root.position - lastRootPosition;
					lastRootPosition = grounding.root.position;
					damperF = Interp.LerpValue(damperF, isGrounded ? 1f : 0f, 1f, 10f);
					heightOffset -= grounding.GetVerticalOffset(p, Vector3.zero) * grounding.pelvisDamper * damperF;
					IKOffset = grounding.up * heightOffset;
				}
			}
		}

		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep = 0.5f;

		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed = 2.5f;

		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius = 0.15f;

		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction = 0.05f;

		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight = 1f;

		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed = 7f;

		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle = 45f;

		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed = 5f;

		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight = 1f;

		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius = 0.1f;

		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown = true;

		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality = Quality.Best;

		private bool initiated;

		public Leg[] legs { get; private set; }

		public Pelvis pelvis { get; private set; }

		public bool isGrounded { get; private set; }

		public Transform root { get; private set; }

		public RaycastHit rootHit { get; private set; }

		public bool rootGrounded => rootHit.distance < maxStep * 2f;

		public Vector3 up
		{
			get
			{
				if (!useRootRotation)
				{
					return Vector3.up;
				}
				return root.up;
			}
		}

		private bool useRootRotation
		{
			get
			{
				if (!rotateSolver)
				{
					return false;
				}
				if (root.up == Vector3.up)
				{
					return false;
				}
				return true;
			}
		}

		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			RaycastHit hitInfo = default(RaycastHit);
			Vector3 vector = up;
			Vector3 zero = Vector3.zero;
			Leg[] array = legs;
			foreach (Leg leg in array)
			{
				zero += leg.transform.position;
			}
			zero /= (float)legs.Length;
			hitInfo.point = zero - vector * maxStep * 10f;
			float num = maxDistanceMlp + 1f;
			hitInfo.distance = maxStep * num;
			if (maxStep <= 0f)
			{
				return hitInfo;
			}
			if (quality != Quality.Best)
			{
				Physics.Raycast(zero + vector * maxStep, -vector, out hitInfo, maxStep * num, layers, QueryTriggerInteraction.Ignore);
			}
			else
			{
				Physics.SphereCast(zero + vector * maxStep, rootSphereCastRadius, -up, out hitInfo, maxStep * num, layers, QueryTriggerInteraction.Ignore);
			}
			return hitInfo;
		}

		public bool IsValid(ref string errorMessage)
		{
			if (root == null)
			{
				errorMessage = "Root transform is null. Can't initiate Grounding.";
				return false;
			}
			if (legs == null)
			{
				errorMessage = "Grounding legs is null. Can't initiate Grounding.";
				return false;
			}
			if (pelvis == null)
			{
				errorMessage = "Grounding pelvis is null. Can't initiate Grounding.";
				return false;
			}
			if (legs.Length == 0)
			{
				errorMessage = "Grounding has 0 legs. Can't initiate Grounding.";
				return false;
			}
			return true;
		}

		public void Initiate(Transform root, Transform[] feet)
		{
			this.root = root;
			initiated = false;
			rootHit = default(RaycastHit);
			if (legs == null)
			{
				legs = new Leg[feet.Length];
			}
			if (legs.Length != feet.Length)
			{
				legs = new Leg[feet.Length];
			}
			for (int i = 0; i < feet.Length; i++)
			{
				if (legs[i] == null)
				{
					legs[i] = new Leg();
				}
			}
			if (pelvis == null)
			{
				pelvis = new Pelvis();
			}
			string errorMessage = string.Empty;
			if (!IsValid(ref errorMessage))
			{
				Warning.Log(errorMessage, root);
			}
			else if (Application.isPlaying)
			{
				for (int j = 0; j < feet.Length; j++)
				{
					legs[j].Initiate(this, feet[j]);
				}
				pelvis.Initiate(this);
				initiated = true;
			}
		}

		public void Update()
		{
			if (!initiated)
			{
				return;
			}
			if ((int)layers == 0)
			{
				LogWarning("Grounding layers are set to nothing. Please add a ground layer.");
			}
			maxStep = Mathf.Clamp(maxStep, 0f, maxStep);
			footRadius = Mathf.Clamp(footRadius, 0.0001f, maxStep);
			pelvisDamper = Mathf.Clamp(pelvisDamper, 0f, 1f);
			rootSphereCastRadius = Mathf.Clamp(rootSphereCastRadius, 0.0001f, rootSphereCastRadius);
			maxFootRotationAngle = Mathf.Clamp(maxFootRotationAngle, 0f, 90f);
			prediction = Mathf.Clamp(prediction, 0f, prediction);
			footSpeed = Mathf.Clamp(footSpeed, 0f, footSpeed);
			rootHit = GetRootHit();
			float num = float.NegativeInfinity;
			float num2 = float.PositiveInfinity;
			isGrounded = false;
			Leg[] array = legs;
			foreach (Leg leg in array)
			{
				leg.Process();
				if (leg.IKOffset > num)
				{
					num = leg.IKOffset;
				}
				if (leg.IKOffset < num2)
				{
					num2 = leg.IKOffset;
				}
				if (leg.isGrounded)
				{
					isGrounded = true;
				}
			}
			pelvis.Process((0f - num) * lowerPelvisWeight, (0f - num2) * liftPelvisWeight, isGrounded);
		}

		public Vector3 GetLegsPlaneNormal()
		{
			if (!initiated)
			{
				return Vector3.up;
			}
			Vector3 vector = up;
			Vector3 vector2 = vector;
			for (int i = 0; i < legs.Length; i++)
			{
				Vector3 vector3 = legs[i].IKPosition - root.position;
				Vector3 normal = vector;
				Vector3 tangent = vector3;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				vector2 = Quaternion.FromToRotation(tangent, vector3) * vector2;
			}
			return vector2;
		}

		public void Reset()
		{
			if (Application.isPlaying)
			{
				pelvis.Reset();
				Leg[] array = legs;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Reset();
				}
			}
		}

		public void LogWarning(string message)
		{
			Warning.Log(message, root);
		}

		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			if (useRootRotation)
			{
				return (Quaternion.Inverse(root.rotation) * (p1 - p2)).y;
			}
			return p1.y - p2.y;
		}

		public Vector3 Flatten(Vector3 v)
		{
			if (useRootRotation)
			{
				Vector3 tangent = v;
				Vector3 normal = root.up;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				return Vector3.Project(v, tangent);
			}
			v.y = 0f;
			return v;
		}

		public Vector3 GetFootCenterOffset()
		{
			return root.forward * footRadius + root.forward * footCenterOffset;
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		public IKSolverAim solver = new IKSolverAim();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page1.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html");
		}

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=wT8fViZpLmQ");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		public IKSolverArm solver = new IKSolverArm();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			UnityEngine.Debug.Log("No User Manual page for this component yet, sorry.");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			UnityEngine.Debug.Log("No Script Reference for this component yet, sorry.");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		public IKSolverCCD solver = new IKSolverCCD();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page3.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		public IKSolverFABRIK solver = new IKSolverFABRIK();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page4.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		public IKSolverFABRIKRoot solver = new IKSolverFABRIKRoot();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page5.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		public BipedReferences references = new BipedReferences();

		public IKSolverFullBodyBiped solver = new IKSolverFullBodyBiped();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page6.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html");
		}

		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=7__IafZGwvI");
		}

		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=tgRMsTphjJo");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public void SetReferences(BipedReferences references, Transform rootNode)
		{
			this.references = references;
			solver.SetToReferences(this.references, rootNode);
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}

		public bool ReferencesError(ref string errorMessage)
		{
			if (BipedReferences.SetupError(references, ref errorMessage))
			{
				return true;
			}
			if (references.spine.Length == 0)
			{
				errorMessage = "References has no spine bones assigned, can not initiate the solver.";
				return true;
			}
			if (solver.rootNode == null)
			{
				errorMessage = "Root Node bone is null, can not initiate the solver.";
				return true;
			}
			if (solver.rootNode != references.pelvis)
			{
				bool flag = false;
				for (int i = 0; i < references.spine.Length; i++)
				{
					if (solver.rootNode == references.spine[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					errorMessage = "The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.";
					return true;
				}
			}
			return false;
		}

		public bool ReferencesWarning(ref string warningMessage)
		{
			if (BipedReferences.SetupWarning(references, ref warningMessage))
			{
				return true;
			}
			Vector3 vector = references.rightUpperArm.position - references.leftUpperArm.position;
			Vector3 vector2 = solver.rootNode.position - references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 0.95f)
			{
				warningMessage = "The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.";
				return true;
			}
			Vector3 vector3 = references.rightThigh.position - references.leftThigh.position;
			Vector3 vector4 = solver.rootNode.position - references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 0.95f)
			{
				warningMessage = "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.";
				return true;
			}
			return false;
		}

		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
			SetReferences(references, solver.rootNode);
		}

		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
			references = new BipedReferences();
			BipedReferences.AutoDetectReferences(ref references, base.transform, new BipedReferences.AutoDetectParams(legsParentInSpine: true, includeEyes: false));
			solver.rootNode = IKSolverFullBodyBiped.DetectRootNodeBone(references);
			solver.SetToReferences(references, solver.rootNode);
		}
	}
	public abstract class IK : SolverManager
	{
		public abstract IKSolver GetIKSolver();

		protected override void UpdateSolver()
		{
			if (!GetIKSolver().initiated)
			{
				InitiateSolver();
			}
			if (GetIKSolver().initiated)
			{
				GetIKSolver().Update();
			}
		}

		protected override void InitiateSolver()
		{
			if (!GetIKSolver().initiated)
			{
				GetIKSolver().Initiate(base.transform);
			}
		}

		protected override void FixTransforms()
		{
			if (GetIKSolver().initiated)
			{
				GetIKSolver().FixTransforms();
			}
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();
	}
	public class IKExecutionOrder : MonoBehaviour
	{
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		private bool fixedFrame;

		private bool animatePhysics
		{
			get
			{
				if (animator == null)
				{
					return false;
				}
				return animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
		}

		private void Start()
		{
			for (int i = 0; i < IKComponents.Length; i++)
			{
				IKComponents[i].enabled = false;
			}
		}

		private void Update()
		{
			if (!animatePhysics)
			{
				FixTransforms();
			}
		}

		private void FixedUpdate()
		{
			fixedFrame = true;
			if (animatePhysics)
			{
				FixTransforms();
			}
		}

		private void LateUpdate()
		{
			if (!animatePhysics || fixedFrame)
			{
				for (int i = 0; i < IKComponents.Length; i++)
				{
					IKComponents[i].GetIKSolver().Update();
				}
				fixedFrame = false;
			}
		}

		private void FixTransforms()
		{
			for (int i = 0; i < IKComponents.Length; i++)
			{
				if (IKComponents[i].fixTransforms)
				{
					IKComponents[i].GetIKSolver().FixTransforms();
				}
			}
		}
	}
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		public IKSolverLeg solver = new IKSolverLeg();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			UnityEngine.Debug.Log("No User Manual page for this component yet, sorry.");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			UnityEngine.Debug.Log("No Script Reference for this component yet, sorry.");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		public IKSolverLimb solver = new IKSolverLimb();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page7.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_limb_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		public IKSolverLookAt solver = new IKSolverLookAt();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page8.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		public IKSolverTrigonometric solver = new IKSolverTrigonometric();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page9.html");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}
	}
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		public class References
		{
			public Transform root;

			public Transform pelvis;

			public Transform spine;

			[Tooltip("Optional")]
			public Transform chest;

			[Tooltip("Optional")]
			public Transform neck;

			public Transform head;

			[Tooltip("Optional")]
			public Transform leftShoulder;

			public Transform leftUpperArm;

			public Transform leftForearm;

			public Transform leftHand;

			[Tooltip("Optional")]
			public Transform rightShoulder;

			public Transform rightUpperArm;

			public Transform rightForearm;

			public Transform rightHand;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Tooltip("Optional")]
			public Transform leftToes;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Tooltip("Optional")]
			public Transform rightToes;

			public bool isFilled
			{
				get
				{
					if (root == null || pelvis == null || spine == null || head == null || leftUpperArm == null || leftForearm == null || leftHand == null || rightUpperArm == null || rightForearm == null || rightHand == null)
					{
						return false;
					}
					if (leftThigh == null && leftCalf == null && leftFoot == null && rightThigh == null && rightCalf == null && rightFoot == null)
					{
						return true;
					}
					if (leftThigh == null || leftCalf == null || leftFoot == null || rightThigh == null || rightCalf == null || rightFoot == null)
					{
						return false;
					}
					return true;
				}
			}

			public bool isEmpty
			{
				get
				{
					if (root != null || pelvis != null || spine != null || chest != null || neck != null || head != null || leftShoulder != null || leftUpperArm != null || leftForearm != null || leftHand != null || rightShoulder != null || rightUpperArm != null || rightForearm != null || rightHand != null || leftThigh != null || leftCalf != null || leftFoot != null || leftToes != null || rightThigh != null || rightCalf != null || rightFoot != null || rightToes != null)
					{
						return false;
					}
					return true;
				}
			}

			public Transform[] GetTransforms()
			{
				return new Transform[22]
				{
					root, pelvis, spine, chest, neck, head, leftShoulder, leftUpperArm, leftForearm, leftHand,
					rightShoulder, rightUpperArm, rightForearm, rightHand, leftThigh, leftCalf, leftFoot, leftToes, rightThigh, rightCalf,
					rightFoot, rightToes
				};
			}

			public static bool AutoDetectReferences(Transform root, out References references)
			{
				references = new References();
				Animator componentInChildren = root.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					UnityEngine.Debug.LogWarning("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
					return false;
				}
				references.root = root;
				references.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				references.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				references.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				references.neck = componentInChildren.GetBoneTransform(HumanBodyBones.Neck);
				references.head = componentInChildren.GetBoneTransform(HumanBodyBones.Head);
				references.leftShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.LeftShoulder);
				references.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				references.leftForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				references.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftHand);
				references.rightShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.RightShoulder);
				references.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperArm);
				references.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerArm);
				references.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightHand);
				references.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				references.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				references.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				references.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftToes);
				references.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				references.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				references.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				references.rightToes = componentInChildren.GetBoneTransform(HumanBodyBones.RightToes);
				return true;
			}
		}

		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references = new References();

		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver = new IKSolverVR();

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			UnityEngine.Debug.Log("Sorry, VRIK User Manual is not finished yet.");
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			UnityEngine.Debug.Log("Sorry, VRIK Script reference is not finished yet.");
		}

		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=6Pfx7lYQiIA&feature=youtu.be");
		}

		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
			References.AutoDetectReferences(base.transform, out references);
		}

		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
			solver.GuessHandOrientations(references, onlyIfZero: false);
		}

		public override IKSolver GetIKSolver()
		{
			return solver;
		}

		protected override void InitiateSolver()
		{
			if (references.isEmpty)
			{
				AutoDetectReferences();
			}
			if (references.isFilled)
			{
				solver.SetToReferences(references);
			}
			base.InitiateSolver();
		}

		protected override void UpdateSolver()
		{
			if (references.root != null && references.root.localScale == Vector3.zero)
			{
				UnityEngine.Debug.LogError("VRIK Root Transform's scale is zero, can not update VRIK. Make sure you have not calibrated the character to a zero scale.", base.transform);
				base.enabled = false;
			}
			else
			{
				base.UpdateSolver();
			}
		}
	}
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/Aim IKJ")]
	public class AimIKJ : MonoBehaviour
	{
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Tooltip("Optional secondary target for another axis of the 'Aim Transform'. Needs 'Pole Weight' to be greater than 0 to have any effect.")]
		public Transform poleTarget;

		[Tooltip("The transform that you want to be aimed at the target. Needs to be a lineal descendant of the bone hierarchy. For example, if you wish to aim a gun, it should be the gun, one of it's children or the hand bone.")]
		public Transform aimTransform;

		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisX;

		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisY;

		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisZ = 1f;

		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisX;

		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisY = 1f;

		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisZ;

		[Space(5f)]
		[Tooltip("The master weight of this solver.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Tooltip("The weight of the 'Pole Target'")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Tooltip("Minimum angular offset from last reached angle. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations = 4;

		[Tooltip("Clamping rotation of the solver. 0 is free rotation, 1 is completely clamped to animated rotation.")]
		[Range(0f, 1f)]
		public float clampWeight = 0.1f;

		[Tooltip("Number of sine smoothing iterations applied on clamping to make the clamping point smoother.")]
		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits = true;

		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Space(5f)]
		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		public Transform[] bones = new Transform[0];

		private Animator animator;

		private PlayableGraph graph;

		private AnimationScriptPlayable IKPlayable;

		private AimIKJob job;

		public bool initiated { get; private set; }

		public Vector3 axis
		{
			get
			{
				return new Vector3(axisX, axisY, axisZ);
			}
			set
			{
				axisX = value.x;
				axisY = value.y;
				axisZ = value.z;
			}
		}

		public Vector3 poleAxis
		{
			get
			{
				return new Vector3(poleAxisX, poleAxisY, poleAxisZ);
			}
			set
			{
				poleAxisX = value.x;
				poleAxisY = value.y;
				poleAxisZ = value.z;
			}
		}

		private void OnEnable()
		{
			if (bones.Length >= 1 && !(axis == Vector3.zero) && (!(poleAxis == Vector3.zero) || !(poleWeight > 0f)))
			{
				animator = GetComponent<Animator>();
				if (aimTransform == null)
				{
					aimTransform = bones[bones.Length - 1];
				}
				if (target == null)
				{
					target = new GameObject("AimIKJ Target (" + base.name + ")").transform;
					target.position = bones[bones.Length - 1].position + aimTransform.rotation * axis * 3f;
				}
				if (poleTarget == null)
				{
					poleTarget = new GameObject("AimIKJ Pole Target (" + base.name + ")").transform;
					poleTarget.position = bones[bones.Length - 1].position + aimTransform.rotation * poleAxis * 3f;
				}
				graph = PlayableGraph.Create("AimIKJ");
				AnimationPlayableOutput output = AnimationPlayableOutput.Create(graph, "ouput", GetComponent<Animator>());
				job = default(AimIKJob);
				job.Setup(GetComponent<Animator>(), bones, target, poleTarget, aimTransform);
				IKPlayable = AnimationScriptPlayable.Create(graph, job);
				PlayableExtensions.AddInput(sourcePlayable: AnimatorControllerPlayable.Create(graph, animator.runtimeAnimatorController), playable: IKPlayable, sourceOutputIndex: 0, weight: 1f);
				output.SetSourcePlayable(IKPlayable);
				graph.Play();
				initiated = true;
			}
		}

		private void Update()
		{
			if (!initiated)
			{
				if (bones.Length < 1)
				{
					UnityEngine.Debug.LogError("AimIKJ needs at least 1 bone to run.", base.transform);
					base.enabled = false;
				}
				else if (new Vector3(axisX, axisY, axisZ) == Vector3.zero)
				{
					UnityEngine.Debug.Log("AimIKJ 'Axis' must not be zero.", base.transform);
				}
				else if (new Vector3(poleAxisX, poleAxisY, poleAxisZ) == Vector3.zero && poleWeight > 0f)
				{
					UnityEngine.Debug.Log("AimIKJ 'Pole Axis' must not be zero when 'Pole Weight' is greater than 0.", base.transform);
				}
				else
				{
					OnEnable();
				}
			}
			else if (initiated)
			{
				if (target == null)
				{
					UnityEngine.Debug.LogError("AimIKJ 'Target' has gone missing, destroying AimIKJ.", base.transform);
					UnityEngine.Object.Destroy(this);
				}
				else if (poleTarget == null)
				{
					UnityEngine.Debug.LogError("AimIKJ 'Pole Target' has gone missing, destroying AimIKJ.", base.transform);
					UnityEngine.Object.Destroy(this);
				}
				else if (aimTransform == null)
				{
					UnityEngine.Debug.LogError("AimIKJ 'Aim transform' has gone missing, destroying AimIKJ.", base.transform);
					UnityEngine.Object.Destroy(this);
				}
			}
		}

		private void OnDisable()
		{
			if (initiated)
			{
				job.Dispose();
				graph.Destroy();
				UnityEngine.Object.Destroy(target);
			}
		}
	}
	public struct AimIKJob : IAnimationJob
	{
		public TransformSceneHandle _target;

		public TransformSceneHandle _poleTarget;

		public TransformStreamHandle _transform;

		public PropertySceneHandle _IKPositionWeight;

		public PropertySceneHandle _poleWeight;

		public PropertySceneHandle _axisX;

		public PropertySceneHandle _axisY;

		public PropertySceneHandle _axisZ;

		public PropertySceneHandle _poleAxisX;

		public PropertySceneHandle _poleAxisY;

		public PropertySceneHandle _poleAxisZ;

		public PropertySceneHandle _clampWeight;

		public PropertySceneHandle _clampSmoothing;

		public PropertySceneHandle _maxIterations;

		public PropertySceneHandle _tolerance;

		public PropertySceneHandle _XY;

		public PropertySceneHandle _useRotationLimits;

		private NativeArray<TransformStreamHandle> bones;

		private NativeArray<PropertySceneHandle> boneWeights;

		private Vector3 lastLocalDirection;

		private float step;

		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		private NativeArray<Vector3> limitAxisArray;

		private NativeArray<int> hingeFlags;

		private NativeArray<PropertySceneHandle> hingeMinArray;

		private NativeArray<PropertySceneHandle> hingeMaxArray;

		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		private NativeArray<Quaternion> hingeLastRotations;

		private NativeArray<float> hingeLastAngles;

		private NativeArray<int> angleFlags;

		private NativeArray<Vector3> angleSecondaryAxisArray;

		private NativeArray<PropertySceneHandle> angleLimitArray;

		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
			this.bones = new NativeArray<TransformStreamHandle>(bones.Length, Allocator.Persistent);
			boneWeights = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i] = animator.BindStreamTransform(bones[i]);
			}
			for (int j = 0; j < this.bones.Length; j++)
			{
				if (bones[j].gameObject.GetComponent<IKJBoneParams>() == null)
				{
					bones[j].gameObject.AddComponent<IKJBoneParams>();
				}
				boneWeights[j] = animator.BindSceneProperty(bones[j].transform, typeof(IKJBoneParams), "weight");
			}
			SetUpRotationLimits(animator, bones);
			_target = animator.BindSceneTransform(target);
			_poleTarget = animator.BindSceneTransform(poleTarget);
			_transform = animator.BindStreamTransform(aimTransform);
			_IKPositionWeight = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "weight");
			_poleWeight = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "poleWeight");
			_axisX = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "axisX");
			_axisY = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "axisY");
			_axisZ = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "axisZ");
			_poleAxisX = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "poleAxisX");
			_poleAxisY = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "poleAxisY");
			_poleAxisZ = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "poleAxisZ");
			_clampWeight = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "clampWeight");
			_clampSmoothing = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "clampSmoothing");
			_maxIterations = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "maxIterations");
			_tolerance = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "tolerance");
			_XY = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "XY");
			_useRotationLimits = animator.BindSceneProperty(animator.transform, typeof(AimIKJ), "useRotationLimits");
			step = 1f / (float)bones.Length;
		}

		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
			limitDefaultLocalRotationArray = new NativeArray<Quaternion>(bones.Length, Allocator.Persistent);
			limitAxisArray = new NativeArray<Vector3>(bones.Length, Allocator.Persistent);
			hingeFlags = new NativeArray<int>(bones.Length, Allocator.Persistent);
			hingeMinArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeMaxArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeUseLimitsArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeLastRotations = new NativeArray<Quaternion>(bones.Length, Allocator.Persistent);
			hingeLastAngles = new NativeArray<float>(bones.Length, Allocator.Persistent);
			angleFlags = new NativeArray<int>(bones.Length, Allocator.Persistent);
			angleSecondaryAxisArray = new NativeArray<Vector3>(bones.Length, Allocator.Persistent);
			angleLimitArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			angleTwistLimitArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			for (int i = 0; i < bones.Length - 1; i++)
			{
				hingeFlags[i] = 0;
				angleFlags[i] = 0;
				RotationLimit component = bones[i].GetComponent<RotationLimit>();
				if (component != null)
				{
					limitDefaultLocalRotationArray[i] = bones[i].localRotation;
					limitAxisArray[i] = component.axis;
					component.Disable();
					if (component is RotationLimitHinge)
					{
						hingeFlags[i] = 1;
						hingeMinArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "min");
						hingeMaxArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "max");
						hingeUseLimitsArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "useLimits");
						hingeLastRotations[i] = bones[i].localRotation;
						hingeLastAngles[i] = 0f;
					}
					if (component is RotationLimitAngle)
					{
						RotationLimitAngle rotationLimitAngle = component as RotationLimitAngle;
						angleFlags[i] = 1;
						angleSecondaryAxisArray[i] = rotationLimitAngle.secondaryAxis;
						angleLimitArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitAngle), "limit");
						angleTwistLimitArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitAngle), "twistLimit");
					}
				}
			}
		}

		private void DisposeRotationLimits()
		{
			limitDefaultLocalRotationArray.Dispose();
			limitAxisArray.Dispose();
			hingeFlags.Dispose();
			hingeMinArray.Dispose();
			hingeMaxArray.Dispose();
			hingeUseLimitsArray.Dispose();
			hingeLastRotations.Dispose();
			hingeLastAngles.Dispose();
			angleFlags.Dispose();
			angleSecondaryAxisArray.Dispose();
			angleLimitArray.Dispose();
			angleTwistLimitArray.Dispose();
		}

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
			Update(stream);
		}

		private void Update(AnimationStream s)
		{
			if (!_target.IsValid(s) || !_poleTarget.IsValid(s) || !_transform.IsValid(s))
			{
				return;
			}
			Vector3 vector = new Vector3(_axisX.GetFloat(s), _axisY.GetFloat(s), _axisZ.GetFloat(s));
			Vector3 vector2 = new Vector3(_poleAxisX.GetFloat(s), _poleAxisY.GetFloat(s), _poleAxisZ.GetFloat(s));
			float @float = _poleWeight.GetFloat(s);
			@float = Mathf.Clamp(@float, 0f, 1f);
			if (vector == Vector3.zero || (vector2 == Vector3.zero && @float > 0f))
			{
				return;
			}
			float float2 = _IKPositionWeight.GetFloat(s);
			if (float2 <= 0f)
			{
				return;
			}
			float2 = Mathf.Min(float2, 1f);
			bool @bool = _XY.GetBool(s);
			float num = _maxIterations.GetInt(s);
			float float3 = _tolerance.GetFloat(s);
			bool bool2 = _useRotationLimits.GetBool(s);
			Vector3 position = _target.GetPosition(s);
			if (@bool)
			{
				position.z = bones[0].GetPosition(s).z;
			}
			Vector3 position2 = _poleTarget.GetPosition(s);
			if (@bool)
			{
				position2.z = position.z;
			}
			float float4 = _clampWeight.GetFloat(s);
			float4 = Mathf.Clamp(float4, 0f, 1f);
			int @int = _clampSmoothing.GetInt(s);
			@int = Mathf.Clamp(@int, 0, 2);
			Vector3 position3 = _transform.GetPosition(s);
			Vector3 vector3 = _transform.GetRotation(s) * vector;
			Vector3 clampedIKPosition = GetClampedIKPosition(s, float4, @int, position, position3, vector3);
			Vector3 b = clampedIKPosition - position3;
			b = Vector3.Slerp(vector3 * b.magnitude, b, float2);
			clampedIKPosition = position3 + b;
			for (int i = 0; (float)i < num && (i < 0 || !(float3 > 0f) || !(GetAngle(s, vector, position) < float3)); i++)
			{
				lastLocalDirection = GetLocalDirection(s, _transform.GetRotation(s) * vector);
				for (int j = 0; j < bones.Length - 1; j++)
				{
					RotateToTarget(s, clampedIKPosition, position2, j, step * (float)(j + 1) * float2 * boneWeights[j].GetFloat(s), @float, @bool, bool2, vector, vector2);
				}
				RotateToTarget(s, clampedIKPosition, position2, bones.Length - 1, float2 * boneWeights[bones.Length - 1].GetFloat(s), @float, @bool, bool2, vector, vector2);
			}
			lastLocalDirection = GetLocalDirection(s, _transform.GetRotation(s) * vector);
		}

		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
			if (XY)
			{
				if (weight >= 0f)
				{
					Vector3 vector = _transform.GetRotation(s) * axis;
					Vector3 vector2 = targetPosition - _transform.GetPosition(s);
					float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
					float target = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
					bones[i].SetRotation(s, Quaternion.AngleAxis(Mathf.DeltaAngle(current, target), Vector3.back) * bones[i].GetRotation(s));
				}
			}
			else
			{
				if (weight >= 0f)
				{
					Quaternion quaternion = Quaternion.FromToRotation(_transform.GetRotation(s) * axis, targetPosition - _transform.GetPosition(s));
					if (weight >= 1f)
					{
						bones[i].SetRotation(s, quaternion * bones[i].GetRotation(s));
					}
					else
					{
						bones[i].SetRotation(s, Quaternion.Lerp(Quaternion.identity, quaternion, weight) * bones[i].GetRotation(s));
					}
				}
				if (poleWeight > 0f)
				{
					Vector3 tangent = polePosition - _transform.GetPosition(s);
					Vector3 normal = _transform.GetRotation(s) * axis;
					Vector3.OrthoNormalize(ref normal, ref tangent);
					Quaternion b = Quaternion.FromToRotation(_transform.GetRotation(s) * poleAxis, tangent);
					bones[i].SetRotation(s, Quaternion.Lerp(Quaternion.identity, b, weight * poleWeight) * bones[i].GetRotation(s));
				}
			}
			if (useRotationLimits)
			{
				if (hingeFlags[i] == 1)
				{
					Quaternion rotation = Quaternion.Inverse(limitDefaultLocalRotationArray[i]) * bones[i].GetLocalRotation(s);
					Quaternion lastRotation = hingeLastRotations[i];
					float lastAngle = hingeLastAngles[i];
					Quaternion quaternion2 = RotationLimitUtilities.LimitHinge(rotation, hingeMinArray[i].GetFloat(s), hingeMaxArray[i].GetFloat(s), hingeUseLimitsArray[i].GetBool(s), limitAxisArray[i], ref lastRotation, ref lastAngle);
					hingeLastRotations[i] = lastRotation;
					hingeLastAngles[i] = lastAngle;
					bones[i].SetLocalRotation(s, limitDefaultLocalRotationArray[i] * quaternion2);
				}
				else if (angleFlags[i] == 1)
				{
					Quaternion quaternion3 = RotationLimitUtilities.LimitAngle(Quaternion.Inverse(limitDefaultLocalRotationArray[i]) * bones[i].GetLocalRotation(s), limitAxisArray[i], angleSecondaryAxisArray[i], angleLimitArray[i].GetFloat(s), angleTwistLimitArray[i].GetFloat(s));
					bones[i].SetLocalRotation(s, limitDefaultLocalRotationArray[i] * quaternion3);
				}
			}
		}

		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return Vector3.Angle(_transform.GetRotation(s) * axis, IKPosition - _transform.GetPosition(s));
		}

		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			if (clampWeight <= 0f)
			{
				return IKPosition;
			}
			if (clampWeight >= 1f)
			{
				return transformPosition + transformAxis * (IKPosition - transformPosition).magnitude;
			}
			float num = Vector3.Angle(transformAxis, IKPosition - transformPosition);
			float num2 = 1f - num / 180f;
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return transformPosition + Vector3.Slerp(transformAxis * 10f, IKPosition - transformPosition, num4 * num3);
		}

		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return Quaternion.Inverse(bones[0].GetRotation(s)) * transformAxis;
		}

		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return Vector3.SqrMagnitude(localDirection - lastLocalDirection);
		}

		public void Dispose()
		{
			bones.Dispose();
			boneWeights.Dispose();
			DisposeRotationLimits();
		}
	}
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/CCD IKJ")]
	public class CCDIKJ : MonoBehaviour
	{
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Tooltip("The master weight of this solver.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Tooltip("Minimum offset from last reached position. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations = 4;

		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits = true;

		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		public Transform[] bones = new Transform[0];

		private Animator animator;

		private PlayableGraph graph;

		private AnimationScriptPlayable IKPlayable;

		private CCDIKJob job;

		public bool initiated { get; private set; }

		private void OnEnable()
		{
			if (bones.Length >= 3)
			{
				animator = GetComponent<Animator>();
				if (target == null)
				{
					target = new GameObject("CCDIKJ Target (" + base.name + ")").transform;
					target.position = bones[bones.Length - 1].position;
					target.rotation = bones[bones.Length - 1].rotation;
				}
				graph = PlayableGraph.Create("CCDIKJ");
				AnimationPlayableOutput output = AnimationPlayableOutput.Create(graph, "ouput", GetComponent<Animator>());
				job = default(CCDIKJob);
				job.Setup(GetComponent<Animator>(), bones, target);
				IKPlayable = AnimationScriptPlayable.Create(graph, job);
				PlayableExtensions.AddInput(sourcePlayable: AnimatorControllerPlayable.Create(graph, animator.runtimeAnimatorController), playable: IKPlayable, sourceOutputIndex: 0, weight: 1f);
				output.SetSourcePlayable(IKPlayable);
				graph.Play();
				initiated = true;
			}
		}

		private void Update()
		{
			if (!initiated)
			{
				if (bones.Length < 3)
				{
					UnityEngine.Debug.LogError("CCDIKJ needs at least 3 bones to run.", base.transform);
					base.enabled = false;
				}
				else
				{
					OnEnable();
				}
			}
			else if (initiated && target == null)
			{
				UnityEngine.Debug.LogError("CCDIKJ 'Target' has gone missing. Destroying CCDIKJ.", base.transform);
				UnityEngine.Object.Destroy(this);
			}
		}

		private void OnDisable()
		{
			if (initiated)
			{
				job.Dispose();
				graph.Destroy();
				UnityEngine.Object.Destroy(target);
			}
		}
	}
	public struct CCDIKJob : IAnimationJob
	{
		public TransformSceneHandle _target;

		public PropertySceneHandle _IKPositionWeight;

		public PropertySceneHandle _maxIterations;

		public PropertySceneHandle _tolerance;

		public PropertySceneHandle _XY;

		public PropertySceneHandle _useRotationLimits;

		private NativeArray<TransformStreamHandle> bones;

		private NativeArray<PropertySceneHandle> boneWeights;

		private NativeArray<float> boneSqrMags;

		private float chainSqrMag;

		private Vector3 lastLocalDirection;

		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		private NativeArray<Vector3> limitAxisArray;

		private NativeArray<int> hingeFlags;

		private NativeArray<PropertySceneHandle> hingeMinArray;

		private NativeArray<PropertySceneHandle> hingeMaxArray;

		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		private NativeArray<Quaternion> hingeLastRotations;

		private NativeArray<float> hingeLastAngles;

		private NativeArray<int> angleFlags;

		private NativeArray<Vector3> angleSecondaryAxisArray;

		private NativeArray<PropertySceneHandle> angleLimitArray;

		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
			this.bones = new NativeArray<TransformStreamHandle>(bones.Length, Allocator.Persistent);
			boneWeights = new NativeArray<PropertySceneHandle>(bones.Length - 1, Allocator.Persistent);
			boneSqrMags = new NativeArray<float>(bones.Length - 1, Allocator.Persistent);
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i] = animator.BindStreamTransform(bones[i]);
			}
			for (int j = 0; j < this.bones.Length - 1; j++)
			{
				if (bones[j].gameObject.GetComponent<IKJBoneParams>() == null)
				{
					bones[j].gameObject.AddComponent<IKJBoneParams>();
				}
				boneWeights[j] = animator.BindSceneProperty(bones[j].transform, typeof(IKJBoneParams), "weight");
			}
			SetUpRotationLimits(animator, bones);
			_target = animator.BindSceneTransform(target);
			_IKPositionWeight = animator.BindSceneProperty(animator.transform, typeof(CCDIKJ), "weight");
			_maxIterations = animator.BindSceneProperty(animator.transform, typeof(CCDIKJ), "maxIterations");
			_tolerance = animator.BindSceneProperty(animator.transform, typeof(CCDIKJ), "tolerance");
			_XY = animator.BindSceneProperty(animator.transform, typeof(CCDIKJ), "XY");
			_useRotationLimits = animator.BindSceneProperty(animator.transform, typeof(CCDIKJ), "useRotationLimits");
		}

		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
			limitDefaultLocalRotationArray = new NativeArray<Quaternion>(bones.Length, Allocator.Persistent);
			limitAxisArray = new NativeArray<Vector3>(bones.Length, Allocator.Persistent);
			hingeFlags = new NativeArray<int>(bones.Length, Allocator.Persistent);
			hingeMinArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeMaxArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeUseLimitsArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			hingeLastRotations = new NativeArray<Quaternion>(bones.Length, Allocator.Persistent);
			hingeLastAngles = new NativeArray<float>(bones.Length, Allocator.Persistent);
			angleFlags = new NativeArray<int>(bones.Length, Allocator.Persistent);
			angleSecondaryAxisArray = new NativeArray<Vector3>(bones.Length, Allocator.Persistent);
			angleLimitArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			angleTwistLimitArray = new NativeArray<PropertySceneHandle>(bones.Length, Allocator.Persistent);
			for (int i = 0; i < bones.Length - 1; i++)
			{
				hingeFlags[i] = 0;
				angleFlags[i] = 0;
				RotationLimit component = bones[i].GetComponent<RotationLimit>();
				if (component != null)
				{
					limitDefaultLocalRotationArray[i] = bones[i].localRotation;
					limitAxisArray[i] = component.axis;
					component.Disable();
					if (component is RotationLimitHinge)
					{
						hingeFlags[i] = 1;
						hingeMinArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "min");
						hingeMaxArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "max");
						hingeUseLimitsArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitHinge), "useLimits");
						hingeLastRotations[i] = bones[i].localRotation;
						hingeLastAngles[i] = 0f;
					}
					if (component is RotationLimitAngle)
					{
						RotationLimitAngle rotationLimitAngle = component as RotationLimitAngle;
						angleFlags[i] = 1;
						angleSecondaryAxisArray[i] = rotationLimitAngle.secondaryAxis;
						angleLimitArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitAngle), "limit");
						angleTwistLimitArray[i] = animator.BindSceneProperty(bones[i].transform, typeof(RotationLimitAngle), "twistLimit");
					}
				}
			}
		}

		private void DisposeRotationLimits()
		{
			limitDefaultLocalRotationArray.Dispose();
			limitAxisArray.Dispose();
			hingeFlags.Dispose();
			hingeMinArray.Dispose();
			hingeMaxArray.Dispose();
			hingeUseLimitsArray.Dispose();
			hingeLastRotations.Dispose();
			hingeLastAngles.Dispose();
			angleFlags.Dispose();
			angleSecondaryAxisArray.Dispose();
			angleLimitArray.Dispose();
			angleTwistLimitArray.Dispose();
		}

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
			Update(stream);
		}

		private void Update(AnimationStream s)
		{
			if (!_target.IsValid(s))
			{
				return;
			}
			float @float = _IKPositionWeight.GetFloat(s);
			if (@float <= 0f)
			{
				return;
			}
			@float = Mathf.Min(@float, 1f);
			Read(s);
			bool @bool = _XY.GetBool(s);
			float num = _maxIterations.GetInt(s);
			float float2 = _tolerance.GetFloat(s);
			bool bool2 = _useRotationLimits.GetBool(s);
			Vector3 position = _target.GetPosition(s);
			if (@bool)
			{
				position.z = bones[0].GetPosition(s).z;
			}
			Vector3 vector = ((num > 1f) ? GetSingularityOffset(s, position, bool2) : Vector3.zero);
			int num2 = 1;
			for (int i = 0; (float)i < num; i++)
			{
				Vector3 localDirection = GetLocalDirection(s);
				if (vector == Vector3.zero && i >= 1 && float2 > 0f && GetPositionOffset(s, localDirection) < float2 * float2)
				{
					break;
				}
				lastLocalDirection = localDirection;
				Solve(s, position + ((i == 0) ? vector : Vector3.zero), @bool, @float, num2, bool2);
				num2++;
				if (num2 >= bones.Length - 1)
				{
					num2 -= bones.Length - 2;
				}
			}
			lastLocalDirection = GetLocalDirection(s);
		}

		private void Read(AnimationStream s)
		{
			chainSqrMag = 0f;
			for (int i = 0; i < bones.Length; i++)
			{
				if (i < bones.Length - 1)
				{
					boneSqrMags[i] = (bones[i].GetPosition(s) - bones[i + 1].GetPosition(s)).sqrMagnitude;
					chainSqrMag += boneSqrMags[i];
				}
			}
		}

		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
			for (int num = bones.Length - 2; num > -1; num--)
			{
				float num2 = weight * boneWeights[num].GetFloat(s);
				if (num2 > 0f)
				{
					Vector3 position = bones[num].GetPosition(s);
					Vector3 fromDirection = bones[bones.Length - 1].GetPosition(s) - position;
					Vector3 toDirection = targetPosition - position;
					if (XY)
					{
						float current = Mathf.Atan2(fromDirection.x, fromDirection.y) * 57.29578f;
						float target = Mathf.Atan2(toDirection.x, toDirection.y) * 57.29578f;
						bones[num].SetRotation(s, Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * num2, Vector3.back) * bones[num].GetRotation(s));
					}
					else
					{
						Quaternion rotation = bones[num].GetRotation(s);
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * rotation;
						if (num2 >= 1f)
						{
							bones[num].SetRotation(s, quaternion);
						}
						else
						{
							bones[num].SetRotation(s, Quaternion.Lerp(rotation, quaternion, num2));
						}
					}
				}
				if (useRotationLimits)
				{
					if (hingeFlags[num] == 1)
					{
						Quaternion rotation2 = Quaternion.Inverse(limitDefaultLocalRotationArray[num]) * bones[num].GetLocalRotation(s);
						Quaternion lastRotation = hingeLastRotations[num];
						float lastAngle = hingeLastAngles[num];
						Quaternion quaternion2 = RotationLimitUtilities.LimitHinge(rotation2, hingeMinArray[num].GetFloat(s), hingeMaxArray[num].GetFloat(s), hingeUseLimitsArray[num].GetBool(s), limitAxisArray[num], ref lastRotation, ref lastAngle);
						hingeLastRotations[num] = lastRotation;
						hingeLastAngles[num] = lastAngle;
						bones[num].SetLocalRotation(s, limitDefaultLocalRotationArray[num] * quaternion2);
					}
					else if (angleFlags[num] == 1)
					{
						Quaternion quaternion3 = RotationLimitUtilities.LimitAngle(Quaternion.Inverse(limitDefaultLocalRotationArray[num]) * bones[num].GetLocalRotation(s), limitAxisArray[num], angleSecondaryAxisArray[num], angleLimitArray[num].GetFloat(s), angleTwistLimitArray[num].GetFloat(s));
						bones[num].SetLocalRotation(s, limitDefaultLocalRotationArray[num] * quaternion3);
					}
				}
			}
		}

		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return Quaternion.Inverse(bones[0].GetRotation(s)) * (bones[bones.Length - 1].GetPosition(s) - bones[0].GetPosition(s));
		}

		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return Vector3.SqrMagnitude(localDirection - lastLocalDirection);
		}

		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			if (!SingularityDetected(s, IKPosition))
			{
				return Vector3.zero;
			}
			Vector3 normalized = (IKPosition - bones[0].GetPosition(s)).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (useRotationLimits && hingeFlags[bones.Length - 2] == 1)
			{
				rhs = bones[bones.Length - 2].GetRotation(s) * limitAxisArray[bones.Length - 2];
			}
			return Vector3.Cross(normalized, rhs) * Mathf.Sqrt(boneSqrMags[bones.Length - 2]) * 0.5f;
		}

		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			Vector3 position = bones[0].GetPosition(s);
			Vector3 lhs = bones[bones.Length - 1].GetPosition(s) - position;
			Vector3 rhs = IKPosition - position;
			float sqrMagnitude = lhs.sqrMagnitude;
			float sqrMagnitude2 = rhs.sqrMagnitude;
			if (sqrMagnitude < sqrMagnitude2)
			{
				return false;
			}
			if (sqrMagnitude < chainSqrMag - boneSqrMags[bones.Length - 2] * 0.1f)
			{
				return false;
			}
			if (sqrMagnitude == 0f)
			{
				return false;
			}
			if (sqrMagnitude2 == 0f)
			{
				return false;
			}
			if (Vector3.Dot(lhs, rhs) < 0.999f)
			{
				return false;
			}
			return true;
		}

		public void Dispose()
		{
			bones.Dispose();
			boneWeights.Dispose();
			boneSqrMags.Dispose();
			DisposeRotationLimits();
		}
	}
	public class IKJBoneParams : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float weight = 1f;
	}
	public static class RotationLimitUtilities
	{
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			if (min == 0f && max == 0f && useLimits)
			{
				return Quaternion.AngleAxis(0f, axis);
			}
			Quaternion quaternion = Limit1DOF(rotation, axis);
			if (!useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(lastRotation);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(axis.z, axis.x, axis.y);
			Vector3 rhs = Vector3.Cross(vector, axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 0f)
			{
				num = 0f - num;
			}
			lastAngle = Mathf.Clamp(lastAngle + num, min, max);
			lastRotation = Quaternion.AngleAxis(lastAngle, axis);
			return lastRotation;
		}

		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return Quaternion.FromToRotation(rotation * axis, axis) * rotation;
		}

		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return LimitTwist(LimitSwing(rotation, axis, limit), axis, secondaryAxis, twistLimit);
		}

		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			if (axis == Vector3.zero)
			{
				return rotation;
			}
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			if (limit >= 180f)
			{
				return rotation;
			}
			Vector3 vector = rotation * axis;
			Quaternion to = Quaternion.FromToRotation(axis, vector);
			Quaternion quaternion = Quaternion.RotateTowards(Quaternion.identity, to, limit);
			return Quaternion.FromToRotation(vector, quaternion * axis) * rotation;
		}

		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			twistLimit = Mathf.Clamp(twistLimit, 0f, 180f);
			if (twistLimit >= 180f)
			{
				return rotation;
			}
			Vector3 normal = rotation * axis;
			Vector3 tangent = orthoAxis;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			Vector3 tangent2 = rotation * orthoAxis;
			Vector3.OrthoNormalize(ref normal, ref tangent2);
			Quaternion quaternion = Quaternion.FromToRotation(tangent2, tangent) * rotation;
			if (twistLimit <= 0f)
			{
				return quaternion;
			}
			return Quaternion.RotateTowards(quaternion, rotation, twistLimit);
		}
	}
	[Serializable]
	public class FABRIKChain
	{
		public FABRIK ik;

		[Range(0f, 1f)]
		public float pull = 1f;

		[Range(0f, 1f)]
		public float pin = 1f;

		public int[] children = new int[0];

		public bool IsValid(ref string message)
		{
			if (ik == null)
			{
				message = "IK unassigned in FABRIKChain.";
				return false;
			}
			if (!ik.solver.IsValid(ref message))
			{
				return false;
			}
			return true;
		}

		public void Initiate()
		{
			ik.enabled = false;
		}

		public void Stage1(FABRIKChain[] chain)
		{
			for (int i = 0; i < children.Length; i++)
			{
				chain[children[i]].Stage1(chain);
			}
			if (children.Length == 0)
			{
				ik.solver.SolveForward(ik.solver.GetIKPosition());
			}
			else
			{
				ik.solver.SolveForward(GetCentroid(chain));
			}
		}

		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
			ik.solver.SolveBackward(rootPosition);
			for (int i = 0; i < children.Length; i++)
			{
				chain[children[i]].Stage2(ik.solver.bones[ik.solver.bones.Length - 1].transform.position, chain);
			}
		}

		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			Vector3 iKPosition = ik.solver.GetIKPosition();
			if (pin >= 1f)
			{
				return iKPosition;
			}
			float num = 0f;
			for (int i = 0; i < children.Length; i++)
			{
				num += chain[children[i]].pull;
			}
			if (num <= 0f)
			{
				return iKPosition;
			}
			if (num < 1f)
			{
				num = 1f;
			}
			Vector3 vector = iKPosition;
			for (int j = 0; j < children.Length; j++)
			{
				Vector3 vector2 = chain[children[j]].ik.solver.bones[0].solverPosition - iKPosition;
				float num2 = chain[children[j]].pull / num;
				vector += vector2 * num2;
			}
			if (pin <= 0f)
			{
				return vector;
			}
			return vector + (iKPosition - vector) * pin;
		}
	}
	public class FBBIKArmBending : MonoBehaviour
	{
		public FullBodyBipedIK ik;

		public Vector3 bendDirectionOffsetLeft;

		public Vector3 bendDirectionOffsetRight;

		public Vector3 characterSpaceBendOffsetLeft;

		public Vector3 characterSpaceBendOffsetRight;

		private Quaternion leftHandTargetRotation;

		private Quaternion rightHandTargetRotation;

		private bool initiated;

		private void LateUpdate()
		{
			if (!(ik == null))
			{
				if (!initiated)
				{
					IKSolverFullBodyBiped solver = ik.solver;
					solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostFBBIK));
					initiated = true;
				}
				if (ik.solver.leftHandEffector.target != null)
				{
					Vector3 left = Vector3.left;
					ik.solver.leftArmChain.bendConstraint.direction = ik.solver.leftHandEffector.target.rotation * left + ik.solver.leftHandEffector.target.rotation * bendDirectionOffsetLeft + ik.transform.rotation * characterSpaceBendOffsetLeft;
					ik.solver.leftArmChain.bendConstraint.weight = 1f;
				}
				if (ik.solver.rightHandEffector.target != null)
				{
					Vector3 right = Vector3.right;
					ik.solver.rightArmChain.bendConstraint.direction = ik.solver.rightHandEffector.target.rotation * right + ik.solver.rightHandEffector.target.rotation * bendDirectionOffsetRight + ik.transform.rotation * characterSpaceBendOffsetRight;
					ik.solver.rightArmChain.bendConstraint.weight = 1f;
				}
			}
		}

		private void OnPostFBBIK()
		{
			if (!(ik == null))
			{
				if (ik.solver.leftHandEffector.target != null)
				{
					ik.references.leftHand.rotation = ik.solver.leftHandEffector.target.rotation;
				}
				if (ik.solver.rightHandEffector.target != null)
				{
					ik.references.rightHand.rotation = ik.solver.rightHandEffector.target.rotation;
				}
			}
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostFBBIK));
			}
		}
	}
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		public class BendBone
		{
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight = 0.5f;

			private Quaternion defaultLocalRotation = Quaternion.identity;

			public BendBone()
			{
			}

			public BendBone(Transform transform, float weight)
			{
				this.transform = transform;
				this.weight = weight;
			}

			public void StoreDefaultLocalState()
			{
				defaultLocalRotation = transform.localRotation;
			}

			public void FixTransforms()
			{
				transform.localRotation = defaultLocalRotation;
			}
		}

		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight = 1f;

		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight = 0.8f;

		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight = 0.8f;

		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody = true;

		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight = 0.5f;

		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight = 0.5f;

		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight = 1f;

		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones = new BendBone[0];

		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight = 1f;

		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper = 500f;

		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones = new Transform[0];

		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight = 1f;

		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch = 0.1f;

		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones = new Transform[0];

		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection = Vector3.forward;

		[Range(0f, 1f)]
		public float chestDirectionWeight = 1f;

		public Transform[] chestBones = new Transform[0];

		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		private Vector3 offset;

		private Vector3 headToBody;

		private Vector3 shoulderCenterToHead;

		private Vector3 headToLeftThigh;

		private Vector3 headToRightThigh;

		private Vector3 leftShoulderPos;

		private Vector3 rightShoulderPos;

		private float shoulderDist;

		private float leftShoulderDist;

		private float rightShoulderDist;

		private Quaternion chestRotation;

		private Quaternion headRotationRelativeToRoot;

		private Quaternion[] ccdDefaultLocalRotations = new Quaternion[0];

		private Vector3 headLocalPosition;

		private Quaternion headLocalRotation;

		private Vector3[] stretchLocalPositions = new Vector3[0];

		private Quaternion[] stretchLocalRotations = new Quaternion[0];

		private Vector3[] chestLocalPositions = new Vector3[0];

		private Quaternion[] chestLocalRotations = new Quaternion[0];

		private int bendBonesCount;

		private int ccdBonesCount;

		private int stretchBonesCount;

		private int chestBonesCount;

		private void Start()
		{
			IKSolverFullBodyBiped solver = ik.solver;
			solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreRead, new IKSolver.UpdateDelegate(OnPreRead));
			IKSolverFullBodyBiped solver2 = ik.solver;
			solver2.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Combine(solver2.OnPreIteration, new IKSolver.IterationDelegate(Iterate));
			IKSolverFullBodyBiped solver3 = ik.solver;
			solver3.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostUpdate));
			IKSolverFullBodyBiped solver4 = ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.UpdateDelegate)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.UpdateDelegate(OnStoreDefaultLocalState));
			IKSolverFullBodyBiped solver5 = ik.solver;
			solver5.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.UpdateDelegate(OnFixTransforms));
			OnStoreDefaultLocalState();
			headRotationRelativeToRoot = Quaternion.Inverse(ik.references.root.rotation) * ik.references.head.rotation;
		}

		private void OnStoreDefaultLocalState()
		{
			BendBone[] array = bendBones;
			for (int i = 0; i < array.Length; i++)
			{
				array[i]?.StoreDefaultLocalState();
			}
			ccdDefaultLocalRotations = new Quaternion[CCDBones.Length];
			for (int j = 0; j < CCDBones.Length; j++)
			{
				if (CCDBones[j] != null)
				{
					ccdDefaultLocalRotations[j] = CCDBones[j].localRotation;
				}
			}
			headLocalPosition = ik.references.head.localPosition;
			headLocalRotation = ik.references.head.localRotation;
			stretchLocalPositions = new Vector3[stretchBones.Length];
			stretchLocalRotations = new Quaternion[stretchBones.Length];
			for (int k = 0; k < stretchBones.Length; k++)
			{
				if (stretchBones[k] != null)
				{
					stretchLocalPositions[k] = stretchBones[k].localPosition;
					stretchLocalRotations[k] = stretchBones[k].localRotation;
				}
			}
			chestLocalPositions = new Vector3[chestBones.Length];
			chestLocalRotations = new Quaternion[chestBones.Length];
			for (int l = 0; l < chestBones.Length; l++)
			{
				if (chestBones[l] != null)
				{
					chestLocalPositions[l] = chestBones[l].localPosition;
					chestLocalRotations[l] = chestBones[l].localRotation;
				}
			}
			bendBonesCount = bendBones.Length;
			ccdBonesCount = CCDBones.Length;
			stretchBonesCount = stretchBones.Length;
			chestBonesCount = chestBones.Length;
		}

		private void OnFixTransforms()
		{
			if (!base.enabled)
			{
				return;
			}
			BendBone[] array = bendBones;
			for (int i = 0; i < array.Length; i++)
			{
				array[i]?.FixTransforms();
			}
			for (int j = 0; j < CCDBones.Length; j++)
			{
				if (CCDBones[j] != null)
				{
					CCDBones[j].localRotation = ccdDefaultLocalRotations[j];
				}
			}
			ik.references.head.localPosition = headLocalPosition;
			ik.references.head.localRotation = headLocalRotation;
			for (int k = 0; k < stretchBones.Length; k++)
			{
				if (stretchBones[k] != null)
				{
					stretchBones[k].localPosition = stretchLocalPositions[k];
					stretchBones[k].localRotation = stretchLocalRotations[k];
				}
			}
			for (int l = 0; l < chestBones.Length; l++)
			{
				if (chestBones[l] != null)
				{
					chestBones[l].localPosition = chestLocalPositions[l];
					chestBones[l].localRotation = chestLocalRotations[l];
				}
			}
		}

		private void OnPreRead()
		{
			if (base.enabled && base.gameObject.activeInHierarchy && ik.solver.iterations != 0)
			{
				ik.solver.FABRIKPass = handsPullBody;
				if (bendBonesCount != bendBones.Length || ccdBonesCount != CCDBones.Length || stretchBonesCount != stretchBones.Length || chestBonesCount != chestBones.Length)
				{
					OnStoreDefaultLocalState();
				}
				ChestDirection();
				SpineBend();
				CCDPass();
				offset = base.transform.position - ik.references.head.position;
				shoulderDist = Vector3.Distance(ik.references.leftUpperArm.position, ik.references.rightUpperArm.position);
				leftShoulderDist = Vector3.Distance(ik.references.head.position, ik.references.leftUpperArm.position);
				rightShoulderDist = Vector3.Distance(ik.references.head.position, ik.references.rightUpperArm.position);
				headToBody = ik.solver.rootNode.position - ik.references.head.position;
				headToLeftThigh = ik.references.leftThigh.position - ik.references.head.position;
				headToRightThigh = ik.references.rightThigh.position - ik.references.head.position;
				leftShoulderPos = ik.references.leftUpperArm.position + offset * bodyWeight;
				rightShoulderPos = ik.references.rightUpperArm.position + offset * bodyWeight;
				chestRotation = Quaternion.LookRotation(ik.references.head.position - ik.references.leftUpperArm.position, ik.references.rightUpperArm.position - ik.references.leftUpperArm.position);
				if (OnPostHeadEffectorFK != null)
				{
					OnPostHeadEffectorFK();
				}
			}
		}

		private void SpineBend()
		{
			float num = bendWeight * ik.solver.IKPositionWeight;
			if (num <= 0f || bendBones.Length == 0)
			{
				return;
			}
			Quaternion rotation = base.transform.rotation * Quaternion.Inverse(ik.references.root.rotation * headRotationRelativeToRoot);
			rotation = QuaTools.ClampRotation(rotation, bodyClampWeight, 2);
			float num2 = 1f / (float)bendBones.Length;
			for (int i = 0; i < bendBones.Length; i++)
			{
				if (bendBones[i].transform != null)
				{
					bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, rotation, num2 * bendBones[i].weight * num) * bendBones[i].transform.rotation;
				}
			}
		}

		private void CCDPass()
		{
			float num = CCDWeight * ik.solver.IKPositionWeight;
			if (!(num <= 0f))
			{
				for (int num2 = CCDBones.Length - 1; num2 > -1; num2--)
				{
					Quaternion quaternion = Quaternion.FromToRotation(ik.references.head.position - CCDBones[num2].position, base.transform.position - CCDBones[num2].position) * CCDBones[num2].rotation;
					float num3 = Mathf.Lerp((CCDBones.Length - num2) / CCDBones.Length, 1f, roll);
					float num4 = Quaternion.Angle(Quaternion.identity, quaternion);
					num4 = Mathf.Lerp(0f, num4, (damper - num4) / damper);
					CCDBones[num2].rotation = Quaternion.RotateTowards(CCDBones[num2].rotation, quaternion, num4 * num * num3);
				}
			}
		}

		private void Iterate(int iteration)
		{
			if (base.enabled && base.gameObject.activeInHierarchy && ik.solver.iterations != 0)
			{
				leftShoulderPos = base.transform.position + (leftShoulderPos - base.transform.position).normalized * leftShoulderDist;
				rightShoulderPos = base.transform.position + (rightShoulderPos - base.transform.position).normalized * rightShoulderDist;
				Solve(ref leftShoulderPos, ref rightShoulderPos, shoulderDist);
				LerpSolverPosition(ik.solver.leftShoulderEffector, leftShoulderPos, positionWeight * ik.solver.IKPositionWeight, ik.solver.leftShoulderEffector.positionOffset);
				LerpSolverPosition(ik.solver.rightShoulderEffector, rightShoulderPos, positionWeight * ik.solver.IKPositionWeight, ik.solver.rightShoulderEffector.positionOffset);
				Quaternion to = Quaternion.LookRotation(base.transform.position - leftShoulderPos, rightShoulderPos - leftShoulderPos);
				Quaternion quaternion = QuaTools.FromToRotation(chestRotation, to);
				Vector3 vector = quaternion * headToBody;
				LerpSolverPosition(ik.solver.bodyEffector, base.transform.position + vector, positionWeight * ik.solver.IKPositionWeight, ik.solver.bodyEffector.positionOffset - ik.solver.pullBodyOffset);
				Quaternion quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion, thighWeight);
				Vector3 vector2 = quaternion2 * headToLeftThigh;
				Vector3 vector3 = quaternion2 * headToRightThigh;
				LerpSolverPosition(ik.solver.leftThighEffector, base.transform.position + vector2, positionWeight * ik.solver.IKPositionWeight, ik.solver.bodyEffector.positionOffset - ik.solver.pullBodyOffset + ik.solver.leftThighEffector.positionOffset);
				LerpSolverPosition(ik.solver.rightThighEffector, base.transform.position + vector3, positionWeight * ik.solver.IKPositionWeight, ik.solver.bodyEffector.positionOffset - ik.solver.pullBodyOffset + ik.solver.rightThighEffector.positionOffset);
			}
		}

		private void OnPostUpdate()
		{
			if (base.enabled && base.gameObject.activeInHierarchy)
			{
				PostStretching();
				Quaternion rotation = QuaTools.FromToRotation(ik.references.head.rotation, base.transform.rotation);
				rotation = QuaTools.ClampRotation(rotation, headClampWeight, 2);
				ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, rotation, rotationWeight * ik.solver.IKPositionWeight) * ik.references.head.rotation;
			}
		}

		private void ChestDirection()
		{
			float num = chestDirectionWeight * ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			bool changed = false;
			chestDirection = V3Tools.ClampDirection(chestDirection, ik.references.root.forward, 0.45f, 2, out changed);
			if (!(chestDirection == Vector3.zero))
			{
				Quaternion b = Quaternion.FromToRotation(ik.references.root.forward, chestDirection);
				b = Quaternion.Lerp(Quaternion.identity, b, num * (1f / (float)chestBones.Length));
				Transform[] array = chestBones;
				foreach (Transform transform in array)
				{
					transform.rotation = b * transform.rotation;
				}
			}
		}

		private void PostStretching()
		{
			float num = postStretchWeight * ik.solver.IKPositionWeight;
			if (num > 0f)
			{
				Vector3 vector = Vector3.ClampMagnitude(base.transform.position - ik.references.head.position, maxStretch);
				vector *= num;
				stretchDamper = Mathf.Max(stretchDamper, 0f);
				if (stretchDamper > 0f)
				{
					vector /= (1f + vector.magnitude) * (1f + stretchDamper);
				}
				for (int i = 0; i < stretchBones.Length; i++)
				{
					if (stretchBones[i] != null)
					{
						stretchBones[i].position += vector / stretchBones.Length;
					}
				}
			}
			if (fixHead && ik.solver.IKPositionWeight > 0f)
			{
				ik.references.head.position = base.transform.position;
			}
		}

		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
			effector.GetNode(ik.solver).solverPosition = Vector3.Lerp(effector.GetNode(ik.solver).solverPosition, position + offset, weight);
		}

		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
			Vector3 vector = pos2 - pos1;
			float magnitude = vector.magnitude;
			if (magnitude != nominalDistance && magnitude != 0f)
			{
				float num = 1f;
				num *= 1f - nominalDistance / magnitude;
				Vector3 vector2 = vector * num * 0.5f;
				pos1 += vector2;
				pos2 -= vector2;
			}
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreRead, new IKSolver.UpdateDelegate(OnPreRead));
				IKSolverFullBodyBiped solver2 = ik.solver;
				solver2.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Remove(solver2.OnPreIteration, new IKSolver.IterationDelegate(Iterate));
				IKSolverFullBodyBiped solver3 = ik.solver;
				solver3.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostUpdate));
				IKSolverFullBodyBiped solver4 = ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.UpdateDelegate)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.UpdateDelegate(OnStoreDefaultLocalState));
				IKSolverFullBodyBiped solver5 = ik.solver;
				solver5.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.UpdateDelegate(OnFixTransforms));
			}
		}
	}
	[Serializable]
	public class FBIKChain
	{
		[Serializable]
		public class ChildConstraint
		{
			public float pushElasticity;

			public float pullElasticity;

			[SerializeField]
			private Transform bone1;

			[SerializeField]
			private Transform bone2;

			private float crossFade;

			private float inverseCrossFade;

			private int chain1Index;

			private int chain2Index;

			public float nominalDistance { get; private set; }

			public bool isRigid { get; private set; }

			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
				this.bone1 = bone1;
				this.bone2 = bone2;
				this.pushElasticity = pushElasticity;
				this.pullElasticity = pullElasticity;
			}

			public void Initiate(IKSolverFullBody solver)
			{
				chain1Index = solver.GetChainIndex(bone1);
				chain2Index = solver.GetChainIndex(bone2);
				OnPreSolve(solver);
			}

			public void OnPreSolve(IKSolverFullBody solver)
			{
				nominalDistance = Vector3.Distance(solver.chain[chain1Index].nodes[0].transform.position, solver.chain[chain2Index].nodes[0].transform.position);
				isRigid = pushElasticity <= 0f && pullElasticity <= 0f;
				if (isRigid)
				{
					float num = solver.chain[chain1Index].pull - solver.chain[chain2Index].pull;
					crossFade = 1f - (0.5f + num * 0.5f);
				}
				else
				{
					crossFade = 0.5f;
				}
				inverseCrossFade = 1f - crossFade;
			}

			public void Solve(IKSolverFullBody solver)
			{
				if (pushElasticity >= 1f && pullElasticity >= 1f)
				{
					return;
				}
				Vector3 vector = solver.chain[chain2Index].nodes[0].solverPosition - solver.chain[chain1Index].nodes[0].solverPosition;
				float magnitude = vector.magnitude;
				if (magnitude != nominalDistance && magnitude != 0f)
				{
					float num = 1f;
					if (!isRigid)
					{
						float num2 = ((magnitude > nominalDistance) ? pullElasticity : pushElasticity);
						num = 1f - num2;
					}
					num *= 1f - nominalDistance / magnitude;
					Vector3 vector2 = vector * num;
					solver.chain[chain1Index].nodes[0].solverPosition += vector2 * crossFade;
					solver.chain[chain2Index].nodes[0].solverPosition -= vector2 * inverseCrossFade;
				}
			}
		}

		[Serializable]
		public enum Smoothing
		{
			None,
			Exponential,
			Cubic
		}

		[Range(0f, 1f)]
		public float pin;

		[Range(0f, 1f)]
		public float pull = 1f;

		[Range(0f, 1f)]
		public float push;

		[Range(-1f, 1f)]
		public float pushParent;

		[Range(0f, 1f)]
		public float reach = 0.1f;

		public Smoothing reachSmoothing = Smoothing.Exponential;

		public Smoothing pushSmoothing = Smoothing.Exponential;

		public IKSolver.Node[] nodes = new IKSolver.Node[0];

		public int[] children = new int[0];

		public ChildConstraint[] childConstraints = new ChildConstraint[0];

		public IKConstraintBend bendConstraint = new IKConstraintBend();

		private float rootLength;

		private bool initiated;

		private float length;

		private float distance;

		private IKSolver.Point p;

		private float reachForce;

		private float pullParentSum;

		private float[] crossFades;

		private float sqrMag1;

		private float sqrMag2;

		private float sqrMagDif;

		private const float maxLimbLength = 0.99999f;

		public FBIKChain()
		{
		}

		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
			this.pin = pin;
			this.pull = pull;
			SetNodes(nodeTransforms);
			children = new int[0];
		}

		public void SetNodes(params Transform[] boneTransforms)
		{
			nodes = new IKSolver.Node[boneTransforms.Length];
			for (int i = 0; i < boneTransforms.Length; i++)
			{
				nodes[i] = new IKSolver.Node(boneTransforms[i]);
			}
		}

		public int GetNodeIndex(Transform boneTransform)
		{
			for (int i = 0; i < nodes.Length; i++)
			{
				if (nodes[i].transform == boneTransform)
				{
					return i;
				}
			}
			return -1;
		}

		public bool IsValid(ref string message)
		{
			if (nodes.Length == 0)
			{
				message = "FBIK chain contains no nodes.";
				return false;
			}
			IKSolver.Node[] array = nodes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					message = "Node transform is null in FBIK chain.";
					return false;
				}
			}
			return true;
		}

		public void Initiate(IKSolverFullBody solver)
		{
			initiated = false;
			IKSolver.Node[] array = nodes;
			foreach (IKSolver.Node obj in array)
			{
				obj.solverPosition = obj.transform.position;
			}
			CalculateBoneLengths(solver);
			ChildConstraint[] array2 = childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Initiate(solver);
			}
			if (nodes.Length == 3)
			{
				bendConstraint.SetBones(nodes[0].transform, nodes[1].transform, nodes[2].transform);
				bendConstraint.Initiate(solver);
			}
			crossFades = new float[children.Length];
			initiated = true;
		}

		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
			if (!initiated)
			{
				return;
			}
			for (int i = 0; i < nodes.Length; i++)
			{
				nodes[i].solverPosition = nodes[i].transform.position + nodes[i].offset;
			}
			CalculateBoneLengths(solver);
			if (!fullBody)
			{
				return;
			}
			for (int j = 0; j < childConstraints.Length; j++)
			{
				childConstraints[j].OnPreSolve(solver);
			}
			if (children.Length != 0)
			{
				float num = nodes[nodes.Length - 1].effectorPositionWeight;
				for (int k = 0; k < children.Length; k++)
				{
					num += solver.chain[children[k]].nodes[0].effectorPositionWeight * solver.chain[children[k]].pull;
				}
				num = Mathf.Clamp(num, 1f, float.PositiveInfinity);
				for (int l = 0; l < children.Length; l++)
				{
					crossFades[l] = solver.chain[children[l]].nodes[0].effectorPositionWeight * solver.chain[children[l]].pull / num;
				}
			}
			pullParentSum = 0f;
			for (int m = 0; m < children.Length; m++)
			{
				pullParentSum += solver.chain[children[m]].pull;
			}
			pullParentSum = Mathf.Clamp(pullParentSum, 1f, float.PositiveInfinity);
			if (nodes.Length == 3)
			{
				reachForce = reach * Mathf.Clamp(nodes[2].effectorPositionWeight, 0f, 1f);
			}
			else
			{
				reachForce = 0f;
			}
			if (push > 0f && nodes.Length > 1)
			{
				distance = Vector3.Distance(nodes[0].transform.position, nodes[nodes.Length - 1].transform.position);
			}
		}

		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
			length = 0f;
			for (int i = 0; i < nodes.Length - 1; i++)
			{
				nodes[i].length = Vector3.Distance(nodes[i].transform.position, nodes[i + 1].transform.position);
				length += nodes[i].length;
				if (nodes[i].length == 0f)
				{
					Warning.Log("Bone " + nodes[i].transform.name + " - " + nodes[i + 1].transform.name + " length is zero, can not solve.", nodes[i].transform);
					return;
				}
			}
			for (int j = 0; j < children.Length; j++)
			{
				solver.chain[children[j]].rootLength = (solver.chain[children[j]].nodes[0].transform.position - nodes[nodes.Length - 1].transform.position).magnitude;
				if (solver.chain[children[j]].rootLength == 0f)
				{
					return;
				}
			}
			if (nodes.Length == 3)
			{
				sqrMag1 = nodes[0].length * nodes[0].length;
				sqrMag2 = nodes[1].length * nodes[1].length;
				sqrMagDif = sqrMag1 - sqrMag2;
			}
		}

		public void Reach(IKSolverFullBody solver)
		{
			if (!initiated)
			{
				return;
			}
			for (int i = 0; i < children.Length; i++)
			{
				solver.chain[children[i]].Reach(solver);
			}
			if (reachForce <= 0f)
			{
				return;
			}
			Vector3 vector = nodes[2].solverPosition - nodes[0].solverPosition;
			if (!(vector == Vector3.zero))
			{
				float magnitude = vector.magnitude;
				Vector3 vector2 = vector / magnitude * length;
				float num = Mathf.Clamp(magnitude / length, 1f - reachForce, 1f + reachForce) - 1f;
				num = Mathf.Clamp(num + reachForce, -1f, 1f);
				switch (reachSmoothing)
				{
				case Smoothing.Exponential:
					num *= num;
					break;
				case Smoothing.Cubic:
					num *= num * num;
					break;
				}
				Vector3 vector3 = vector2 * Mathf.Clamp(num, 0f, magnitude);
				nodes[0].solverPosition += vector3 * (1f - nodes[0].effectorPositionWeight);
				nodes[2].solverPosition += vector3;
			}
		}

		public Vector3 Push(IKSolverFullBody solver)
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < children.Length; i++)
			{
				zero += solver.chain[children[i]].Push(solver) * solver.chain[children[i]].pushParent;
			}
			nodes[nodes.Length - 1].solverPosition += zero;
			if (nodes.Length < 2)
			{
				return Vector3.zero;
			}
			if (push <= 0f)
			{
				return Vector3.zero;
			}
			Vector3 vector = nodes[2].solverPosition - nodes[0].solverPosition;
			float magnitude = vector.magnitude;
			if (magnitude == 0f)
			{
				return Vector3.zero;
			}
			float num = 1f - magnitude / distance;
			if (num <= 0f)
			{
				return Vector3.zero;
			}
			switch (pushSmoothing)
			{
			case Smoothing.Exponential:
				num *= num;
				break;
			case Smoothing.Cubic:
				num *= num * num;
				break;
			}
			Vector3 vector2 = -vector * num * push;
			nodes[0].solverPosition += vector2;
			return vector2;
		}

		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
			if (!initiated)
			{
				return;
			}
			for (int i = 0; i < children.Length; i++)
			{
				solver.chain[children[i]].SolveTrigonometric(solver, calculateBendDirection);
			}
			if (nodes.Length == 3)
			{
				Vector3 vector = nodes[2].solverPosition - nodes[0].solverPosition;
				float magnitude = vector.magnitude;
				if (magnitude != 0f)
				{
					float num = Mathf.Clamp(magnitude, 0f, length * 0.99999f);
					Vector3 direction = vector / magnitude * num;
					Vector3 bendDirection = ((calculateBendDirection && bendConstraint.initiated) ? bendConstraint.GetDir(solver) : (nodes[1].solverPosition - nodes[0].solverPosition));
					Vector3 dirToBendPoint = GetDirToBendPoint(direction, bendDirection, num);
					nodes[1].solverPosition = nodes[0].solverPosition + dirToBendPoint;
				}
			}
		}

		public void Stage1(IKSolverFullBody solver)
		{
			for (int i = 0; i < children.Length; i++)
			{
				solver.chain[children[i]].Stage1(solver);
			}
			if (children.Length == 0)
			{
				ForwardReach(nodes[nodes.Length - 1].solverPosition);
				return;
			}
			Vector3 solverPosition = nodes[nodes.Length - 1].solverPosition;
			SolveChildConstraints(solver);
			for (int j = 0; j < children.Length; j++)
			{
				Vector3 vector = solver.chain[children[j]].nodes[0].solverPosition;
				if (solver.chain[children[j]].rootLength > 0f)
				{
					vector = SolveFABRIKJoint(nodes[nodes.Length - 1].solverPosition, solver.chain[children[j]].nodes[0].solverPosition, solver.chain[children[j]].rootLength);
				}
				if (pullParentSum > 0f)
				{
					solverPosition += (vector - nodes[nodes.Length - 1].solverPosition) * (solver.chain[children[j]].pull / pullParentSum);
				}
			}
			ForwardReach(Vector3.Lerp(solverPosition, nodes[nodes.Length - 1].solverPosition, pin));
		}

		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
			BackwardReach(position);
			int num = Mathf.Clamp(solver.iterations, 2, 4);
			if (childConstraints.Length != 0)
			{
				for (int i = 0; i < num; i++)
				{
					SolveConstraintSystems(solver);
				}
			}
			for (int j = 0; j < children.Length; j++)
			{
				solver.chain[children[j]].Stage2(solver, nodes[nodes.Length - 1].solverPosition);
			}
		}

		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
			SolveChildConstraints(solver);
			for (int i = 0; i < children.Length; i++)
			{
				SolveLinearConstraint(nodes[nodes.Length - 1], solver.chain[children[i]].nodes[0], crossFades[i], solver.chain[children[i]].rootLength);
			}
		}

		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return pos2 + (pos1 - pos2).normalized * length;
		}

		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			float num = (directionMagnitude * directionMagnitude + sqrMagDif) / 2f / directionMagnitude;
			float y = (float)Math.Sqrt(Mathf.Clamp(sqrMag1 - num * num, 0f, float.PositiveInfinity));
			if (direction == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(direction, bendDirection) * new Vector3(0f, y, num);
		}

		private void SolveChildConstraints(IKSolverFullBody solver)
		{
			for (int i = 0; i < childConstraints.Length; i++)
			{
				childConstraints[i].Solve(solver);
			}
		}

		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
			Vector3 vector = node2.solverPosition - node1.solverPosition;
			float magnitude = vector.magnitude;
			if (distance != magnitude && magnitude != 0f)
			{
				Vector3 vector2 = vector * (1f - distance / magnitude);
				node1.solverPosition += vector2 * crossFade;
				node2.solverPosition -= vector2 * (1f - crossFade);
			}
		}

		public void ForwardReach(Vector3 position)
		{
			nodes[nodes.Length - 1].solverPosition = position;
			for (int num = nodes.Length - 2; num > -1; num--)
			{
				nodes[num].solverPosition = SolveFABRIKJoint(nodes[num].solverPosition, nodes[num + 1].solverPosition, nodes[num].length);
			}
		}

		private void BackwardReach(Vector3 position)
		{
			if (rootLength > 0f)
			{
				position = SolveFABRIKJoint(nodes[0].solverPosition, position, rootLength);
			}
			nodes[0].solverPosition = position;
			for (int i = 1; i < nodes.Length; i++)
			{
				nodes[i].solverPosition = SolveFABRIKJoint(nodes[i].solverPosition, nodes[i - 1].solverPosition, nodes[i - 1].length);
			}
		}
	}
	[Serializable]
	public class IKConstraintBend
	{
		public Transform bone1;

		public Transform bone2;

		public Transform bone3;

		public Transform bendGoal;

		public Vector3 direction = Vector3.right;

		public Quaternion rotationOffset;

		[Range(0f, 1f)]
		public float weight;

		public Vector3 defaultLocalDirection;

		public Vector3 defaultChildDirection;

		[NonSerialized]
		public float clampF = 0.505f;

		private int chainIndex1;

		private int nodeIndex1;

		private int chainIndex2;

		private int nodeIndex2;

		private int chainIndex3;

		private int nodeIndex3;

		private bool limbOrientationsSet;

		public bool initiated { get; private set; }

		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			if (bone1 == null || bone2 == null || bone3 == null)
			{
				logger?.Invoke("Bend Constraint contains a null reference.");
				return false;
			}
			if (solver.GetPoint(bone1) == null)
			{
				logger?.Invoke("Bend Constraint is referencing to a bone '" + bone1.name + "' that does not excist in the Node Chain.");
				return false;
			}
			if (solver.GetPoint(bone2) == null)
			{
				logger?.Invoke("Bend Constraint is referencing to a bone '" + bone2.name + "' that does not excist in the Node Chain.");
				return false;
			}
			if (solver.GetPoint(bone3) == null)
			{
				logger?.Invoke("Bend Constraint is referencing to a bone '" + bone3.name + "' that does not excist in the Node Chain.");
				return false;
			}
			return true;
		}

		public IKConstraintBend()
		{
		}

		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
			SetBones(bone1, bone2, bone3);
		}

		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
			this.bone1 = bone1;
			this.bone2 = bone2;
			this.bone3 = bone3;
		}

		public void Initiate(IKSolverFullBody solver)
		{
			solver.GetChainAndNodeIndexes(bone1, out chainIndex1, out nodeIndex1);
			solver.GetChainAndNodeIndexes(bone2, out chainIndex2, out nodeIndex2);
			solver.GetChainAndNodeIndexes(bone3, out chainIndex3, out nodeIndex3);
			direction = OrthoToBone1(solver, OrthoToLimb(solver, bone2.position - bone1.position));
			if (!limbOrientationsSet)
			{
				defaultLocalDirection = Quaternion.Inverse(bone1.rotation) * direction;
				Vector3 vector = Vector3.Cross((bone3.position - bone1.position).normalized, direction);
				defaultChildDirection = Quaternion.Inverse(bone3.rotation) * vector;
			}
			initiated = true;
		}

		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
			if (upper == Vector3.zero)
			{
				UnityEngine.Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (lower == Vector3.zero)
			{
				UnityEngine.Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (last == Vector3.zero)
			{
				UnityEngine.Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			defaultLocalDirection = upper.normalized;
			defaultChildDirection = last.normalized;
			limbOrientationsSet = true;
		}

		public void LimitBend(float solverWeight, float positionWeight)
		{
			if (initiated)
			{
				Vector3 vector = bone1.rotation * -defaultLocalDirection;
				Vector3 fromDirection = bone3.position - bone2.position;
				bool changed = false;
				Vector3 toDirection = V3Tools.ClampDirection(fromDirection, vector, clampF * solverWeight, 0, out changed);
				Quaternion rotation = bone3.rotation;
				if (changed)
				{
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
					bone2.rotation = quaternion * bone2.rotation;
				}
				if (positionWeight > 0f)
				{
					Vector3 normal = bone2.position - bone1.position;
					Vector3 tangent = bone3.position - bone2.position;
					Vector3.OrthoNormalize(ref normal, ref tangent);
					Quaternion quaternion2 = Quaternion.FromToRotation(tangent, vector);
					bone2.rotation = Quaternion.Lerp(bone2.rotation, quaternion2 * bone2.rotation, positionWeight * solverWeight);
				}
				if (changed || positionWeight > 0f)
				{
					bone3.rotation = rotation;
				}
			}
		}

		public Vector3 GetDir(IKSolverFullBody solver)
		{
			if (!initiated)
			{
				return Vector3.zero;
			}
			float num = weight * solver.IKPositionWeight;
			if (bendGoal != null)
			{
				Vector3 vector = bendGoal.position - solver.GetNode(chainIndex1, nodeIndex1).solverPosition;
				if (vector != Vector3.zero)
				{
					direction = vector;
				}
			}
			if (num >= 1f)
			{
				return direction.normalized;
			}
			Vector3 vector2 = solver.GetNode(chainIndex3, nodeIndex3).solverPosition - solver.GetNode(chainIndex1, nodeIndex1).solverPosition;
			Vector3 vector3 = Quaternion.FromToRotation(bone3.position - bone1.position, vector2) * (bone2.position - bone1.position);
			if (solver.GetNode(chainIndex3, nodeIndex3).effectorRotationWeight > 0f)
			{
				Vector3 b = -Vector3.Cross(vector2, solver.GetNode(chainIndex3, nodeIndex3).solverRotation * defaultChildDirection);
				vector3 = Vector3.Lerp(vector3, b, solver.GetNode(chainIndex3, nodeIndex3).effectorRotationWeight);
			}
			if (rotationOffset != Quaternion.identity)
			{
				vector3 = Quaternion.FromToRotation(rotationOffset * vector2, vector2) * rotationOffset * vector3;
			}
			if (num <= 0f)
			{
				return vector3;
			}
			return Vector3.Lerp(vector3, direction.normalized, num);
		}

		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			Vector3 normal = solver.GetNode(chainIndex3, nodeIndex3).solverPosition - solver.GetNode(chainIndex1, nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return tangent;
		}

		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			Vector3 normal = solver.GetNode(chainIndex2, nodeIndex2).solverPosition - solver.GetNode(chainIndex1, nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return tangent;
		}
	}
	[Serializable]
	public class IKEffector
	{
		public Transform bone;

		public Transform target;

		[Range(0f, 1f)]
		public float positionWeight;

		[Range(0f, 1f)]
		public float rotationWeight;

		public Vector3 position = Vector3.zero;

		public Quaternion rotation = Quaternion.identity;

		public Vector3 positionOffset;

		public bool effectChildNodes = true;

		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		public Transform[] childBones = new Transform[0];

		public Transform planeBone1;

		public Transform planeBone2;

		public Transform planeBone3;

		public Quaternion planeRotationOffset = Quaternion.identity;

		private float posW;

		private float rotW;

		private Vector3[] localPositions = new Vector3[0];

		private bool usePlaneNodes;

		private Quaternion animatedPlaneRotation = Quaternion.identity;

		private Vector3 animatedPosition;

		private bool firstUpdate;

		private int chainIndex = -1;

		private int nodeIndex = -1;

		private int plane1ChainIndex;

		private int plane1NodeIndex = -1;

		private int plane2ChainIndex = -1;

		private int plane2NodeIndex = -1;

		private int plane3ChainIndex = -1;

		private int plane3NodeIndex = -1;

		private int[] childChainIndexes = new int[0];

		private int[] childNodeIndexes = new int[0];

		public bool isEndEffector { get; private set; }

		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return solver.chain[chainIndex].nodes[nodeIndex];
		}

		public void PinToBone(float positionWeight, float rotationWeight)
		{
			position = bone.position;
			this.positionWeight = Mathf.Clamp(positionWeight, 0f, 1f);
			rotation = bone.rotation;
			this.rotationWeight = Mathf.Clamp(rotationWeight, 0f, 1f);
		}

		public IKEffector()
		{
		}

		public IKEffector(Transform bone, Transform[] childBones)
		{
			this.bone = bone;
			this.childBones = childBones;
		}

		public bool IsValid(IKSolver solver, ref string message)
		{
			if (bone == null)
			{
				message = "IK Effector bone is null.";
				return false;
			}
			if (solver.GetPoint(bone) == null)
			{
				message = "IK Effector is referencing to a bone '" + bone.name + "' that does not excist in the Node Chain.";
				return false;
			}
			Transform[] array = childBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					message = "IK Effector contains a null reference.";
					return false;
				}
			}
			array = childBones;
			foreach (Transform transform in array)
			{
				if (solver.GetPoint(transform) == null)
				{
					message = "IK Effector is referencing to a bone '" + transform.name + "' that does not excist in the Node Chain.";
					return false;
				}
			}
			if (planeBone1 != null && solver.GetPoint(planeBone1) == null)
			{
				message = "IK Effector is referencing to a bone '" + planeBone1.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (planeBone2 != null && solver.GetPoint(planeBone2) == null)
			{
				message = "IK Effector is referencing to a bone '" + planeBone2.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (planeBone3 != null && solver.GetPoint(planeBone3) == null)
			{
				message = "IK Effector is referencing to a bone '" + planeBone3.name + "' that does not excist in the Node Chain.";
				return false;
			}
			return true;
		}

		public void Initiate(IKSolverFullBody solver)
		{
			position = bone.position;
			rotation = bone.rotation;
			animatedPlaneRotation = Quaternion.identity;
			solver.GetChainAndNodeIndexes(bone, out chainIndex, out nodeIndex);
			childChainIndexes = new int[childBones.Length];
			childNodeIndexes = new int[childBones.Length];
			for (int i = 0; i < childBones.Length; i++)
			{
				solver.GetChainAndNodeIndexes(childBones[i], out childChainIndexes[i], out childNodeIndexes[i]);
			}
			localPositions = new Vector3[childBones.Length];
			usePlaneNodes = false;
			if (planeBone1 != null)
			{
				solver.GetChainAndNodeIndexes(planeBone1, out plane1ChainIndex, out plane1NodeIndex);
				if (planeBone2 != null)
				{
					solver.GetChainAndNodeIndexes(planeBone2, out plane2ChainIndex, out plane2NodeIndex);
					if (planeBone3 != null)
					{
						solver.GetChainAndNodeIndexes(planeBone3, out plane3ChainIndex, out plane3NodeIndex);
						usePlaneNodes = true;
					}
				}
				isEndEffector = true;
			}
			else
			{
				isEndEffector = false;
			}
		}

		public void ResetOffset(IKSolverFullBody solver)
		{
			solver.GetNode(chainIndex, nodeIndex).offset = Vector3.zero;
			for (int i = 0; i < childChainIndexes.Length; i++)
			{
				solver.GetNode(childChainIndexes[i], childNodeIndexes[i]).offset = Vector3.zero;
			}
		}

		public void SetToTarget()
		{
			if (!(target == null))
			{
				position = target.position;
				rotation = target.rotation;
			}
		}

		public void OnPreSolve(IKSolverFullBody solver)
		{
			positionWeight = Mathf.Clamp(positionWeight, 0f, 1f);
			rotationWeight = Mathf.Clamp(rotationWeight, 0f, 1f);
			maintainRelativePositionWeight = Mathf.Clamp(maintainRelativePositionWeight, 0f, 1f);
			posW = positionWeight * solver.IKPositionWeight;
			rotW = rotationWeight * solver.IKPositionWeight;
			solver.GetNode(chainIndex, nodeIndex).effectorPositionWeight = posW;
			solver.GetNode(chainIndex, nodeIndex).effectorRotationWeight = rotW;
			solver.GetNode(chainIndex, nodeIndex).solverRotation = rotation;
			if (float.IsInfinity(positionOffset.x) || float.IsInfinity(positionOffset.y) || float.IsInfinity(positionOffset.z))
			{
				UnityEngine.Debug.LogError("Invalid IKEffector.positionOffset (contains Infinity)! Please make sure not to set IKEffector.positionOffset to infinite values.", bone);
			}
			if (float.IsNaN(positionOffset.x) || float.IsNaN(positionOffset.y) || float.IsNaN(positionOffset.z))
			{
				UnityEngine.Debug.LogError("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.", bone);
			}
			if (positionOffset.sqrMagnitude > 1E+10f)
			{
				UnityEngine.Debug.LogError("Additive effector positionOffset detected in Full Body IK (extremely large value). Make sure you are not circularily adding to effector positionOffset each frame.", bone);
			}
			if (float.IsInfinity(position.x) || float.IsInfinity(position.y) || float.IsInfinity(position.z))
			{
				UnityEngine.Debug.LogError("Invalid IKEffector.position (contains Infinity)!");
			}
			solver.GetNode(chainIndex, nodeIndex).offset += positionOffset * solver.IKPositionWeight;
			if (effectChildNodes && solver.iterations > 0)
			{
				for (int i = 0; i < childBones.Length; i++)
				{
					localPositions[i] = childBones[i].transform.position - bone.transform.position;
					solver.GetNode(childChainIndexes[i], childNodeIndexes[i]).offset += positionOffset * solver.IKPositionWeight;
				}
			}
			if (usePlaneNodes && maintainRelativePositionWeight > 0f)
			{
				animatedPlaneRotation = Quaternion.LookRotation(planeBone2.position - planeBone1.position, planeBone3.position - planeBone1.position);
			}
			firstUpdate = true;
		}

		public void OnPostWrite()
		{
			positionOffset = Vector3.zero;
		}

		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			Vector3 solverPosition = solver.GetNode(plane1ChainIndex, plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = solver.GetNode(plane2ChainIndex, plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = solver.GetNode(plane3ChainIndex, plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				Warning.Log("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", bone);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		public void Update(IKSolverFullBody solver)
		{
			if (firstUpdate)
			{
				animatedPosition = bone.position + solver.GetNode(chainIndex, nodeIndex).offset;
				firstUpdate = false;
			}
			solver.GetNode(chainIndex, nodeIndex).solverPosition = Vector3.Lerp(GetPosition(solver, out planeRotationOffset), position, posW);
			if (effectChildNodes)
			{
				for (int i = 0; i < childBones.Length; i++)
				{
					solver.GetNode(childChainIndexes[i], childNodeIndexes[i]).solverPosition = Vector3.Lerp(solver.GetNode(childChainIndexes[i], childNodeIndexes[i]).solverPosition, solver.GetNode(chainIndex, nodeIndex).solverPosition + localPositions[i], posW);
				}
			}
		}

		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			planeRotationOffset = Quaternion.identity;
			if (!isEndEffector)
			{
				return solver.GetNode(chainIndex, nodeIndex).solverPosition;
			}
			if (maintainRelativePositionWeight <= 0f)
			{
				return animatedPosition;
			}
			Vector3 vector = bone.position;
			Vector3 vector2 = vector - planeBone1.position;
			planeRotationOffset = GetPlaneRotation(solver) * Quaternion.Inverse(animatedPlaneRotation);
			vector = solver.GetNode(plane1ChainIndex, plane1NodeIndex).solverPosition + planeRotationOffset * vector2;
			planeRotationOffset = Quaternion.Lerp(Quaternion.identity, planeRotationOffset, maintainRelativePositionWeight);
			return Vector3.Lerp(animatedPosition, vector + solver.GetNode(chainIndex, nodeIndex).offset, maintainRelativePositionWeight);
		}
	}
	[Serializable]
	public class IKMapping
	{
		[Serializable]
		public class BoneMap
		{
			public Transform transform;

			public int chainIndex = -1;

			public int nodeIndex = -1;

			public Vector3 defaultLocalPosition;

			public Quaternion defaultLocalRotation;

			public Vector3 localSwingAxis;

			public Vector3 localTwistAxis;

			public Vector3 planePosition;

			public Vector3 ikPosition;

			public Quaternion defaultLocalTargetRotation;

			private Quaternion maintainRotation;

			public float length;

			public Quaternion animatedRotation;

			private Transform planeBone1;

			private Transform planeBone2;

			private Transform planeBone3;

			private int plane1ChainIndex = -1;

			private int plane1NodeIndex = -1;

			private int plane2ChainIndex = -1;

			private int plane2NodeIndex = -1;

			private int plane3ChainIndex = -1;

			private int plane3NodeIndex = -1;

			public Vector3 swingDirection => transform.rotation * localSwingAxis;

			public bool isNodeBone => nodeIndex != -1;

			private Quaternion lastAnimatedTargetRotation
			{
				get
				{
					if (planeBone1.position == planeBone3.position)
					{
						return Quaternion.identity;
					}
					return Quaternion.LookRotation(planeBone2.position - planeBone1.position, planeBone3.position - planeBone1.position);
				}
			}

			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
				this.transform = transform;
				solver.GetChainAndNodeIndexes(transform, out chainIndex, out nodeIndex);
			}

			public void StoreDefaultLocalState()
			{
				defaultLocalPosition = transform.localPosition;
				defaultLocalRotation = transform.localRotation;
			}

			public void FixTransform(bool position)
			{
				if (position)
				{
					transform.localPosition = defaultLocalPosition;
				}
				transform.localRotation = defaultLocalRotation;
			}

			public void SetLength(BoneMap nextBone)
			{
				length = Vector3.Distance(transform.position, nextBone.transform.position);
			}

			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
				SetLocalSwingAxis(swingTarget, this);
			}

			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
				localSwingAxis = Quaternion.Inverse(transform.rotation) * (bone1.transform.position - bone2.transform.position);
			}

			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
				Vector3.OrthoNormalize(ref normalDirection, ref twistDirection);
				localTwistAxis = Quaternion.Inverse(transform.rotation) * twistDirection;
			}

			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
				this.planeBone1 = planeBone1;
				this.planeBone2 = planeBone2;
				this.planeBone3 = planeBone3;
				solver.GetChainAndNodeIndexes(planeBone1, out plane1ChainIndex, out plane1NodeIndex);
				solver.GetChainAndNodeIndexes(planeBone2, out plane2ChainIndex, out plane2NodeIndex);
				solver.GetChainAndNodeIndexes(planeBone3, out plane3ChainIndex, out plane3NodeIndex);
				UpdatePlane(rotation: true, position: true);
			}

			public void UpdatePlane(bool rotation, bool position)
			{
				Quaternion rotation2 = lastAnimatedTargetRotation;
				if (rotation)
				{
					defaultLocalTargetRotation = QuaTools.RotationToLocalSpace(transform.rotation, rotation2);
				}
				if (position)
				{
					planePosition = Quaternion.Inverse(rotation2) * (transform.position - planeBone1.position);
				}
			}

			public void SetIKPosition()
			{
				ikPosition = transform.position;
			}

			public void MaintainRotation()
			{
				maintainRotation = transform.rotation;
			}

			public void SetToIKPosition()
			{
				transform.position = ikPosition;
			}

			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null)
			{
				if (fixNode == null)
				{
					fixNode = solver.GetNode(chainIndex, nodeIndex);
				}
				if (weight >= 1f)
				{
					transform.position = fixNode.solverPosition;
				}
				else
				{
					transform.position = Vector3.Lerp(transform.position, fixNode.solverPosition, weight);
				}
			}

			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return solver.GetNode(plane1ChainIndex, plane1NodeIndex).solverPosition + GetTargetRotation(solver) * planePosition;
			}

			public void PositionToPlane(IKSolverFullBody solver)
			{
				transform.position = GetPlanePosition(solver);
			}

			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
				Quaternion quaternion = GetTargetRotation(solver) * defaultLocalTargetRotation;
				if (weight >= 1f)
				{
					transform.rotation = quaternion;
				}
				else
				{
					transform.rotation = Quaternion.Lerp(transform.rotation, quaternion, weight);
				}
			}

			public void Swing(Vector3 swingTarget, float weight)
			{
				Swing(swingTarget, transform.position, weight);
			}

			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
				Quaternion quaternion = Quaternion.FromToRotation(transform.rotation * localSwingAxis, pos1 - pos2) * transform.rotation;
				if (weight >= 1f)
				{
					transform.rotation = quaternion;
				}
				else
				{
					transform.rotation = Quaternion.Lerp(transform.rotation, quaternion, weight);
				}
			}

			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
				Vector3.OrthoNormalize(ref normalDirection, ref twistDirection);
				Quaternion quaternion = Quaternion.FromToRotation(transform.rotation * localTwistAxis, twistDirection) * transform.rotation;
				if (weight >= 1f)
				{
					transform.rotation = quaternion;
				}
				else
				{
					transform.rotation = Quaternion.Lerp(transform.rotation, quaternion, weight);
				}
			}

			public void RotateToMaintain(float weight)
			{
				if (!(weight <= 0f))
				{
					transform.rotation = Quaternion.Lerp(transform.rotation, maintainRotation, weight);
				}
			}

			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
				if (!isNodeBone)
				{
					return;
				}
				float num = weight * solver.GetNode(chainIndex, nodeIndex).effectorRotationWeight;
				if (!(num <= 0f))
				{
					if (num >= 1f)
					{
						transform.rotation = solver.GetNode(chainIndex, nodeIndex).solverRotation;
					}
					else
					{
						transform.rotation = Quaternion.Lerp(transform.rotation, solver.GetNode(chainIndex, nodeIndex).solverRotation, num);
					}
				}
			}

			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				Vector3 solverPosition = solver.GetNode(plane1ChainIndex, plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = solver.GetNode(plane2ChainIndex, plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = solver.GetNode(plane3ChainIndex, plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}
		}

		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return true;
		}

		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null)
		{
			if (bone == null)
			{
				message = "IKMappingLimb contains a null reference.";
				logger?.Invoke(message);
				return false;
			}
			if (solver.GetPoint(bone) == null)
			{
				message = "IKMappingLimb is referencing to a bone '" + bone.name + "' that does not excist in the Node Chain.";
				logger?.Invoke(message);
				return false;
			}
			return true;
		}

		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return pos2 + (pos1 - pos2).normalized * length;
		}
	}
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		public Transform bone;

		[Range(0f, 1f)]
		public float maintainRotationWeight = 1f;

		private BoneMap boneMap = new BoneMap();

		public override bool IsValid(IKSolver solver, ref string message)
		{
			if (!base.IsValid(solver, ref message))
			{
				return false;
			}
			if (bone == null)
			{
				message = "IKMappingBone's bone is null.";
				return false;
			}
			return true;
		}

		public IKMappingBone()
		{
		}

		public IKMappingBone(Transform bone)
		{
			this.bone = bone;
		}

		public void StoreDefaultLocalState()
		{
			boneMap.StoreDefaultLocalState();
		}

		public void FixTransforms()
		{
			boneMap.FixTransform(position: false);
		}

		public override void Initiate(IKSolverFullBody solver)
		{
			if (boneMap == null)
			{
				boneMap = new BoneMap();
			}
			boneMap.Initiate(bone, solver);
		}

		public void ReadPose()
		{
			boneMap.MaintainRotation();
		}

		public void WritePose(float solverWeight)
		{
			boneMap.RotateToMaintain(solverWeight * maintainRotationWeight);
		}
	}
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		public enum BoneMapType
		{
			Parent,
			Bone1,
			Bone2,
			Bone3
		}

		public Transform parentBone;

		public Transform bone1;

		public Transform bone2;

		public Transform bone3;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Range(0f, 1f)]
		public float weight = 1f;

		private BoneMap boneMapParent = new BoneMap();

		private BoneMap boneMap1 = new BoneMap();

		private BoneMap boneMap2 = new BoneMap();

		private BoneMap boneMap3 = new BoneMap();

		public override bool IsValid(IKSolver solver, ref string message)
		{
			if (!base.IsValid(solver, ref message))
			{
				return false;
			}
			if (!BoneIsValid(bone1, solver, ref message))
			{
				return false;
			}
			if (!BoneIsValid(bone2, solver, ref message))
			{
				return false;
			}
			if (!BoneIsValid(bone3, solver, ref message))
			{
				return false;
			}
			return true;
		}

		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			switch (boneMap)
			{
			case BoneMapType.Parent:
				if (parentBone == null)
				{
					Warning.Log("This limb does not have a parent (shoulder) bone", bone1);
				}
				return boneMapParent;
			case BoneMapType.Bone1:
				return boneMap1;
			case BoneMapType.Bone2:
				return boneMap2;
			default:
				return boneMap3;
			}
		}

		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
			boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(bone1.rotation) * Quaternion.LookRotation(bone2.position - bone1.position, bone1.rotation * -upper));
			boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(bone2.rotation) * Quaternion.LookRotation(bone3.position - bone2.position, bone2.rotation * -lower));
		}

		public IKMappingLimb()
		{
		}

		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
			SetBones(bone1, bone2, bone3, parentBone);
		}

		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
			this.bone1 = bone1;
			this.bone2 = bone2;
			this.bone3 = bone3;
			this.parentBone = parentBone;
		}

		public void StoreDefaultLocalState()
		{
			if (parentBone != null)
			{
				boneMapParent.StoreDefaultLocalState();
			}
			boneMap1.StoreDefaultLocalState();
			boneMap2.StoreDefaultLocalState();
			boneMap3.StoreDefaultLocalState();
		}

		public void FixTransforms()
		{
			if (parentBone != null)
			{
				boneMapParent.FixTransform(position: false);
			}
			boneMap1.FixTransform(position: true);
			boneMap2.FixTransform(position: false);
			boneMap3.FixTransform(position: false);
		}

		public override void Initiate(IKSolverFullBody solver)
		{
			if (boneMapParent == null)
			{
				boneMapParent = new BoneMap();
			}
			if (boneMap1 == null)
			{
				boneMap1 = new BoneMap();
			}
			if (boneMap2 == null)
			{
				boneMap2 = new BoneMap();
			}
			if (boneMap3 == null)
			{
				boneMap3 = new BoneMap();
			}
			if (parentBone != null)
			{
				boneMapParent.Initiate(parentBone, solver);
			}
			boneMap1.Initiate(bone1, solver);
			boneMap2.Initiate(bone2, solver);
			boneMap3.Initiate(bone3, solver);
			boneMap1.SetPlane(solver, boneMap1.transform, boneMap2.transform, boneMap3.transform);
			boneMap2.SetPlane(solver, boneMap2.transform, boneMap3.transform, boneMap1.transform);
			if (parentBone != null)
			{
				boneMapParent.SetLocalSwingAxis(boneMap1);
			}
		}

		public void ReadPose()
		{
			boneMap1.UpdatePlane(rotation: true, position: true);
			boneMap2.UpdatePlane(rotation: true, position: false);
			weight = Mathf.Clamp(weight, 0f, 1f);
			boneMap3.MaintainRotation();
		}

		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
			if (weight <= 0f)
			{
				return;
			}
			if (fullBody)
			{
				if (parentBone != null)
				{
					boneMapParent.Swing(solver.GetNode(boneMap1.chainIndex, boneMap1.nodeIndex).solverPosition, weight);
				}
				boneMap1.FixToNode(solver, weight);
			}
			boneMap1.RotateToPlane(solver, weight);
			boneMap2.RotateToPlane(solver, weight);
			boneMap3.RotateToMaintain(maintainRotationWeight * weight * solver.IKPositionWeight);
			boneMap3.RotateToEffector(solver, weight);
		}
	}
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		public Transform[] spineBones;

		public Transform leftUpperArmBone;

		public Transform rightUpperArmBone;

		public Transform leftThighBone;

		public Transform rightThighBone;

		[Range(1f, 3f)]
		public int iterations = 3;

		[Range(0f, 1f)]
		public float twistWeight = 1f;

		private int rootNodeIndex;

		private BoneMap[] spine = new BoneMap[0];

		private BoneMap leftUpperArm = new BoneMap();

		private BoneMap rightUpperArm = new BoneMap();

		private BoneMap leftThigh = new BoneMap();

		private BoneMap rightThigh = new BoneMap();

		private bool useFABRIK;

		public override bool IsValid(IKSolver solver, ref string message)
		{
			if (!base.IsValid(solver, ref message))
			{
				return false;
			}
			Transform[] array = spineBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					message = "Spine bones contains a null reference.";
					return false;
				}
			}
			int num = 0;
			for (int j = 0; j < spineBones.Length; j++)
			{
				if (solver.GetPoint(spineBones[j]) != null)
				{
					num++;
				}
			}
			if (num == 0)
			{
				message = "IKMappingSpine does not contain any nodes.";
				return false;
			}
			if (leftUpperArmBone == null)
			{
				message = "IKMappingSpine is missing the left upper arm bone.";
				return false;
			}
			if (rightUpperArmBone == null)
			{
				message = "IKMappingSpine is missing the right upper arm bone.";
				return false;
			}
			if (leftThighBone == null)
			{
				message = "IKMappingSpine is missing the left thigh bone.";
				return false;
			}
			if (rightThighBone == null)
			{
				message = "IKMappingSpine is missing the right thigh bone.";
				return false;
			}
			if (solver.GetPoint(leftUpperArmBone) == null)
			{
				message = "Full Body IK is missing the left upper arm node.";
				return false;
			}
			if (solver.GetPoint(rightUpperArmBone) == null)
			{
				message = "Full Body IK is missing the right upper arm node.";
				return false;
			}
			if (solver.GetPoint(leftThighBone) == null)
			{
				message = "Full Body IK is missing the left thigh node.";
				return false;
			}
			if (solver.GetPoint(rightThighBone) == null)
			{
				message = "Full Body IK is missing the right thigh node.";
				return false;
			}
			return true;
		}

		public IKMappingSpine()
		{
		}

		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
			SetBones(spineBones, leftUpperArmBone, rightUpperArmBone, leftThighBone, rightThighBone);
		}

		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
			this.spineBones = spineBones;
			this.leftUpperArmBone = leftUpperArmBone;
			this.rightUpperArmBone = rightUpperArmBone;
			this.leftThighBone = leftThighBone;
			this.rightThighBone = rightThighBone;
		}

		public void StoreDefaultLocalState()
		{
			for (int i = 0; i < spine.Length; i++)
			{
				spine[i].StoreDefaultLocalState();
			}
		}

		public void FixTransforms()
		{
			for (int i = 0; i < spine.Length; i++)
			{
				spine[i].FixTransform(i == 0 || i == spine.Length - 1);
			}
		}

		public override void Initiate(IKSolverFullBody solver)
		{
			if (iterations <= 0)
			{
				iterations = 3;
			}
			if (spine == null || spine.Length != spineBones.Length)
			{
				spine = new BoneMap[spineBones.Length];
			}
			rootNodeIndex = -1;
			for (int i = 0; i < spineBones.Length; i++)
			{
				if (spine[i] == null)
				{
					spine[i] = new BoneMap();
				}
				spine[i].Initiate(spineBones[i], solver);
				if (spine[i].isNodeBone)
				{
					rootNodeIndex = i;
				}
			}
			if (leftUpperArm == null)
			{
				leftUpperArm = new BoneMap();
			}
			if (rightUpperArm == null)
			{
				rightUpperArm = new BoneMap();
			}
			if (leftThigh == null)
			{
				leftThigh = new BoneMap();
			}
			if (rightThigh == null)
			{
				rightThigh = new BoneMap();
			}
			leftUpperArm.Initiate(leftUpperArmBone, solver);
			rightUpperArm.Initiate(rightUpperArmBone, solver);
			leftThigh.Initiate(leftThighBone, solver);
			rightThigh.Initiate(rightThighBone, solver);
			for (int j = 0; j < spine.Length; j++)
			{
				spine[j].SetIKPosition();
			}
			spine[0].SetPlane(solver, spine[rootNodeIndex].transform, leftThigh.transform, rightThigh.transform);
			for (int k = 0; k < spine.Length - 1; k++)
			{
				spine[k].SetLength(spine[k + 1]);
				spine[k].SetLocalSwingAxis(spine[k + 1]);
				spine[k].SetLocalTwistAxis(leftUpperArm.transform.position - rightUpperArm.transform.position, spine[k + 1].transform.position - spine[k].transform.position);
			}
			spine[spine.Length - 1].SetPlane(solver, spine[rootNodeIndex].transform, leftUpperArm.transform, rightUpperArm.transform);
			spine[spine.Length - 1].SetLocalSwingAxis(leftUpperArm, rightUpperArm);
			useFABRIK = UseFABRIK();
		}

		private bool UseFABRIK()
		{
			if (spine.Length > 3)
			{
				return true;
			}
			if (rootNodeIndex != 1)
			{
				return true;
			}
			return false;
		}

		public void ReadPose()
		{
			spine[0].UpdatePlane(rotation: true, position: true);
			for (int i = 0; i < spine.Length - 1; i++)
			{
				spine[i].SetLength(spine[i + 1]);
				spine[i].SetLocalSwingAxis(spine[i + 1]);
				spine[i].SetLocalTwistAxis(leftUpperArm.transform.position - rightUpperArm.transform.position, spine[i + 1].transform.position - spine[i].transform.position);
			}
			spine[spine.Length - 1].UpdatePlane(rotation: true, position: true);
			spine[spine.Length - 1].SetLocalSwingAxis(leftUpperArm, rightUpperArm);
		}

		public void WritePose(IKSolverFullBody solver)
		{
			Vector3 planePosition = spine[0].GetPlanePosition(solver);
			Vector3 solverPosition = solver.GetNode(spine[rootNodeIndex].chainIndex, spine[rootNodeIndex].nodeIndex).solverPosition;
			Vector3 planePosition2 = spine[spine.Length - 1].GetPlanePosition(solver);
			if (useFABRIK)
			{
				Vector3 vector = solver.GetNode(spine[rootNodeIndex].chainIndex, spine[rootNodeIndex].nodeIndex).solverPosition - spine[rootNodeIndex].transform.position;
				for (int i = 0; i < spine.Length; i++)
				{
					spine[i].ikPosition = spine[i].transform.position + vector;
				}
				for (int j = 0; j < iterations; j++)
				{
					ForwardReach(planePosition2);
					BackwardReach(planePosition);
					spine[rootNodeIndex].ikPosition = solverPosition;
				}
			}
			else
			{
				spine[0].ikPosition = planePosition;
				spine[rootNodeIndex].ikPosition = solverPosition;
			}
			spine[spine.Length - 1].ikPosition = planePosition2;
			MapToSolverPositions(solver);
		}

		public void ForwardReach(Vector3 position)
		{
			spine[spineBones.Length - 1].ikPosition = position;
			for (int num = spine.Length - 2; num > -1; num--)
			{
				spine[num].ikPosition = SolveFABRIKJoint(spine[num].ikPosition, spine[num + 1].ikPosition, spine[num].length);
			}
		}

		private void BackwardReach(Vector3 position)
		{
			spine[0].ikPosition = position;
			for (int i = 1; i < spine.Length; i++)
			{
				spine[i].ikPosition = SolveFABRIKJoint(spine[i].ikPosition, spine[i - 1].ikPosition, spine[i - 1].length);
			}
		}

		private void MapToSolverPositions(IKSolverFullBody solver)
		{
			spine[0].SetToIKPosition();
			spine[0].RotateToPlane(solver, 1f);
			for (int i = 1; i < spine.Length - 1; i++)
			{
				spine[i].Swing(spine[i + 1].ikPosition, 1f);
				if (twistWeight > 0f)
				{
					float num = (float)i / ((float)spine.Length - 2f);
					Vector3 solverPosition = solver.GetNode(leftUpperArm.chainIndex, leftUpperArm.nodeIndex).solverPosition;
					Vector3 solverPosition2 = solver.GetNode(rightUpperArm.chainIndex, rightUpperArm.nodeIndex).solverPosition;
					spine[i].Twist(solverPosition - solverPosition2, spine[i + 1].ikPosition - spine[i].transform.position, num * twistWeight);
				}
			}
			spine[spine.Length - 1].SetToIKPosition();
			spine[spine.Length - 1].RotateToPlane(solver, 1f);
		}
	}
	[Serializable]
	public abstract class IKSolver
	{
		[Serializable]
		public class Point
		{
			public Transform transform;

			[Range(0f, 1f)]
			public float weight = 1f;

			public Vector3 solverPosition;

			public Quaternion solverRotation = Quaternion.identity;

			public Vector3 defaultLocalPosition;

			public Quaternion defaultLocalRotation;

			public void StoreDefaultLocalState()
			{
				defaultLocalPosition = transform.localPosition;
				defaultLocalRotation = transform.localRotation;
			}

			public void FixTransform()
			{
				if (transform.localPosition != defaultLocalPosition)
				{
					transform.localPosition = defaultLocalPosition;
				}
				if (transform.localRotation != defaultLocalRotation)
				{
					transform.localRotation = defaultLocalRotation;
				}
			}

			public void UpdateSolverPosition()
			{
				solverPosition = transform.position;
			}

			public void UpdateSolverLocalPosition()
			{
				solverPosition = transform.localPosition;
			}

			public void UpdateSolverState()
			{
				solverPosition = transform.position;
				solverRotation = transform.rotation;
			}

			public void UpdateSolverLocalState()
			{
				solverPosition = transform.localPosition;
				solverRotation = transform.localRotation;
			}
		}

		[Serializable]
		public class Bone : Point
		{
			public float length;

			public float sqrMag;

			public Vector3 axis = -Vector3.right;

			private RotationLimit _rotationLimit;

			private bool isLimited = true;

			public RotationLimit rotationLimit
			{
				get
				{
					if (!isLimited)
					{
						return null;
					}
					if (_rotationLimit == null)
					{
						_rotationLimit = transform.GetComponent<RotationLimit>();
					}
					isLimited = _rotationLimit != null;
					return _rotationLimit;
				}
				set
				{
					_rotationLimit = value;
					isLimited = value != null;
				}
			}

			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
				if (!(weight <= 0f))
				{
					Quaternion quaternion = Quaternion.FromToRotation(transform.rotation * axis, swingTarget - transform.position);
					if (weight >= 1f)
					{
						transform.rotation = quaternion * transform.rotation;
					}
					else
					{
						transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * transform.rotation;
					}
				}
			}

			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
				if (weight <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(bones[index].solverRotation * bones[index].axis, swingTarget - bones[index].solverPosition);
				if (weight >= 1f)
				{
					for (int i = index; i < bones.Length; i++)
					{
						bones[i].solverRotation = quaternion * bones[i].solverRotation;
					}
				}
				else
				{
					for (int j = index; j < bones.Length; j++)
					{
						bones[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * bones[j].solverRotation;
					}
				}
			}

			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
				if (!(weight <= 0f))
				{
					Vector3 vector = transform.rotation * axis;
					Vector3 vector2 = swingTarget - transform.position;
					float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
					float target = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
					transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * weight, Vector3.back) * transform.rotation;
				}
			}

			public void SetToSolverPosition()
			{
				transform.position = solverPosition;
			}

			public Bone()
			{
			}

			public Bone(Transform transform)
			{
				base.transform = transform;
			}

			public Bone(Transform transform, float weight)
			{
				base.transform = transform;
				base.weight = weight;
			}
		}

		[Serializable]
		public class Node : Point
		{
			public float length;

			public float effectorPositionWeight;

			public float effectorRotationWeight;

			public Vector3 offset;

			public Node()
			{
			}

			public Node(Transform transform)
			{
				base.transform = transform;
			}

			public Node(Transform transform, float weight)
			{
				base.transform = transform;
				base.weight = weight;
			}
		}

		public delegate void UpdateDelegate();

		public delegate void IterationDelegate(int i);

		[HideInInspector]
		public Vector3 IKPosition;

		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight = 1f;

		public UpdateDelegate OnPreInitiate;

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnPreUpdate;

		public UpdateDelegate OnPostUpdate;

		protected bool firstInitiation = true;

		[SerializeField]
		[HideInInspector]
		protected Transform root;

		public bool initiated { get; private set; }

		public bool IsValid()
		{
			string message = string.Empty;
			return IsValid(ref message);
		}

		public abstract bool IsValid(ref string message);

		public void Initiate(Transform root)
		{
			if (OnPreInitiate != null)
			{
				OnPreInitiate();
			}
			if (root == null)
			{
				UnityEngine.Debug.LogError("Initiating IKSolver with null root Transform.");
			}
			this.root = root;
			initiated = false;
			string message = string.Empty;
			if (!IsValid(ref message))
			{
				Warning.Log(message, root);
				return;
			}
			OnInitiate();
			StoreDefaultLocalState();
			initiated = true;
			firstInitiation = false;
			if (OnPostInitiate != null)
			{
				OnPostInitiate();
			}
		}

		public void Update()
		{
			if (OnPreUpdate != null)
			{
				OnPreUpdate();
			}
			if (firstInitiation)
			{
				Initiate(root);
			}
			if (initiated)
			{
				OnUpdate();
				if (OnPostUpdate != null)
				{
					OnPostUpdate();
				}
			}
		}

		public virtual Vector3 GetIKPosition()
		{
			return IKPosition;
		}

		public void SetIKPosition(Vector3 position)
		{
			IKPosition = position;
		}

		public float GetIKPositionWeight()
		{
			return IKPositionWeight;
		}

		public void SetIKPositionWeight(float weight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		public Transform GetRoot()
		{
			return root;
		}

		public abstract Point[] GetPoints();

		public abstract Point GetPoint(Transform transform);

		public abstract void FixTransforms();

		public abstract void StoreDefaultLocalState();

		protected abstract void OnInitiate();

		protected abstract void OnUpdate();

		protected void LogWarning(string message)
		{
			Warning.Log(message, root, logInEditMode: true);
		}

		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			for (int i = 0; i < bones.Length; i++)
			{
				for (int j = 0; j < bones.Length; j++)
				{
					if (i != j && bones[i].transform == bones[j].transform)
					{
						return bones[i].transform;
					}
				}
			}
			return null;
		}

		public static bool HierarchyIsValid(Bone[] bones)
		{
			for (int i = 1; i < bones.Length; i++)
			{
				if (!Hierarchy.IsAncestor(bones[i].transform, bones[i - 1].transform))
				{
					return false;
				}
			}
			return true;
		}

		protected static float PreSolveBones(ref Bone[] bones)
		{
			float num = 0f;
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].solverPosition = bones[i].transform.position;
				bones[i].solverRotation = bones[i].transform.rotation;
			}
			for (int j = 0; j < bones.Length; j++)
			{
				if (j < bones.Length - 1)
				{
					bones[j].sqrMag = (bones[j + 1].solverPosition - bones[j].solverPosition).sqrMagnitude;
					bones[j].length = Mathf.Sqrt(bones[j].sqrMag);
					num += bones[j].length;
					bones[j].axis = Quaternion.Inverse(bones[j].solverRotation) * (bones[j + 1].solverPosition - bones[j].solverPosition);
				}
				else
				{
					bones[j].sqrMag = 0f;
					bones[j].length = 0f;
				}
			}
			return num;
		}
	}
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		public Transform transform;

		public Vector3 axis = Vector3.forward;

		public Vector3 poleAxis = Vector3.up;

		public Vector3 polePosition;

		[Range(0f, 1f)]
		public float poleWeight;

		public Transform poleTarget;

		[Range(0f, 1f)]
		public float clampWeight = 0.1f;

		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		public IterationDelegate OnPreIteration;

		private float step;

		private Vector3 clampedIKPosition;

		private RotationLimit transformLimit;

		private Transform lastTransform;

		public Vector3 transformAxis => transform.rotation * axis;

		public Vector3 transformPoleAxis => transform.rotation * poleAxis;

		protected override int minBones => 1;

		protected override Vector3 localDirection => bones[0].transform.InverseTransformDirection(bones[bones.Length - 1].transform.forward);

		public float GetAngle()
		{
			return Vector3.Angle(transformAxis, IKPosition - transform.position);
		}

		protected override void OnInitiate()
		{
			if ((firstInitiation || !Application.isPlaying) && transform != null)
			{
				IKPosition = transform.position + transformAxis * 3f;
				polePosition = transform.position + transformPoleAxis * 3f;
			}
			for (int i = 0; i < bones.Length; i++)
			{
				if (bones[i].rotationLimit != null)
				{
					bones[i].rotationLimit.Disable();
				}
			}
			step = 1f / (float)bones.Length;
			if (Application.isPlaying)
			{
				axis = axis.normalized;
			}
		}

		protected override void OnUpdate()
		{
			if (axis == Vector3.zero)
			{
				if (!Warning.logged)
				{
					LogWarning("IKSolverAim axis is Vector3.zero.");
				}
				return;
			}
			if (poleAxis == Vector3.zero && poleWeight > 0f)
			{
				if (!Warning.logged)
				{
					LogWarning("IKSolverAim poleAxis is Vector3.zero.");
				}
				return;
			}
			if (target != null)
			{
				IKPosition = target.position;
			}
			if (poleTarget != null)
			{
				polePosition = poleTarget.position;
			}
			if (XY)
			{
				IKPosition.z = bones[0].transform.position.z;
			}
			if (IKPositionWeight <= 0f)
			{
				return;
			}
			IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
			if (transform != lastTransform)
			{
				transformLimit = transform.GetComponent<RotationLimit>();
				if (transformLimit != null)
				{
					transformLimit.enabled = false;
				}
				lastTransform = transform;
			}
			if (transformLimit != null)
			{
				transformLimit.Apply();
			}
			if (transform == null)
			{
				if (!Warning.logged)
				{
					LogWarning("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
				}
				return;
			}
			clampWeight = Mathf.Clamp(clampWeight, 0f, 1f);
			clampedIKPosition = GetClampedIKPosition();
			Vector3 b = clampedIKPosition - transform.position;
			b = Vector3.Slerp(transformAxis * b.magnitude, b, IKPositionWeight);
			clampedIKPosition = transform.position + b;
			for (int i = 0; i < maxIterations && (i < 1 || !(tolerance > 0f) || !(GetAngle() < tolerance)); i++)
			{
				lastLocalDirection = localDirection;
				if (OnPreIteration != null)
				{
					OnPreIteration(i);
				}
				Solve();
			}
			lastLocalDirection = localDirection;
		}

		private void Solve()
		{
			for (int i = 0; i < bones.Length - 1; i++)
			{
				RotateToTarget(clampedIKPosition, bones[i], step * (float)(i + 1) * IKPositionWeight * bones[i].weight);
			}
			RotateToTarget(clampedIKPosition, bones[bones.Length - 1], IKPositionWeight * bones[bones.Length - 1].weight);
		}

		private Vector3 GetClampedIKPosition()
		{
			if (clampWeight <= 0f)
			{
				return IKPosition;
			}
			if (clampWeight >= 1f)
			{
				return transform.position + transformAxis * (IKPosition - transform.position).magnitude;
			}
			float num = Vector3.Angle(transformAxis, IKPosition - transform.position);
			float num2 = 1f - num / 180f;
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return transform.position + Vector3.Slerp(transformAxis * 10f, IKPosition - transform.position, num4 * num3);
		}

		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
			if (XY)
			{
				if (weight >= 0f)
				{
					Vector3 vector = transformAxis;
					Vector3 vector2 = targetPosition - transform.position;
					float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
					float num = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
					bone.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, num), Vector3.back) * bone.transform.rotation;
				}
			}
			else
			{
				if (weight >= 0f)
				{
					Quaternion quaternion = Quaternion.FromToRotation(transformAxis, targetPosition - transform.position);
					if (weight >= 1f)
					{
						bone.transform.rotation = quaternion * bone.transform.rotation;
					}
					else
					{
						bone.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * bone.transform.rotation;
					}
				}
				if (poleWeight > 0f)
				{
					Vector3 tangent = polePosition - transform.position;
					Vector3 normal = transformAxis;
					Vector3.OrthoNormalize(ref normal, ref tangent);
					Quaternion b = Quaternion.FromToRotation(transformPoleAxis, tangent);
					bone.transform.rotation = Quaternion.Lerp(Quaternion.identity, b, weight * poleWeight) * bone.transform.rotation;
				}
			}
			if (useRotationLimits && bone.rotationLimit != null)
			{
				bone.rotationLimit.Apply();
			}
		}
	}
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		public Quaternion IKRotation = Quaternion.identity;

		public Point chest = new Point();

		public Point shoulder = new Point();

		public Point upperArm = new Point();

		public Point forearm = new Point();

		public Point hand = new Point();

		public bool isLeft;

		public IKSolverVR.Arm arm = new IKSolverVR.Arm();

		private Vector3[] positions = new Vector3[6];

		private Quaternion[] rotations = new Quaternion[6];

		public override bool IsValid(ref string message)
		{
			if (chest.transform == null || shoulder.transform == null || upperArm.transform == null || forearm.transform == null || hand.transform == null)
			{
				message = "Please assign all bone slots of the Arm IK solver.";
				return false;
			}
			UnityEngine.Object[] objects = new Transform[5] { chest.transform, shoulder.transform, upperArm.transform, forearm.transform, hand.transform };
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the ArmIK.";
				return false;
			}
			return true;
		}

		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			this.chest.transform = chest;
			this.shoulder.transform = shoulder;
			this.upperArm.transform = upperArm;
			this.forearm.transform = forearm;
			this.hand.transform = hand;
			Initiate(root);
			return base.initiated;
		}

		public override Point[] GetPoints()
		{
			return new Point[5] { chest, shoulder, upperArm, forearm, hand };
		}

		public override Point GetPoint(Transform transform)
		{
			if (chest.transform == transform)
			{
				return chest;
			}
			if (shoulder.transform == transform)
			{
				return shoulder;
			}
			if (upperArm.transform == transform)
			{
				return upperArm;
			}
			if (forearm.transform == transform)
			{
				return forearm;
			}
			if (hand.transform == transform)
			{
				return hand;
			}
			return null;
		}

		public override void StoreDefaultLocalState()
		{
			shoulder.StoreDefaultLocalState();
			upperArm.StoreDefaultLocalState();
			forearm.StoreDefaultLocalState();
			hand.StoreDefaultLocalState();
		}

		public override void FixTransforms()
		{
			if (base.initiated)
			{
				shoulder.FixTransform();
				upperArm.FixTransform();
				forearm.FixTransform();
				hand.FixTransform();
			}
		}

		protected override void OnInitiate()
		{
			IKPosition = hand.transform.position;
			IKRotation = hand.transform.rotation;
			Read();
		}

		protected override void OnUpdate()
		{
			Read();
			Solve();
			Write();
		}

		private void Solve()
		{
			arm.PreSolve();
			arm.ApplyOffsets();
			arm.Solve(isLeft);
			arm.ResetOffsets();
		}

		private void Read()
		{
			arm.IKPosition = IKPosition;
			arm.positionWeight = IKPositionWeight;
			arm.IKRotation = IKRotation;
			arm.rotationWeight = IKRotationWeight;
			positions[0] = root.position;
			positions[1] = chest.transform.position;
			positions[2] = shoulder.transform.position;
			positions[3] = upperArm.transform.position;
			positions[4] = forearm.transform.position;
			positions[5] = hand.transform.position;
			rotations[0] = root.rotation;
			rotations[1] = chest.transform.rotation;
			rotations[2] = shoulder.transform.rotation;
			rotations[3] = upperArm.transform.rotation;
			rotations[4] = forearm.transform.rotation;
			rotations[5] = hand.transform.rotation;
			arm.Read(positions, rotations, hasChest: false, hasNeck: false, hasShoulders: true, hasToes: false, hasLegs: false, 1, 2);
		}

		private void Write()
		{
			arm.Write(ref positions, ref rotations);
			shoulder.transform.rotation = rotations[2];
			upperArm.transform.rotation = rotations[3];
			forearm.transform.rotation = rotations[4];
			hand.transform.rotation = rotations[5];
			forearm.transform.position = positions[4];
			hand.transform.position = positions[5];
		}
	}
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		public IterationDelegate OnPreIteration;

		public void FadeOutBoneWeights()
		{
			if (bones.Length >= 2)
			{
				bones[0].weight = 1f;
				float num = 1f / (float)(bones.Length - 1);
				for (int i = 1; i < bones.Length; i++)
				{
					bones[i].weight = num * (float)(bones.Length - 1 - i);
				}
			}
		}

		protected override void OnInitiate()
		{
			if (firstInitiation || !Application.isPlaying)
			{
				IKPosition = bones[bones.Length - 1].transform.position;
			}
			InitiateBones();
		}

		protected override void OnUpdate()
		{
			if (IKPositionWeight <= 0f)
			{
				return;
			}
			IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
			if (target != null)
			{
				IKPosition = target.position;
			}
			if (XY)
			{
				IKPosition.z = bones[0].transform.position.z;
			}
			Vector3 vector = ((maxIterations > 1) ? GetSingularityOffset() : Vector3.zero);
			for (int i = 0; i < maxIterations && (!(vector == Vector3.zero) || i < 1 || !(tolerance > 0f) || !(base.positionOffset < tolerance * tolerance)); i++)
			{
				lastLocalDirection = localDirection;
				if (OnPreIteration != null)
				{
					OnPreIteration(i);
				}
				Solve(IKPosition + ((i == 0) ? vector : Vector3.zero));
			}
			lastLocalDirection = localDirection;
		}

		private void Solve(Vector3 targetPosition)
		{
			if (XY)
			{
				for (int num = bones.Length - 2; num > -1; num--)
				{
					float num2 = bones[num].weight * IKPositionWeight;
					if (num2 > 0f)
					{
						Vector3 vector = bones[bones.Length - 1].transform.position - bones[num].transform.position;
						Vector3 vector2 = targetPosition - bones[num].transform.position;
						float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
						float num3 = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
						bones[num].transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, num3) * num2, Vector3.back) * bones[num].transform.rotation;
					}
					if (useRotationLimits && bones[num].rotationLimit != null)
					{
						bones[num].rotationLimit.Apply();
					}
				}
				return;
			}
			for (int num4 = bones.Length - 2; num4 > -1; num4--)
			{
				float num5 = bones[num4].weight * IKPositionWeight;
				if (num5 > 0f)
				{
					Vector3 fromDirection = bones[bones.Length - 1].transform.position - bones[num4].transform.position;
					Vector3 toDirection = targetPosition - bones[num4].transform.position;
					Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * bones[num4].transform.rotation;
					if (num5 >= 1f)
					{
						bones[num4].transform.rotation = quaternion;
					}
					else
					{
						bones[num4].transform.rotation = Quaternion.Lerp(bones[num4].transform.rotation, quaternion, num5);
					}
				}
				if (useRotationLimits && bones[num4].rotationLimit != null)
				{
					bones[num4].rotationLimit.Apply();
				}
			}
		}
	}
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		public IterationDelegate OnPreIteration;

		private bool[] limitedBones = new bool[0];

		private Vector3[] solverLocalPositions = new Vector3[0];

		protected override bool boneLengthCanBeZero => false;

		public void SolveForward(Vector3 position)
		{
			if (!base.initiated)
			{
				if (!Warning.logged)
				{
					LogWarning("Trying to solve uninitiated FABRIK chain.");
				}
			}
			else
			{
				OnPreSolve();
				ForwardReach(position);
			}
		}

		public void SolveBackward(Vector3 position)
		{
			if (!base.initiated)
			{
				if (!Warning.logged)
				{
					LogWarning("Trying to solve uninitiated FABRIK chain.");
				}
			}
			else
			{
				BackwardReach(position);
				OnPostSolve();
			}
		}

		public override Vector3 GetIKPosition()
		{
			if (target != null)
			{
				return target.position;
			}
			return IKPosition;
		}

		protected override void OnInitiate()
		{
			if (firstInitiation || !Application.isPlaying)
			{
				IKPosition = bones[bones.Length - 1].transform.position;
			}
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].solverPosition = bones[i].transform.position;
				bones[i].solverRotation = bones[i].transform.rotation;
			}
			limitedBones = new bool[bones.Length];
			solverLocalPositions = new Vector3[bones.Length];
			InitiateBones();
			for (int j = 0; j < bones.Length; j++)
			{
				solverLocalPositions[j] = Quaternion.Inverse(GetParentSolverRotation(j)) * (bones[j].transform.position - GetParentSolverPosition(j));
			}
		}

		protected override void OnUpdate()
		{
			if (IKPositionWeight <= 0f)
			{
				return;
			}
			IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
			OnPreSolve();
			if (target != null)
			{
				IKPosition = target.position;
			}
			if (XY)
			{
				IKPosition.z = bones[0].transform.position.z;
			}
			Vector3 vector = ((maxIterations > 1) ? GetSingularityOffset() : Vector3.zero);
			for (int i = 0; i < maxIterations && (!(vector == Vector3.zero) || i < 1 || !(tolerance > 0f) || !(base.positionOffset < tolerance * tolerance)); i++)
			{
				lastLocalDirection = localDirection;
				if (OnPreIteration != null)
				{
					OnPreIteration(i);
				}
				Solve(IKPosition + ((i == 0) ? vector : Vector3.zero));
			}
			OnPostSolve();
		}

		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			if (XY)
			{
				pos1.z = pos2.z;
			}
			return pos2 + (pos1 - pos2).normalized * length;
		}

		private void OnPreSolve()
		{
			chainLength = 0f;
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].solverPosition = bones[i].transform.position;
				bones[i].solverRotation = bones[i].transform.rotation;
				if (i < bones.Length - 1)
				{
					bones[i].length = (bones[i].transform.position - bones[i + 1].transform.position).magnitude;
					bones[i].axis = Quaternion.Inverse(bones[i].transform.rotation) * (bones[i + 1].transform.position - bones[i].transform.position);
					chainLength += bones[i].length;
				}
				if (useRotationLimits)
				{
					solverLocalPositions[i] = Quaternion.Inverse(GetParentSolverRotation(i)) * (bones[i].transform.position - GetParentSolverPosition(i));
				}
			}
		}

		private void OnPostSolve()
		{
			if (!useRotationLimits)
			{
				MapToSolverPositions();
			}
			else
			{
				MapToSolverPositionsLimited();
			}
			lastLocalDirection = localDirection;
		}

		private void Solve(Vector3 targetPosition)
		{
			ForwardReach(targetPosition);
			BackwardReach(bones[0].transform.position);
		}

		private void ForwardReach(Vector3 position)
		{
			bones[bones.Length - 1].solverPosition = Vector3.Lerp(bones[bones.Length - 1].solverPosition, position, IKPositionWeight);
			for (int i = 0; i < limitedBones.Length; i++)
			{
				limitedBones[i] = false;
			}
			for (int num = bones.Length - 2; num > -1; num--)
			{
				bones[num].solverPosition = SolveJoint(bones[num].solverPosition, bones[num + 1].solverPosition, bones[num].length);
				LimitForward(num, num + 1);
			}
			LimitForward(0, 0);
		}

		private void SolverMove(int index, Vector3 offset)
		{
			for (int i = index; i < bones.Length; i++)
			{
				bones[i].solverPosition += offset;
			}
		}

		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
			for (int i = index; i < bones.Length; i++)
			{
				bones[i].solverRotation = rotation * bones[i].solverRotation;
				if (!recursive)
				{
					break;
				}
			}
		}

		private void SolverRotateChildren(int index, Quaternion rotation)
		{
			for (int i = index + 1; i < bones.Length; i++)
			{
				bones[i].solverRotation = rotation * bones[i].solverRotation;
			}
		}

		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
			for (int i = index + 1; i < bones.Length; i++)
			{
				Vector3 vector = bones[i].solverPosition - bones[index].solverPosition;
				bones[i].solverPosition = bones[index].solverPosition + rotation * vector;
			}
		}

		private Quaternion GetParentSolverRotation(int index)
		{
			if (index > 0)
			{
				return bones[index - 1].solverRotation;
			}
			if (bones[0].transform.parent == null)
			{
				return Quaternion.identity;
			}
			return bones[0].transform.parent.rotation;
		}

		private Vector3 GetParentSolverPosition(int index)
		{
			if (index > 0)
			{
				return bones[index - 1].solverPosition;
			}
			if (bones[0].transform.parent == null)
			{
				return Vector3.zero;
			}
			return bones[0].transform.parent.position;
		}

		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			changed = false;
			Quaternion parentSolverRotation = GetParentSolverRotation(index);
			Quaternion localRotation = Quaternion.Inverse(parentSolverRotation) * q;
			Quaternion limitedLocalRotation = bones[index].rotationLimit.GetLimitedLocalRotation(localRotation, out changed);
			if (!changed)
			{
				return q;
			}
			return parentSolverRotation * limitedLocalRotation;
		}

		private void LimitForward(int rotateBone, int limitBone)
		{
			if (!useRotationLimits || bones[limitBone].rotationLimit == null)
			{
				return;
			}
			Vector3 solverPosition = bones[bones.Length - 1].solverPosition;
			for (int i = rotateBone; i < bones.Length - 1 && !limitedBones[i]; i++)
			{
				Quaternion rotation = Quaternion.FromToRotation(bones[i].solverRotation * bones[i].axis, bones[i + 1].solverPosition - bones[i].solverPosition);
				SolverRotate(i, rotation, recursive: false);
			}
			bool changed = false;
			Quaternion limitedRotation = GetLimitedRotation(limitBone, bones[limitBone].solverRotation, out changed);
			if (changed)
			{
				if (limitBone < bones.Length - 1)
				{
					Quaternion rotation2 = QuaTools.FromToRotation(bones[limitBone].solverRotation, limitedRotation);
					bones[limitBone].solverRotation = limitedRotation;
					SolverRotateChildren(limitBone, rotation2);
					SolverMoveChildrenAroundPoint(limitBone, rotation2);
					Quaternion rotation3 = Quaternion.FromToRotation(bones[bones.Length - 1].solverPosition - bones[rotateBone].solverPosition, solverPosition - bones[rotateBone].solverPosition);
					SolverRotate(rotateBone, rotation3, recursive: true);
					SolverMoveChildrenAroundPoint(rotateBone, rotation3);
					SolverMove(rotateBone, solverPosition - bones[bones.Length - 1].solverPosition);
				}
				else
				{
					bones[limitBone].solverRotation = limitedRotation;
				}
			}
			limitedBones[limitBone] = true;
		}

		private void BackwardReach(Vector3 position)
		{
			if (useRotationLimits)
			{
				BackwardReachLimited(position);
			}
			else
			{
				BackwardReachUnlimited(position);
			}
		}

		private void BackwardReachUnlimited(Vector3 position)
		{
			bones[0].solverPosition = position;
			for (int i = 1; i < bones.Length; i++)
			{
				bones[i].solverPosition = SolveJoint(bones[i].solverPosition, bones[i - 1].solverPosition, bones[i - 1].length);
			}
		}

		private void BackwardReachLimited(Vector3 position)
		{
			bones[0].solverPosition = position;
			for (int i = 0; i < bones.Length - 1; i++)
			{
				Vector3 vector = SolveJoint(bones[i + 1].solverPosition, bones[i].solverPosition, bones[i].length);
				Quaternion quaternion = Quaternion.FromToRotation(bones[i].solverRotation * bones[i].axis, vector - bones[i].solverPosition) * bones[i].solverRotation;
				if (bones[i].rotationLimit != null)
				{
					bool changed = false;
					quaternion = GetLimitedRotation(i, quaternion, out changed);
				}
				Quaternion rotation = QuaTools.FromToRotation(bones[i].solverRotation, quaternion);
				bones[i].solverRotation = quaternion;
				SolverRotateChildren(i, rotation);
				bones[i + 1].solverPosition = bones[i].solverPosition + bones[i].solverRotation * solverLocalPositions[i + 1];
			}
			for (int j = 0; j < bones.Length; j++)
			{
				bones[j].solverRotation = Quaternion.LookRotation(bones[j].solverRotation * Vector3.forward, bones[j].solverRotation * Vector3.up);
			}
		}

		private void MapToSolverPositions()
		{
			bones[0].transform.position = bones[0].solverPosition;
			for (int i = 0; i < bones.Length - 1; i++)
			{
				if (XY)
				{
					bones[i].Swing2D(bones[i + 1].solverPosition);
				}
				else
				{
					bones[i].Swing(bones[i + 1].solverPosition);
				}
			}
		}

		private void MapToSolverPositionsLimited()
		{
			bones[0].transform.position = bones[0].solverPosition;
			for (int i = 0; i < bones.Length; i++)
			{
				if (i < bones.Length - 1)
				{
					bones[i].transform.rotation = bones[i].solverRotation;
				}
			}
		}
	}
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		public int iterations = 4;

		[Range(0f, 1f)]
		public float rootPin;

		public FABRIKChain[] chains = new FABRIKChain[0];

		private bool zeroWeightApplied;

		private bool[] isRoot;

		private Vector3 rootDefaultPosition;

		public override bool IsValid(ref string message)
		{
			if (chains.Length == 0)
			{
				message = "IKSolverFABRIKRoot contains no chains.";
				return false;
			}
			FABRIKChain[] array = chains;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].IsValid(ref message))
				{
					return false;
				}
			}
			for (int j = 0; j < chains.Length; j++)
			{
				for (int k = 0; k < chains.Length; k++)
				{
					if (j != k && chains[j].ik == chains[k].ik)
					{
						message = chains[j].ik.name + " is represented more than once in IKSolverFABRIKRoot chain.";
						return false;
					}
				}
			}
			for (int l = 0; l < chains.Length; l++)
			{
				for (int m = 0; m < chains[l].children.Length; m++)
				{
					int num = chains[l].children[m];
					if (num < 0)
					{
						message = chains[l].ik.name + "IKSolverFABRIKRoot chain at index " + l + " has invalid children array. Child index is < 0.";
						return false;
					}
					if (num == l)
					{
						message = chains[l].ik.name + "IKSolverFABRIKRoot chain at index " + l + " has invalid children array. Child index is referencing to itself.";
						return false;
					}
					if (num >= chains.Length)
					{
						message = chains[l].ik.name + "IKSolverFABRIKRoot chain at index " + l + " has invalid children array. Child index > number of chains";
						return false;
					}
					for (int n = 0; n < chains.Length; n++)
					{
						if (num != n)
						{
							continue;
						}
						for (int num2 = 0; num2 < chains[n].children.Length; num2++)
						{
							if (chains[n].children[num2] == l)
							{
								message = "Circular parenting. " + chains[n].ik.name + " already has " + chains[l].ik.name + " listed as it's child.";
								return false;
							}
						}
					}
					for (int num3 = 0; num3 < chains[l].children.Length; num3++)
					{
						if (m != num3 && chains[l].children[num3] == num)
						{
							message = "Chain number " + num + " is represented more than once in the children of " + chains[l].ik.name;
							return false;
						}
					}
				}
			}
			return true;
		}

		public override void StoreDefaultLocalState()
		{
			rootDefaultPosition = root.localPosition;
			for (int i = 0; i < chains.Length; i++)
			{
				chains[i].ik.solver.StoreDefaultLocalState();
			}
		}

		public override void FixTransforms()
		{
			if (base.initiated)
			{
				root.localPosition = rootDefaultPosition;
				for (int i = 0; i < chains.Length; i++)
				{
					chains[i].ik.solver.FixTransforms();
				}
			}
		}

		protected override void OnInitiate()
		{
			for (int i = 0; i < chains.Length; i++)
			{
				chains[i].Initiate();
			}
			isRoot = new bool[chains.Length];
			for (int j = 0; j < chains.Length; j++)
			{
				isRoot[j] = IsRoot(j);
			}
		}

		private bool IsRoot(int index)
		{
			for (int i = 0; i < chains.Length; i++)
			{
				for (int j = 0; j < chains[i].children.Length; j++)
				{
					if (chains[i].children[j] == index)
					{
						return false;
					}
				}
			}
			return true;
		}

		protected override void OnUpdate()
		{
			if (IKPositionWeight <= 0f && zeroWeightApplied)
			{
				return;
			}
			IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
			for (int i = 0; i < chains.Length; i++)
			{
				chains[i].ik.solver.IKPositionWeight = IKPositionWeight;
			}
			if (IKPositionWeight <= 0f)
			{
				zeroWeightApplied = true;
				return;
			}
			zeroWeightApplied = false;
			for (int j = 0; j < iterations; j++)
			{
				for (int k = 0; k < chains.Length; k++)
				{
					if (isRoot[k])
					{
						chains[k].Stage1(chains);
					}
				}
				Vector3 centroid = GetCentroid();
				root.position = centroid;
				for (int l = 0; l < chains.Length; l++)
				{
					if (isRoot[l])
					{
						chains[l].Stage2(centroid, chains);
					}
				}
			}
		}

		public override Point[] GetPoints()
		{
			Point[] array = new Point[0];
			for (int i = 0; i < chains.Length; i++)
			{
				AddPointsToArray(ref array, chains[i]);
			}
			return array;
		}

		public override Point GetPoint(Transform transform)
		{
			Point point = null;
			for (int i = 0; i < chains.Length; i++)
			{
				point = chains[i].ik.solver.GetPoint(transform);
				if (point != null)
				{
					return point;
				}
			}
			return null;
		}

		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
			Point[] points = chain.ik.solver.GetPoints();
			Array.Resize(ref array, array.Length + points.Length);
			int num = 0;
			for (int i = array.Length - points.Length; i < array.Length; i++)
			{
				array[i] = points[num];
				num++;
			}
		}

		private Vector3 GetCentroid()
		{
			Vector3 position = root.position;
			if (rootPin >= 1f)
			{
				return position;
			}
			float num = 0f;
			for (int i = 0; i < chains.Length; i++)
			{
				if (isRoot[i])
				{
					num += chains[i].pull;
				}
			}
			for (int j = 0; j < chains.Length; j++)
			{
				if (isRoot[j] && num > 0f)
				{
					position += (chains[j].ik.solver.bones[0].solverPosition - root.position) * (chains[j].pull / Mathf.Clamp(num, 1f, num));
				}
			}
			return Vector3.Lerp(position, root.position, rootPin);
		}
	}
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		[Range(0f, 10f)]
		public int iterations = 4;

		public FBIKChain[] chain = new FBIKChain[0];

		public IKEffector[] effectors = new IKEffector[0];

		public IKMappingSpine spineMapping = new IKMappingSpine();

		public IKMappingBone[] boneMappings = new IKMappingBone[0];

		public IKMappingLimb[] limbMappings = new IKMappingLimb[0];

		public bool FABRIKPass = true;

		public UpdateDelegate OnPreRead;

		public UpdateDelegate OnPreSolve;

		public IterationDelegate OnPreIteration;

		public IterationDelegate OnPostIteration;

		public UpdateDelegate OnPreBend;

		public UpdateDelegate OnPostSolve;

		public UpdateDelegate OnStoreDefaultLocalState;

		public UpdateDelegate OnFixTransforms;

		public IKEffector GetEffector(Transform t)
		{
			for (int i = 0; i < effectors.Length; i++)
			{
				if (effectors[i].bone == t)
				{
					return effectors[i];
				}
			}
			return null;
		}

		public FBIKChain GetChain(Transform transform)
		{
			int chainIndex = GetChainIndex(transform);
			if (chainIndex == -1)
			{
				return null;
			}
			return chain[chainIndex];
		}

		public int GetChainIndex(Transform transform)
		{
			for (int i = 0; i < chain.Length; i++)
			{
				for (int j = 0; j < chain[i].nodes.Length; j++)
				{
					if (chain[i].nodes[j].transform == transform)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return chain[chainIndex].nodes[nodeIndex];
		}

		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
			chainIndex = GetChainIndex(transform);
			if (chainIndex == -1)
			{
				nodeIndex = -1;
			}
			else
			{
				nodeIndex = chain[chainIndex].GetNodeIndex(transform);
			}
		}

		public override Point[] GetPoints()
		{
			int num = 0;
			for (int i = 0; i < chain.Length; i++)
			{
				num += chain[i].nodes.Length;
			}
			Point[] array = new Point[num];
			int num2 = 0;
			for (int j = 0; j < chain.Length; j++)
			{
				for (int k = 0; k < chain[j].nodes.Length; k++)
				{
					array[num2] = chain[j].nodes[k];
				}
			}
			return array;
		}

		public override Point GetPoint(Transform transform)
		{
			for (int i = 0; i < chain.Length; i++)
			{
				for (int j = 0; j < chain[i].nodes.Length; j++)
				{
					if (chain[i].nodes[j].transform == transform)
					{
						return chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		public override bool IsValid(ref string message)
		{
			if (chain == null)
			{
				message = "FBIK chain is null, can't initiate solver.";
				return false;
			}
			if (chain.Length == 0)
			{
				message = "FBIK chain length is 0, can't initiate solver.";
				return false;
			}
			for (int i = 0; i < chain.Length; i++)
			{
				if (!chain[i].IsValid(ref message))
				{
					return false;
				}
			}
			IKEffector[] array = effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			if (!spineMapping.IsValid(this, ref message))
			{
				return false;
			}
			IKMappingLimb[] array2 = limbMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				if (!array2[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = boneMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				if (!array3[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			return true;
		}

		public override void StoreDefaultLocalState()
		{
			spineMapping.StoreDefaultLocalState();
			for (int i = 0; i < limbMappings.Length; i++)
			{
				limbMappings[i].StoreDefaultLocalState();
			}
			for (int j = 0; j < boneMappings.Length; j++)
			{
				boneMappings[j].StoreDefaultLocalState();
			}
			if (OnStoreDefaultLocalState != null)
			{
				OnStoreDefaultLocalState();
			}
		}

		public override void FixTransforms()
		{
			if (base.initiated && !(IKPositionWeight <= 0f))
			{
				spineMapping.FixTransforms();
				for (int i = 0; i < limbMappings.Length; i++)
				{
					limbMappings[i].FixTransforms();
				}
				for (int j = 0; j < boneMappings.Length; j++)
				{
					boneMappings[j].FixTransforms();
				}
				if (OnFixTransforms != null)
				{
					OnFixTransforms();
				}
			}
		}

		protected override void OnInitiate()
		{
			for (int i = 0; i < chain.Length; i++)
			{
				chain[i].Initiate(this);
			}
			IKEffector[] array = effectors;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].Initiate(this);
			}
			spineMapping.Initiate(this);
			IKMappingBone[] array2 = boneMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].Initiate(this);
			}
			IKMappingLimb[] array3 = limbMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j].Initiate(this);
			}
		}

		protected override void OnUpdate()
		{
			if (IKPositionWeight <= 0f)
			{
				for (int i = 0; i < effectors.Length; i++)
				{
					effectors[i].positionOffset = Vector3.zero;
				}
			}
			else if (chain.Length != 0)
			{
				IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
				if (OnPreRead != null)
				{
					OnPreRead();
				}
				ReadPose();
				if (OnPreSolve != null)
				{
					OnPreSolve();
				}
				Solve();
				if (OnPostSolve != null)
				{
					OnPostSolve();
				}
				WritePose();
				for (int j = 0; j < effectors.Length; j++)
				{
					effectors[j].OnPostWrite();
				}
			}
		}

		protected virtual void ReadPose()
		{
			for (int i = 0; i < chain.Length; i++)
			{
				if (chain[i].bendConstraint.initiated)
				{
					chain[i].bendConstraint.LimitBend(IKPositionWeight, GetEffector(chain[i].nodes[2].transform).positionWeight);
				}
			}
			for (int j = 0; j < effectors.Length; j++)
			{
				effectors[j].ResetOffset(this);
			}
			for (int k = 0; k < effectors.Length; k++)
			{
				effectors[k].OnPreSolve(this);
			}
			for (int l = 0; l < chain.Length; l++)
			{
				chain[l].ReadPose(this, iterations > 0);
			}
			if (iterations > 0)
			{
				spineMapping.ReadPose();
				for (int m = 0; m < boneMappings.Length; m++)
				{
					boneMappings[m].ReadPose();
				}
			}
			for (int n = 0; n < limbMappings.Length; n++)
			{
				limbMappings[n].ReadPose();
			}
		}

		protected virtual void Solve()
		{
			if (iterations > 0)
			{
				for (int i = 0; i < ((!FABRIKPass) ? 1 : iterations); i++)
				{
					if (OnPreIteration != null)
					{
						OnPreIteration(i);
					}
					for (int j = 0; j < effectors.Length; j++)
					{
						if (effectors[j].isEndEffector)
						{
							effectors[j].Update(this);
						}
					}
					if (FABRIKPass)
					{
						chain[0].Push(this);
						if (FABRIKPass)
						{
							chain[0].Reach(this);
						}
						for (int k = 0; k < effectors.Length; k++)
						{
							if (!effectors[k].isEndEffector)
							{
								effectors[k].Update(this);
							}
						}
					}
					chain[0].SolveTrigonometric(this);
					if (FABRIKPass)
					{
						chain[0].Stage1(this);
						for (int l = 0; l < effectors.Length; l++)
						{
							if (!effectors[l].isEndEffector)
							{
								effectors[l].Update(this);
							}
						}
						chain[0].Stage2(this, chain[0].nodes[0].solverPosition);
					}
					if (OnPostIteration != null)
					{
						OnPostIteration(i);
					}
				}
			}
			if (OnPreBend != null)
			{
				OnPreBend();
			}
			for (int m = 0; m < effectors.Length; m++)
			{
				if (effectors[m].isEndEffector)
				{
					effectors[m].Update(this);
				}
			}
			ApplyBendConstraints();
		}

		protected virtual void ApplyBendConstraints()
		{
			chain[0].SolveTrigonometric(this, calculateBendDirection: true);
		}

		protected virtual void WritePose()
		{
			if (IKPositionWeight <= 0f)
			{
				return;
			}
			if (iterations > 0)
			{
				spineMapping.WritePose(this);
				for (int i = 0; i < boneMappings.Length; i++)
				{
					boneMappings[i].WritePose(IKPositionWeight);
				}
			}
			for (int j = 0; j < limbMappings.Length; j++)
			{
				limbMappings[j].WritePose(this, iterations > 0);
			}
		}
	}
	[Serializable]
	public enum FullBodyBipedEffector
	{
		Body,
		LeftShoulder,
		RightShoulder,
		LeftThigh,
		RightThigh,
		LeftHand,
		RightHand,
		LeftFoot,
		RightFoot
	}
	[Serializable]
	public enum FullBodyBipedChain
	{
		LeftArm,
		RightArm,
		LeftLeg,
		RightLeg
	}
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		public Transform rootNode;

		[Range(0f, 1f)]
		public float spineStiffness = 0.5f;

		[Range(-1f, 1f)]
		public float pullBodyVertical = 0.5f;

		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		private Vector3 offset;

		public IKEffector bodyEffector => GetEffector(FullBodyBipedEffector.Body);

		public IKEffector leftShoulderEffector => GetEffector(FullBodyBipedEffector.LeftShoulder);

		public IKEffector rightShoulderEffector => GetEffector(FullBodyBipedEffector.RightShoulder);

		public IKEffector leftThighEffector => GetEffector(FullBodyBipedEffector.LeftThigh);

		public IKEffector rightThighEffector => GetEffector(FullBodyBipedEffector.RightThigh);

		public IKEffector leftHandEffector => GetEffector(FullBodyBipedEffector.LeftHand);

		public IKEffector rightHandEffector => GetEffector(FullBodyBipedEffector.RightHand);

		public IKEffector leftFootEffector => GetEffector(FullBodyBipedEffector.LeftFoot);

		public IKEffector rightFootEffector => GetEffector(FullBodyBipedEffector.RightFoot);

		public FBIKChain leftArmChain => chain[1];

		public FBIKChain rightArmChain => chain[2];

		public FBIKChain leftLegChain => chain[3];

		public FBIKChain rightLegChain => chain[4];

		public IKMappingLimb leftArmMapping => limbMappings[0];

		public IKMappingLimb rightArmMapping => limbMappings[1];

		public IKMappingLimb leftLegMapping => limbMappings[2];

		public IKMappingLimb rightLegMapping => limbMappings[3];

		public IKMappingBone headMapping => boneMappings[0];

		public Vector3 pullBodyOffset { get; private set; }

		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
			GetChain(c).pull = pull;
			GetChain(c).reach = reach;
		}

		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
			GetEffector(effector).positionWeight = Mathf.Clamp(positionWeight, 0f, 1f);
			GetEffector(effector).rotationWeight = Mathf.Clamp(rotationWeight, 0f, 1f);
		}

		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return c switch
			{
				FullBodyBipedChain.LeftArm => chain[1], 
				FullBodyBipedChain.RightArm => chain[2], 
				FullBodyBipedChain.LeftLeg => chain[3], 
				FullBodyBipedChain.RightLeg => chain[4], 
				_ => null, 
			};
		}

		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return effector switch
			{
				FullBodyBipedEffector.Body => chain[0], 
				FullBodyBipedEffector.LeftShoulder => chain[1], 
				FullBodyBipedEffector.RightShoulder => chain[2], 
				FullBodyBipedEffector.LeftThigh => chain[3], 
				FullBodyBipedEffector.RightThigh => chain[4], 
				FullBodyBipedEffector.LeftHand => chain[1], 
				FullBodyBipedEffector.RightHand => chain[2], 
				FullBodyBipedEffector.LeftFoot => chain[3], 
				FullBodyBipedEffector.RightFoot => chain[4], 
				_ => null, 
			};
		}

		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return effector switch
			{
				FullBodyBipedEffector.Body => effectors[0], 
				FullBodyBipedEffector.LeftShoulder => effectors[1], 
				FullBodyBipedEffector.RightShoulder => effectors[2], 
				FullBodyBipedEffector.LeftThigh => effectors[3], 
				FullBodyBipedEffector.RightThigh => effectors[4], 
				FullBodyBipedEffector.LeftHand => effectors[5], 
				FullBodyBipedEffector.RightHand => effectors[6], 
				FullBodyBipedEffector.LeftFoot => effectors[7], 
				FullBodyBipedEffector.RightFoot => effectors[8], 
				_ => null, 
			};
		}

		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return c switch
			{
				FullBodyBipedChain.LeftArm => effectors[5], 
				FullBodyBipedChain.RightArm => effectors[6], 
				FullBodyBipedChain.LeftLeg => effectors[7], 
				FullBodyBipedChain.RightLeg => effectors[8], 
				_ => null, 
			};
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return chain switch
			{
				FullBodyBipedChain.LeftArm => limbMappings[0], 
				FullBodyBipedChain.RightArm => limbMappings[1], 
				FullBodyBipedChain.LeftLeg => limbMappings[2], 
				FullBodyBipedChain.RightLeg => limbMappings[3], 
				_ => null, 
			};
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return effector switch
			{
				FullBodyBipedEffector.LeftShoulder => limbMappings[0], 
				FullBodyBipedEffector.RightShoulder => limbMappings[1], 
				FullBodyBipedEffector.LeftThigh => limbMappings[2], 
				FullBodyBipedEffector.RightThigh => limbMappings[3], 
				FullBodyBipedEffector.LeftHand => limbMappings[0], 
				FullBodyBipedEffector.RightHand => limbMappings[1], 
				FullBodyBipedEffector.LeftFoot => limbMappings[2], 
				FullBodyBipedEffector.RightFoot => limbMappings[3], 
				_ => null, 
			};
		}

		public IKMappingSpine GetSpineMapping()
		{
			return spineMapping;
		}

		public IKMappingBone GetHeadMapping()
		{
			return boneMappings[0];
		}

		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return limb switch
			{
				FullBodyBipedChain.LeftArm => chain[1].bendConstraint, 
				FullBodyBipedChain.RightArm => chain[2].bendConstraint, 
				FullBodyBipedChain.LeftLeg => chain[3].bendConstraint, 
				FullBodyBipedChain.RightLeg => chain[4].bendConstraint, 
				_ => null, 
			};
		}

		public override bool IsValid(ref string message)
		{
			if (!base.IsValid(ref message))
			{
				return false;
			}
			if (rootNode == null)
			{
				message = "Root Node bone is null. FBBIK will not initiate.";
				return false;
			}
			if (chain.Length != 5 || chain[0].nodes.Length != 1 || chain[1].nodes.Length != 3 || chain[2].nodes.Length != 3 || chain[3].nodes.Length != 3 || chain[4].nodes.Length != 3 || effectors.Length != 9 || limbMappings.Length != 4)
			{
				message = "Invalid FBBIK setup. Please right-click on the component header and select 'Reinitiate'.";
				return false;
			}
			return true;
		}

		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
			root = references.root;
			if (rootNode == null)
			{
				rootNode = DetectRootNodeBone(references);
			}
			this.rootNode = rootNode;
			if (chain == null || chain.Length != 5)
			{
				chain = new FBIKChain[5];
			}
			for (int i = 0; i < chain.Length; i++)
			{
				if (chain[i] == null)
				{
					chain[i] = new FBIKChain();
				}
			}
			chain[0].pin = 0f;
			chain[0].SetNodes(rootNode);
			chain[0].children = new int[4] { 1, 2, 3, 4 };
			chain[1].SetNodes(references.leftUpperArm, references.leftForearm, references.leftHand);
			chain[2].SetNodes(references.rightUpperArm, references.rightForearm, references.rightHand);
			chain[3].SetNodes(references.leftThigh, references.leftCalf, references.leftFoot);
			chain[4].SetNodes(references.rightThigh, references.rightCalf, references.rightFoot);
			if (effectors.Length != 9)
			{
				effectors = new IKEffector[9]
				{
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector()
				};
			}
			effectors[0].bone = rootNode;
			effectors[0].childBones = new Transform[2] { references.leftThigh, references.rightThigh };
			effectors[1].bone = references.leftUpperArm;
			effectors[2].bone = references.rightUpperArm;
			effectors[3].bone = references.leftThigh;
			effectors[4].bone = references.rightThigh;
			effectors[5].bone = references.leftHand;
			effectors[6].bone = references.rightHand;
			effectors[7].bone = references.leftFoot;
			effectors[8].bone = references.rightFoot;
			effectors[5].planeBone1 = references.leftUpperArm;
			effectors[5].planeBone2 = references.rightUpperArm;
			effectors[5].planeBone3 = rootNode;
			effectors[6].planeBone1 = references.rightUpperArm;
			effectors[6].planeBone2 = references.leftUpperArm;
			effectors[6].planeBone3 = rootNode;
			effectors[7].planeBone1 = references.leftThigh;
			effectors[7].planeBone2 = references.rightThigh;
			effectors[7].planeBone3 = rootNode;
			effectors[8].planeBone1 = references.rightThigh;
			effectors[8].planeBone2 = references.leftThigh;
			effectors[8].planeBone3 = rootNode;
			chain[0].childConstraints = new FBIKChain.ChildConstraint[4]
			{
				new FBIKChain.ChildConstraint(references.leftUpperArm, references.rightThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(references.rightUpperArm, references.leftThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(references.leftUpperArm, references.rightUpperArm),
				new FBIKChain.ChildConstraint(references.leftThigh, references.rightThigh)
			};
			Transform[] array = new Transform[references.spine.Length + 1];
			array[0] = references.pelvis;
			for (int j = 0; j < references.spine.Length; j++)
			{
				array[j + 1] = references.spine[j];
			}
			if (spineMapping == null)
			{
				spineMapping = new IKMappingSpine();
				spineMapping.iterations = 3;
			}
			spineMapping.SetBones(array, references.leftUpperArm, references.rightUpperArm, references.leftThigh, references.rightThigh);
			int num = ((references.head != null) ? 1 : 0);
			if (boneMappings.Length != num)
			{
				boneMappings = new IKMappingBone[num];
				for (int k = 0; k < boneMappings.Length; k++)
				{
					boneMappings[k] = new IKMappingBone();
				}
				if (num == 1)
				{
					boneMappings[0].maintainRotationWeight = 0f;
				}
			}
			if (boneMappings.Length != 0)
			{
				boneMappings[0].bone = references.head;
			}
			if (limbMappings.Length != 4)
			{
				limbMappings = new IKMappingLimb[4]
				{
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb()
				};
				limbMappings[2].maintainRotationWeight = 1f;
				limbMappings[3].maintainRotationWeight = 1f;
			}
			limbMappings[0].SetBones(references.leftUpperArm, references.leftForearm, references.leftHand, GetLeftClavicle(references));
			limbMappings[1].SetBones(references.rightUpperArm, references.rightForearm, references.rightHand, GetRightClavicle(references));
			limbMappings[2].SetBones(references.leftThigh, references.leftCalf, references.leftFoot);
			limbMappings[3].SetBones(references.rightThigh, references.rightCalf, references.rightFoot);
			if (Application.isPlaying)
			{
				Initiate(references.root);
			}
		}

		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			if (!references.isFilled)
			{
				return null;
			}
			if (references.spine.Length < 1)
			{
				return null;
			}
			int num = references.spine.Length;
			if (num == 1)
			{
				return references.spine[0];
			}
			Vector3 vector = Vector3.Lerp(references.leftThigh.position, references.rightThigh.position, 0.5f);
			Vector3 onNormal = Vector3.Lerp(references.leftUpperArm.position, references.rightUpperArm.position, 0.5f) - vector;
			float magnitude = onNormal.magnitude;
			if (references.spine.Length < 2)
			{
				return references.spine[0];
			}
			int num2 = 0;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector2 = Vector3.Project(references.spine[i].position - vector, onNormal);
				if (Vector3.Dot(vector2.normalized, onNormal.normalized) > 0f && vector2.magnitude / magnitude < 0.5f)
				{
					num2 = i;
				}
			}
			return references.spine[num2];
		}

		public void SetLimbOrientations(BipedLimbOrientations o)
		{
			SetLimbOrientation(FullBodyBipedChain.LeftArm, o.leftArm);
			SetLimbOrientation(FullBodyBipedChain.RightArm, o.rightArm);
			SetLimbOrientation(FullBodyBipedChain.LeftLeg, o.leftLeg);
			SetLimbOrientation(FullBodyBipedChain.RightLeg, o.rightLeg);
		}

		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
			if (chain == FullBodyBipedChain.LeftArm || chain == FullBodyBipedChain.RightArm)
			{
				GetBendConstraint(chain).SetLimbOrientation(-limbOrientation.upperBoneForwardAxis, -limbOrientation.lowerBoneForwardAxis, -limbOrientation.lastBoneLeftAxis);
				GetLimbMapping(chain).SetLimbOrientation(-limbOrientation.upperBoneForwardAxis, -limbOrientation.lowerBoneForwardAxis);
			}
			else
			{
				GetBendConstraint(chain).SetLimbOrientation(limbOrientation.upperBoneForwardAxis, limbOrientation.lowerBoneForwardAxis, limbOrientation.lastBoneLeftAxis);
				GetLimbMapping(chain).SetLimbOrientation(limbOrientation.upperBoneForwardAxis, limbOrientation.lowerBoneForwardAxis);
			}
		}

		private static Transform GetLeftClavicle(BipedReferences references)
		{
			if (references.leftUpperArm == null)
			{
				return null;
			}
			if (!Contains(references.spine, references.leftUpperArm.parent))
			{
				return references.leftUpperArm.parent;
			}
			return null;
		}

		private static Transform GetRightClavicle(BipedReferences references)
		{
			if (references.rightUpperArm == null)
			{
				return null;
			}
			if (!Contains(references.spine, references.rightUpperArm.parent))
			{
				return references.rightUpperArm.parent;
			}
			return null;
		}

		private static bool Contains(Transform[] array, Transform transform)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == transform)
				{
					return true;
				}
			}
			return false;
		}

		protected override void ReadPose()
		{
			for (int i = 0; i < effectors.Length; i++)
			{
				effectors[i].SetToTarget();
			}
			PullBody();
			float pushElasticity = Mathf.Clamp(1f - spineStiffness, 0f, 1f);
			chain[0].childConstraints[0].pushElasticity = pushElasticity;
			chain[0].childConstraints[1].pushElasticity = pushElasticity;
			base.ReadPose();
		}

		private void PullBody()
		{
			if (iterations >= 1 && (pullBodyVertical != 0f || pullBodyHorizontal != 0f))
			{
				Vector3 bodyOffset = GetBodyOffset();
				pullBodyOffset = V3Tools.ExtractVertical(bodyOffset, root.up, pullBodyVertical) + V3Tools.ExtractHorizontal(bodyOffset, root.up, pullBodyHorizontal);
				bodyEffector.positionOffset += pullBodyOffset;
			}
		}

		private Vector3 GetBodyOffset()
		{
			Vector3 vector = Vector3.zero + GetHandBodyPull(leftHandEffector, leftArmChain, Vector3.zero) * Mathf.Clamp(leftHandEffector.positionWeight, 0f, 1f);
			return vector + GetHandBodyPull(rightHandEffector, rightArmChain, vector) * Mathf.Clamp(rightHandEffector.positionWeight, 0f, 1f);
		}

		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			Vector3 vector = effector.position - (arm.nodes[0].transform.position + offset);
			float num = arm.nodes[0].length + arm.nodes[1].length;
			float magnitude = vector.magnitude;
			if (magnitude < num)
			{
				return Vector3.zero;
			}
			float num2 = magnitude - num;
			return vector / magnitude * num2;
		}

		protected override void ApplyBendConstraints()
		{
			if (iterations > 0)
			{
				chain[1].bendConstraint.rotationOffset = leftHandEffector.planeRotationOffset;
				chain[2].bendConstraint.rotationOffset = rightHandEffector.planeRotationOffset;
				chain[3].bendConstraint.rotationOffset = leftFootEffector.planeRotationOffset;
				chain[4].bendConstraint.rotationOffset = rightFootEffector.planeRotationOffset;
			}
			else
			{
				offset = Vector3.Lerp(effectors[0].positionOffset, effectors[0].position - (effectors[0].bone.position + effectors[0].positionOffset), effectors[0].positionWeight);
				for (int i = 0; i < 5; i++)
				{
					effectors[i].GetNode(this).solverPosition += offset;
				}
			}
			base.ApplyBendConstraints();
		}

		protected override void WritePose()
		{
			if (iterations == 0)
			{
				spineMapping.spineBones[0].position += offset;
			}
			base.WritePose();
		}
	}
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		public Transform target;

		public float tolerance;

		public int maxIterations = 4;

		public bool useRotationLimits = true;

		public bool XY;

		public Bone[] bones = new Bone[0];

		protected Vector3 lastLocalDirection;

		protected float chainLength;

		protected virtual int minBones => 2;

		protected virtual bool boneLengthCanBeZero => true;

		protected virtual bool allowCommonParent => false;

		protected virtual Vector3 localDirection => bones[0].transform.InverseTransformDirection(bones[bones.Length - 1].transform.position - bones[0].transform.position);

		protected float positionOffset => Vector3.SqrMagnitude(localDirection - lastLocalDirection);

		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			if (bones == null || bones.Length != hierarchy.Length)
			{
				bones = new Bone[hierarchy.Length];
			}
			for (int i = 0; i < hierarchy.Length; i++)
			{
				if (bones[i] == null)
				{
					bones[i] = new Bone();
				}
				bones[i].transform = hierarchy[i];
			}
			Initiate(root);
			return base.initiated;
		}

		public void AddBone(Transform bone)
		{
			Transform[] array = new Transform[bones.Length + 1];
			for (int i = 0; i < bones.Length; i++)
			{
				array[i] = bones[i].transform;
			}
			array[^1] = bone;
			SetChain(array, root);
		}

		public override void StoreDefaultLocalState()
		{
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].StoreDefaultLocalState();
			}
		}

		public override void FixTransforms()
		{
			if (base.initiated && !(IKPositionWeight <= 0f))
			{
				for (int i = 0; i < bones.Length; i++)
				{
					bones[i].FixTransform();
				}
			}
		}

		public override bool IsValid(ref string message)
		{
			if (bones.Length == 0)
			{
				message = "IK chain has no Bones.";
				return false;
			}
			if (bones.Length < minBones)
			{
				message = "IK chain has less than " + minBones + " Bones.";
				return false;
			}
			Bone[] array = bones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					message = "One of the Bones is null.";
					return false;
				}
			}
			Transform transform = IKSolver.ContainsDuplicateBone(bones);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (!allowCommonParent && !IKSolver.HierarchyIsValid(bones))
			{
				message = "Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order.";
				return false;
			}
			if (!boneLengthCanBeZero)
			{
				for (int j = 0; j < bones.Length - 1; j++)
				{
					if ((bones[j].transform.position - bones[j + 1].transform.position).magnitude == 0f)
					{
						message = "Bone " + j + " length is zero.";
						return false;
					}
				}
			}
			return true;
		}

		public override Point[] GetPoints()
		{
			return bones;
		}

		public override Point GetPoint(Transform transform)
		{
			for (int i = 0; i < bones.Length; i++)
			{
				if (bones[i].transform == transform)
				{
					return bones[i];
				}
			}
			return null;
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected void InitiateBones()
		{
			chainLength = 0f;
			for (int i = 0; i < bones.Length; i++)
			{
				if (i < bones.Length - 1)
				{
					bones[i].length = (bones[i].transform.position - bones[i + 1].transform.position).magnitude;
					chainLength += bones[i].length;
					Vector3 position = bones[i + 1].transform.position;
					bones[i].axis = Quaternion.Inverse(bones[i].transform.rotation) * (position - bones[i].transform.position);
					if (bones[i].rotationLimit != null)
					{
						if (XY && !(bones[i].rotationLimit is RotationLimitHinge))
						{
							Warning.Log("Only Hinge Rotation Limits should be used on 2D IK solvers.", bones[i].transform);
						}
						bones[i].rotationLimit.Disable();
					}
				}
				else
				{
					bones[i].axis = Quaternion.Inverse(bones[i].transform.rotation) * (bones[bones.Length - 1].transform.position - bones[0].transform.position);
				}
			}
		}

		protected Vector3 GetSingularityOffset()
		{
			if (!SingularityDetected())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (IKPosition - bones[0].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (useRotationLimits && bones[bones.Length - 2].rotationLimit != null && bones[bones.Length - 2].rotationLimit is RotationLimitHinge)
			{
				rhs = bones[bones.Length - 2].transform.rotation * bones[bones.Length - 2].rotationLimit.axis;
			}
			return Vector3.Cross(normalized, rhs) * bones[bones.Length - 2].length * 0.5f;
		}

		private bool SingularityDetected()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 vector = bones[bones.Length - 1].transform.position - bones[0].transform.position;
			Vector3 vector2 = IKPosition - bones[0].transform.position;
			float magnitude = vector.magnitude;
			float magnitude2 = vector2.magnitude;
			if (magnitude < magnitude2)
			{
				return false;
			}
			if (magnitude < chainLength - bones[bones.Length - 2].length * 0.1f)
			{
				return false;
			}
			if (magnitude == 0f)
			{
				return false;
			}
			if (magnitude2 == 0f)
			{
				return false;
			}
			if (magnitude2 > magnitude)
			{
				return false;
			}
			if (Vector3.Dot(vector / magnitude, vector2 / magnitude2) < 0.999f)
			{
				return false;
			}
			return true;
		}
	}
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		public Quaternion IKRotation = Quaternion.identity;

		public Point pelvis = new Point();

		public Point thigh = new Point();

		public Point calf = new Point();

		public Point foot = new Point();

		public Point toe = new Point();

		public IKSolverVR.Leg leg = new IKSolverVR.Leg();

		public Vector3 heelOffset;

		private Vector3[] positions = new Vector3[6];

		private Quaternion[] rotations = new Quaternion[6];

		public override bool IsValid(ref string message)
		{
			if (pelvis.transform == null || thigh.transform == null || calf.transform == null || foot.transform == null || toe.transform == null)
			{
				message = "Please assign all bone slots of the Leg IK solver.";
				return false;
			}
			UnityEngine.Object[] objects = new Transform[5] { pelvis.transform, thigh.transform, calf.transform, foot.transform, toe.transform };
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the LegIK.";
				return false;
			}
			return true;
		}

		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			this.pelvis.transform = pelvis;
			this.thigh.transform = thigh;
			this.calf.transform = calf;
			this.foot.transform = foot;
			this.toe.transform = toe;
			Initiate(root);
			return base.initiated;
		}

		public override Point[] GetPoints()
		{
			return new Point[5] { pelvis, thigh, calf, foot, toe };
		}

		public override Point GetPoint(Transform transform)
		{
			if (pelvis.transform == transform)
			{
				return pelvis;
			}
			if (thigh.transform == transform)
			{
				return thigh;
			}
			if (calf.transform == transform)
			{
				return calf;
			}
			if (foot.transform == transform)
			{
				return foot;
			}
			if (toe.transform == transform)
			{
				return toe;
			}
			return null;
		}

		public override void StoreDefaultLocalState()
		{
			thigh.StoreDefaultLocalState();
			calf.StoreDefaultLocalState();
			foot.StoreDefaultLocalState();
			toe.StoreDefaultLocalState();
		}

		public override void FixTransforms()
		{
			if (base.initiated)
			{
				thigh.FixTransform();
				calf.FixTransform();
				foot.FixTransform();
				toe.FixTransform();
			}
		}

		protected override void OnInitiate()
		{
			IKPosition = toe.transform.position;
			IKRotation = toe.transform.rotation;
			Read();
		}

		protected override void OnUpdate()
		{
			Read();
			Solve();
			Write();
		}

		private void Solve()
		{
			leg.heelPositionOffset += heelOffset;
			leg.PreSolve();
			leg.ApplyOffsets();
			leg.Solve(stretch: true);
			leg.ResetOffsets();
		}

		private void Read()
		{
			leg.IKPosition = IKPosition;
			leg.positionWeight = IKPositionWeight;
			leg.IKRotation = IKRotation;
			leg.rotationWeight = IKRotationWeight;
			positions[0] = root.position;
			positions[1] = pelvis.transform.position;
			positions[2] = thigh.transform.position;
			positions[3] = calf.transform.position;
			positions[4] = foot.transform.position;
			positions[5] = toe.transform.position;
			rotations[0] = root.rotation;
			rotations[1] = pelvis.transform.rotation;
			rotations[2] = thigh.transform.rotation;
			rotations[3] = calf.transform.rotation;
			rotations[4] = foot.transform.rotation;
			rotations[5] = toe.transform.rotation;
			leg.Read(positions, rotations, hasChest: false, hasNeck: false, hasShoulders: false, hasToes: true, hasLegs: true, 1, 2);
		}

		private void Write()
		{
			leg.Write(ref positions, ref rotations);
			thigh.transform.rotation = rotations[2];
			calf.transform.rotation = rotations[3];
			foot.transform.rotation = rotations[4];
			toe.transform.rotation = rotations[5];
			calf.transform.position = positions[3];
			foot.transform.position = positions[4];
		}
	}
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		public enum BendModifier
		{
			Animation,
			Target,
			Parent,
			Arm,
			Goal
		}

		[Serializable]
		public struct AxisDirection
		{
			public Vector3 direction;

			public Vector3 axis;

			public float dot;

			public AxisDirection(Vector3 direction, Vector3 axis)
			{
				this.direction = direction.normalized;
				this.axis = axis.normalized;
				dot = 0f;
			}
		}

		public AvatarIKGoal goal;

		public BendModifier bendModifier;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Range(0f, 1f)]
		public float bendModifierWeight = 1f;

		public Transform bendGoal;

		private bool maintainBendFor1Frame;

		private bool maintainRotationFor1Frame;

		private Quaternion defaultRootRotation;

		private Quaternion parentDefaultRotation;

		private Quaternion bone3RotationBeforeSolve;

		private Quaternion maintainRotation;

		private Quaternion bone3DefaultRotation;

		private Vector3 _bendNormal;

		private Vector3 animationNormal;

		private AxisDirection[] axisDirectionsLeft = new AxisDirection[4];

		private AxisDirection[] axisDirectionsRight = new AxisDirection[4];

		private AxisDirection[] axisDirections
		{
			get
			{
				if (goal == AvatarIKGoal.LeftHand)
				{
					return axisDirectionsLeft;
				}
				return axisDirectionsRight;
			}
		}

		public void MaintainRotation()
		{
			if (base.initiated)
			{
				maintainRotation = bone3.transform.rotation;
				maintainRotationFor1Frame = true;
			}
		}

		public void MaintainBend()
		{
			if (base.initiated)
			{
				animationNormal = bone1.GetBendNormalFromCurrentRotation();
				maintainBendFor1Frame = true;
			}
		}

		protected override void OnInitiateVirtual()
		{
			defaultRootRotation = root.rotation;
			if (bone1.transform.parent != null)
			{
				parentDefaultRotation = Quaternion.Inverse(defaultRootRotation) * bone1.transform.parent.rotation;
			}
			if (bone3.rotationLimit != null)
			{
				bone3.rotationLimit.Disable();
			}
			bone3DefaultRotation = bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(bone2.transform.position - bone1.transform.position, bone3.transform.position - bone2.transform.position);
			if (vector != Vector3.zero)
			{
				bendNormal = vector;
			}
			animationNormal = bendNormal;
			StoreAxisDirections(ref axisDirectionsLeft);
			StoreAxisDirections(ref axisDirectionsRight);
		}

		protected override void OnUpdateVirtual()
		{
			if (IKPositionWeight > 0f)
			{
				bendModifierWeight = Mathf.Clamp(bendModifierWeight, 0f, 1f);
				maintainRotationWeight = Mathf.Clamp(maintainRotationWeight, 0f, 1f);
				_bendNormal = bendNormal;
				bendNormal = GetModifiedBendNormal();
			}
			if (maintainRotationWeight * IKPositionWeight > 0f)
			{
				bone3RotationBeforeSolve = (maintainRotationFor1Frame ? maintainRotation : bone3.transform.rotation);
				maintainRotationFor1Frame = false;
			}
		}

		protected override void OnPostSolveVirtual()
		{
			if (IKPositionWeight > 0f)
			{
				bendNormal = _bendNormal;
			}
			if (maintainRotationWeight * IKPositionWeight > 0f)
			{
				bone3.transform.rotation = Quaternion.Slerp(bone3.transform.rotation, bone3RotationBeforeSolve, maintainRotationWeight * IKPositionWeight);
			}
		}

		public IKSolverLimb()
		{
		}

		public IKSolverLimb(AvatarIKGoal goal)
		{
			this.goal = goal;
		}

		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
			axisDirections[0] = new AxisDirection(Vector3.zero, new Vector3(-1f, 0f, 0f));
			axisDirections[1] = new AxisDirection(new Vector3(0.5f, 0f, -0.2f), new Vector3(-0.5f, -1f, 1f));
			axisDirections[2] = new AxisDirection(new Vector3(-0.5f, -1f, -0.2f), new Vector3(0f, 0.5f, -1f));
			axisDirections[3] = new AxisDirection(new Vector3(-0.5f, -0.5f, 1f), new Vector3(-1f, -1f, -1f));
		}

		private Vector3 GetModifiedBendNormal()
		{
			float num = bendModifierWeight;
			if (num <= 0f)
			{
				return bendNormal;
			}
			switch (bendModifier)
			{
			case BendModifier.Animation:
				if (!maintainBendFor1Frame)
				{
					MaintainBend();
				}
				maintainBendFor1Frame = false;
				return Vector3.Lerp(bendNormal, animationNormal, num);
			case BendModifier.Parent:
			{
				if (bone1.transform.parent == null)
				{
					return bendNormal;
				}
				Quaternion quaternion = bone1.transform.parent.rotation * Quaternion.Inverse(parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, quaternion * Quaternion.Inverse(defaultRootRotation), num) * bendNormal;
			}
			case BendModifier.Target:
			{
				Quaternion b = IKRotation * Quaternion.Inverse(bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * bendNormal;
			}
			case BendModifier.Arm:
			{
				if (bone1.transform.parent == null)
				{
					return bendNormal;
				}
				if (goal == AvatarIKGoal.LeftFoot || goal == AvatarIKGoal.RightFoot)
				{
					if (!Warning.logged)
					{
						LogWarning("Trying to use the 'Arm' bend modifier on a leg.");
					}
					return bendNormal;
				}
				Vector3 normalized = (IKPosition - bone1.transform.position).normalized;
				normalized = Quaternion.Inverse(bone1.transform.parent.rotation * Quaternion.Inverse(parentDefaultRotation)) * normalized;
				if (goal == AvatarIKGoal.LeftHand)
				{
					normalized.x = 0f - normalized.x;
				}
				for (int i = 1; i < axisDirections.Length; i++)
				{
					axisDirections[i].dot = Mathf.Clamp(Vector3.Dot(axisDirections[i].direction, normalized), 0f, 1f);
					axisDirections[i].dot = Interp.Float(axisDirections[i].dot, InterpolationMode.InOutQuintic);
				}
				Vector3 vector2 = axisDirections[0].axis;
				for (int j = 1; j < axisDirections.Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, axisDirections[j].axis, axisDirections[j].dot);
				}
				if (goal == AvatarIKGoal.LeftHand)
				{
					vector2.x = 0f - vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = bone1.transform.parent.rotation * Quaternion.Inverse(parentDefaultRotation) * vector2;
				if (num >= 1f)
				{
					return vector3;
				}
				return Vector3.Lerp(bendNormal, vector3, num);
			}
			case BendModifier.Goal:
			{
				if (bendGoal == null)
				{
					if (!Warning.logged)
					{
						LogWarning("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.");
					}
					return bendNormal;
				}
				Vector3 vector = Vector3.Cross(bendGoal.position - bone1.transform.position, IKPosition - bone1.transform.position);
				if (vector == Vector3.zero)
				{
					return bendNormal;
				}
				if (num >= 1f)
				{
					return vector;
				}
				return Vector3.Lerp(bendNormal, vector, num);
			}
			default:
				return bendNormal;
			}
		}
	}
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		public class LookAtBone : Bone
		{
			public Vector3 forward => transform.rotation * axis;

			public LookAtBone()
			{
			}

			public LookAtBone(Transform transform)
			{
				base.transform = transform;
			}

			public void Initiate(Transform root)
			{
				if (!(transform == null))
				{
					axis = Quaternion.Inverse(transform.rotation) * root.forward;
				}
			}

			public void LookAt(Vector3 direction, float weight)
			{
				Quaternion quaternion = Quaternion.FromToRotation(forward, direction);
				Quaternion rotation = transform.rotation;
				transform.rotation = Quaternion.Lerp(rotation, quaternion * rotation, weight);
			}
		}

		public Transform target;

		public LookAtBone[] spine = new LookAtBone[0];

		public LookAtBone head = new LookAtBone();

		public LookAtBone[] eyes = new LookAtBone[0];

		[Range(0f, 1f)]
		public float bodyWeight = 0.5f;

		[Range(0f, 1f)]
		public float headWeight = 0.5f;

		[Range(0f, 1f)]
		public float eyesWeight = 1f;

		[Range(0f, 1f)]
		public float clampWeight = 0.5f;

		[Range(0f, 1f)]
		public float clampWeightHead = 0.5f;

		[Range(0f, 1f)]
		public float clampWeightEyes = 0.5f;

		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		public AnimationCurve spineWeightCurve = new AnimationCurve(new Keyframe(0f, 0.3f), new Keyframe(1f, 1f));

		public Vector3 spineTargetOffset;

		private Vector3[] spineForwards = new Vector3[0];

		private Vector3[] headForwards = new Vector3[1];

		private Vector3[] eyeForward = new Vector3[1];

		private bool spineIsValid
		{
			get
			{
				if (spine == null)
				{
					return false;
				}
				if (spine.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < spine.Length; i++)
				{
					if (spine[i] == null || spine[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		private bool spineIsEmpty => spine.Length == 0;

		private bool headIsValid
		{
			get
			{
				if (head == null)
				{
					return false;
				}
				return true;
			}
		}

		private bool headIsEmpty => head.transform == null;

		private bool eyesIsValid
		{
			get
			{
				if (eyes == null)
				{
					return false;
				}
				if (eyes.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < eyes.Length; i++)
				{
					if (eyes[i] == null || eyes[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		private bool eyesIsEmpty => eyes.Length == 0;

		public void SetLookAtWeight(float weight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
		}

		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
			this.clampWeight = Mathf.Clamp(clampWeight, 0f, 1f);
			clampWeightHead = this.clampWeight;
			clampWeightEyes = this.clampWeight;
		}

		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
			IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
			this.clampWeight = Mathf.Clamp(clampWeight, 0f, 1f);
			this.clampWeightHead = Mathf.Clamp(clampWeightHead, 0f, 1f);
			this.clampWeightEyes = Mathf.Clamp(clampWeightEyes, 0f, 1f);
		}

		public override void StoreDefaultLocalState()
		{
			for (int i = 0; i < spine.Length; i++)
			{
				spine[i].StoreDefaultLocalState();
			}
			for (int j = 0; j < eyes.Length; j++)
			{
				eyes[j].StoreDefaultLocalState();
			}
			if (head != null && head.transform != null)
			{
				head.StoreDefaultLocalState();
			}
		}

		public override void FixTransforms()
		{
			if (base.initiated && !(IKPositionWeight <= 0f))
			{
				for (int i = 0; i < spine.Length; i++)
				{
					spine[i].FixTransform();
				}
				for (int j = 0; j < eyes.Length; j++)
				{
					eyes[j].FixTransform();
				}
				if (head != null && head.transform != null)
				{
					head.FixTransform();
				}
			}
		}

		public override bool IsValid(ref string message)
		{
			if (!spineIsValid)
			{
				message = "IKSolverLookAt spine setup is invalid. Can't initiate solver.";
				return false;
			}
			if (!headIsValid)
			{
				message = "IKSolverLookAt head transform is null. Can't initiate solver.";
				return false;
			}
			if (!eyesIsValid)
			{
				message = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			if (spineIsEmpty && headIsEmpty && eyesIsEmpty)
			{
				message = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			Bone[] bones = spine;
			Transform transform = IKSolver.ContainsDuplicateBone(bones);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			bones = eyes;
			Transform transform2 = IKSolver.ContainsDuplicateBone(bones);
			if (transform2 != null)
			{
				message = transform2.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			return true;
		}

		public override Point[] GetPoints()
		{
			Point[] array = new Point[spine.Length + eyes.Length + ((head.transform != null) ? 1 : 0)];
			for (int i = 0; i < spine.Length; i++)
			{
				array[i] = spine[i];
			}
			int num = 0;
			for (int j = spine.Length; j < array.Length; j++)
			{
				array[j] = eyes[num];
				num++;
			}
			if (head.transform != null)
			{
				array[^1] = head;
			}
			return array;
		}

		public override Point GetPoint(Transform transform)
		{
			LookAtBone[] array = spine;
			foreach (LookAtBone lookAtBone in array)
			{
				if (lookAtBone.transform == transform)
				{
					return lookAtBone;
				}
			}
			array = eyes;
			foreach (LookAtBone lookAtBone2 in array)
			{
				if (lookAtBone2.transform == transform)
				{
					return lookAtBone2;
				}
			}
			if (head.transform == transform)
			{
				return head;
			}
			return null;
		}

		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			SetBones(spine, ref this.spine);
			this.head = new LookAtBone(head);
			SetBones(eyes, ref this.eyes);
			Initiate(root);
			return base.initiated;
		}

		protected override void OnInitiate()
		{
			if (firstInitiation || !Application.isPlaying)
			{
				if (spine.Length != 0)
				{
					IKPosition = spine[spine.Length - 1].transform.position + root.forward * 3f;
				}
				else if (head.transform != null)
				{
					IKPosition = head.transform.position + root.forward * 3f;
				}
				else if (eyes.Length != 0 && eyes[0].transform != null)
				{
					IKPosition = eyes[0].transform.position + root.forward * 3f;
				}
			}
			LookAtBone[] array = spine;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(root);
			}
			if (head != null)
			{
				head.Initiate(root);
			}
			array = eyes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(root);
			}
			if (spineForwards == null || spineForwards.Length != spine.Length)
			{
				spineForwards = new Vector3[spine.Length];
			}
			if (headForwards == null)
			{
				headForwards = new Vector3[1];
			}
			if (eyeForward == null)
			{
				eyeForward = new Vector3[1];
			}
		}

		protected override void OnUpdate()
		{
			if (!(IKPositionWeight <= 0f))
			{
				IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
				if (target != null)
				{
					IKPosition = target.position;
				}
				SolveSpine();
				SolveHead();
				SolveEyes();
			}
		}

		private void SolveSpine()
		{
			if (!(bodyWeight <= 0f) && !spineIsEmpty)
			{
				Vector3 normalized = (IKPosition + spineTargetOffset - spine[spine.Length - 1].transform.position).normalized;
				GetForwards(ref spineForwards, spine[0].forward, normalized, spine.Length, clampWeight);
				for (int i = 0; i < spine.Length; i++)
				{
					spine[i].LookAt(spineForwards[i], bodyWeight * IKPositionWeight);
				}
			}
		}

		private void SolveHead()
		{
			if (!(headWeight <= 0f) && !headIsEmpty)
			{
				Vector3 vector = ((spine.Length != 0 && spine[spine.Length - 1].transform != null) ? spine[spine.Length - 1].forward : head.forward);
				Vector3 normalized = Vector3.Lerp(vector, (IKPosition - head.transform.position).normalized, headWeight * IKPositionWeight).normalized;
				GetForwards(ref headForwards, vector, normalized, 1, clampWeightHead);
				head.LookAt(headForwards[0], headWeight * IKPositionWeight);
			}
		}

		private void SolveEyes()
		{
			if (!(eyesWeight <= 0f) && !eyesIsEmpty)
			{
				for (int i = 0; i < eyes.Length; i++)
				{
					Vector3 baseForward = ((head.transform != null) ? head.forward : eyes[i].forward);
					GetForwards(ref eyeForward, baseForward, (IKPosition - eyes[i].transform.position).normalized, 1, clampWeightEyes);
					eyes[i].LookAt(eyeForward[0], eyesWeight * IKPositionWeight);
				}
			}
		}

		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			if (clamp >= 1f || IKPositionWeight <= 0f)
			{
				for (int i = 0; i < forwards.Length; i++)
				{
					forwards[i] = baseForward;
				}
				return forwards;
			}
			float num = Vector3.Angle(baseForward, targetForward);
			float num2 = 1f - num / 180f;
			float num3 = ((clamp > 0f) ? Mathf.Clamp(1f - (clamp - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clamp > 0f) ? Mathf.Clamp(num2 / clamp, 0f, 1f) : 1f);
			for (int j = 0; j < clampSmoothing; j++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			if (forwards.Length == 1)
			{
				forwards[0] = Vector3.Slerp(baseForward, targetForward, num4 * num3);
			}
			else
			{
				float num5 = 1f / (float)(forwards.Length - 1);
				for (int k = 0; k < forwards.Length; k++)
				{
					forwards[k] = Vector3.Slerp(baseForward, targetForward, spineWeightCurve.Evaluate(num5 * (float)k) * num4 * num3);
				}
			}
			return forwards;
		}

		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
			if (array == null)
			{
				bones = new LookAtBone[0];
				return;
			}
			if (bones.Length != array.Length)
			{
				bones = new LookAtBone[array.Length];
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (bones[i] == null)
				{
					bones[i] = new LookAtBone(array[i]);
				}
				else
				{
					bones[i].transform = array[i];
				}
			}
		}
	}
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : Bone
		{
			private Quaternion targetToLocalSpace;

			private Vector3 defaultLocalBendNormal;

			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
				Quaternion rotation = Quaternion.LookRotation(childPosition - transform.position, bendNormal);
				targetToLocalSpace = QuaTools.RotationToLocalSpace(transform.rotation, rotation);
				defaultLocalBendNormal = Quaternion.Inverse(transform.rotation) * bendNormal;
			}

			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return Quaternion.LookRotation(direction, bendNormal) * targetToLocalSpace;
			}

			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return transform.rotation * defaultLocalBendNormal;
			}
		}

		public Transform target;

		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		public Quaternion IKRotation = Quaternion.identity;

		public Vector3 bendNormal = Vector3.right;

		public TrigonometricBone bone1 = new TrigonometricBone();

		public TrigonometricBone bone2 = new TrigonometricBone();

		public TrigonometricBone bone3 = new TrigonometricBone();

		protected Vector3 weightIKPosition;

		protected bool directHierarchy = true;

		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
			if (!base.initiated || weight <= 0f)
			{
				return;
			}
			Vector3 vector = Vector3.Cross(goalPosition - bone1.transform.position, IKPosition - bone1.transform.position);
			if (vector != Vector3.zero)
			{
				if (weight >= 1f)
				{
					bendNormal = vector;
				}
				else
				{
					bendNormal = Vector3.Lerp(bendNormal, vector, weight);
				}
			}
		}

		public void SetBendPlaneToCurrent()
		{
			if (base.initiated)
			{
				Vector3 vector = Vector3.Cross(bone2.transform.position - bone1.transform.position, bone3.transform.position - bone2.transform.position);
				if (vector != Vector3.zero)
				{
					bendNormal = vector;
				}
			}
		}

		public void SetIKRotation(Quaternion rotation)
		{
			IKRotation = rotation;
		}

		public void SetIKRotationWeight(float weight)
		{
			IKRotationWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		public Quaternion GetIKRotation()
		{
			return IKRotation;
		}

		public float GetIKRotationWeight()
		{
			return IKRotationWeight;
		}

		public override Point[] GetPoints()
		{
			return new Point[3] { bone1, bone2, bone3 };
		}

		public override Point GetPoint(Transform transform)
		{
			if (bone1.transform == transform)
			{
				return bone1;
			}
			if (bone2.transform == transform)
			{
				return bone2;
			}
			if (bone3.transform == transform)
			{
				return bone3;
			}
			return null;
		}

		public override void StoreDefaultLocalState()
		{
			bone1.StoreDefaultLocalState();
			bone2.StoreDefaultLocalState();
			bone3.StoreDefaultLocalState();
		}

		public override void FixTransforms()
		{
			if (base.initiated)
			{
				bone1.FixTransform();
				bone2.FixTransform();
				bone3.FixTransform();
			}
		}

		public override bool IsValid(ref string message)
		{
			if (bone1.transform == null || bone2.transform == null || bone3.transform == null)
			{
				message = "Please assign all Bones to the IK solver.";
				return false;
			}
			UnityEngine.Object[] objects = new Transform[3] { bone1.transform, bone2.transform, bone3.transform };
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (bone1.transform.position == bone2.transform.position)
			{
				message = "first bone position is the same as second bone position.";
				return false;
			}
			if (bone2.transform.position == bone3.transform.position)
			{
				message = "second bone position is the same as third bone position.";
				return false;
			}
			return true;
		}

		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			this.bone1.transform = bone1;
			this.bone2.transform = bone2;
			this.bone3.transform = bone3;
			Initiate(root);
			return base.initiated;
		}

		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
			if (weight <= 0f)
			{
				return;
			}
			targetPosition = Vector3.Lerp(bone3.position, targetPosition, weight);
			Vector3 vector = targetPosition - bone1.position;
			float magnitude = vector.magnitude;
			if (magnitude != 0f)
			{
				float sqrMagnitude = (bone2.position - bone1.position).sqrMagnitude;
				float sqrMagnitude2 = (bone3.position - bone2.position).sqrMagnitude;
				Vector3 bendDirection = Vector3.Cross(vector, bendNormal);
				Vector3 directionToBendPoint = GetDirectionToBendPoint(vector, magnitude, bendDirection, sqrMagnitude, sqrMagnitude2);
				Quaternion quaternion = Quaternion.FromToRotation(bone2.position - bone1.position, directionToBendPoint);
				if (weight < 1f)
				{
					quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, weight);
				}
				bone1.rotation = quaternion * bone1.rotation;
				Quaternion quaternion2 = Quaternion.FromToRotation(bone3.position - bone2.position, targetPosition - bone2.position);
				if (weight < 1f)
				{
					quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, weight);
				}
				bone2.rotation = quaternion2 * bone2.rotation;
			}
		}

		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			float num = (directionMag * directionMag + (sqrMag1 - sqrMag2)) / 2f / directionMag;
			float y = (float)Math.Sqrt(Mathf.Clamp(sqrMag1 - num * num, 0f, float.PositiveInfinity));
			if (direction == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(direction, bendDirection) * new Vector3(0f, y, num);
		}

		protected override void OnInitiate()
		{
			if (bendNormal == Vector3.zero)
			{
				bendNormal = Vector3.right;
			}
			OnInitiateVirtual();
			IKPosition = bone3.transform.position;
			IKRotation = bone3.transform.rotation;
			InitiateBones();
			directHierarchy = IsDirectHierarchy();
		}

		private bool IsDirectHierarchy()
		{
			if (bone3.transform.parent != bone2.transform)
			{
				return false;
			}
			if (bone2.transform.parent != bone1.transform)
			{
				return false;
			}
			return true;
		}

		private void InitiateBones()
		{
			bone1.Initiate(bone2.transform.position, bendNormal);
			bone2.Initiate(bone3.transform.position, bendNormal);
			SetBendPlaneToCurrent();
		}

		protected override void OnUpdate()
		{
			IKPositionWeight = Mathf.Clamp(IKPositionWeight, 0f, 1f);
			IKRotationWeight = Mathf.Clamp(IKRotationWeight, 0f, 1f);
			if (target != null)
			{
				IKPosition = target.position;
				IKRotation = target.rotation;
			}
			OnUpdateVirtual();
			if (IKPositionWeight > 0f)
			{
				if (!directHierarchy)
				{
					bone1.Initiate(bone2.transform.position, bendNormal);
					bone2.Initiate(bone3.transform.position, bendNormal);
				}
				bone1.sqrMag = (bone2.transform.position - bone1.transform.position).sqrMagnitude;
				bone2.sqrMag = (bone3.transform.position - bone2.transform.position).sqrMagnitude;
				if (bendNormal == Vector3.zero && !Warning.logged)
				{
					LogWarning("IKSolverTrigonometric Bend Normal is Vector3.zero.");
				}
				weightIKPosition = Vector3.Lerp(bone3.transform.position, IKPosition, IKPositionWeight);
				Vector3 vector = Vector3.Lerp(bone1.GetBendNormalFromCurrentRotation(), bendNormal, IKPositionWeight);
				Vector3 vector2 = Vector3.Lerp(bone2.transform.position - bone1.transform.position, GetBendDirection(weightIKPosition, vector), IKPositionWeight);
				if (vector2 == Vector3.zero)
				{
					vector2 = bone2.transform.position - bone1.transform.position;
				}
				bone1.transform.rotation = bone1.GetRotation(vector2, vector);
				bone2.transform.rotation = bone2.GetRotation(weightIKPosition - bone2.transform.position, bone2.GetBendNormalFromCurrentRotation());
			}
			if (IKRotationWeight > 0f)
			{
				bone3.transform.rotation = Quaternion.Slerp(bone3.transform.rotation, IKRotation, IKRotationWeight);
			}
			OnPostSolveVirtual();
		}

		protected virtual void OnInitiateVirtual()
		{
		}

		protected virtual void OnUpdateVirtual()
		{
		}

		protected virtual void OnPostSolveVirtual()
		{
		}

		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			Vector3 vector = IKPosition - bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt(sqrMagnitude);
			float num2 = (sqrMagnitude + bone1.sqrMag - bone2.sqrMag) / 2f / num;
			float y = (float)Math.Sqrt(Mathf.Clamp(bone1.sqrMag - num2 * num2, 0f, float.PositiveInfinity));
			Vector3 upwards = Vector3.Cross(vector, bendNormal);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(0f, y, num2);
		}
	}
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		public class Arm : BodyPart
		{
			[Serializable]
			public enum ShoulderRotationMode
			{
				YawPitch,
				FromTo
			}

			[Tooltip("The hand target")]
			public Transform target;

			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Tooltip("Positional weight of the hand target.")]
			[Range(0f, 1f)]
			public float positionWeight = 1f;

			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight = 1f;

			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight = 1f;

			[Tooltip("The weight of twisting the shoulders back when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight = 1f;

			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis = Vector3.zero;

			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis = Vector3.zero;

			[Tooltip("Use this to make the arm shorter/longer.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp = 1f;

			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve = new AnimationCurve();

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Vector3 bendDirection = Vector3.back;

			[NonSerialized]
			[HideInInspector]
			public Vector3 handPositionOffset;

			private bool hasShoulder;

			private Vector3 chestForwardAxis;

			private Vector3 chestUpAxis;

			private Quaternion chestRotation = Quaternion.identity;

			private Vector3 chestForward;

			private Vector3 chestUp;

			private Quaternion forearmRelToUpperArm = Quaternion.identity;

			private const float yawOffsetAngle = 45f;

			private const float pitchOffsetAngle = -30f;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			private VirtualBone shoulder => bones[0];

			private VirtualBone upperArm => bones[hasShoulder ? 1 : 0];

			private VirtualBone forearm => bones[(!hasShoulder) ? 1 : 2];

			private VirtualBone hand => bones[hasShoulder ? 3 : 2];

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
				Vector3 vector = positions[index];
				Quaternion quaternion = rotations[index];
				Vector3 vector2 = positions[index + 1];
				Quaternion quaternion2 = rotations[index + 1];
				Vector3 vector3 = positions[index + 2];
				Quaternion quaternion3 = rotations[index + 2];
				Vector3 iKPosition = positions[index + 3];
				Quaternion iKRotation = rotations[index + 3];
				if (!initiated)
				{
					IKPosition = iKPosition;
					IKRotation = iKRotation;
					rotation = IKRotation;
					hasShoulder = hasShoulders;
					bones = new VirtualBone[hasShoulder ? 4 : 3];
					if (hasShoulder)
					{
						bones[0] = new VirtualBone(vector, quaternion);
						bones[1] = new VirtualBone(vector2, quaternion2);
						bones[2] = new VirtualBone(vector3, quaternion3);
						bones[3] = new VirtualBone(iKPosition, iKRotation);
					}
					else
					{
						bones[0] = new VirtualBone(vector2, quaternion2);
						bones[1] = new VirtualBone(vector3, quaternion3);
						bones[2] = new VirtualBone(iKPosition, iKRotation);
					}
					chestForwardAxis = Quaternion.Inverse(rootRotation) * (rotations[0] * Vector3.forward);
					chestUpAxis = Quaternion.Inverse(rootRotation) * (rotations[0] * Vector3.up);
				}
				if (hasShoulder)
				{
					bones[0].Read(vector, quaternion);
					bones[1].Read(vector2, quaternion2);
					bones[2].Read(vector3, quaternion3);
					bones[3].Read(iKPosition, iKRotation);
				}
				else
				{
					bones[0].Read(vector2, quaternion2);
					bones[1].Read(vector3, quaternion3);
					bones[2].Read(iKPosition, iKRotation);
				}
			}

			public override void PreSolve()
			{
				if (target != null)
				{
					IKPosition = target.position;
					IKRotation = target.rotation;
				}
				position = V3Tools.Lerp(hand.solverPosition, IKPosition, positionWeight);
				rotation = QuaTools.Lerp(hand.solverRotation, IKRotation, rotationWeight);
				shoulder.axis = shoulder.axis.normalized;
				forearmRelToUpperArm = Quaternion.Inverse(upperArm.solverRotation) * forearm.solverRotation;
			}

			public override void ApplyOffsets()
			{
				position += handPositionOffset;
			}

			private void Stretching()
			{
				float num = upperArm.length + forearm.length;
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				if (armLengthMlp != 1f)
				{
					num *= armLengthMlp;
					zero = (forearm.solverPosition - upperArm.solverPosition) * (armLengthMlp - 1f);
					zero2 = (hand.solverPosition - forearm.solverPosition) * (armLengthMlp - 1f);
					forearm.solverPosition += zero;
					hand.solverPosition += zero + zero2;
				}
				float time = Vector3.Distance(upperArm.solverPosition, position) / num;
				float num2 = stretchCurve.Evaluate(time);
				num2 *= positionWeight;
				zero = (forearm.solverPosition - upperArm.solverPosition) * num2;
				zero2 = (hand.solverPosition - forearm.solverPosition) * num2;
				forearm.solverPosition += zero;
				hand.solverPosition += zero + zero2;
			}

			public void Solve(bool isLeft)
			{
				chestRotation = Quaternion.LookRotation(rootRotation * chestForwardAxis, rootRotation * chestUpAxis);
				chestForward = chestRotation * Vector3.forward;
				chestUp = chestRotation * Vector3.up;
				if (hasShoulder && shoulderRotationWeight > 0f)
				{
					switch (shoulderRotationMode)
					{
					case ShoulderRotationMode.YawPitch:
					{
						Vector3 normalized = (position - shoulder.solverPosition).normalized;
						float num3 = (isLeft ? 45f : (-45f));
						Quaternion quaternion2 = Quaternion.AngleAxis((isLeft ? (-90f) : 90f) + num3, chestUp) * chestRotation;
						Vector3 lhs = Quaternion.Inverse(quaternion2) * normalized;
						float num4 = Mathf.Atan2(lhs.x, lhs.z) * 57.29578f;
						float f = Vector3.Dot(lhs, Vector3.up);
						f = 1f - Mathf.Abs(f);
						num4 *= f;
						num4 -= num3;
						float num5 = (isLeft ? (-20f) : (-50f));
						float num6 = (isLeft ? 50f : 20f);
						num4 = DamperValue(num4, num5 - num3, num6 - num3, 0.7f);
						Vector3 fromDirection = shoulder.solverRotation * shoulder.axis;
						Vector3 toDirection = quaternion2 * (Quaternion.AngleAxis(num4, Vector3.up) * Vector3.forward);
						Quaternion quaternion3 = Quaternion.FromToRotation(fromDirection, toDirection);
						quaternion2 = Quaternion.AngleAxis(isLeft ? (-90f) : 90f, chestUp) * chestRotation;
						quaternion2 = Quaternion.AngleAxis(isLeft ? (-30f) : 30f, chestForward) * quaternion2;
						normalized = position - (shoulder.solverPosition + chestRotation * (isLeft ? Vector3.right : Vector3.left) * base.mag);
						lhs = Quaternion.Inverse(quaternion2) * normalized;
						float num7 = Mathf.Atan2(lhs.y, lhs.z) * 57.29578f;
						num7 -= -30f;
						num7 = DamperValue(num7, -15f, 75f);
						Quaternion b2 = Quaternion.AngleAxis(0f - num7, quaternion2 * Vector3.right) * quaternion3;
						if (shoulderRotationWeight * positionWeight < 1f)
						{
							b2 = Quaternion.Lerp(Quaternion.identity, b2, shoulderRotationWeight * positionWeight);
						}
						VirtualBone.RotateBy(bones, b2);
						Stretching();
						VirtualBone.SolveTrigonometric(bones, 1, 2, 3, position, GetBendNormal(position - upperArm.solverPosition), positionWeight);
						float angle = Mathf.Clamp(num7 * positionWeight * shoulderRotationWeight * shoulderTwistWeight * 2f, 0f, 180f);
						shoulder.solverRotation = Quaternion.AngleAxis(angle, shoulder.solverRotation * (isLeft ? shoulder.axis : (-shoulder.axis))) * shoulder.solverRotation;
						upperArm.solverRotation = Quaternion.AngleAxis(angle, upperArm.solverRotation * (isLeft ? upperArm.axis : (-upperArm.axis))) * upperArm.solverRotation;
						break;
					}
					case ShoulderRotationMode.FromTo:
					{
						Quaternion solverRotation = shoulder.solverRotation;
						Quaternion b = Quaternion.FromToRotation((upperArm.solverPosition - shoulder.solverPosition).normalized + chestForward, position - shoulder.solverPosition);
						b = Quaternion.Slerp(Quaternion.identity, b, 0.5f * shoulderRotationWeight * positionWeight);
						VirtualBone.RotateBy(bones, b);
						Stretching();
						VirtualBone.SolveTrigonometric(bones, 0, 2, 3, position, Vector3.Cross(forearm.solverPosition - shoulder.solverPosition, hand.solverPosition - shoulder.solverPosition), 0.5f * shoulderRotationWeight * positionWeight);
						VirtualBone.SolveTrigonometric(bones, 1, 2, 3, position, GetBendNormal(position - upperArm.solverPosition), positionWeight);
						Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(chestUp, chestForward));
						Vector3 vector = quaternion * (solverRotation * shoulder.axis);
						Vector3 vector2 = quaternion * (shoulder.solverRotation * shoulder.axis);
						float current = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
						float num = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f;
						float num2 = Mathf.DeltaAngle(current, num);
						if (isLeft)
						{
							num2 = 0f - num2;
						}
						num2 = Mathf.Clamp(num2 * shoulderRotationWeight * shoulderTwistWeight * 2f * positionWeight, 0f, 180f);
						shoulder.solverRotation = Quaternion.AngleAxis(num2, shoulder.solverRotation * (isLeft ? shoulder.axis : (-shoulder.axis))) * shoulder.solverRotation;
						upperArm.solverRotation = Quaternion.AngleAxis(num2, upperArm.solverRotation * (isLeft ? upperArm.axis : (-upperArm.axis))) * upperArm.solverRotation;
						break;
					}
					}
				}
				else
				{
					Stretching();
					if (hasShoulder)
					{
						VirtualBone.SolveTrigonometric(bones, 1, 2, 3, position, GetBendNormal(position - upperArm.solverPosition), positionWeight);
					}
					else
					{
						VirtualBone.SolveTrigonometric(bones, 0, 1, 2, position, GetBendNormal(position - upperArm.solverPosition), positionWeight);
					}
				}
				Quaternion quaternion4 = upperArm.solverRotation * forearmRelToUpperArm;
				Quaternion quaternion5 = Quaternion.FromToRotation(quaternion4 * forearm.axis, hand.solverPosition - forearm.solverPosition);
				RotateTo(forearm, quaternion5 * quaternion4, positionWeight);
				if (rotationWeight >= 1f)
				{
					hand.solverRotation = rotation;
				}
				else if (rotationWeight > 0f)
				{
					hand.solverRotation = Quaternion.Lerp(hand.solverRotation, rotation, rotationWeight);
				}
			}

			public override void ResetOffsets()
			{
				handPositionOffset = Vector3.zero;
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
				if (hasShoulder)
				{
					solvedPositions[index] = shoulder.solverPosition;
					solvedRotations[index] = shoulder.solverRotation;
				}
				solvedPositions[index + 1] = upperArm.solverPosition;
				solvedPositions[index + 2] = forearm.solverPosition;
				solvedPositions[index + 3] = hand.solverPosition;
				solvedRotations[index + 1] = upperArm.solverRotation;
				solvedRotations[index + 2] = forearm.solverRotation;
				solvedRotations[index + 3] = hand.solverRotation;
			}

			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				float num = max - min;
				if (weight < 1f)
				{
					float num2 = max - num * 0.5f;
					float num3 = value - num2;
					num3 *= 0.5f;
					value = num2 + num3;
				}
				value -= min;
				float t = Interp.Float(Mathf.Clamp(value / num, 0f, 1f), InterpolationMode.InOutQuintic);
				return Mathf.Lerp(min, max, t);
			}

			private Vector3 GetBendNormal(Vector3 dir)
			{
				if (bendGoal != null)
				{
					bendDirection = bendGoal.position - bones[1].solverPosition;
				}
				Vector3 vector = bones[0].solverRotation * bones[0].axis;
				Vector3 down = Vector3.down;
				Vector3 toDirection = Quaternion.Inverse(chestRotation) * dir.normalized + Vector3.forward;
				Vector3 vector2 = Quaternion.FromToRotation(down, toDirection) * Vector3.back;
				Vector3 fromDirection = Quaternion.Inverse(chestRotation) * vector;
				toDirection = Quaternion.Inverse(chestRotation) * dir;
				vector2 = Quaternion.FromToRotation(fromDirection, toDirection) * vector2;
				vector2 = chestRotation * vector2;
				vector2 += vector;
				vector2 -= rotation * wristToPalmAxis;
				vector2 -= rotation * palmToThumbAxis * 0.5f;
				if (bendGoalWeight > 0f)
				{
					vector2 = Vector3.Slerp(vector2, bendDirection, bendGoalWeight);
				}
				if (swivelOffset != 0f)
				{
					vector2 = Quaternion.AngleAxis(swivelOffset, -dir) * vector2;
				}
				return Vector3.Cross(vector2, dir);
			}

			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
				UnityEngine.Debug.DrawLine(bone1.solverPosition, bone2.solverPosition, color);
				UnityEngine.Debug.DrawLine(bone2.solverPosition, bone3.solverPosition, color);
			}
		}

		[Serializable]
		public abstract class BodyPart
		{
			[HideInInspector]
			public VirtualBone[] bones = new VirtualBone[0];

			protected bool initiated;

			protected Vector3 rootPosition;

			protected Quaternion rootRotation = Quaternion.identity;

			protected int index = -1;

			public float sqrMag { get; private set; }

			public float mag { get; private set; }

			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			public abstract void PreSolve();

			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			public abstract void ApplyOffsets();

			public abstract void ResetOffsets();

			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
				this.index = index;
				rootPosition = positions[rootIndex];
				rootRotation = rotations[rootIndex];
				OnRead(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, rootIndex, index);
				mag = VirtualBone.PreSolve(ref bones);
				sqrMag = mag * mag;
				initiated = true;
			}

			public void MovePosition(Vector3 position)
			{
				Vector3 vector = position - bones[0].solverPosition;
				VirtualBone[] array = bones;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].solverPosition += vector;
				}
			}

			public void MoveRotation(Quaternion rotation)
			{
				Quaternion rotation2 = QuaTools.FromToRotation(bones[0].solverRotation, rotation);
				VirtualBone.RotateAroundPoint(bones, 0, bones[0].solverPosition, rotation2);
			}

			public void Translate(Vector3 position, Quaternion rotation)
			{
				MovePosition(position);
				MoveRotation(rotation);
			}

			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
				Vector3 vector = newRootPos - rootPosition;
				rootPosition = newRootPos;
				VirtualBone[] array = bones;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].solverPosition += vector;
				}
				Quaternion rotation = QuaTools.FromToRotation(rootRotation, newRootRot);
				rootRotation = newRootRot;
				VirtualBone.RotateAroundPoint(bones, 0, newRootPos, rotation);
			}

			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
				if (weight <= 0f)
				{
					return;
				}
				Quaternion quaternion = QuaTools.FromToRotation(bone.solverRotation, rotation);
				if (weight < 1f)
				{
					quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, weight);
				}
				for (int i = 0; i < bones.Length; i++)
				{
					if (bones[i] == bone)
					{
						VirtualBone.RotateAroundPoint(bones, i, bones[i].solverPosition, quaternion);
						break;
					}
				}
			}

			public void Visualize(Color color)
			{
				for (int i = 0; i < bones.Length - 1; i++)
				{
					UnityEngine.Debug.DrawLine(bones[i].solverPosition, bones[i + 1].solverPosition, color);
				}
			}

			public void Visualize()
			{
				Visualize(Color.white);
			}
		}

		[Serializable]
		public class Footstep
		{
			public float stepSpeed = 3f;

			public Vector3 characterSpaceOffset;

			public Vector3 position;

			public Quaternion rotation = Quaternion.identity;

			public Quaternion stepToRootRot = Quaternion.identity;

			public bool isSupportLeg;

			public Vector3 stepFrom;

			public Vector3 stepTo;

			public Quaternion stepFromRot = Quaternion.identity;

			public Quaternion stepToRot = Quaternion.identity;

			private Quaternion footRelativeToRoot = Quaternion.identity;

			private float supportLegW;

			private float supportLegWV;

			public bool isStepping => stepProgress < 1f;

			public float stepProgress { get; private set; }

			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
				this.characterSpaceOffset = characterSpaceOffset;
				Reset(rootRotation, footPosition, footRotation);
				footRelativeToRoot = Quaternion.Inverse(rootRotation) * rotation;
			}

			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
				position = footPosition;
				rotation = footRotation;
				stepFrom = position;
				stepTo = position;
				stepFromRot = rotation;
				stepToRot = rotation;
				stepToRootRot = rootRotation;
				stepProgress = 1f;
			}

			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
				stepFrom = position;
				stepTo = p;
				stepFromRot = rotation;
				stepToRootRot = rootRotation;
				stepToRot = rootRotation * footRelativeToRoot;
				stepProgress = 0f;
			}

			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
				stepTo = Vector3.Lerp(stepTo, p, Time.deltaTime * speed);
				stepToRot = Quaternion.Lerp(stepToRot, rootRotation * footRelativeToRoot, Time.deltaTime * speed);
				stepToRootRot = stepToRot * Quaternion.Inverse(footRelativeToRoot);
			}

			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
				if (!(speed <= 0f) && !(minAngle >= 180f))
				{
					Quaternion quaternion = rootRotation * footRelativeToRoot;
					float num = Quaternion.Angle(rotation, quaternion);
					if (num > minAngle)
					{
						rotation = Quaternion.RotateTowards(rotation, quaternion, Mathf.Min(Time.deltaTime * speed * (1f - supportLegW), num - minAngle));
					}
				}
			}

			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
				float target = (isSupportLeg ? 1f : 0f);
				supportLegW = Mathf.SmoothDamp(supportLegW, target, ref supportLegWV, 0.2f);
				if (isStepping)
				{
					stepProgress = Mathf.MoveTowards(stepProgress, 1f, Time.deltaTime * stepSpeed);
					if (stepProgress >= 1f)
					{
						onStep.Invoke();
					}
					float t = Interp.Float(stepProgress, interpolation);
					position = Vector3.Lerp(stepFrom, stepTo, t);
					rotation = Quaternion.Lerp(stepFromRot, stepToRot, t);
				}
			}
		}

		[Serializable]
		public class Leg : BodyPart
		{
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Tooltip("Positional weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Tooltip("Rotational weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Tooltip("Angular offset of the knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight = 0.5f;

			[Tooltip("Use this to make the leg shorter/longer.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp = 1f;

			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length).")]
			public AnimationCurve stretchCurve = new AnimationCurve();

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion footRotationOffset = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public float currentMag;

			private Vector3 footPosition;

			private Quaternion footRotation = Quaternion.identity;

			private Vector3 bendNormal;

			private Quaternion calfRelToThigh = Quaternion.identity;

			private Quaternion thighRelToFoot = Quaternion.identity;

			private Vector3 bendNormalRelToPelvis;

			private Vector3 bendNormalRelToTarget;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			public bool hasToes { get; private set; }

			public VirtualBone thigh => bones[0];

			private VirtualBone calf => bones[1];

			private VirtualBone foot => bones[2];

			private VirtualBone toes => bones[3];

			public VirtualBone lastBone => bones[bones.Length - 1];

			public Vector3 thighRelativeToPelvis { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
				Vector3 vector = positions[index];
				Quaternion quaternion = rotations[index];
				Vector3 vector2 = positions[index + 1];
				Quaternion quaternion2 = rotations[index + 1];
				Vector3 vector3 = positions[index + 2];
				Quaternion iKRotation = rotations[index + 2];
				Vector3 iKPosition = positions[index + 3];
				Quaternion iKRotation2 = rotations[index + 3];
				if (!initiated)
				{
					this.hasToes = hasToes;
					bones = new VirtualBone[hasToes ? 4 : 3];
					if (hasToes)
					{
						bones[0] = new VirtualBone(vector, quaternion);
						bones[1] = new VirtualBone(vector2, quaternion2);
						bones[2] = new VirtualBone(vector3, iKRotation);
						bones[3] = new VirtualBone(iKPosition, iKRotation2);
						IKPosition = iKPosition;
						IKRotation = iKRotation2;
					}
					else
					{
						bones[0] = new VirtualBone(vector, quaternion);
						bones[1] = new VirtualBone(vector2, quaternion2);
						bones[2] = new VirtualBone(vector3, iKRotation);
						IKPosition = vector3;
						IKRotation = iKRotation;
					}
					bendNormal = Vector3.Cross(vector2 - vector, vector3 - vector2);
					bendNormalRelToPelvis = Quaternion.Inverse(rootRotation) * bendNormal;
					bendNormalRelToTarget = Quaternion.Inverse(IKRotation) * bendNormal;
					rotation = IKRotation;
				}
				if (hasToes)
				{
					bones[0].Read(vector, quaternion);
					bones[1].Read(vector2, quaternion2);
					bones[2].Read(vector3, iKRotation);
					bones[3].Read(iKPosition, iKRotation2);
				}
				else
				{
					bones[0].Read(vector, quaternion);
					bones[1].Read(vector2, quaternion2);
					bones[2].Read(vector3, iKRotation);
				}
			}

			public override void PreSolve()
			{
				if (target != null)
				{
					IKPosition = target.position;
					IKRotation = target.rotation;
				}
				footPosition = foot.solverPosition;
				footRotation = foot.solverRotation;
				position = lastBone.solverPosition;
				rotation = lastBone.solverRotation;
				if (rotationWeight > 0f)
				{
					ApplyRotationOffset(QuaTools.FromToRotation(rotation, IKRotation), rotationWeight);
				}
				if (positionWeight > 0f)
				{
					ApplyPositionOffset(IKPosition - position, positionWeight);
				}
				thighRelativeToPelvis = Quaternion.Inverse(rootRotation) * (thigh.solverPosition - rootPosition);
				calfRelToThigh = Quaternion.Inverse(thigh.solverRotation) * calf.solverRotation;
				thighRelToFoot = Quaternion.Inverse(lastBone.solverRotation) * thigh.solverRotation;
				if (bendToTargetWeight <= 0f)
				{
					bendNormal = rootRotation * bendNormalRelToPelvis;
				}
				else if (bendToTargetWeight >= 1f)
				{
					bendNormal = rotation * bendNormalRelToTarget;
				}
				else
				{
					bendNormal = Vector3.Slerp(rootRotation * bendNormalRelToPelvis, rotation * bendNormalRelToTarget, bendToTargetWeight);
				}
			}

			public override void ApplyOffsets()
			{
				ApplyPositionOffset(footPositionOffset, 1f);
				ApplyRotationOffset(footRotationOffset, 1f);
				Quaternion quaternion = Quaternion.FromToRotation(footPosition - position, footPosition + heelPositionOffset - position);
				footPosition = position + quaternion * (footPosition - position);
				footRotation = quaternion * footRotation;
				float num = 0f;
				if (bendGoal != null && bendGoalWeight > 0f)
				{
					Vector3 vector = Vector3.Cross(bendGoal.position - thigh.solverPosition, position - thigh.solverPosition);
					Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(bendNormal, thigh.solverPosition - foot.solverPosition)) * vector;
					num = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f * bendGoalWeight;
				}
				float num2 = swivelOffset + num;
				if (num2 != 0f)
				{
					bendNormal = Quaternion.AngleAxis(num2, thigh.solverPosition - lastBone.solverPosition) * bendNormal;
					thigh.solverRotation = Quaternion.AngleAxis(0f - num2, thigh.solverRotation * thigh.axis) * thigh.solverRotation;
				}
			}

			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
				if (!(weight <= 0f))
				{
					offset *= weight;
					footPosition += offset;
					position += offset;
				}
			}

			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
				if (!(weight <= 0f))
				{
					if (weight < 1f)
					{
						offset = Quaternion.Lerp(Quaternion.identity, offset, weight);
					}
					footRotation = offset * footRotation;
					rotation = offset * rotation;
					bendNormal = offset * bendNormal;
					footPosition = position + offset * (footPosition - position);
				}
			}

			public void Solve(bool stretch)
			{
				if (stretch)
				{
					Stretching();
				}
				VirtualBone.SolveTrigonometric(bones, 0, 1, 2, footPosition, bendNormal, 1f);
				RotateTo(foot, footRotation);
				if (!hasToes)
				{
					return;
				}
				Vector3 vector = Vector3.Cross(foot.solverPosition - thigh.solverPosition, toes.solverPosition - foot.solverPosition);
				VirtualBone.SolveTrigonometric(bones, 0, 2, 3, position, vector, 1f);
				if (bendToTargetWeight > 0f)
				{
					Quaternion quaternion = rotation * thighRelToFoot;
					Quaternion quaternion2 = Quaternion.FromToRotation(quaternion * thigh.axis, calf.solverPosition - thigh.solverPosition);
					if (bendToTargetWeight < 1f)
					{
						thigh.solverRotation = Quaternion.Slerp(thigh.solverRotation, quaternion2 * quaternion, bendToTargetWeight);
					}
					else
					{
						thigh.solverRotation = quaternion2 * quaternion;
					}
				}
				Quaternion quaternion3 = thigh.solverRotation * calfRelToThigh;
				Quaternion quaternion4 = Quaternion.FromToRotation(quaternion3 * calf.axis, foot.solverPosition - calf.solverPosition);
				calf.solverRotation = quaternion4 * quaternion3;
				toes.solverRotation = rotation;
			}

			private void Stretching()
			{
				float num = thigh.length + calf.length;
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				if (legLengthMlp != 1f)
				{
					num *= legLengthMlp;
					zero = (calf.solverPosition - thigh.solverPosition) * (legLengthMlp - 1f);
					zero2 = (foot.solverPosition - calf.solverPosition) * (legLengthMlp - 1f);
					calf.solverPosition += zero;
					foot.solverPosition += zero + zero2;
					if (hasToes)
					{
						toes.solverPosition += zero + zero2;
					}
				}
				float time = Vector3.Distance(thigh.solverPosition, footPosition) / num;
				float num2 = stretchCurve.Evaluate(time);
				zero = (calf.solverPosition - thigh.solverPosition) * num2;
				zero2 = (foot.solverPosition - calf.solverPosition) * num2;
				calf.solverPosition += zero;
				foot.solverPosition += zero + zero2;
				if (hasToes)
				{
					toes.solverPosition += zero + zero2;
				}
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
				solvedRotations[index] = thigh.solverRotation;
				solvedRotations[index + 1] = calf.solverRotation;
				solvedRotations[index + 2] = foot.solverRotation;
				solvedPositions[index] = thigh.solverPosition;
				solvedPositions[index + 1] = calf.solverPosition;
				solvedPositions[index + 2] = foot.solverPosition;
				if (hasToes)
				{
					solvedRotations[index + 3] = toes.solverRotation;
					solvedPositions[index + 3] = toes.solverPosition;
				}
			}

			public override void ResetOffsets()
			{
				footPositionOffset = Vector3.zero;
				footRotationOffset = Quaternion.identity;
				heelPositionOffset = Vector3.zero;
			}
		}

		[Serializable]
		public class Locomotion
		{
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight = 1f;

			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance = 0.3f;

			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold = 0.4f;

			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold = 60f;

			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp = 1f;

			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity = 0.4f;

			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor = 0.4f;

			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch = 1f;

			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed = 20f;

			[Tooltip("The speed of steps.")]
			public float stepSpeed = 3f;

			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle = 20f;

			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed = 400f;

			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation = InterpolationMode.InOutSine;

			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[HideInInspector]
			public bool blockingEnabled;

			[HideInInspector]
			public LayerMask blockingLayers;

			[HideInInspector]
			public float raycastRadius = 0.2f;

			[HideInInspector]
			public float raycastHeight = 0.2f;

			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep = new UnityEvent();

			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep = new UnityEvent();

			private Footstep[] footsteps = new Footstep[0];

			private Vector3 lastComPosition;

			private Vector3 comVelocity;

			private int leftFootIndex;

			private int rightFootIndex;

			public Vector3 centerOfMass { get; private set; }

			public Vector3 leftFootstepPosition => footsteps[0].position;

			public Vector3 rightFootstepPosition => footsteps[1].position;

			public Quaternion leftFootstepRotation => footsteps[0].rotation;

			public Quaternion rightFootstepRotation => footsteps[1].rotation;

			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
				leftFootIndex = (hasToes ? 17 : 16);
				rightFootIndex = (hasToes ? 21 : 20);
				footsteps = new Footstep[2]
				{
					new Footstep(rotations[0], positions[leftFootIndex], rotations[leftFootIndex], footDistance * Vector3.left),
					new Footstep(rotations[0], positions[rightFootIndex], rotations[rightFootIndex], footDistance * Vector3.right)
				};
			}

			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
				lastComPosition = Vector3.Lerp(positions[1], positions[5], 0.25f) + rotations[0] * offset;
				comVelocity = Vector3.zero;
				footsteps[0].Reset(rotations[0], positions[leftFootIndex], rotations[leftFootIndex]);
				footsteps[1].Reset(rotations[0], positions[rightFootIndex], rotations[rightFootIndex]);
			}

			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
				Vector3 vector = lastComPosition - pivot;
				lastComPosition = pivot + delta * vector;
				Footstep[] array = footsteps;
				foreach (Footstep footstep in array)
				{
					footstep.rotation = delta * footstep.rotation;
					footstep.stepFromRot = delta * footstep.stepFromRot;
					footstep.stepToRot = delta * footstep.stepToRot;
					footstep.stepToRootRot = delta * footstep.stepToRootRot;
					Vector3 vector2 = footstep.position - pivot;
					footstep.position = pivot + delta * vector2;
					Vector3 vector3 = footstep.stepFrom - pivot;
					footstep.stepFrom = pivot + delta * vector3;
					Vector3 vector4 = footstep.stepTo - pivot;
					footstep.stepTo = pivot + delta * vector4;
				}
			}

			public void AddDeltaPosition(Vector3 delta)
			{
				lastComPosition += delta;
				Footstep[] array = footsteps;
				foreach (Footstep obj in array)
				{
					obj.position += delta;
					obj.stepFrom += delta;
					obj.stepTo += delta;
				}
			}

			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
				if (weight <= 0f)
				{
					leftFootPosition = Vector3.zero;
					rightFootPosition = Vector3.zero;
					leftFootRotation = Quaternion.identity;
					rightFootRotation = Quaternion.identity;
					leftFootOffset = 0f;
					rightFootOffset = 0f;
					leftHeelOffset = 0f;
					rightHeelOffset = 0f;
					return;
				}
				Vector3 vector = rootBone.solverRotation * Vector3.up;
				Vector3 vector2 = spine.pelvis.solverPosition + spine.pelvis.solverRotation * leftLeg.thighRelativeToPelvis;
				Vector3 vector3 = spine.pelvis.solverPosition + spine.pelvis.solverRotation * rightLeg.thighRelativeToPelvis;
				footsteps[0].characterSpaceOffset = footDistance * Vector3.left;
				footsteps[1].characterSpaceOffset = footDistance * Vector3.right;
				Vector3 faceDirection = spine.faceDirection;
				Vector3 vector4 = V3Tools.ExtractVertical(faceDirection, vector, 1f);
				Quaternion quaternion = Quaternion.LookRotation(faceDirection - vector4, vector);
				float num = 1f;
				float num2 = 1f;
				float num3 = 0.2f;
				float num4 = num + num2 + 2f * num3;
				centerOfMass = Vector3.zero;
				centerOfMass += spine.pelvis.solverPosition * num;
				centerOfMass += spine.head.solverPosition * num2;
				centerOfMass += leftArm.position * num3;
				centerOfMass += rightArm.position * num3;
				centerOfMass /= num4;
				centerOfMass += rootBone.solverRotation * offset;
				comVelocity = ((Time.deltaTime > 0f) ? ((centerOfMass - lastComPosition) / Time.deltaTime) : Vector3.zero);
				lastComPosition = centerOfMass;
				comVelocity = Vector3.ClampMagnitude(comVelocity, maxVelocity) * velocityFactor;
				Vector3 vector5 = centerOfMass + comVelocity;
				Vector3 vector6 = V3Tools.PointToPlane(spine.pelvis.solverPosition, rootBone.solverPosition, vector);
				Vector3 vector7 = V3Tools.PointToPlane(vector5, rootBone.solverPosition, vector);
				Vector3 vector8 = Vector3.Lerp(footsteps[0].position, footsteps[1].position, 0.5f);
				float num5 = Vector3.Angle(vector5 - vector8, rootBone.solverRotation * Vector3.up) * comAngleMlp;
				for (int i = 0; i < footsteps.Length; i++)
				{
					footsteps[i].isSupportLeg = supportLegIndex == i;
				}
				for (int j = 0; j < footsteps.Length; j++)
				{
					if (footsteps[j].isStepping)
					{
						Vector3 vector9 = vector7 + rootBone.solverRotation * footsteps[j].characterSpaceOffset;
						if (!StepBlocked(footsteps[j].stepFrom, vector9, rootBone.solverPosition))
						{
							footsteps[j].UpdateStepping(vector9, quaternion, 10f);
						}
					}
					else
					{
						footsteps[j].UpdateStanding(quaternion, relaxLegTwistMinAngle, relaxLegTwistSpeed);
					}
				}
				if (CanStep())
				{
					int num6 = -1;
					float num7 = float.NegativeInfinity;
					for (int k = 0; k < footsteps.Length; k++)
					{
						if (footsteps[k].isStepping)
						{
							continue;
						}
						Vector3 vector10 = vector7 + rootBone.solverRotation * footsteps[k].characterSpaceOffset;
						float num8 = ((k == 0) ? leftLeg.mag : rightLeg.mag);
						Vector3 b = ((k == 0) ? vector2 : vector3);
						float num9 = Vector3.Distance(footsteps[k].position, b);
						bool flag = false;
						if (num9 >= num8 * maxLegStretch)
						{
							vector10 = vector6 + rootBone.solverRotation * footsteps[k].characterSpaceOffset;
							flag = true;
						}
						bool flag2 = false;
						for (int l = 0; l < footsteps.Length; l++)
						{
							if (l != k && !flag)
							{
								if (!(Vector3.Distance(footsteps[k].position, footsteps[l].position) < 0.25f) || !((footsteps[k].position - vector10).sqrMagnitude < (footsteps[l].position - vector10).sqrMagnitude))
								{
									flag2 = GetLineSphereCollision(footsteps[k].position, vector10, footsteps[l].position, 0.25f);
								}
								if (flag2)
								{
									break;
								}
							}
						}
						float num10 = Quaternion.Angle(quaternion, footsteps[k].stepToRootRot);
						if (flag2 && !(num10 > angleThreshold))
						{
							continue;
						}
						float num11 = Vector3.Distance(footsteps[k].position, vector10);
						float num12 = Mathf.Lerp(stepThreshold, stepThreshold * 0.1f, num5 * 0.015f);
						if (flag)
						{
							num12 *= 0.5f;
						}
						if (k == 0)
						{
							num12 *= 0.9f;
						}
						if (!StepBlocked(footsteps[k].position, vector10, rootBone.solverPosition) && (num11 > num12 || num10 > angleThreshold))
						{
							float num13 = 0f;
							num13 -= num11;
							if (num13 > num7)
							{
								num6 = k;
								num7 = num13;
							}
						}
					}
					if (num6 != -1)
					{
						Vector3 p = vector7 + rootBone.solverRotation * footsteps[num6].characterSpaceOffset;
						footsteps[num6].stepSpeed = UnityEngine.Random.Range(stepSpeed, stepSpeed * 1.5f);
						footsteps[num6].StepTo(p, quaternion);
					}
				}
				footsteps[0].Update(stepInterpolation, onLeftFootstep);
				footsteps[1].Update(stepInterpolation, onRightFootstep);
				leftFootPosition = footsteps[0].position;
				rightFootPosition = footsteps[1].position;
				leftFootPosition = V3Tools.PointToPlane(leftFootPosition, leftLeg.lastBone.readPosition, vector);
				rightFootPosition = V3Tools.PointToPlane(rightFootPosition, rightLeg.lastBone.readPosition, vector);
				leftFootOffset = stepHeight.Evaluate(footsteps[0].stepProgress);
				rightFootOffset = stepHeight.Evaluate(footsteps[1].stepProgress);
				leftHeelOffset = heelHeight.Evaluate(footsteps[0].stepProgress);
				rightHeelOffset = heelHeight.Evaluate(footsteps[1].stepProgress);
				leftFootRotation = footsteps[0].rotation;
				rightFootRotation = footsteps[1].rotation;
			}

			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				if ((int)blockingLayers == -1 || !blockingEnabled)
				{
					return false;
				}
				Vector3 vector = fromPosition;
				vector.y = rootPosition.y + raycastHeight + raycastRadius;
				Vector3 direction = toPosition - vector;
				direction.y = 0f;
				RaycastHit hitInfo;
				if (raycastRadius <= 0f)
				{
					return Physics.Raycast(vector, direction, out hitInfo, direction.magnitude, blockingLayers);
				}
				return Physics.SphereCast(vector, raycastRadius, direction, out hitInfo, direction.magnitude, blockingLayers);
			}

			private bool CanStep()
			{
				Footstep[] array = footsteps;
				foreach (Footstep footstep in array)
				{
					if (footstep.isStepping && footstep.stepProgress < 0.8f)
					{
						return false;
					}
				}
				return true;
			}

			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				Vector3 forward = lineEnd - lineStart;
				Vector3 vector = sphereCenter - lineStart;
				float num = vector.magnitude - sphereRadius;
				if (num > forward.magnitude)
				{
					return false;
				}
				Vector3 vector2 = Quaternion.Inverse(Quaternion.LookRotation(forward, vector)) * vector;
				if (vector2.z < 0f)
				{
					return num < 0f;
				}
				return vector2.y - sphereRadius < 0f;
			}
		}

		[Serializable]
		public class Spine : BodyPart
		{
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight = 1f;

			[Tooltip("Rotational weight of the head target.")]
			[Range(0f, 1f)]
			public float rotationWeight = 1f;

			[Tooltip("Positional weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Tooltip("Rotational weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Tooltip("Rotational weight of the chest target.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight = 0.8f;

			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness = 0.55f;

			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness = 0.1f;

			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness = 0.2f;

			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands = 1f;

			[Tooltip("Clamps chest rotation.")]
			[Range(0f, 1f)]
			public float chestClampWeight = 0.5f;

			[Tooltip("Clamps head rotation.")]
			[Range(0f, 1f)]
			public float headClampWeight = 0.6f;

			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching = 0.5f;

			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition = 0.2f;

			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle = 25f;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationHead = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationPelvis = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion pelvisRotationOffset = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Quaternion chestRotationOffset = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Quaternion headRotationOffset = Quaternion.identity;

			[NonSerialized]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPosition;

			private Quaternion headRotation = Quaternion.identity;

			private Quaternion pelvisRotation = Quaternion.identity;

			private Quaternion anchorRelativeToHead = Quaternion.identity;

			private Quaternion anchorRelativeToPelvis = Quaternion.identity;

			private Quaternion pelvisRelativeRotation = Quaternion.identity;

			private Quaternion chestRelativeRotation = Quaternion.identity;

			private Vector3 headDeltaPosition;

			private Quaternion pelvisDeltaRotation = Quaternion.identity;

			private Quaternion chestTargetRotation = Quaternion.identity;

			private int pelvisIndex;

			private int spineIndex = 1;

			private int chestIndex = -1;

			private int neckIndex = -1;

			private int headIndex = -1;

			private float length;

			private bool hasChest;

			private bool hasNeck;

			private bool hasLegs;

			private float headHeight;

			private float sizeMlp;

			private Vector3 chestForward;

			public VirtualBone pelvis => bones[pelvisIndex];

			public VirtualBone firstSpineBone => bones[spineIndex];

			public VirtualBone chest
			{
				get
				{
					if (hasChest)
					{
						return bones[chestIndex];
					}
					return bones[spineIndex];
				}
			}

			private VirtualBone neck => bones[neckIndex];

			public VirtualBone head => bones[headIndex];

			public Quaternion anchorRotation { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
				Vector3 vector = positions[index];
				Quaternion quaternion = rotations[index];
				Vector3 vector2 = positions[index + 1];
				Quaternion quaternion2 = rotations[index + 1];
				Vector3 vector3 = positions[index + 2];
				Quaternion quaternion3 = rotations[index + 2];
				Vector3 position = positions[index + 3];
				Quaternion rotation = rotations[index + 3];
				Vector3 vector4 = positions[index + 4];
				Quaternion quaternion4 = rotations[index + 4];
				this.hasLegs = hasLegs;
				if (!hasChest)
				{
					vector3 = vector2;
					quaternion3 = quaternion2;
				}
				if (!initiated)
				{
					this.hasChest = hasChest;
					this.hasNeck = hasNeck;
					headHeight = V3Tools.ExtractVertical(vector4 - positions[0], rotations[0] * Vector3.up, 1f).magnitude;
					int num = 3;
					if (hasChest)
					{
						num++;
					}
					if (hasNeck)
					{
						num++;
					}
					bones = new VirtualBone[num];
					chestIndex = ((!hasChest) ? 1 : 2);
					neckIndex = 1;
					if (hasChest)
					{
						neckIndex++;
					}
					if (hasNeck)
					{
						neckIndex++;
					}
					headIndex = 2;
					if (hasChest)
					{
						headIndex++;
					}
					if (hasNeck)
					{
						headIndex++;
					}
					bones[0] = new VirtualBone(vector, quaternion);
					bones[1] = new VirtualBone(vector2, quaternion2);
					if (hasChest)
					{
						bones[chestIndex] = new VirtualBone(vector3, quaternion3);
					}
					if (hasNeck)
					{
						bones[neckIndex] = new VirtualBone(position, rotation);
					}
					bones[headIndex] = new VirtualBone(vector4, quaternion4);
					pelvisRotationOffset = Quaternion.identity;
					chestRotationOffset = Quaternion.identity;
					headRotationOffset = Quaternion.identity;
					anchorRelativeToHead = Quaternion.Inverse(quaternion4) * rotations[0];
					anchorRelativeToPelvis = Quaternion.Inverse(quaternion) * rotations[0];
					pelvisRelativeRotation = Quaternion.Inverse(quaternion4) * quaternion;
					chestRelativeRotation = Quaternion.Inverse(quaternion4) * quaternion3;
					chestForward = Quaternion.Inverse(quaternion3) * (rotations[0] * Vector3.forward);
					faceDirection = rotations[0] * Vector3.forward;
					IKPositionHead = vector4;
					IKRotationHead = quaternion4;
					IKPositionPelvis = vector;
					IKRotationPelvis = quaternion;
					goalPositionChest = vector3 + rotations[0] * Vector3.forward;
				}
				bones[0].Read(vector, quaternion);
				bones[1].Read(vector2, quaternion2);
				if (hasChest)
				{
					bones[chestIndex].Read(vector3, quaternion3);
				}
				if (hasNeck)
				{
					bones[neckIndex].Read(position, rotation);
				}
				bones[headIndex].Read(vector4, quaternion4);
				float num2 = Vector3.Distance(vector, vector4);
				sizeMlp = num2 / 0.7f;
			}

			public override void PreSolve()
			{
				if (headTarget != null)
				{
					IKPositionHead = headTarget.position;
					IKRotationHead = headTarget.rotation;
				}
				if (chestGoal != null)
				{
					goalPositionChest = chestGoal.position;
				}
				if (pelvisTarget != null)
				{
					IKPositionPelvis = pelvisTarget.position;
					IKRotationPelvis = pelvisTarget.rotation;
				}
				headPosition = V3Tools.Lerp(head.solverPosition, IKPositionHead, positionWeight);
				headRotation = QuaTools.Lerp(head.solverRotation, IKRotationHead, rotationWeight);
				pelvisRotation = QuaTools.Lerp(pelvis.solverRotation, IKRotationPelvis, rotationWeight);
			}

			public override void ApplyOffsets()
			{
				headPosition += headPositionOffset;
				Vector3 vector = rootRotation * Vector3.up;
				if (vector == Vector3.up)
				{
					headPosition.y = Math.Max(rootPosition.y + minHeadHeight, headPosition.y);
				}
				else
				{
					Vector3 vector2 = headPosition - rootPosition;
					Vector3 vector3 = V3Tools.ExtractHorizontal(vector2, vector, 1f);
					Vector3 vector4 = vector2 - vector3;
					if (Vector3.Dot(vector4, vector) > 0f)
					{
						if (vector4.magnitude < minHeadHeight)
						{
							vector4 = vector4.normalized * minHeadHeight;
						}
					}
					else
					{
						vector4 = -vector4.normalized * minHeadHeight;
					}
					headPosition = rootPosition + vector3 + vector4;
				}
				headRotation = headRotationOffset * headRotation;
				headDeltaPosition = headPosition - head.solverPosition;
				pelvisDeltaRotation = QuaTools.FromToRotation(pelvis.solverRotation, headRotation * pelvisRelativeRotation);
				anchorRotation = ((pelvisTarget != null) ? (pelvisRotation * anchorRelativeToPelvis) : (headRotation * anchorRelativeToHead));
			}

			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
				chestTargetRotation = headRotation * chestRelativeRotation;
				AdjustChestByHands(ref chestTargetRotation, arms);
				faceDirection = Vector3.Cross(anchorRotation * Vector3.right, rootBone.readRotation * Vector3.up) + anchorRotation * Vector3.forward;
			}

			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
				CalculateChestTargetRotation(rootBone, arms);
				if (maxRootAngle < 180f)
				{
					Vector3 vector = Quaternion.Inverse(rootBone.solverRotation) * faceDirection;
					float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
					float angle = 0f;
					float num2 = maxRootAngle;
					if (num > num2)
					{
						angle = num - num2;
					}
					if (num < 0f - num2)
					{
						angle = num + num2;
					}
					rootBone.solverRotation = Quaternion.AngleAxis(angle, rootBone.readRotation * Vector3.up) * rootBone.solverRotation;
				}
				Vector3 solverPosition = pelvis.solverPosition;
				Vector3 rootUp = rootBone.solverRotation * Vector3.up;
				TranslatePelvis(legs, headDeltaPosition, pelvisDeltaRotation);
				FABRIKPass(solverPosition, rootUp);
				Bend(bones, pelvisIndex, chestIndex, chestTargetRotation, chestRotationOffset, chestClampWeight, uniformWeight: false, neckStiffness);
				if (chestGoalWeight > 0f)
				{
					Quaternion targetRotation = Quaternion.FromToRotation(bones[chestIndex].solverRotation * chestForward, goalPositionChest - bones[chestIndex].solverPosition) * bones[chestIndex].solverRotation;
					Bend(bones, pelvisIndex, chestIndex, targetRotation, chestRotationOffset, chestClampWeight, uniformWeight: false, chestGoalWeight);
				}
				InverseTranslateToHead(legs, limited: false, useCurrentLegMag: false, Vector3.zero, 1f);
				FABRIKPass(solverPosition, rootUp);
				Bend(bones, neckIndex, headIndex, headRotation, headClampWeight, uniformWeight: true, 1f);
				SolvePelvis();
			}

			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
				Vector3 startPosition = Vector3.Lerp(pelvis.solverPosition, animatedPelvisPos, maintainPelvisPosition) + pelvisPositionOffset;
				Vector3 targetPosition = headPosition - chestPositionOffset;
				Vector3 startOffset = bones[bones.Length - 1].solverPosition - bones[0].solverPosition;
				VirtualBone.SolveFABRIK(bones, startPosition, targetPosition, 1f, 1f, 1, base.mag, startOffset);
			}

			private void SolvePelvis()
			{
				if (pelvisPositionWeight > 0f)
				{
					Quaternion solverRotation = head.solverRotation;
					Vector3 vector = (IKPositionPelvis + pelvisPositionOffset - pelvis.solverPosition) * pelvisPositionWeight;
					VirtualBone[] array = bones;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].solverPosition += vector;
					}
					Vector3 bendNormal = anchorRotation * Vector3.right;
					if (hasChest && hasNeck)
					{
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, spineIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 0.6f);
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, chestIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 0.6f);
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, neckIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 1f);
					}
					else if (hasChest && !hasNeck)
					{
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, spineIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 0.75f);
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, chestIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 1f);
					}
					else if (!hasChest && hasNeck)
					{
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, spineIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 0.75f);
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, neckIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight * 1f);
					}
					else if (!hasNeck && !hasChest)
					{
						VirtualBone.SolveTrigonometric(bones, pelvisIndex, spineIndex, headIndex, headPosition, bendNormal, pelvisPositionWeight);
					}
					head.solverRotation = solverRotation;
				}
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
				solvedPositions[index] = bones[0].solverPosition;
				solvedRotations[index] = bones[0].solverRotation;
				solvedRotations[index + 1] = bones[1].solverRotation;
				if (hasChest)
				{
					solvedRotations[index + 2] = bones[chestIndex].solverRotation;
				}
				if (hasNeck)
				{
					solvedRotations[index + 3] = bones[neckIndex].solverRotation;
				}
				solvedRotations[index + 4] = bones[headIndex].solverRotation;
			}

			public override void ResetOffsets()
			{
				pelvisPositionOffset = Vector3.zero;
				chestPositionOffset = Vector3.zero;
				headPositionOffset = locomotionHeadPositionOffset;
				pelvisRotationOffset = Quaternion.identity;
				chestRotationOffset = Quaternion.identity;
				headRotationOffset = Quaternion.identity;
			}

			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
				Quaternion quaternion = Quaternion.Inverse(anchorRotation);
				Vector3 vector = quaternion * (arms[0].position - headPosition) / sizeMlp;
				Vector3 vector2 = quaternion * (arms[1].position - headPosition) / sizeMlp;
				Vector3 forward = Vector3.forward;
				forward.x += vector.x * Mathf.Abs(vector.x);
				forward.x += vector.z * Mathf.Abs(vector.z);
				forward.x += vector2.x * Mathf.Abs(vector2.x);
				forward.x -= vector2.z * Mathf.Abs(vector2.z);
				forward.x *= 5f * rotateChestByHands;
				Quaternion quaternion2 = Quaternion.AngleAxis(Mathf.Atan2(forward.x, forward.z) * 57.29578f, rootRotation * Vector3.up);
				chestTargetRotation = quaternion2 * chestTargetRotation;
				Vector3 up = Vector3.up;
				up.x += vector.y;
				up.x -= vector2.y;
				up.x *= 0.5f * rotateChestByHands;
				quaternion2 = Quaternion.AngleAxis(Mathf.Atan2(up.x, up.y) * 57.29578f, rootRotation * Vector3.back);
				chestTargetRotation = quaternion2 * chestTargetRotation;
			}

			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
				Vector3 vector = (headPosition + offset - head.solverPosition) * w;
				Vector3 vector2 = pelvis.solverPosition + vector;
				MovePosition(limited ? LimitPelvisPosition(legs, vector2, useCurrentLegMag) : vector2);
			}

			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
				Vector3 solverPosition = head.solverPosition;
				deltaRotation = QuaTools.ClampRotation(deltaRotation, chestClampWeight, 2);
				Quaternion a = Quaternion.Slerp(Quaternion.identity, deltaRotation, bodyRotStiffness);
				a = Quaternion.Slerp(a, QuaTools.FromToRotation(pelvis.solverRotation, IKRotationPelvis), pelvisRotationWeight);
				VirtualBone.RotateAroundPoint(bones, 0, pelvis.solverPosition, pelvisRotationOffset * a);
				deltaPosition -= head.solverPosition - solverPosition;
				Vector3 vector = rootRotation * Vector3.forward;
				float num = V3Tools.ExtractVertical(deltaPosition, rootRotation * Vector3.up, 1f).magnitude * (0f - moveBodyBackWhenCrouching) * headHeight;
				deltaPosition += vector * num;
				MovePosition(LimitPelvisPosition(legs, pelvis.solverPosition + deltaPosition * bodyPosStiffness, useCurrentLegMag: false));
			}

			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				if (!hasLegs)
				{
					return pelvisPosition;
				}
				if (useCurrentLegMag)
				{
					Leg[] array = legs;
					foreach (Leg leg in array)
					{
						leg.currentMag = Vector3.Distance(leg.thigh.solverPosition, leg.lastBone.solverPosition);
					}
				}
				for (int j = 0; j < it; j++)
				{
					Leg[] array = legs;
					foreach (Leg leg2 in array)
					{
						Vector3 vector = pelvisPosition - pelvis.solverPosition;
						Vector3 vector2 = leg2.thigh.solverPosition + vector;
						Vector3 vector3 = vector2 - leg2.position;
						float maxLength = (useCurrentLegMag ? leg2.currentMag : leg2.mag);
						Vector3 vector4 = leg2.position + Vector3.ClampMagnitude(vector3, maxLength);
						pelvisPosition += vector4 - vector2;
					}
				}
				return pelvisPosition;
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
				if (w <= 0f || bones.Length == 0)
				{
					return;
				}
				int num = lastIndex + 1 - firstIndex;
				if (num < 1)
				{
					return;
				}
				Quaternion rotation = QuaTools.FromToRotation(bones[lastIndex].solverRotation, targetRotation);
				rotation = QuaTools.ClampRotation(rotation, clampWeight, 2);
				float num2 = (uniformWeight ? (1f / (float)num) : 0f);
				for (int i = firstIndex; i < lastIndex + 1; i++)
				{
					if (!uniformWeight)
					{
						num2 = Mathf.Clamp((i - firstIndex + 1) / num, 0f, 1f);
					}
					VirtualBone.RotateAroundPoint(bones, i, bones[i].solverPosition, Quaternion.Slerp(Quaternion.identity, rotation, num2 * w));
				}
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
				if (w <= 0f || bones.Length == 0)
				{
					return;
				}
				int num = lastIndex + 1 - firstIndex;
				if (num < 1)
				{
					return;
				}
				Quaternion rotation = QuaTools.FromToRotation(bones[lastIndex].solverRotation, targetRotation);
				rotation = QuaTools.ClampRotation(rotation, clampWeight, 2);
				float num2 = (uniformWeight ? (1f / (float)num) : 0f);
				for (int i = firstIndex; i < lastIndex + 1; i++)
				{
					if (!uniformWeight)
					{
						if (num == 1)
						{
							num2 = 1f;
						}
						else if (num == 2)
						{
							num2 = ((i == 0) ? 0.2f : 0.8f);
						}
						else if (num == 3)
						{
							num2 = i switch
							{
								0 => 0.15f, 
								1 => 0.4f, 
								_ => 0.45f, 
							};
						}
						else if (num > 3)
						{
							num2 = 1f / (float)num;
						}
					}
					VirtualBone.RotateAroundPoint(bones, i, bones[i].solverPosition, Quaternion.Slerp(Quaternion.Slerp(Quaternion.identity, rotationOffset, num2), rotation, num2 * w));
				}
			}
		}

		[Serializable]
		public enum PositionOffset
		{
			Pelvis,
			Chest,
			Head,
			LeftHand,
			RightHand,
			LeftFoot,
			RightFoot,
			LeftHeel,
			RightHeel
		}

		[Serializable]
		public enum RotationOffset
		{
			Pelvis,
			Chest,
			Head
		}

		[Serializable]
		public class VirtualBone
		{
			public Vector3 readPosition;

			public Quaternion readRotation;

			public Vector3 solverPosition;

			public Quaternion solverRotation;

			public float length;

			public float sqrMag;

			public Vector3 axis;

			public VirtualBone(Vector3 position, Quaternion rotation)
			{
				Read(position, rotation);
			}

			public void Read(Vector3 position, Quaternion rotation)
			{
				readPosition = position;
				readRotation = rotation;
				solverPosition = position;
				solverRotation = rotation;
			}

			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
				if (!(weight <= 0f))
				{
					Quaternion quaternion = Quaternion.FromToRotation(bones[index].solverRotation * bones[index].axis, swingTarget - bones[index].solverPosition);
					if (weight < 1f)
					{
						quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, weight);
					}
					for (int i = index; i < bones.Length; i++)
					{
						bones[i].solverRotation = quaternion * bones[i].solverRotation;
					}
				}
			}

			public static float PreSolve(ref VirtualBone[] bones)
			{
				float num = 0f;
				for (int i = 0; i < bones.Length; i++)
				{
					if (i < bones.Length - 1)
					{
						bones[i].sqrMag = (bones[i + 1].solverPosition - bones[i].solverPosition).sqrMagnitude;
						bones[i].length = Mathf.Sqrt(bones[i].sqrMag);
						num += bones[i].length;
						bones[i].axis = Quaternion.Inverse(bones[i].solverRotation) * (bones[i + 1].solverPosition - bones[i].solverPosition);
					}
					else
					{
						bones[i].sqrMag = 0f;
						bones[i].length = 0f;
					}
				}
				return num;
			}

			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
				for (int i = index; i < bones.Length; i++)
				{
					if (bones[i] != null)
					{
						Vector3 vector = bones[i].solverPosition - point;
						bones[i].solverPosition = point + rotation * vector;
						bones[i].solverRotation = rotation * bones[i].solverRotation;
					}
				}
			}

			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
				for (int i = index; i < bones.Length; i++)
				{
					if (bones[i] != null)
					{
						Vector3 vector = bones[i].solverPosition - bones[index].solverPosition;
						bones[i].solverPosition = bones[index].solverPosition + rotation * vector;
						bones[i].solverRotation = rotation * bones[i].solverRotation;
					}
				}
			}

			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
				for (int i = 0; i < bones.Length; i++)
				{
					if (bones[i] != null)
					{
						if (i > 0)
						{
							Vector3 vector = bones[i].solverPosition - bones[0].solverPosition;
							bones[i].solverPosition = bones[0].solverPosition + rotation * vector;
						}
						bones[i].solverRotation = rotation * bones[i].solverRotation;
					}
				}
			}

			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
				Quaternion rotation2 = QuaTools.FromToRotation(bones[index].solverRotation, rotation);
				RotateAroundPoint(bones, index, bones[index].solverPosition, rotation2);
			}

			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
				if (weight <= 0f)
				{
					return;
				}
				targetPosition = Vector3.Lerp(bones[third].solverPosition, targetPosition, weight);
				Vector3 vector = targetPosition - bones[first].solverPosition;
				float sqrMagnitude = vector.sqrMagnitude;
				if (sqrMagnitude != 0f)
				{
					float directionMag = Mathf.Sqrt(sqrMagnitude);
					float sqrMagnitude2 = (bones[second].solverPosition - bones[first].solverPosition).sqrMagnitude;
					float sqrMagnitude3 = (bones[third].solverPosition - bones[second].solverPosition).sqrMagnitude;
					Vector3 bendDirection = Vector3.Cross(vector, bendNormal);
					Vector3 directionToBendPoint = GetDirectionToBendPoint(vector, directionMag, bendDirection, sqrMagnitude2, sqrMagnitude3);
					Quaternion quaternion = Quaternion.FromToRotation(bones[second].solverPosition - bones[first].solverPosition, directionToBendPoint);
					if (weight < 1f)
					{
						quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, weight);
					}
					RotateAroundPoint(bones, first, bones[first].solverPosition, quaternion);
					Quaternion quaternion2 = Quaternion.FromToRotation(bones[third].solverPosition - bones[second].solverPosition, targetPosition - bones[second].solverPosition);
					if (weight < 1f)
					{
						quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, weight);
					}
					RotateAroundPoint(bones, second, bones[second].solverPosition, quaternion2);
				}
			}

			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				float num = (directionMag * directionMag + (sqrMag1 - sqrMag2)) / 2f / directionMag;
				float y = (float)Math.Sqrt(Mathf.Clamp(sqrMag1 - num * num, 0f, float.PositiveInfinity));
				if (direction == Vector3.zero)
				{
					return Vector3.zero;
				}
				return Quaternion.LookRotation(direction, bendDirection) * new Vector3(0f, y, num);
			}

			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
				if (weight <= 0f)
				{
					return;
				}
				if (minNormalizedTargetDistance > 0f)
				{
					Vector3 vector = targetPosition - startPosition;
					float magnitude = vector.magnitude;
					targetPosition = startPosition + vector / magnitude * Mathf.Max(length * minNormalizedTargetDistance, magnitude);
				}
				for (int i = 0; i < iterations; i++)
				{
					bones[^1].solverPosition = Vector3.Lerp(bones[^1].solverPosition, targetPosition, weight);
					for (int num = bones.Length - 2; num > -1; num--)
					{
						bones[num].solverPosition = SolveFABRIKJoint(bones[num].solverPosition, bones[num + 1].solverPosition, bones[num].length);
					}
					if (i == 0)
					{
						for (int j = 0; j < bones.Length; j++)
						{
							bones[j].solverPosition += startOffset;
						}
					}
					bones[0].solverPosition = startPosition;
					for (int k = 1; k < bones.Length; k++)
					{
						bones[k].solverPosition = SolveFABRIKJoint(bones[k].solverPosition, bones[k - 1].solverPosition, bones[k - 1].length);
					}
				}
				for (int l = 0; l < bones.Length - 1; l++)
				{
					SwingRotation(bones, l, bones[l + 1].solverPosition);
				}
			}

			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return pos2 + (pos1 - pos2).normalized * length;
			}

			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
				if (weight <= 0f)
				{
					return;
				}
				for (int i = 0; i < iterations; i++)
				{
					for (int num = bones.Length - 2; num > -1; num--)
					{
						Vector3 fromDirection = bones[^1].solverPosition - bones[num].solverPosition;
						Vector3 toDirection = targetPosition - bones[num].solverPosition;
						Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
						if (weight >= 1f)
						{
							RotateBy(bones, num, quaternion);
						}
						else
						{
							RotateBy(bones, num, Quaternion.Lerp(Quaternion.identity, quaternion, weight));
						}
					}
				}
			}
		}

		private Transform[] solverTransforms = new Transform[0];

		private bool hasChest;

		private bool hasNeck;

		private bool hasShoulders;

		private bool hasToes;

		private bool hasLegs;

		private Vector3[] readPositions = new Vector3[0];

		private Quaternion[] readRotations = new Quaternion[0];

		private Vector3[] solvedPositions = new Vector3[22];

		private Quaternion[] solvedRotations = new Quaternion[22];

		private Quaternion[] defaultLocalRotations = new Quaternion[21];

		private Vector3[] defaultLocalPositions = new Vector3[21];

		private Vector3 rootV;

		private Vector3 rootVelocity;

		private Vector3 bodyOffset;

		private int supportLegIndex;

		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet = true;

		[Tooltip("The spine solver.")]
		public Spine spine = new Spine();

		[Tooltip("The left arm solver.")]
		public Arm leftArm = new Arm();

		[Tooltip("The right arm solver.")]
		public Arm rightArm = new Arm();

		[Tooltip("The left leg solver.")]
		public Leg leftLeg = new Leg();

		[Tooltip("The right leg solver.")]
		public Leg rightLeg = new Leg();

		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion = new Locomotion();

		private Leg[] legs = new Leg[2];

		private Arm[] arms = new Arm[2];

		private Vector3 headPosition;

		private Vector3 headDeltaPosition;

		private Vector3 raycastOriginPelvis;

		private Vector3 lastOffset;

		private Vector3 debugPos1;

		private Vector3 debugPos2;

		private Vector3 debugPos3;

		private Vector3 debugPos4;

		[HideInInspector]
		public VirtualBone rootBone { get; private set; }

		public void SetToReferences(VRIK.References references)
		{
			if (!references.isFilled)
			{
				UnityEngine.Debug.LogError("Invalid references, one or more Transforms are missing.");
				return;
			}
			solverTransforms = references.GetTransforms();
			hasChest = solverTransforms[3] != null;
			hasNeck = solverTransforms[4] != null;
			hasShoulders = solverTransforms[6] != null && solverTransforms[10] != null;
			hasToes = solverTransforms[17] != null && solverTransforms[21] != null;
			hasLegs = solverTransforms[14] != null;
			readPositions = new Vector3[solverTransforms.Length];
			readRotations = new Quaternion[solverTransforms.Length];
			DefaultAnimationCurves();
			GuessHandOrientations(references, onlyIfZero: true);
		}

		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
			if (!references.isFilled)
			{
				UnityEngine.Debug.LogWarning("VRIK References are not filled in, can not guess hand orientations. Right-click on VRIK header and slect 'Guess Hand Orientations' when you have filled in the References.", references.root);
				return;
			}
			if (leftArm.wristToPalmAxis == Vector3.zero || !onlyIfZero)
			{
				leftArm.wristToPalmAxis = GuessWristToPalmAxis(references.leftHand, references.leftForearm);
			}
			if (leftArm.palmToThumbAxis == Vector3.zero || !onlyIfZero)
			{
				leftArm.palmToThumbAxis = GuessPalmToThumbAxis(references.leftHand, references.leftForearm);
			}
			if (rightArm.wristToPalmAxis == Vector3.zero || !onlyIfZero)
			{
				rightArm.wristToPalmAxis = GuessWristToPalmAxis(references.rightHand, references.rightForearm);
			}
			if (rightArm.palmToThumbAxis == Vector3.zero || !onlyIfZero)
			{
				rightArm.palmToThumbAxis = GuessPalmToThumbAxis(references.rightHand, references.rightForearm);
			}
		}

		public void DefaultAnimationCurves()
		{
			if (locomotion.stepHeight == null)
			{
				locomotion.stepHeight = new AnimationCurve();
			}
			if (locomotion.heelHeight == null)
			{
				locomotion.heelHeight = new AnimationCurve();
			}
			if (locomotion.stepHeight.keys.Length == 0)
			{
				locomotion.stepHeight.keys = GetSineKeyframes(0.03f);
			}
			if (locomotion.heelHeight.keys.Length == 0)
			{
				locomotion.heelHeight.keys = GetSineKeyframes(0.03f);
			}
		}

		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
			switch (positionOffset)
			{
			case PositionOffset.Pelvis:
				spine.pelvisPositionOffset += value;
				break;
			case PositionOffset.Chest:
				spine.chestPositionOffset += value;
				break;
			case PositionOffset.Head:
				spine.headPositionOffset += value;
				break;
			case PositionOffset.LeftHand:
				leftArm.handPositionOffset += value;
				break;
			case PositionOffset.RightHand:
				rightArm.handPositionOffset += value;
				break;
			case PositionOffset.LeftFoot:
				leftLeg.footPositionOffset += value;
				break;
			case PositionOffset.RightFoot:
				rightLeg.footPositionOffset += value;
				break;
			case PositionOffset.LeftHeel:
				leftLeg.heelPositionOffset += value;
				break;
			case PositionOffset.RightHeel:
				rightLeg.heelPositionOffset += value;
				break;
			}
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
			AddRotationOffset(rotationOffset, Quaternion.Euler(value));
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
			switch (rotationOffset)
			{
			case RotationOffset.Pelvis:
				spine.pelvisRotationOffset = value * spine.pelvisRotationOffset;
				break;
			case RotationOffset.Chest:
				spine.chestRotationOffset = value * spine.chestRotationOffset;
				break;
			case RotationOffset.Head:
				spine.headRotationOffset = value * spine.headRotationOffset;
				break;
			}
		}

		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
			locomotion.AddDeltaPosition(deltaPosition);
			raycastOriginPelvis += deltaPosition;
			locomotion.AddDeltaRotation(deltaRotation, platformPivot);
			spine.faceDirection = deltaRotation * spine.faceDirection;
		}

		public void Reset()
		{
			if (base.initiated)
			{
				UpdateSolverTransforms();
				Read(readPositions, readRotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs);
				spine.faceDirection = rootBone.readRotation * Vector3.forward;
				if (hasLegs)
				{
					locomotion.Reset(readPositions, readRotations);
					raycastOriginPelvis = spine.pelvis.readPosition;
				}
			}
		}

		public override void StoreDefaultLocalState()
		{
			for (int i = 1; i < solverTransforms.Length; i++)
			{
				if (solverTransforms[i] != null)
				{
					defaultLocalPositions[i - 1] = solverTransforms[i].localPosition;
					defaultLocalRotations[i - 1] = solverTransforms[i].localRotation;
				}
			}
		}

		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			for (int i = 1; i < solverTransforms.Length; i++)
			{
				if (solverTransforms[i] != null)
				{
					bool num = i == 1;
					bool flag = i > 5 && i < 14;
					bool flag2 = i >= 14;
					if (num || flag || flag2)
					{
						solverTransforms[i].localPosition = defaultLocalPositions[i - 1];
					}
					solverTransforms[i].localRotation = defaultLocalRotations[i - 1];
				}
			}
		}

		public override Point[] GetPoints()
		{
			UnityEngine.Debug.LogError("GetPoints() is not applicable to IKSolverVR.");
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			UnityEngine.Debug.LogError("GetPoint is not applicable to IKSolverVR.");
			return null;
		}

		public override bool IsValid(ref string message)
		{
			if (solverTransforms == null || solverTransforms.Length == 0)
			{
				message = "Trying to initiate IKSolverVR with invalid bone references.";
				return false;
			}
			if (leftArm.wristToPalmAxis == Vector3.zero)
			{
				message = "Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.";
				return false;
			}
			if (rightArm.wristToPalmAxis == Vector3.zero)
			{
				message = "Right arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.";
				return false;
			}
			if (leftArm.palmToThumbAxis == Vector3.zero)
			{
				message = "Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.";
				return false;
			}
			if (rightArm.palmToThumbAxis == Vector3.zero)
			{
				message = "Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.";
				return false;
			}
			return true;
		}

		private Vector3 GetNormal(Transform[] transforms)
		{
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			for (int i = 0; i < transforms.Length; i++)
			{
				zero2 += transforms[i].position;
			}
			zero2 /= (float)transforms.Length;
			for (int j = 0; j < transforms.Length - 1; j++)
			{
				zero += Vector3.Cross(transforms[j].position - zero2, transforms[j + 1].position - zero2).normalized;
			}
			return zero;
		}

		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			Vector3 vector = forearm.position - hand.position;
			Vector3 vector2 = AxisTools.ToVector3(AxisTools.GetAxisToDirection(hand, vector));
			if (Vector3.Dot(vector, hand.rotation * vector2) > 0f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			if (hand.childCount == 0)
			{
				UnityEngine.Debug.LogWarning("Hand " + hand.name + " does not have any fingers, VRIK can not guess the hand bone's orientation. Please assign 'Wrist To Palm Axis' and 'Palm To Thumb Axis' manually for both arms in VRIK settings.", hand);
				return Vector3.zero;
			}
			float num = float.PositiveInfinity;
			int index = 0;
			for (int i = 0; i < hand.childCount; i++)
			{
				float num2 = Vector3.SqrMagnitude(hand.GetChild(i).position - hand.position);
				if (num2 < num)
				{
					num = num2;
					index = i;
				}
			}
			Vector3 vector = Vector3.Cross(Vector3.Cross(hand.position - forearm.position, hand.GetChild(index).position - hand.position), hand.position - forearm.position);
			Vector3 vector2 = AxisTools.ToVector3(AxisTools.GetAxisToDirection(hand, vector));
			if (Vector3.Dot(vector, hand.rotation * vector2) < 0f)
			{
				vector2 = -vector2;
			}
			return vector2;
		}

		private static Keyframe[] GetSineKeyframes(float mag)
		{
			Keyframe[] array = new Keyframe[3];
			array[0].time = 0f;
			array[0].value = 0f;
			array[1].time = 0.5f;
			array[1].value = mag;
			array[2].time = 1f;
			array[2].value = 0f;
			return array;
		}

		private void UpdateSolverTransforms()
		{
			for (int i = 0; i < solverTransforms.Length; i++)
			{
				if (solverTransforms[i] != null)
				{
					readPositions[i] = solverTransforms[i].position;
					readRotations[i] = solverTransforms[i].rotation;
				}
			}
		}

		protected override void OnInitiate()
		{
			UpdateSolverTransforms();
			Read(readPositions, readRotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs);
		}

		protected override void OnUpdate()
		{
			if (IKPositionWeight > 0f)
			{
				UpdateSolverTransforms();
				Read(readPositions, readRotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs);
				Solve();
				Write();
				WriteTransforms();
			}
		}

		private void WriteTransforms()
		{
			for (int i = 0; i < solverTransforms.Length; i++)
			{
				if (solverTransforms[i] != null)
				{
					bool num = i < 2;
					bool flag = i > 5 && i < 14;
					bool flag2 = i >= 14;
					if (num)
					{
						solverTransforms[i].position = V3Tools.Lerp(solverTransforms[i].position, GetPosition(i), IKPositionWeight);
					}
					if (flag || flag2)
					{
						solverTransforms[i].position = V3Tools.Lerp(solverTransforms[i].position, GetPosition(i), IKPositionWeight);
					}
					solverTransforms[i].rotation = QuaTools.Lerp(solverTransforms[i].rotation, GetRotation(i), IKPositionWeight);
				}
			}
		}

		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
			if (rootBone == null)
			{
				rootBone = new VirtualBone(positions[0], rotations[0]);
			}
			else
			{
				rootBone.Read(positions[0], rotations[0]);
			}
			spine.Read(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, 0, 1);
			leftArm.Read(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, hasChest ? 3 : 2, 6);
			rightArm.Read(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, hasChest ? 3 : 2, 10);
			if (hasLegs)
			{
				leftLeg.Read(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, 1, 14);
				rightLeg.Read(positions, rotations, hasChest, hasNeck, hasShoulders, hasToes, hasLegs, 1, 18);
			}
			for (int i = 0; i < rotations.Length; i++)
			{
				solvedPositions[i] = positions[i];
				solvedRotations[i] = rotations[i];
			}
			if (!base.initiated)
			{
				if (hasLegs)
				{
					legs = new Leg[2] { leftLeg, rightLeg };
				}
				arms = new Arm[2] { leftArm, rightArm };
				if (hasLegs)
				{
					locomotion.Initiate(positions, rotations, hasToes);
				}
				raycastOriginPelvis = spine.pelvis.readPosition;
				spine.faceDirection = readRotations[0] * Vector3.forward;
			}
		}

		private void Solve()
		{
			spine.PreSolve();
			Arm[] array = arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].PreSolve();
			}
			if (hasLegs)
			{
				Leg[] array2 = legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].PreSolve();
				}
			}
			array = arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ApplyOffsets();
			}
			spine.ApplyOffsets();
			spine.Solve(rootBone, legs, arms);
			if (hasLegs && spine.pelvisPositionWeight > 0f && plantFeet)
			{
				Warning.Log("If VRIK 'Pelvis Position Weight' is > 0, 'Plant Feet' should be disabled to improve performance and stability.", root);
			}
			if (hasLegs && locomotion.weight > 0f)
			{
				Vector3 leftFootPosition = Vector3.zero;
				Vector3 rightFootPosition = Vector3.zero;
				Quaternion leftFootRotation = Quaternion.identity;
				Quaternion rightFootRotation = Quaternion.identity;
				float leftFootOffset = 0f;
				float rightFootOffset = 0f;
				float leftHeelOffset = 0f;
				float rightHeelOffset = 0f;
				locomotion.Solve(rootBone, spine, leftLeg, rightLeg, leftArm, rightArm, supportLegIndex, out leftFootPosition, out rightFootPosition, out leftFootRotation, out rightFootRotation, out leftFootOffset, out rightFootOffset, out leftHeelOffset, out rightHeelOffset);
				leftFootPosition += root.up * leftFootOffset;
				rightFootPosition += root.up * rightFootOffset;
				leftLeg.footPositionOffset += (leftFootPosition - leftLeg.lastBone.solverPosition) * IKPositionWeight * (1f - leftLeg.positionWeight) * locomotion.weight;
				rightLeg.footPositionOffset += (rightFootPosition - rightLeg.lastBone.solverPosition) * IKPositionWeight * (1f - rightLeg.positionWeight) * locomotion.weight;
				leftLeg.heelPositionOffset += root.up * leftHeelOffset * locomotion.weight;
				rightLeg.heelPositionOffset += root.up * rightHeelOffset * locomotion.weight;
				Quaternion b = QuaTools.FromToRotation(leftLeg.lastBone.solverRotation, leftFootRotation);
				Quaternion b2 = QuaTools.FromToRotation(rightLeg.lastBone.solverRotation, rightFootRotation);
				b = Quaternion.Lerp(Quaternion.identity, b, IKPositionWeight * (1f - leftLeg.rotationWeight) * locomotion.weight);
				b2 = Quaternion.Lerp(Quaternion.identity, b2, IKPositionWeight * (1f - rightLeg.rotationWeight) * locomotion.weight);
				leftLeg.footRotationOffset = b * leftLeg.footRotationOffset;
				rightLeg.footRotationOffset = b2 * rightLeg.footRotationOffset;
				Vector3 point = Vector3.Lerp(leftLeg.position + leftLeg.footPositionOffset, rightLeg.position + rightLeg.footPositionOffset, 0.5f);
				point = V3Tools.PointToPlane(point, rootBone.solverPosition, root.up);
				Vector3 a = rootBone.solverPosition + rootVelocity * Time.deltaTime * 2f * locomotion.weight;
				a = Vector3.Lerp(a, point, Time.deltaTime * locomotion.rootSpeed * locomotion.weight);
				rootBone.solverPosition = a;
				rootVelocity += (point - rootBone.solverPosition) * Time.deltaTime * 10f;
				Vector3 vector = V3Tools.ExtractVertical(rootVelocity, root.up, 1f);
				rootVelocity -= vector;
				float num = leftFootOffset + rightFootOffset;
				bodyOffset = Vector3.Lerp(bodyOffset, root.up * num, Time.deltaTime * 3f);
				bodyOffset = Vector3.Lerp(Vector3.zero, bodyOffset, locomotion.weight);
			}
			if (hasLegs)
			{
				Leg[] array2 = legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].ApplyOffsets();
				}
				if (!plantFeet)
				{
					spine.InverseTranslateToHead(legs, limited: false, useCurrentLegMag: false, bodyOffset, 1f);
					array2 = legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].TranslateRoot(spine.pelvis.solverPosition, spine.pelvis.solverRotation);
					}
					array2 = legs;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].Solve(stretch: true);
					}
				}
				else
				{
					for (int j = 0; j < 2; j++)
					{
						spine.InverseTranslateToHead(legs, limited: true, useCurrentLegMag: true, bodyOffset, 1f);
						array2 = legs;
						for (int i = 0; i < array2.Length; i++)
						{
							array2[i].TranslateRoot(spine.pelvis.solverPosition, spine.pelvis.solverRotation);
						}
						array2 = legs;
						for (int i = 0; i < array2.Length; i++)
						{
							array2[i].Solve(j == 0);
						}
					}
				}
			}
			else
			{
				spine.InverseTranslateToHead(legs, limited: false, useCurrentLegMag: false, bodyOffset, 1f);
			}
			for (int k = 0; k < arms.Length; k++)
			{
				arms[k].TranslateRoot(spine.chest.solverPosition, spine.chest.solverRotation);
			}
			for (int l = 0; l < arms.Length; l++)
			{
				arms[l].Solve(l == 0);
			}
			spine.ResetOffsets();
			if (hasLegs)
			{
				Leg[] array2 = legs;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].ResetOffsets();
				}
			}
			array = arms;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ResetOffsets();
			}
			if (hasLegs)
			{
				spine.pelvisPositionOffset += GetPelvisOffset();
				spine.chestPositionOffset += spine.pelvisPositionOffset;
			}
			Write();
			if (!hasLegs)
			{
				return;
			}
			supportLegIndex = -1;
			float num2 = float.PositiveInfinity;
			for (int m = 0; m < legs.Length; m++)
			{
				float num3 = Vector3.SqrMagnitude(legs[m].lastBone.solverPosition - legs[m].bones[0].solverPosition);
				if (num3 < num2)
				{
					supportLegIndex = m;
					num2 = num3;
				}
			}
		}

		private Vector3 GetPosition(int index)
		{
			return solvedPositions[index];
		}

		private Quaternion GetRotation(int index)
		{
			return solvedRotations[index];
		}

		private void Write()
		{
			solvedPositions[0] = rootBone.solverPosition;
			solvedRotations[0] = rootBone.solverRotation;
			spine.Write(ref solvedPositions, ref solvedRotations);
			if (hasLegs)
			{
				Leg[] array = legs;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Write(ref solvedPositions, ref solvedRotations);
				}
			}
			Arm[] array2 = arms;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Write(ref solvedPositions, ref solvedRotations);
			}
		}

		private Vector3 GetPelvisOffset()
		{
			if (locomotion.weight <= 0f)
			{
				return Vector3.zero;
			}
			if ((int)locomotion.blockingLayers == -1)
			{
				return Vector3.zero;
			}
			Vector3 vector = raycastOriginPelvis;
			vector.y = spine.pelvis.solverPosition.y;
			Vector3 vector2 = spine.pelvis.readPosition;
			vector2.y = spine.pelvis.solverPosition.y;
			Vector3 direction = vector2 - vector;
			RaycastHit hitInfo;
			if (locomotion.raycastRadius <= 0f)
			{
				if (Physics.Raycast(vector, direction, out hitInfo, direction.magnitude * 1.1f, locomotion.blockingLayers))
				{
					vector2 = hitInfo.point;
				}
			}
			else if (Physics.SphereCast(vector, locomotion.raycastRadius * 1.1f, direction, out hitInfo, direction.magnitude, locomotion.blockingLayers))
			{
				vector2 = vector + direction.normalized * hitInfo.distance / 1.1f;
			}
			Vector3 vector3 = spine.pelvis.solverPosition;
			direction = vector3 - vector2;
			if (locomotion.raycastRadius <= 0f)
			{
				if (Physics.Raycast(vector2, direction, out hitInfo, direction.magnitude, locomotion.blockingLayers))
				{
					vector3 = hitInfo.point;
				}
			}
			else if (Physics.SphereCast(vector2, locomotion.raycastRadius, direction, out hitInfo, direction.magnitude, locomotion.blockingLayers))
			{
				vector3 = vector2 + direction.normalized * hitInfo.distance;
			}
			lastOffset = Vector3.Lerp(lastOffset, Vector3.zero, Time.deltaTime * 3f);
			vector3 += Vector3.ClampMagnitude(lastOffset, 0.75f);
			vector3.y = spine.pelvis.solverPosition.y;
			lastOffset = Vector3.Lerp(lastOffset, vector3 - spine.pelvis.solverPosition, Time.deltaTime * 15f);
			return lastOffset;
		}
	}
	public class TwistRelaxer : MonoBehaviour
	{
		public IK ik;

		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade = 0.5f;

		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		private Vector3 twistAxis = Vector3.right;

		private Vector3 axis = Vector3.forward;

		private Vector3 axisRelativeToParentDefault;

		private Vector3 axisRelativeToChildDefault;

		public void Relax()
		{
			if (!(weight <= 0f))
			{
				Quaternion rotation = base.transform.rotation;
				Quaternion quaternion = Quaternion.AngleAxis(twistAngleOffset, rotation * twistAxis);
				rotation = quaternion * rotation;
				Vector3 a = quaternion * parent.rotation * axisRelativeToParentDefault;
				Vector3 b = quaternion * child.rotation * axisRelativeToChildDefault;
				Vector3 vector = Vector3.Slerp(a, b, parentChildCrossfade);
				vector = Quaternion.Inverse(Quaternion.LookRotation(rotation * axis, rotation * twistAxis)) * vector;
				float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				Quaternion rotation2 = child.rotation;
				base.transform.rotation = Quaternion.AngleAxis(num * weight, rotation * twistAxis) * rotation;
				child.rotation = rotation2;
			}
		}

		private void Start()
		{
			if (parent == null)
			{
				parent = base.transform.parent;
			}
			if (child == null)
			{
				if (base.transform.childCount == 0)
				{
					Transform[] componentsInChildren = parent.GetComponentsInChildren<Transform>();
					for (int i = 1; i < componentsInChildren.Length; i++)
					{
						if (componentsInChildren[i] != base.transform)
						{
							child = componentsInChildren[i];
							break;
						}
					}
				}
				else
				{
					child = base.transform.GetChild(0);
				}
			}
			twistAxis = base.transform.InverseTransformDirection(child.position - base.transform.position);
			axis = new Vector3(twistAxis.y, twistAxis.z, twistAxis.x);
			Vector3 vector = base.transform.rotation * axis;
			axisRelativeToParentDefault = Quaternion.Inverse(parent.rotation) * vector;
			axisRelativeToChildDefault = Quaternion.Inverse(child.rotation) * vector;
			if (ik != null)
			{
				IKSolver iKSolver = ik.GetIKSolver();
				iKSolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostUpdate));
			}
		}

		private void OnPostUpdate()
		{
			if (ik != null)
			{
				Relax();
			}
		}

		private void LateUpdate()
		{
			if (ik == null)
			{
				Relax();
			}
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolver iKSolver = ik.GetIKSolver();
				iKSolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostUpdate));
			}
		}
	}
	[Serializable]
	public class InteractionEffector
	{
		private Poser poser;

		private IKEffector effector;

		private float timer;

		private float length;

		private float weight;

		private float fadeInSpeed;

		private float defaultPositionWeight;

		private float defaultRotationWeight;

		private float defaultPull;

		private float defaultReach;

		private float defaultPush;

		private float defaultPushParent;

		private float resetTimer;

		private bool positionWeightUsed;

		private bool rotationWeightUsed;

		private bool pullUsed;

		private bool reachUsed;

		private bool pushUsed;

		private bool pushParentUsed;

		private bool pickedUp;

		private bool defaults;

		private bool pickUpOnPostFBBIK;

		private Vector3 pickUpPosition;

		private Vector3 pausePositionRelative;

		private Quaternion pickUpRotation;

		private Quaternion pauseRotationRelative;

		private InteractionTarget interactionTarget;

		private Transform target;

		private List<bool> triggered = new List<bool>();

		private InteractionSystem interactionSystem;

		private bool started;

		public FullBodyBipedEffector effectorType { get; private set; }

		public bool isPaused { get; private set; }

		public InteractionObject interactionObject { get; private set; }

		public bool inInteraction => interactionObject != null;

		public float progress
		{
			get
			{
				if (!inInteraction)
				{
					return 0f;
				}
				if (length == 0f)
				{
					return 0f;
				}
				return timer / length;
			}
		}

		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
			this.effectorType = effectorType;
		}

		public void Initiate(InteractionSystem interactionSystem)
		{
			this.interactionSystem = interactionSystem;
			if (effector == null)
			{
				effector = interactionSystem.ik.solver.GetEffector(effectorType);
				poser = effector.bone.GetComponent<Poser>();
			}
			StoreDefaults();
		}

		private void StoreDefaults()
		{
			defaultPositionWeight = interactionSystem.ik.solver.GetEffector(effectorType).positionWeight;
			defaultRotationWeight = interactionSystem.ik.solver.GetEffector(effectorType).rotationWeight;
			defaultPull = interactionSystem.ik.solver.GetChain(effectorType).pull;
			defaultReach = interactionSystem.ik.solver.GetChain(effectorType).reach;
			defaultPush = interactionSystem.ik.solver.GetChain(effectorType).push;
			defaultPushParent = interactionSystem.ik.solver.GetChain(effectorType).pushParent;
		}

		public bool ResetToDefaults(float speed)
		{
			if (inInteraction)
			{
				return false;
			}
			if (isPaused)
			{
				return false;
			}
			if (defaults)
			{
				return false;
			}
			resetTimer = Mathf.MoveTowards(resetTimer, 0f, Time.deltaTime * speed);
			if (effector.isEndEffector)
			{
				if (pullUsed)
				{
					interactionSystem.ik.solver.GetChain(effectorType).pull = Mathf.Lerp(defaultPull, interactionSystem.ik.solver.GetChain(effectorType).pull, resetTimer);
				}
				if (reachUsed)
				{
					interactionSystem.ik.solver.GetChain(effectorType).reach = Mathf.Lerp(defaultReach, interactionSystem.ik.solver.GetChain(effectorType).reach, resetTimer);
				}
				if (pushUsed)
				{
					interactionSystem.ik.solver.GetChain(effectorType).push = Mathf.Lerp(defaultPush, interactionSystem.ik.solver.GetChain(effectorType).push, resetTimer);
				}
				if (pushParentUsed)
				{
					interactionSystem.ik.solver.GetChain(effectorType).pushParent = Mathf.Lerp(defaultPushParent, interactionSystem.ik.solver.GetChain(effectorType).pushParent, resetTimer);
				}
			}
			if (positionWeightUsed)
			{
				effector.positionWeight = Mathf.Lerp(defaultPositionWeight, effector.positionWeight, resetTimer);
			}
			if (rotationWeightUsed)
			{
				effector.rotationWeight = Mathf.Lerp(defaultRotationWeight, effector.rotationWeight, resetTimer);
			}
			if (resetTimer <= 0f)
			{
				pullUsed = false;
				reachUsed = false;
				pushUsed = false;
				pushParentUsed = false;
				positionWeightUsed = false;
				rotationWeightUsed = false;
				defaults = true;
			}
			return true;
		}

		public bool Pause()
		{
			if (!inInteraction)
			{
				return false;
			}
			isPaused = true;
			pausePositionRelative = target.InverseTransformPoint(effector.position);
			pauseRotationRelative = Quaternion.Inverse(target.rotation) * effector.rotation;
			if (interactionSystem.OnInteractionPause != null)
			{
				interactionSystem.OnInteractionPause(effectorType, interactionObject);
			}
			return true;
		}

		public bool Resume()
		{
			if (!inInteraction)
			{
				return false;
			}
			isPaused = false;
			if (interactionSystem.OnInteractionResume != null)
			{
				interactionSystem.OnInteractionResume(effectorType, interactionObject);
			}
			return true;
		}

		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			if (!inInteraction)
			{
				effector.position = effector.bone.position;
				effector.rotation = effector.bone.rotation;
			}
			else
			{
				if (!interrupt)
				{
					return false;
				}
				defaults = false;
			}
			target = interactionObject.GetTarget(effectorType, tag);
			if (target == null)
			{
				return false;
			}
			interactionTarget = target.GetComponent<InteractionTarget>();
			this.interactionObject = interactionObject;
			if (interactionSystem.OnInteractionStart != null)
			{
				interactionSystem.OnInteractionStart(effectorType, interactionObject);
			}
			interactionObject.OnStartInteraction(interactionSystem);
			triggered.Clear();
			for (int i = 0; i < interactionObject.events.Length; i++)
			{
				triggered.Add(item: false);
			}
			if (poser != null)
			{
				if (poser.poseRoot == null)
				{
					poser.weight = 0f;
				}
				if (interactionTarget != null)
				{
					poser.poseRoot = target.transform;
				}
				else
				{
					poser.poseRoot = null;
				}
				poser.AutoMapping();
			}
			positionWeightUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.PositionWeight);
			rotationWeightUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.RotationWeight);
			pullUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Pull);
			reachUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Reach);
			pushUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Push);
			pushParentUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.PushParent);
			if (defaults)
			{
				StoreDefaults();
			}
			timer = 0f;
			weight = 0f;
			fadeInSpeed = ((fadeInTime > 0f) ? (1f / fadeInTime) : 1000f);
			length = interactionObject.length;
			isPaused = false;
			pickedUp = false;
			pickUpPosition = Vector3.zero;
			pickUpRotation = Quaternion.identity;
			if (interactionTarget != null)
			{
				interactionTarget.RotateTo(effector.bone.position);
			}
			started = true;
			return true;
		}

		public void Update(Transform root, float speed)
		{
			if (!inInteraction)
			{
				if (started)
				{
					isPaused = false;
					pickedUp = false;
					defaults = false;
					resetTimer = 1f;
					started = false;
				}
				return;
			}
			if (interactionTarget != null && !interactionTarget.rotateOnce)
			{
				interactionTarget.RotateTo(effector.bone.position);
			}
			if (isPaused)
			{
				effector.position = target.TransformPoint(pausePositionRelative);
				effector.rotation = target.rotation * pauseRotationRelative;
				interactionObject.Apply(interactionSystem.ik.solver, effectorType, interactionTarget, timer, weight);
				return;
			}
			timer += Time.deltaTime * speed * ((interactionTarget != null) ? interactionTarget.interactionSpeedMlp : 1f);
			weight = Mathf.Clamp(weight + Time.deltaTime * fadeInSpeed * speed, 0f, 1f);
			bool pickUp = false;
			bool pause = false;
			TriggerUntriggeredEvents(checkTime: true, out pickUp, out pause);
			Vector3 b = (pickedUp ? pickUpPosition : target.position);
			Quaternion b2 = (pickedUp ? pickUpRotation : target.rotation);
			effector.position = Vector3.Lerp(effector.bone.position, b, weight);
			effector.rotation = Quaternion.Lerp(effector.bone.rotation, b2, weight);
			interactionObject.Apply(interactionSystem.ik.solver, effectorType, interactionTarget, timer, weight);
			if (pickUp)
			{
				PickUp(root);
			}
			if (pause)
			{
				Pause();
			}
			float value = interactionObject.GetValue(InteractionObject.WeightCurve.Type.PoserWeight, interactionTarget, timer);
			if (poser != null)
			{
				poser.weight = Mathf.Lerp(poser.weight, value, weight);
			}
			else if (value > 0f)
			{
				Warning.Log("InteractionObject " + interactionObject.name + " has a curve/multipler for Poser Weight, but the bone of effector " + effectorType.ToString() + " has no HandPoser/GenericPoser attached.", effector.bone);
			}
			if (timer >= length)
			{
				Stop();
			}
		}

		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
			pickUp = false;
			pause = false;
			for (int i = 0; i < triggered.Count; i++)
			{
				if (triggered[i] || (checkTime && !(interactionObject.events[i].time < timer)))
				{
					continue;
				}
				interactionObject.events[i].Activate(effector.bone);
				if (interactionObject.events[i].pickUp)
				{
					if (timer >= interactionObject.events[i].time)
					{
						timer = interactionObject.events[i].time;
					}
					pickUp = true;
				}
				if (interactionObject.events[i].pause)
				{
					if (timer >= interactionObject.events[i].time)
					{
						timer = interactionObject.events[i].time;
					}
					pause = true;
				}
				if (interactionSystem.OnInteractionEvent != null)
				{
					interactionSystem.OnInteractionEvent(effectorType, interactionObject, interactionObject.events[i]);
				}
				triggered[i] = true;
			}
		}

		private void PickUp(Transform root)
		{
			pickUpPosition = effector.position;
			pickUpRotation = effector.rotation;
			pickUpOnPostFBBIK = true;
			pickedUp = true;
			Rigidbody component = interactionObject.targetsRoot.GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (root.GetComponent<Collider>() != null)
				{
					Collider[] componentsInChildren = interactionObject.targetsRoot.GetComponentsInChildren<Collider>();
					foreach (Collider collider in componentsInChildren)
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(root.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (interactionSystem.OnInteractionPickUp != null)
			{
				interactionSystem.OnInteractionPickUp(effectorType, interactionObject);
			}
		}

		public bool Stop()
		{
			if (!inInteraction)
			{
				return false;
			}
			bool pickUp = false;
			bool pause = false;
			TriggerUntriggeredEvents(checkTime: false, out pickUp, out pause);
			if (interactionSystem.OnInteractionStop != null)
			{
				interactionSystem.OnInteractionStop(effectorType, interactionObject);
			}
			if (interactionTarget != null)
			{
				interactionTarget.ResetRotation();
			}
			interactionObject = null;
			weight = 0f;
			timer = 0f;
			isPaused = false;
			target = null;
			defaults = false;
			resetTimer = 1f;
			if (poser != null && !pickedUp)
			{
				poser.weight = 0f;
			}
			pickedUp = false;
			started = false;
			return true;
		}

		public void OnPostFBBIK()
		{
			if (inInteraction)
			{
				float num = interactionObject.GetValue(InteractionObject.WeightCurve.Type.RotateBoneWeight, interactionTarget, timer) * weight;
				if (num > 0f)
				{
					Quaternion b = (pickedUp ? pickUpRotation : effector.rotation);
					Quaternion quaternion = Quaternion.Slerp(effector.bone.rotation, b, num * num);
					effector.bone.localRotation = Quaternion.Inverse(effector.bone.parent.rotation) * quaternion;
				}
				if (pickUpOnPostFBBIK)
				{
					Vector3 position = effector.bone.position;
					effector.bone.position = pickUpPosition;
					interactionObject.targetsRoot.parent = effector.bone;
					effector.bone.position = position;
					pickUpOnPostFBBIK = false;
				}
			}
		}
	}
	[Serializable]
	public class InteractionLookAt
	{
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed = 5f;

		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed = 1f;

		[HideInInspector]
		public bool isPaused;

		private Transform lookAtTarget;

		private float stopLookTime;

		private float weight;

		private bool firstFBBIKSolve;

		public void Look(Transform target, float time)
		{
			if (!(ik == null))
			{
				if (ik.solver.IKPositionWeight <= 0f)
				{
					ik.solver.IKPosition = ik.solver.GetRoot().position + ik.solver.GetRoot().forward * 3f;
				}
				lookAtTarget = target;
				stopLookTime = time;
			}
		}

		public void OnFixTransforms()
		{
			if (!(ik == null) && ik.fixTransforms)
			{
				ik.solver.FixTransforms();
			}
		}

		public void Update()
		{
			if (ik == null)
			{
				return;
			}
			if (ik.enabled)
			{
				ik.enabled = false;
			}
			if (!(lookAtTarget == null))
			{
				if (isPaused)
				{
					stopLookTime += Time.deltaTime;
				}
				float num = ((Time.time < stopLookTime) ? weightSpeed : (0f - weightSpeed));
				weight = Mathf.Clamp(weight + num * Time.deltaTime, 0f, 1f);
				ik.solver.IKPositionWeight = Interp.Float(weight, InterpolationMode.InOutQuintic);
				ik.solver.IKPosition = Vector3.Lerp(ik.solver.IKPosition, lookAtTarget.position, lerpSpeed * Time.deltaTime);
				if (weight <= 0f)
				{
					lookAtTarget = null;
				}
				firstFBBIKSolve = true;
			}
		}

		public void SolveSpine()
		{
			if (!(ik == null) && firstFBBIKSolve)
			{
				float headWeight = ik.solver.headWeight;
				float eyesWeight = ik.solver.eyesWeight;
				ik.solver.headWeight = 0f;
				ik.solver.eyesWeight = 0f;
				ik.solver.Update();
				ik.solver.headWeight = headWeight;
				ik.solver.eyesWeight = eyesWeight;
			}
		}

		public void SolveHead()
		{
			if (!(ik == null) && firstFBBIKSolve)
			{
				float bodyWeight = ik.solver.bodyWeight;
				ik.solver.bodyWeight = 0f;
				ik.solver.Update();
				ik.solver.bodyWeight = bodyWeight;
				firstFBBIKSolve = false;
			}
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		public class InteractionEvent
		{
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			public void Activate(Transform t)
			{
				unityEvent.Invoke();
				AnimatorEvent[] array = animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Activate(pickUp);
				}
				Message[] array2 = messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].Send(t);
				}
			}
		}

		[Serializable]
		public class Message
		{
			[Tooltip("The name of the function called.")]
			public string function;

			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			private const string empty = "";

			public void Send(Transform t)
			{
				if (!(recipient == null) && !(function == string.Empty) && !(function == ""))
				{
					recipient.SendMessage(function, t, SendMessageOptions.RequireReceiver);
				}
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Tooltip("The crossfading time.")]
			public float crossfadeTime = 0.3f;

			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			private const string empty = "";

			public void Activate(bool pickUp)
			{
				if (animator != null)
				{
					if (pickUp)
					{
						animator.applyRootMotion = false;
					}
					Activate(animator);
				}
				if (animation != null)
				{
					Activate(animation);
				}
			}

			private void Activate(Animator animator)
			{
				if (!(animationState == ""))
				{
					if (resetNormalizedTime)
					{
						animator.CrossFade(animationState, crossfadeTime, layer, 0f);
					}
					else
					{
						animator.CrossFade(animationState, crossfadeTime, layer);
					}
				}
			}

			private void Activate(Animation animation)
			{
				if (!(animationState == ""))
				{
					if (resetNormalizedTime)
					{
						animation[animationState].normalizedTime = 0f;
					}
					animation[animationState].layer = layer;
					animation.CrossFade(animationState, crossfadeTime);
				}
			}
		}

		[Serializable]
		public class WeightCurve
		{
			[Serializable]
			public enum Type
			{
				PositionWeight,
				RotationWeight,
				PositionOffsetX,
				PositionOffsetY,
				PositionOffsetZ,
				Pull,
				Reach,
				RotateBoneWeight,
				Push,
				PushParent,
				PoserWeight
			}

			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			public float GetValue(float timer)
			{
				return curve.Evaluate(timer);
			}
		}

		[Serializable]
		public class Multiplier
		{
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier = 1f;

			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return weightCurve.GetValue(timer) * multiplier;
			}
		}

		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		public WeightCurve[] weightCurves;

		public Multiplier[] multipliers;

		public InteractionEvent[] events;

		private InteractionTarget[] targets = new InteractionTarget[0];

		public float length { get; private set; }

		public InteractionSystem lastUsedInteractionSystem { get; private set; }

		public Transform lookAtTarget
		{
			get
			{
				if (otherLookAtTarget != null)
				{
					return otherLookAtTarget;
				}
				return base.transform;
			}
		}

		public Transform targetsRoot
		{
			get
			{
				if (otherTargetsRoot != null)
				{
					return otherTargetsRoot;
				}
				return base.transform;
			}
		}

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public void Initiate()
		{
			for (int i = 0; i < weightCurves.Length; i++)
			{
				if (weightCurves[i].curve.length > 0)
				{
					float time = weightCurves[i].curve.keys[weightCurves[i].curve.length - 1].time;
					length = Mathf.Clamp(length, time, length);
				}
			}
			for (int j = 0; j < events.Length; j++)
			{
				length = Mathf.Clamp(length, events[j].time, length);
			}
			targets = targetsRoot.GetComponentsInChildren<InteractionTarget>();
		}

		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			InteractionTarget[] array;
			if (interactionSystem.tag == string.Empty || interactionSystem.tag == "")
			{
				array = targets;
				foreach (InteractionTarget interactionTarget in array)
				{
					if (interactionTarget.effectorType == effectorType)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			array = targets;
			foreach (InteractionTarget interactionTarget2 in array)
			{
				if (interactionTarget2.effectorType == effectorType && interactionTarget2.tag == interactionSystem.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		public bool CurveUsed(WeightCurve.Type type)
		{
			WeightCurve[] array = weightCurves;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].type == type)
				{
					return true;
				}
			}
			Multiplier[] array2 = multipliers;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].result == type)
				{
					return true;
				}
			}
			return false;
		}

		public InteractionTarget[] GetTargets()
		{
			return targets;
		}

		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			if (tag == string.Empty || tag == "")
			{
				return GetTarget(effectorType);
			}
			for (int i = 0; i < targets.Length; i++)
			{
				if (targets[i].effectorType == effectorType && targets[i].tag == tag)
				{
					return targets[i].transform;
				}
			}
			return base.transform;
		}

		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
			lastUsedInteractionSystem = interactionSystem;
		}

		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
			for (int i = 0; i < weightCurves.Length; i++)
			{
				float num = ((target == null) ? 1f : target.GetValue(weightCurves[i].type));
				Apply(solver, effector, weightCurves[i].type, weightCurves[i].GetValue(timer), weight * num);
			}
			for (int j = 0; j < multipliers.Length; j++)
			{
				if (multipliers[j].curve == multipliers[j].result && !Warning.logged)
				{
					Warning.Log("InteractionObject Multiplier 'Curve' " + multipliers[j].curve.ToString() + "and 'Result' are the same.", base.transform);
				}
				int weightCurveIndex = GetWeightCurveIndex(multipliers[j].curve);
				if (weightCurveIndex != -1)
				{
					float num2 = ((target == null) ? 1f : target.GetValue(multipliers[j].result));
					Apply(solver, effector, multipliers[j].result, multipliers[j].GetValue(weightCurves[weightCurveIndex], timer), weight * num2);
				}
				else if (!Warning.logged)
				{
					Warning.Log("InteractionObject Multiplier curve " + multipliers[j].curve.ToString() + "does not exist.", base.transform);
				}
			}
		}

		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			int weightCurveIndex = GetWeightCurveIndex(weightCurveType);
			if (weightCurveIndex != -1)
			{
				float num = ((target == null) ? 1f : target.GetValue(weightCurveType));
				return weightCurves[weightCurveIndex].GetValue(timer) * num;
			}
			for (int i = 0; i < multipliers.Length; i++)
			{
				if (multipliers[i].result == weightCurveType)
				{
					int weightCurveIndex2 = GetWeightCurveIndex(multipliers[i].curve);
					if (weightCurveIndex2 != -1)
					{
						float num2 = ((target == null) ? 1f : target.GetValue(multipliers[i].result));
						return multipliers[i].GetValue(weightCurves[weightCurveIndex2], timer) * num2;
					}
				}
			}
			return 0f;
		}

		private void Awake()
		{
			Initiate();
		}

		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
			switch (type)
			{
			case WeightCurve.Type.PositionWeight:
				solver.GetEffector(effector).positionWeight = Mathf.Lerp(solver.GetEffector(effector).positionWeight, value, weight);
				break;
			case WeightCurve.Type.RotationWeight:
				solver.GetEffector(effector).rotationWeight = Mathf.Lerp(solver.GetEffector(effector).rotationWeight, value, weight);
				break;
			case WeightCurve.Type.PositionOffsetX:
				solver.GetEffector(effector).position += ((positionOffsetSpace != null) ? positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.right * value * weight;
				break;
			case WeightCurve.Type.PositionOffsetY:
				solver.GetEffector(effector).position += ((positionOffsetSpace != null) ? positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.up * value * weight;
				break;
			case WeightCurve.Type.PositionOffsetZ:
				solver.GetEffector(effector).position += ((positionOffsetSpace != null) ? positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.forward * value * weight;
				break;
			case WeightCurve.Type.Pull:
				solver.GetChain(effector).pull = Mathf.Lerp(solver.GetChain(effector).pull, value, weight);
				break;
			case WeightCurve.Type.Reach:
				solver.GetChain(effector).reach = Mathf.Lerp(solver.GetChain(effector).reach, value, weight);
				break;
			case WeightCurve.Type.Push:
				solver.GetChain(effector).push = Mathf.Lerp(solver.GetChain(effector).push, value, weight);
				break;
			case WeightCurve.Type.PushParent:
				solver.GetChain(effector).pushParent = Mathf.Lerp(solver.GetChain(effector).pushParent, value, weight);
				break;
			case WeightCurve.Type.RotateBoneWeight:
				break;
			}
		}

		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			for (int i = 0; i < targets.Length; i++)
			{
				if (targets[i].effectorType == effectorType)
				{
					return targets[i].transform;
				}
			}
			return base.transform;
		}

		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			for (int i = 0; i < weightCurves.Length; i++)
			{
				if (weightCurves[i].type == weightCurveType)
				{
					return i;
				}
			}
			return -1;
		}

		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			for (int i = 0; i < multipliers.Length; i++)
			{
				if (multipliers[i].result == weightCurveType)
				{
					return i;
				}
			}
			return -1;
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html");
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag = "";

		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime = 0.3f;

		[Tooltip("The master speed for all interactions.")]
		public float speed = 1f;

		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed = 1f;

		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance = 1f;

		private List<InteractionTrigger> inContact = new List<InteractionTrigger>();

		private List<int> bestRangeIndexes = new List<int>();

		public InteractionDelegate OnInteractionStart;

		public InteractionDelegate OnInteractionPause;

		public InteractionDelegate OnInteractionPickUp;

		public InteractionDelegate OnInteractionResume;

		public InteractionDelegate OnInteractionStop;

		public InteractionEventDelegate OnInteractionEvent;

		public RaycastHit raycastHit;

		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt = new InteractionLookAt();

		private InteractionEffector[] interactionEffectors = new InteractionEffector[9]
		{
			new InteractionEffector(FullBodyBipedEffector.Body),
			new InteractionEffector(FullBodyBipedEffector.LeftFoot),
			new InteractionEffector(FullBodyBipedEffector.LeftHand),
			new InteractionEffector(FullBodyBipedEffector.LeftShoulder),
			new InteractionEffector(FullBodyBipedEffector.LeftThigh),
			new InteractionEffector(FullBodyBipedEffector.RightFoot),
			new InteractionEffector(FullBodyBipedEffector.RightHand),
			new InteractionEffector(FullBodyBipedEffector.RightShoulder),
			new InteractionEffector(FullBodyBipedEffector.RightThigh)
		};

		private bool initiated;

		private Collider lastCollider;

		private Collider c;

		public bool inInteraction
		{
			get
			{
				if (!IsValid(log: true))
				{
					return false;
				}
				for (int i = 0; i < interactionEffectors.Length; i++)
				{
					if (interactionEffectors[i].inInteraction && !interactionEffectors[i].isPaused)
					{
						return true;
					}
				}
				return false;
			}
		}

		public FullBodyBipedIK ik
		{
			get
			{
				return fullBody;
			}
			set
			{
				fullBody = value;
			}
		}

		public List<InteractionTrigger> triggersInRange { get; private set; }

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					if (interactionEffectors[i].inInteraction)
					{
						return !interactionEffectors[i].isPaused;
					}
					return false;
				}
			}
			return false;
		}

		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					if (interactionEffectors[i].inInteraction)
					{
						return interactionEffectors[i].isPaused;
					}
					return false;
				}
			}
			return false;
		}

		public bool IsPaused()
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].inInteraction && interactionEffectors[i].isPaused)
				{
					return true;
				}
			}
			return false;
		}

		public bool IsInSync()
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (!interactionEffectors[i].isPaused)
				{
					continue;
				}
				for (int j = 0; j < interactionEffectors.Length; j++)
				{
					if (j != i && interactionEffectors[j].inInteraction && !interactionEffectors[j].isPaused)
					{
						return false;
					}
				}
			}
			return true;
		}

		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			if (interactionObject == null)
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].Start(interactionObject, targetTag, fadeInTime, interrupt);
				}
			}
			return false;
		}

		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].Pause();
				}
			}
			return false;
		}

		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].Resume();
				}
			}
			return false;
		}

		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].Stop();
				}
			}
			return false;
		}

		public void PauseAll()
		{
			if (IsValid(log: true))
			{
				for (int i = 0; i < interactionEffectors.Length; i++)
				{
					interactionEffectors[i].Pause();
				}
			}
		}

		public void ResumeAll()
		{
			if (IsValid(log: true))
			{
				for (int i = 0; i < interactionEffectors.Length; i++)
				{
					interactionEffectors[i].Resume();
				}
			}
		}

		public void StopAll()
		{
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				interactionEffectors[i].Stop();
			}
		}

		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return null;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].interactionObject;
				}
			}
			return null;
		}

		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			if (!IsValid(log: true))
			{
				return 0f;
			}
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].effectorType == effectorType)
				{
					return interactionEffectors[i].progress;
				}
			}
			return 0f;
		}

		public float GetMinActiveProgress()
		{
			if (!IsValid(log: true))
			{
				return 0f;
			}
			float num = 1f;
			for (int i = 0; i < interactionEffectors.Length; i++)
			{
				if (interactionEffectors[i].inInteraction)
				{
					float progress = interactionEffectors[i].progress;
					if (progress > 0f && progress < num)
					{
						num = progress;
					}
				}
			}
			return num;
		}

		public bool TriggerInteraction(int index, bool interrupt)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			if (!TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = triggersInRange[index].ranges[bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					if (!StartInteraction(range.interactions[i].effectors[j], range.interactions[i].interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			interactionObject = null;
			if (!IsValid(log: true))
			{
				return false;
			}
			if (!TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = triggersInRange[index].ranges[bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					interactionObject = range.interactions[i].interactionObject;
					if (!StartInteraction(range.interactions[i].effectors[j], interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			interactionTarget = null;
			if (!IsValid(log: true))
			{
				return false;
			}
			if (!TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = triggersInRange[index].ranges[bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform target = interactionObject.GetTarget(range.interactions[i].effectors[j], base.tag);
					if (target != null)
					{
						interactionTarget = target.GetComponent<InteractionTarget>();
					}
					if (!StartInteraction(range.interactions[i].effectors[j], interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			if (!IsValid(log: true))
			{
				return null;
			}
			int closestTriggerIndex = GetClosestTriggerIndex();
			if (closestTriggerIndex < 0 || closestTriggerIndex >= triggersInRange.Count)
			{
				return null;
			}
			return triggersInRange[closestTriggerIndex].ranges[bestRangeIndexes[closestTriggerIndex]];
		}

		public InteractionObject GetClosestInteractionObjectInRange()
		{
			InteractionTrigger.Range closestInteractionRange = GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject;
		}

		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			InteractionTrigger.Range closestInteractionRange = GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject.GetTarget(closestInteractionRange.interactions[0].effectors[0], this);
		}

		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionObject[0];
			}
			InteractionObject[] array = new InteractionObject[closestInteractionRange.interactions.Length];
			for (int i = 0; i < closestInteractionRange.interactions.Length; i++)
			{
				array[i] = closestInteractionRange.interactions[i].interactionObject;
			}
			return array;
		}

		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionTarget[0];
			}
			List<InteractionTarget> list = new List<InteractionTarget>();
			InteractionTrigger.Range.Interaction[] interactions = closestInteractionRange.interactions;
			foreach (InteractionTrigger.Range.Interaction interaction in interactions)
			{
				FullBodyBipedEffector[] effectors = interaction.effectors;
				foreach (FullBodyBipedEffector effectorType in effectors)
				{
					list.Add(interaction.interactionObject.GetTarget(effectorType, this));
				}
			}
			return list.ToArray();
		}

		public bool TriggerEffectorsReady(int index)
		{
			if (!IsValid(log: true))
			{
				return false;
			}
			if (!TriggerIndexIsValid(index))
			{
				return false;
			}
			for (int i = 0; i < triggersInRange[index].ranges.Length; i++)
			{
				InteractionTrigger.Range range = triggersInRange[index].ranges[i];
				for (int j = 0; j < range.interactions.Length; j++)
				{
					for (int k = 0; k < range.interactions[j].effectors.Length; k++)
					{
						if (IsInInteraction(range.interactions[j].effectors[k]))
						{
							return false;
						}
					}
				}
				for (int l = 0; l < range.interactions.Length; l++)
				{
					for (int m = 0; m < range.interactions[l].effectors.Length; m++)
					{
						if (!IsPaused(range.interactions[l].effectors[m]))
						{
							continue;
						}
						for (int n = 0; n < range.interactions[l].effectors.Length; n++)
						{
							if (n != m && !IsPaused(range.interactions[l].effectors[n]))
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			if (!IsValid(log: true))
			{
				return null;
			}
			if (index < 0 || index >= bestRangeIndexes.Count)
			{
				Warning.Log("Index out of range.", base.transform);
				return null;
			}
			return triggersInRange[index].ranges[bestRangeIndexes[index]];
		}

		public int GetClosestTriggerIndex()
		{
			if (!IsValid(log: true))
			{
				return -1;
			}
			if (triggersInRange.Count == 0)
			{
				return -1;
			}
			if (triggersInRange.Count == 1)
			{
				return 0;
			}
			int result = -1;
			float num = float.PositiveInfinity;
			for (int i = 0; i < triggersInRange.Count; i++)
			{
				if (triggersInRange[i] != null)
				{
					float num2 = Vector3.SqrMagnitude(triggersInRange[i].transform.position - base.transform.position);
					if (num2 < num)
					{
						result = i;
						num = num2;
					}
				}
			}
			return result;
		}

		private void Start()
		{
			if (fullBody == null)
			{
				fullBody = GetComponent<FullBodyBipedIK>();
			}
			if (fullBody == null)
			{
				Warning.Log("InteractionSystem can not find a FullBodyBipedIK component", base.transform);
				return;
			}
			IKSolverFullBodyBiped solver = fullBody.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(OnPreFBBIK));
			IKSolverFullBodyBiped solver2 = fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostFBBIK));
			IKSolverFullBodyBiped solver3 = fullBody.solver;
			solver3.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Combine(solver3.OnFixTransforms, new IKSolver.UpdateDelegate(OnFixTransforms));
			OnInteractionStart = (InteractionDelegate)Delegate.Combine(OnInteractionStart, new InteractionDelegate(LookAtInteraction));
			OnInteractionPause = (InteractionDelegate)Delegate.Combine(OnInteractionPause, new InteractionDelegate(InteractionPause));
			OnInteractionResume = (InteractionDelegate)Delegate.Combine(OnInteractionResume, new InteractionDelegate(InteractionResume));
			OnInteractionStop = (InteractionDelegate)Delegate.Combine(OnInteractionStop, new InteractionDelegate(InteractionStop));
			InteractionEffector[] array = interactionEffectors;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(this);
			}
			triggersInRange = new List<InteractionTrigger>();
			c = GetComponent<Collider>();
			UpdateTriggerEventBroadcasting();
			initiated = true;
		}

		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			lookAt.isPaused = true;
		}

		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			lookAt.isPaused = false;
		}

		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			lookAt.isPaused = false;
		}

		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			lookAt.Look(interactionObject.lookAtTarget, Time.time + interactionObject.length * 0.5f);
		}

		public void OnTriggerEnter(Collider c)
		{
			if (!(fullBody == null))
			{
				InteractionTrigger component = c.GetComponent<InteractionTrigger>();
				if (!(component == null) && !inContact.Contains(component))
				{
					inContact.Add(component);
				}
			}
		}

		public void OnTriggerExit(Collider c)
		{
			if (!(fullBody == null))
			{
				InteractionTrigger component = c.GetComponent<InteractionTrigger>();
				if (!(component == null))
				{
					inContact.Remove(component);
				}
			}
		}

		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			bestRangeIndex = -1;
			if (!IsValid(log: true))
			{
				return false;
			}
			if (index < 0 || index >= inContact.Count)
			{
				Warning.Log("Index out of range.", base.transform);
				return false;
			}
			if (inContact[index] == null)
			{
				Warning.Log("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform);
				return false;
			}
			bestRangeIndex = inContact[index].GetBestRangeIndex(base.transform, FPSCamera, raycastHit);
			if (bestRangeIndex == -1)
			{
				return false;
			}
			return true;
		}

		private void OnDrawGizmosSelected()
		{
			if (!Application.isPlaying)
			{
				if (fullBody == null)
				{
					fullBody = GetComponent<FullBodyBipedIK>();
				}
				if (characterCollider == null)
				{
					characterCollider = GetComponent<Collider>();
				}
			}
		}

		private void Update()
		{
			if (fullBody == null)
			{
				return;
			}
			UpdateTriggerEventBroadcasting();
			Raycasting();
			triggersInRange.Clear();
			bestRangeIndexes.Clear();
			for (int i = 0; i < inContact.Count; i++)
			{
				int bestRangeIndex = -1;
				if (inContact[i] != null && inContact[i].gameObject.activeInHierarchy && inContact[i].enabled && ContactIsInRange(i, out bestRangeIndex))
				{
					triggersInRange.Add(inContact[i]);
					bestRangeIndexes.Add(bestRangeIndex);
				}
			}
			lookAt.Update();
		}

		private void Raycasting()
		{
			if ((int)camRaycastLayers != -1 && !(FPSCamera == null))
			{
				Physics.Raycast(FPSCamera.position, FPSCamera.forward, out raycastHit, camRaycastDistance, camRaycastLayers);
			}
		}

		private void UpdateTriggerEventBroadcasting()
		{
			if (characterCollider == null)
			{
				characterCollider = c;
			}
			if (characterCollider != null && characterCollider != c)
			{
				if (characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (lastCollider != null && lastCollider != c && lastCollider != characterCollider)
				{
					TriggerEventBroadcaster component = lastCollider.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						UnityEngine.Object.Destroy(component);
					}
				}
			}
			lastCollider = characterCollider;
		}

		private void UpdateEffectors()
		{
			if (!(fullBody == null))
			{
				for (int i = 0; i < interactionEffectors.Length; i++)
				{
					interactionEffectors[i].Update(base.transform, speed);
				}
				for (int j = 0; j < interactionEffectors.Length; j++)
				{
					interactionEffectors[j].ResetToDefaults(resetToDefaultsSpeed * speed);
				}
			}
		}

		private void OnPreFBBIK()
		{
			if (base.enabled && !(fullBody == null))
			{
				lookAt.SolveSpine();
				UpdateEffectors();
			}
		}

		private void OnPostFBBIK()
		{
			if (base.enabled && !(fullBody == null))
			{
				for (int i = 0; i < interactionEffectors.Length; i++)
				{
					interactionEffectors[i].OnPostFBBIK();
				}
				lookAt.SolveHead();
			}
		}

		private void OnFixTransforms()
		{
			lookAt.OnFixTransforms();
		}

		private void OnDestroy()
		{
			if (!(fullBody == null))
			{
				IKSolverFullBodyBiped solver = fullBody.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(OnPreFBBIK));
				IKSolverFullBodyBiped solver2 = fullBody.solver;
				solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(OnPostFBBIK));
				IKSolverFullBodyBiped solver3 = fullBody.solver;
				solver3.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Remove(solver3.OnFixTransforms, new IKSolver.UpdateDelegate(OnFixTransforms));
				OnInteractionStart = (InteractionDelegate)Delegate.Remove(OnInteractionStart, new InteractionDelegate(LookAtInteraction));
				OnInteractionPause = (InteractionDelegate)Delegate.Remove(OnInteractionPause, new InteractionDelegate(InteractionPause));
				OnInteractionResume = (InteractionDelegate)Delegate.Remove(OnInteractionResume, new InteractionDelegate(InteractionResume));
				OnInteractionStop = (InteractionDelegate)Delegate.Remove(OnInteractionStop, new InteractionDelegate(InteractionStop));
			}
		}

		private bool IsValid(bool log)
		{
			if (fullBody == null)
			{
				if (log)
				{
					Warning.Log("FBBIK is null. Will not update the InteractionSystem", base.transform);
				}
				return false;
			}
			if (!initiated)
			{
				if (log)
				{
					Warning.Log("The InteractionSystem has not been initiated yet.", base.transform);
				}
				return false;
			}
			return true;
		}

		private bool TriggerIndexIsValid(int index)
		{
			if (index < 0 || index >= triggersInRange.Count)
			{
				Warning.Log("Index out of range.", base.transform);
				return false;
			}
			if (triggersInRange[index] == null)
			{
				Warning.Log("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform);
				return false;
			}
			return true;
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_system.html");
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		public class Multiplier
		{
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}

		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp = 1f;

		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis = Vector3.up;

		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight = 1f;

		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce = true;

		private Quaternion defaultLocalRotation;

		private Transform lastPivot;

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			for (int i = 0; i < multipliers.Length; i++)
			{
				if (multipliers[i].curve == curveType)
				{
					return multipliers[i].multiplier;
				}
			}
			return 1f;
		}

		public void ResetRotation()
		{
			if (pivot != null)
			{
				pivot.localRotation = defaultLocalRotation;
			}
		}

		public void RotateTo(Vector3 position)
		{
			if (!(pivot == null))
			{
				if (pivot != lastPivot)
				{
					defaultLocalRotation = pivot.localRotation;
					lastPivot = pivot;
				}
				pivot.localRotation = defaultLocalRotation;
				if (twistWeight > 0f)
				{
					Vector3 tangent = base.transform.position - pivot.position;
					Vector3 vector = pivot.rotation * twistAxis;
					Vector3 normal = vector;
					Vector3.OrthoNormalize(ref normal, ref tangent);
					normal = vector;
					Vector3 tangent2 = position - pivot.position;
					Vector3.OrthoNormalize(ref normal, ref tangent2);
					Quaternion b = QuaTools.FromToAroundAxis(tangent, tangent2, vector);
					pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, twistWeight) * pivot.rotation;
				}
				if (swingWeight > 0f)
				{
					Quaternion b2 = Quaternion.FromToRotation(base.transform.position - pivot.position, position - pivot.position);
					pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, swingWeight) * pivot.rotation;
				}
			}
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html");
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		public class CharacterPosition
		{
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle = 45f;

			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius = 0.5f;

			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			public Vector3 offset3D => new Vector3(offset.x, 0f, offset.y);

			public Vector3 direction3D => Quaternion.AngleAxis(angleOffset, Vector3.up) * Vector3.forward;

			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				error = 0f;
				if (!use)
				{
					return true;
				}
				error = 180f;
				if (radius <= 0f)
				{
					return false;
				}
				if (maxAngle <= 0f)
				{
					return false;
				}
				Vector3 forward = trigger.forward;
				if (fixYAxis)
				{
					forward.y = 0f;
				}
				if (forward == Vector3.zero)
				{
					return false;
				}
				Vector3 normal = (fixYAxis ? Vector3.up : trigger.up);
				Quaternion quaternion = Quaternion.LookRotation(forward, normal);
				Vector3 vector = trigger.position + quaternion * offset3D;
				Vector3 vector2 = (orbit ? trigger.position : vector);
				Vector3 tangent = character.position - vector2;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				tangent *= Vector3.Project(character.position - vector2, tangent).magnitude;
				if (orbit)
				{
					float magnitude = offset.magnitude;
					float magnitude2 = tangent.magnitude;
					if (magnitude2 < magnitude - radius || magnitude2 > magnitude + radius)
					{
						return false;
					}
				}
				else if (tangent.magnitude > radius)
				{
					return false;
				}
				Vector3 tangent2 = quaternion * direction3D;
				Vector3.OrthoNormalize(ref normal, ref tangent2);
				if (orbit)
				{
					Vector3 vector3 = vector - trigger.position;
					if (vector3 == Vector3.zero)
					{
						vector3 = Vector3.forward;
					}
					tangent = Quaternion.Inverse(Quaternion.LookRotation(vector3, normal)) * tangent;
					tangent2 = Quaternion.AngleAxis(Mathf.Atan2(tangent.x, tangent.z) * 57.29578f, normal) * tangent2;
				}
				float num = Vector3.Angle(tangent2, character.forward);
				if (num > maxAngle)
				{
					return false;
				}
				error = num / maxAngle * 180f;
				return true;
			}
		}

		[Serializable]
		public class CameraPosition
		{
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction = -Vector3.forward;

			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance = 0.5f;

			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle = 45f;

			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			public Quaternion GetRotation()
			{
				Vector3 forward = lookAtTarget.transform.forward;
				if (fixYAxis)
				{
					forward.y = 0f;
				}
				if (forward == Vector3.zero)
				{
					return Quaternion.identity;
				}
				Vector3 upwards = (fixYAxis ? Vector3.up : lookAtTarget.transform.up);
				return Quaternion.LookRotation(forward, upwards);
			}

			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				error = 0f;
				if (lookAtTarget == null)
				{
					return true;
				}
				error = 180f;
				if (raycastFrom == null)
				{
					return false;
				}
				if (hit.collider != lookAtTarget)
				{
					return false;
				}
				if (hit.distance > maxDistance)
				{
					return false;
				}
				if (direction == Vector3.zero)
				{
					return false;
				}
				if (maxDistance <= 0f)
				{
					return false;
				}
				if (maxAngle <= 0f)
				{
					return false;
				}
				Vector3 to = GetRotation() * direction;
				float num = Vector3.Angle(raycastFrom.position - hit.point, to);
				if (num > maxAngle)
				{
					return false;
				}
				error = num / maxAngle * 180f;
				return true;
			}
		}

		[Serializable]
		public class Range
		{
			[Serializable]
			public class Interaction
			{
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}

			[HideInInspector]
			[SerializeField]
			public string name;

			[HideInInspector]
			[SerializeField]
			public bool show = true;

			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				maxError = 0f;
				float error = 0f;
				float error2 = 0f;
				if (!characterPosition.IsInRange(character, trigger, out error))
				{
					return false;
				}
				if (!cameraPosition.IsInRange(raycastFrom, raycastHit, trigger, out error2))
				{
					return false;
				}
				maxError = Mathf.Max(error, error2);
				return true;
			}
		}

		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges = new Range[0];

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		private void Start()
		{
		}

		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			if (GetComponent<Collider>() == null)
			{
				Warning.Log("Using the InteractionTrigger requires a Collider component.", base.transform);
				return -1;
			}
			int result = -1;
			float num = 180f;
			float maxError = 0f;
			for (int i = 0; i < ranges.Length; i++)
			{
				if (ranges[i].IsInRange(character, raycastFrom, raycastHit, base.transform, out maxError) && maxError <= num)
				{
					num = maxError;
					result = i;
				}
			}
			return result;
		}
	}
	public class GenericPoser : Poser
	{
		[Serializable]
		public class Map
		{
			public Transform bone;

			public Transform target;

			private Vector3 defaultLocalPosition;

			private Quaternion defaultLocalRotation;

			public Map(Transform bone, Transform target)
			{
				this.bone = bone;
				this.target = target;
				StoreDefaultState();
			}

			public void StoreDefaultState()
			{
				defaultLocalPosition = bone.localPosition;
				defaultLocalRotation = bone.localRotation;
			}

			public void FixTransform()
			{
				bone.localPosition = defaultLocalPosition;
				bone.localRotation = defaultLocalRotation;
			}

			public void Update(float localRotationWeight, float localPositionWeight)
			{
				bone.localRotation = Quaternion.Lerp(bone.localRotation, target.localRotation, localRotationWeight);
				bone.localPosition = Vector3.Lerp(bone.localPosition, target.localPosition, localPositionWeight);
			}
		}

		public Map[] maps;

		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
			if (poseRoot == null)
			{
				maps = new Map[0];
				return;
			}
			maps = new Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				Transform targetNamed = GetTargetNamed(componentsInChildren[i].name, componentsInChildren2);
				if (targetNamed != null)
				{
					Array.Resize(ref maps, maps.Length + 1);
					maps[maps.Length - 1] = new Map(componentsInChildren[i], targetNamed);
				}
			}
			StoreDefaultState();
		}

		protected override void InitiatePoser()
		{
			StoreDefaultState();
		}

		protected override void UpdatePoser()
		{
			if (!(weight <= 0f) && (!(localPositionWeight <= 0f) || !(localRotationWeight <= 0f)) && !(poseRoot == null))
			{
				float num = localRotationWeight * weight;
				float num2 = localPositionWeight * weight;
				for (int i = 0; i < maps.Length; i++)
				{
					maps[i].Update(num, num2);
				}
			}
		}

		protected override void FixPoserTransforms()
		{
			for (int i = 0; i < maps.Length; i++)
			{
				maps[i].FixTransform();
			}
		}

		private void StoreDefaultState()
		{
			for (int i = 0; i < maps.Length; i++)
			{
				maps[i].StoreDefaultState();
			}
		}

		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].name == tName)
				{
					return array[i];
				}
			}
			return null;
		}
	}
	public class HandPoser : Poser
	{
		protected Transform[] children;

		private Transform _poseRoot;

		private Transform[] poseChildren;

		private Vector3[] defaultLocalPositions;

		private Quaternion[] defaultLocalRotations;

		public override void AutoMapping()
		{
			if (poseRoot == null)
			{
				poseChildren = new Transform[0];
			}
			else
			{
				poseChildren = poseRoot.GetComponentsInChildren<Transform>();
			}
			_poseRoot = poseRoot;
		}

		protected override void InitiatePoser()
		{
			children = GetComponentsInChildren<Transform>();
			StoreDefaultState();
		}

		protected override void FixPoserTransforms()
		{
			for (int i = 0; i < children.Length; i++)
			{
				children[i].localPosition = defaultLocalPositions[i];
				children[i].localRotation = defaultLocalRotations[i];
			}
		}

		protected override void UpdatePoser()
		{
			if (weight <= 0f || (localPositionWeight <= 0f && localRotationWeight <= 0f))
			{
				return;
			}
			if (_poseRoot != poseRoot)
			{
				AutoMapping();
			}
			if (poseRoot == null)
			{
				return;
			}
			if (children.Length != poseChildren.Length)
			{
				Warning.Log("Number of children does not match with the pose", base.transform);
				return;
			}
			float t = localRotationWeight * weight;
			float t2 = localPositionWeight * weight;
			for (int i = 0; i < children.Length; i++)
			{
				if (children[i] != base.transform)
				{
					children[i].localRotation = Quaternion.Lerp(children[i].localRotation, poseChildren[i].localRotation, t);
					children[i].localPosition = Vector3.Lerp(children[i].localPosition, poseChildren[i].localPosition, t2);
				}
			}
		}

		protected void StoreDefaultState()
		{
			defaultLocalPositions = new Vector3[children.Length];
			defaultLocalRotations = new Quaternion[children.Length];
			for (int i = 0; i < children.Length; i++)
			{
				defaultLocalPositions[i] = children[i].localPosition;
				defaultLocalRotations[i] = children[i].localRotation;
			}
		}
	}
	public abstract class Poser : SolverManager
	{
		public Transform poseRoot;

		[Range(0f, 1f)]
		public float weight = 1f;

		[Range(0f, 1f)]
		public float localRotationWeight = 1f;

		[Range(0f, 1f)]
		public float localPositionWeight;

		private bool initiated;

		public abstract void AutoMapping();

		public void UpdateManual()
		{
			UpdatePoser();
		}

		protected abstract void InitiatePoser();

		protected abstract void UpdatePoser();

		protected abstract void FixPoserTransforms();

		protected override void UpdateSolver()
		{
			if (!initiated)
			{
				InitiateSolver();
			}
			if (initiated)
			{
				UpdatePoser();
			}
		}

		protected override void InitiateSolver()
		{
			if (!initiated)
			{
				InitiatePoser();
				initiated = true;
			}
		}

		protected override void FixTransforms()
		{
			if (initiated)
			{
				FixPoserTransforms();
			}
		}
	}
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		public class Rigidbone
		{
			public Rigidbody r;

			public Transform t;

			public Collider collider;

			public Joint joint;

			public Rigidbody c;

			public bool updateAnchor;

			public Vector3 deltaPosition;

			public Quaternion deltaRotation;

			public float deltaTime;

			public Vector3 lastPosition;

			public Quaternion lastRotation;

			public Rigidbone(Rigidbody r)
			{
				this.r = r;
				t = r.transform;
				joint = t.GetComponent<Joint>();
				collider = t.GetComponent<Collider>();
				if (joint != null)
				{
					c = joint.connectedBody;
					updateAnchor = c != null;
				}
				lastPosition = t.position;
				lastRotation = t.rotation;
			}

			public void RecordVelocity()
			{
				deltaPosition = t.position - lastPosition;
				lastPosition = t.position;
				deltaRotation = QuaTools.FromToRotation(lastRotation, t.rotation);
				lastRotation = t.rotation;
				deltaTime = Time.deltaTime;
			}

			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
				if (updateAnchor)
				{
					joint.connectedAnchor = t.InverseTransformPoint(c.position);
				}
				r.isKinematic = false;
				if (velocityWeight != 0f)
				{
					r.velocity = deltaPosition / deltaTime * velocityWeight;
				}
				if (angularVelocityWeight != 0f)
				{
					float angle = 0f;
					Vector3 axis = Vector3.zero;
					deltaRotation.ToAngleAxis(out angle, out axis);
					angle *= (float)Math.PI / 180f;
					angle /= deltaTime;
					axis *= angle * angularVelocityWeight;
					r.angularVelocity = Vector3.ClampMagnitude(axis, r.maxAngularVelocity);
				}
				r.WakeUp();
			}
		}

		public class Child
		{
			public Transform t;

			public Vector3 localPosition;

			public Quaternion localRotation;

			public Child(Transform transform)
			{
				t = transform;
				localPosition = t.localPosition;
				localRotation = t.localRotation;
			}

			public void FixTransform(float weight)
			{
				if (!(weight <= 0f))
				{
					if (weight >= 1f)
					{
						t.localPosition = localPosition;
						t.localRotation = localRotation;
					}
					else
					{
						t.localPosition = Vector3.Lerp(t.localPosition, localPosition, weight);
						t.localRotation = Quaternion.Lerp(t.localRotation, localRotation, weight);
					}
				}
			}

			public void StoreLocalState()
			{
				localPosition = t.localPosition;
				localRotation = t.localRotation;
			}
		}

		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime = 0.2f;

		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity = 1f;

		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity = 1f;

		private Animator animator;

		private Rigidbone[] rigidbones = new Rigidbone[0];

		private Child[] children = new Child[0];

		private bool enableRagdollFlag;

		private AnimatorUpdateMode animatorUpdateMode;

		private IK[] allIKComponents = new IK[0];

		private bool[] fixTransforms = new bool[0];

		private float ragdollWeight;

		private float ragdollWeightV;

		private bool fixedFrame;

		private bool[] disabledIKComponents = new bool[0];

		private bool isRagdoll
		{
			get
			{
				if (!rigidbones[0].r.isKinematic)
				{
					return !animator.enabled;
				}
				return false;
			}
		}

		private bool ikUsed
		{
			get
			{
				if (ik == null)
				{
					return false;
				}
				if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 0f)
				{
					return true;
				}
				IK[] array = allIKComponents;
				foreach (IK iK in array)
				{
					if (iK.enabled && iK.GetIKSolver().IKPositionWeight > 0f)
					{
						return true;
					}
				}
				return false;
			}
		}

		public void EnableRagdoll()
		{
			if (!isRagdoll)
			{
				StopAllCoroutines();
				enableRagdollFlag = true;
			}
		}

		public void DisableRagdoll()
		{
			if (isRagdoll)
			{
				StoreLocalState();
				StopAllCoroutines();
				StartCoroutine(DisableRagdollSmooth());
			}
		}

		public void Start()
		{
			animator = GetComponent<Animator>();
			allIKComponents = GetComponentsInChildren<IK>();
			disabledIKComponents = new bool[allIKComponents.Length];
			fixTransforms = new bool[allIKComponents.Length];
			if (ik != null)
			{
				IKSolver iKSolver = ik.GetIKSolver();
				iKSolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iKSolver.OnPostUpdate, new IKSolver.UpdateDelegate(AfterLastIK));
			}
			Rigidbody[] componentsInChildren = GetComponentsInChildren<Rigidbody>();
			int num = ((componentsInChildren[0].gameObject == base.gameObject) ? 1 : 0);
			rigidbones = new Rigidbone[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 0; i < rigidbones.Length; i++)
			{
				rigidbones[i] = new Rigidbone(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = GetComponentsInChildren<Transform>();
			children = new Child[componentsInChildren2.Length - 1];
			for (int j = 0; j < children.Length; j++)
			{
				children[j] = new Child(componentsInChildren2[j + 1]);
			}
		}

		private IEnumerator DisableRagdollSmooth()
		{
			for (int i = 0; i < rigidbones.Length; i++)
			{
				rigidbones[i].r.isKinematic = true;
			}
			for (int j = 0; j < allIKComponents.Length; j++)
			{
				allIKComponents[j].fixTransforms = fixTransforms[j];
				if (disabledIKComponents[j])
				{
					allIKComponents[j].enabled = true;
				}
			}
			animator.updateMode = animatorUpdateMode;
			animator.enabled = true;
			while (ragdollWeight > 0f)
			{
				ragdollWeight = Mathf.SmoothDamp(ragdollWeight, 0f, ref ragdollWeightV, ragdollToAnimationTime);
				if (ragdollWeight < 0.001f)
				{
					ragdollWeight = 0f;
				}
				yield return null;
			}
			yield return null;
		}

		private void Update()
		{
			if (!isRagdoll)
			{
				return;
			}
			if (!applyIkOnRagdoll)
			{
				bool flag = false;
				for (int i = 0; i < allIKComponents.Length; i++)
				{
					if (allIKComponents[i].enabled)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					for (int j = 0; j < allIKComponents.Length; j++)
					{
						disabledIKComponents[j] = false;
					}
				}
				for (int k = 0; k < allIKComponents.Length; k++)
				{
					if (allIKComponents[k].enabled)
					{
						allIKComponents[k].enabled = false;
						disabledIKComponents[k] = true;
					}
				}
				return;
			}
			bool flag2 = false;
			for (int l = 0; l < allIKComponents.Length; l++)
			{
				if (disabledIKComponents[l])
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			for (int m = 0; m < allIKComponents.Length; m++)
			{
				if (disabledIKComponents[m])
				{
					allIKComponents[m].enabled = true;
				}
			}
			for (int n = 0; n < allIKComponents.Length; n++)
			{
				disabledIKComponents[n] = false;
			}
		}

		private void FixedUpdate()
		{
			if (isRagdoll && applyIkOnRagdoll)
			{
				FixTransforms(1f);
			}
			fixedFrame = true;
		}

		private void LateUpdate()
		{
			if (animator.updateMode != AnimatorUpdateMode.AnimatePhysics || (animator.updateMode == AnimatorUpdateMode.AnimatePhysics && fixedFrame))
			{
				AfterAnimation();
			}
			fixedFrame = false;
			if (!ikUsed)
			{
				OnFinalPose();
			}
		}

		private void AfterLastIK()
		{
			if (ikUsed)
			{
				OnFinalPose();
			}
		}

		private void AfterAnimation()
		{
			if (isRagdoll)
			{
				StoreLocalState();
			}
			else
			{
				FixTransforms(ragdollWeight);
			}
		}

		private void OnFinalPose()
		{
			if (!isRagdoll)
			{
				RecordVelocities();
			}
			if (enableRagdollFlag)
			{
				RagdollEnabler();
			}
		}

		private void RagdollEnabler()
		{
			StoreLocalState();
			for (int i = 0; i < allIKComponents.Length; i++)
			{
				disabledIKComponents[i] = false;
			}
			if (!applyIkOnRagdoll)
			{
				for (int j = 0; j < allIKComponents.Length; j++)
				{
					if (allIKComponents[j].enabled)
					{
						allIKComponents[j].enabled = false;
						disabledIKComponents[j] = true;
					}
				}
			}
			animatorUpdateMode = animator.updateMode;
			animator.updateMode = AnimatorUpdateMode.AnimatePhysics;
			animator.enabled = false;
			for (int k = 0; k < rigidbones.Length; k++)
			{
				rigidbones[k].WakeUp(applyVelocity, applyAngularVelocity);
			}
			for (int l = 0; l < fixTransforms.Length; l++)
			{
				fixTransforms[l] = allIKComponents[l].fixTransforms;
				allIKComponents[l].fixTransforms = false;
			}
			ragdollWeight = 1f;
			ragdollWeightV = 0f;
			enableRagdollFlag = false;
		}

		private void RecordVelocities()
		{
			Rigidbone[] array = rigidbones;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].RecordVelocity();
			}
		}

		private void StoreLocalState()
		{
			Child[] array = children;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].StoreLocalState();
			}
		}

		private void FixTransforms(float weight)
		{
			Child[] array = children;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FixTransform(weight);
			}
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolver iKSolver = ik.GetIKSolver();
				iKSolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iKSolver.OnPostUpdate, new IKSolver.UpdateDelegate(AfterLastIK));
			}
		}
	}
	public abstract class RotationLimit : MonoBehaviour
	{
		public Vector3 axis = Vector3.forward;

		[HideInInspector]
		public Quaternion defaultLocalRotation;

		private bool initiated;

		private bool applicationQuit;

		private bool defaultLocalRotationSet;

		public Vector3 secondaryAxis => new Vector3(axis.y, axis.z, axis.x);

		public Vector3 crossAxis => Vector3.Cross(axis, secondaryAxis);

		public void SetDefaultLocalRotation()
		{
			defaultLocalRotation = base.transform.localRotation;
			defaultLocalRotationSet = true;
		}

		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			if (!initiated)
			{
				Awake();
			}
			Quaternion quaternion = Quaternion.Inverse(defaultLocalRotation) * localRotation;
			Quaternion quaternion2 = LimitRotation(quaternion);
			changed = quaternion2 != quaternion;
			if (!changed)
			{
				return localRotation;
			}
			return defaultLocalRotation * quaternion2;
		}

		public bool Apply()
		{
			bool changed = false;
			base.transform.localRotation = GetLimitedLocalRotation(base.transform.localRotation, out changed);
			return changed;
		}

		public void Disable()
		{
			if (initiated)
			{
				base.enabled = false;
				return;
			}
			Awake();
			base.enabled = false;
		}

		protected abstract Quaternion LimitRotation(Quaternion rotation);

		private void Awake()
		{
			if (!defaultLocalRotationSet)
			{
				SetDefaultLocalRotation();
			}
			if (axis == Vector3.zero)
			{
				UnityEngine.Debug.LogError("Axis is Vector3.zero.");
			}
			initiated = true;
		}

		private void LateUpdate()
		{
			Apply();
		}

		public void LogWarning(string message)
		{
			Warning.Log(message, base.transform);
		}

		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return Quaternion.FromToRotation(rotation * axis, axis) * rotation;
		}

		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			twistLimit = Mathf.Clamp(twistLimit, 0f, 180f);
			if (twistLimit >= 180f)
			{
				return rotation;
			}
			Vector3 normal = rotation * axis;
			Vector3 tangent = orthoAxis;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			Vector3 tangent2 = rotation * orthoAxis;
			Vector3.OrthoNormalize(ref normal, ref tangent2);
			Quaternion quaternion = Quaternion.FromToRotation(tangent2, tangent) * rotation;
			if (twistLimit <= 0f)
			{
				return quaternion;
			}
			return Quaternion.RotateTowards(quaternion, rotation, twistLimit);
		}

		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			Vector3.OrthoNormalize(ref normal, ref v1);
			Vector3.OrthoNormalize(ref normal, ref v2);
			return Vector3.Angle(v1, v2);
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Range(0f, 180f)]
		public float limit = 45f;

		[Range(0f, 180f)]
		public float twistLimit = 180f;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return RotationLimit.LimitTwist(LimitSwing(rotation), axis, base.secondaryAxis, twistLimit);
		}

		private Quaternion LimitSwing(Quaternion rotation)
		{
			if (axis == Vector3.zero)
			{
				return rotation;
			}
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			if (limit >= 180f)
			{
				return rotation;
			}
			Vector3 vector = rotation * axis;
			Quaternion to = Quaternion.FromToRotation(axis, vector);
			Quaternion quaternion = Quaternion.RotateTowards(Quaternion.identity, to, limit);
			return Quaternion.FromToRotation(vector, quaternion * axis) * rotation;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		public bool useLimits = true;

		public float min = -45f;

		public float max = 90f;

		[HideInInspector]
		public float zeroAxisDisplayOffset;

		private Quaternion lastRotation = Quaternion.identity;

		private float lastAngle;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			lastRotation = LimitHinge(rotation);
			return lastRotation;
		}

		private Quaternion LimitHinge(Quaternion rotation)
		{
			if (min == 0f && max == 0f && useLimits)
			{
				return Quaternion.AngleAxis(0f, axis);
			}
			Quaternion quaternion = RotationLimit.Limit1DOF(rotation, axis);
			if (!useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(lastRotation);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(axis.z, axis.x, axis.y);
			Vector3 rhs = Vector3.Cross(vector, axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 0f)
			{
				num = 0f - num;
			}
			lastAngle = Mathf.Clamp(lastAngle + num, min, max);
			return Quaternion.AngleAxis(lastAngle, axis);
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		public class ReachCone
		{
			public Vector3[] tetrahedron;

			public float volume;

			public Vector3 S;

			public Vector3 B;

			public Vector3 o => tetrahedron[0];

			public Vector3 a => tetrahedron[1];

			public Vector3 b => tetrahedron[2];

			public Vector3 c => tetrahedron[3];

			public bool isValid => volume > 0f;

			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
				tetrahedron = new Vector3[4];
				tetrahedron[0] = _o;
				tetrahedron[1] = _a;
				tetrahedron[2] = _b;
				tetrahedron[3] = _c;
				volume = 0f;
				S = Vector3.zero;
				B = Vector3.zero;
			}

			public void Calculate()
			{
				Vector3 lhs = Vector3.Cross(a, b);
				volume = Vector3.Dot(lhs, c) / 6f;
				S = Vector3.Cross(a, b).normalized;
				B = Vector3.Cross(b, c).normalized;
			}
		}

		[Serializable]
		public class LimitPoint
		{
			public Vector3 point;

			public float tangentWeight;

			public LimitPoint()
			{
				point = Vector3.forward;
				tangentWeight = 1f;
			}
		}

		[Range(0f, 180f)]
		public float twistLimit = 180f;

		[Range(0f, 3f)]
		public int smoothIterations;

		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones = new ReachCone[0];

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public void SetLimitPoints(LimitPoint[] points)
		{
			if (points.Length < 3)
			{
				LogWarning("The polygon must have at least 3 Limit Points.");
				return;
			}
			this.points = points;
			BuildReachCones();
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			if (reachCones.Length == 0)
			{
				Start();
			}
			return RotationLimit.LimitTwist(LimitSwing(rotation), axis, base.secondaryAxis, twistLimit);
		}

		private void Start()
		{
			if (points.Length < 3)
			{
				ResetToDefault();
			}
			for (int i = 0; i < reachCones.Length; i++)
			{
				if (!reachCones[i].isValid)
				{
					if (smoothIterations <= 0)
					{
						int num = 0;
						num = ((i < reachCones.Length - 1) ? (i + 1) : 0);
						LogWarning("Reach Cone {point " + i + ", point " + num + ", Origin} has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.");
					}
					else
					{
						LogWarning("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.");
					}
				}
			}
			axis = axis.normalized;
		}

		public void ResetToDefault()
		{
			points = new LimitPoint[4];
			for (int i = 0; i < points.Length; i++)
			{
				points[i] = new LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(45f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(45f, Vector3.up);
			points[0].point = quaternion * quaternion2 * axis;
			points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * axis;
			points[2].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * axis;
			points[3].point = quaternion * Quaternion.Inverse(quaternion2) * axis;
			BuildReachCones();
		}

		public void BuildReachCones()
		{
			smoothIterations = Mathf.Clamp(smoothIterations, 0, 3);
			P = new Vector3[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				P[i] = points[i].point.normalized;
			}
			for (int j = 0; j < smoothIterations; j++)
			{
				P = SmoothPoints();
			}
			reachCones = new ReachCone[P.Length];
			for (int k = 0; k < reachCones.Length - 1; k++)
			{
				reachCones[k] = new ReachCone(Vector3.zero, axis.normalized, P[k], P[k + 1]);
			}
			reachCones[P.Length - 1] = new ReachCone(Vector3.zero, axis.normalized, P[P.Length - 1], P[0]);
			for (int l = 0; l < reachCones.Length; l++)
			{
				reachCones[l].Calculate();
			}
		}

		private Vector3[] SmoothPoints()
		{
			Vector3[] array = new Vector3[P.Length * 2];
			float scalar = GetScalar(P.Length);
			for (int i = 0; i < array.Length; i += 2)
			{
				array[i] = PointToTangentPlane(P[i / 2], 1f);
			}
			for (int j = 1; j < array.Length; j += 2)
			{
				Vector3 vector = Vector3.zero;
				Vector3 zero = Vector3.zero;
				Vector3 vector2 = Vector3.zero;
				if (j > 1 && j < array.Length - 2)
				{
					vector = array[j - 2];
					vector2 = array[j + 1];
				}
				else if (j == 1)
				{
					vector = array[^2];
					vector2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					vector = array[j - 2];
					vector2 = array[0];
				}
				zero = ((j >= array.Length - 1) ? array[0] : array[j + 1]);
				int num = array.Length / points.Length;
				array[j] = 0.5f * (array[j - 1] + zero) + scalar * points[j / num].tangentWeight * (zero - vector) + scalar * points[j / num].tangentWeight * (array[j - 1] - vector2);
			}
			for (int k = 0; k < array.Length; k++)
			{
				array[k] = TangentPointToSphere(array[k], 1f);
			}
			return array;
		}

		private float GetScalar(int k)
		{
			if (k <= 3)
			{
				return 0.1667f;
			}
			return k switch
			{
				4 => 0.1036f, 
				5 => 0.085f, 
				6 => 0.0773f, 
				7 => 0.07f, 
				_ => 0.0625f, 
			};
		}

		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			float num = Vector3.Dot(axis, p);
			float num2 = 2f * r * r / (r * r + num);
			return num2 * p + (1f - num2) * -axis;
		}

		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			float num = Vector3.Dot(q - axis, q - axis);
			float num2 = 4f * r * r / (4f * r * r + num);
			return num2 * q + (1f - num2) * -axis;
		}

		private Quaternion LimitSwing(Quaternion rotation)
		{
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			Vector3 vector = rotation * axis;
			int reachCone = GetReachCone(vector);
			if (reachCone == -1)
			{
				if (!Warning.logged)
				{
					LogWarning("RotationLimitPolygonal reach cones are invalid.");
				}
				return rotation;
			}
			if (Vector3.Dot(reachCones[reachCone].B, vector) > 0f)
			{
				return rotation;
			}
			Vector3 rhs = Vector3.Cross(axis, vector);
			vector = Vector3.Cross(-reachCones[reachCone].B, rhs);
			return Quaternion.FromToRotation(rotation * axis, vector) * rotation;
		}

		private int GetReachCone(Vector3 L)
		{
			float num = Vector3.Dot(reachCones[0].S, L);
			for (int i = 0; i < reachCones.Length; i++)
			{
				float num2 = num;
				num = ((i >= reachCones.Length - 1) ? Vector3.Dot(reachCones[0].S, L) : Vector3.Dot(reachCones[i + 1].S, L));
				if (num2 >= 0f && num < 0f)
				{
					return i;
				}
			}
			return -1;
		}
	}
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Range(0f, 180f)]
		public float twistLimit = 180f;

		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html");
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		public void SetSpline(Keyframe[] keyframes)
		{
			spline.keys = keyframes;
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return RotationLimit.LimitTwist(LimitSwing(rotation), axis, base.secondaryAxis, twistLimit);
		}

		public Quaternion LimitSwing(Quaternion rotation)
		{
			if (axis == Vector3.zero)
			{
				return rotation;
			}
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			Vector3 vector = rotation * axis;
			float num = RotationLimit.GetOrthogonalAngle(vector, base.secondaryAxis, axis);
			if (Vector3.Dot(vector, base.crossAxis) < 0f)
			{
				num = 180f + (180f - num);
			}
			float maxDegreesDelta = spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(axis, vector);
			Quaternion quaternion = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, quaternion * axis) * rotation;
		}
	}
	public class AimController : MonoBehaviour
	{
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime = 0.3f;

		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime = 0.3f;

		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget = true;

		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta = 3f;

		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta = 3f;

		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed = 3f;

		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot = Vector3.up;

		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance = 1f;

		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle = 45f;

		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime = 0.2f;

		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection = Vector3.forward;

		private Transform lastTarget;

		private float switchWeight;

		private float switchWeightV;

		private float weightV;

		private Vector3 lastPosition;

		private Vector3 dir;

		private bool lastSmoothTowardsTarget;

		private bool turningToTarget;

		private float turnToTargetMlp = 1f;

		private float turnToTargetMlpV;

		private Vector3 pivot => ik.transform.position + ik.transform.rotation * pivotOffsetFromRoot;

		private void Start()
		{
			lastPosition = ik.solver.IKPosition;
			dir = ik.solver.IKPosition - pivot;
			ik.solver.target = null;
		}

		private void LateUpdate()
		{
			if (target != lastTarget)
			{
				if (lastTarget == null && target != null)
				{
					lastPosition = target.position;
					dir = target.position - pivot;
					ik.solver.IKPosition = target.position + offset;
				}
				else
				{
					lastPosition = ik.solver.IKPosition;
					dir = ik.solver.IKPosition - pivot;
				}
				switchWeight = 0f;
				lastTarget = target;
			}
			ik.solver.IKPositionWeight = Mathf.SmoothDamp(ik.solver.IKPositionWeight, (target != null) ? weight : 0f, ref weightV, weightSmoothTime);
			if (ik.solver.IKPositionWeight >= 0.999f)
			{
				ik.solver.IKPositionWeight = 1f;
			}
			if (ik.solver.IKPositionWeight <= 0.001f)
			{
				ik.solver.IKPositionWeight = 0f;
			}
			if (!(ik.solver.IKPositionWeight <= 0f))
			{
				switchWeight = Mathf.SmoothDamp(switchWeight, 1f, ref switchWeightV, targetSwitchSmoothTime);
				if (switchWeight >= 0.999f)
				{
					switchWeight = 1f;
				}
				if (target != null)
				{
					ik.solver.IKPosition = Vector3.Lerp(lastPosition, target.position + offset, switchWeight);
				}
				if (smoothTurnTowardsTarget != lastSmoothTowardsTarget)
				{
					dir = ik.solver.IKPosition - pivot;
					lastSmoothTowardsTarget = smoothTurnTowardsTarget;
				}
				if (smoothTurnTowardsTarget)
				{
					Vector3 b = ik.solver.IKPosition - pivot;
					dir = Vector3.Slerp(dir, b, Time.deltaTime * slerpSpeed);
					dir = Vector3.RotateTowards(dir, b, Time.deltaTime * maxRadiansDelta, maxMagnitudeDelta);
					ik.solver.IKPosition = pivot + dir;
				}
				ApplyMinDistance();
				RootRotation();
				if (useAnimatedAimDirection)
				{
					ik.solver.axis = ik.solver.transform.InverseTransformVector(ik.transform.rotation * animatedAimDirection);
				}
			}
		}

		private void ApplyMinDistance()
		{
			Vector3 vector = pivot;
			Vector3 vector2 = ik.solver.IKPosition - vector;
			vector2 = vector2.normalized * Mathf.Max(vector2.magnitude, minDistance);
			ik.solver.IKPosition = vector + vector2;
		}

		private void RootRotation()
		{
			float num = Mathf.Lerp(180f, maxRootAngle * turnToTargetMlp, ik.solver.IKPositionWeight);
			if (!(num < 180f))
			{
				return;
			}
			Vector3 vector = Quaternion.Inverse(ik.transform.rotation) * (ik.solver.IKPosition - pivot);
			float num2 = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			float angle = 0f;
			if (num2 > num)
			{
				angle = num2 - num;
				if (!turningToTarget && turnToTarget)
				{
					StartCoroutine(TurnToTarget());
				}
			}
			if (num2 < 0f - num)
			{
				angle = num2 + num;
				if (!turningToTarget && turnToTarget)
				{
					StartCoroutine(TurnToTarget());
				}
			}
			ik.transform.rotation = Quaternion.AngleAxis(angle, ik.transform.up) * ik.transform.rotation;
		}

		private IEnumerator TurnToTarget()
		{
			turningToTarget = true;
			while (turnToTargetMlp > 0f)
			{
				turnToTargetMlp = Mathf.SmoothDamp(turnToTargetMlp, 0f, ref turnToTargetMlpV, turnToTargetTime);
				if (turnToTargetMlp < 0.01f)
				{
					turnToTargetMlp = 0f;
				}
				yield return null;
			}
			turnToTargetMlp = 1f;
			turningToTarget = false;
		}
	}
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		public class Pose
		{
			public bool visualize = true;

			public string name;

			public Vector3 direction;

			public float yaw = 75f;

			public float pitch = 45f;

			private float angleBuffer;

			public bool IsInDirection(Vector3 d)
			{
				if (direction == Vector3.zero)
				{
					return false;
				}
				if (yaw <= 0f || pitch <= 0f)
				{
					return false;
				}
				if (yaw < 180f)
				{
					Vector3 vector = new Vector3(direction.x, 0f, direction.z);
					if (vector == Vector3.zero)
					{
						vector = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(d.x, 0f, d.z), vector) > yaw + angleBuffer)
					{
						return false;
					}
				}
				if (pitch >= 180f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, d) - num) < pitch + angleBuffer;
			}

			public void SetAngleBuffer(float value)
			{
				angleBuffer = value;
			}
		}

		public float angleBuffer = 5f;

		public Pose[] poses = new Pose[0];

		public Pose GetPose(Vector3 localDirection)
		{
			if (poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < poses.Length - 1; i++)
			{
				if (poses[i].IsInDirection(localDirection))
				{
					return poses[i];
				}
			}
			return poses[poses.Length - 1];
		}

		public void SetPoseActive(Pose pose)
		{
			for (int i = 0; i < poses.Length; i++)
			{
				poses[i].SetAngleBuffer((poses[i] == pose) ? angleBuffer : 0f);
			}
		}
	}
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;
			}

			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight = 1f;

			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight = 1f;

			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed = 3f;

			private Vector3 lastRelativePos;

			private Vector3 smoothDelta;

			private bool firstUpdate;

			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
				if (!(transform == null) && !(relativeTo == null))
				{
					Vector3 vector = relativeTo.InverseTransformDirection(transform.position - relativeTo.position);
					if (firstUpdate)
					{
						lastRelativePos = vector;
						firstUpdate = false;
					}
					Vector3 vector2 = (vector - lastRelativePos) / deltaTime;
					smoothDelta = ((speed <= 0f) ? vector2 : Vector3.Lerp(smoothDelta, vector2, deltaTime * speed));
					Vector3 v = relativeTo.TransformDirection(smoothDelta);
					Vector3 vector3 = V3Tools.ExtractVertical(v, solver.GetRoot().up, verticalWeight) + V3Tools.ExtractHorizontal(v, solver.GetRoot().up, horizontalWeight);
					for (int i = 0; i < effectorLinks.Length; i++)
					{
						solver.GetEffector(effectorLinks[i].effector).positionOffset += vector3 * w * effectorLinks[i].weight;
					}
					lastRelativePos = vector;
				}
			}

			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				v1.x *= v2.x;
				v1.y *= v2.y;
				v1.z *= v2.z;
				return v1;
			}
		}

		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		protected override void OnModifyOffset()
		{
			if (!ik.fixTransforms)
			{
				if (!Warning.logged)
				{
					Warning.Log("Amplifier needs the Fix Transforms option of the FBBIK to be set to true. Otherwise it might amplify to infinity, should the animator of the character stop because of culling.", base.transform);
				}
				return;
			}
			Body[] array = bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(ik.solver, weight, base.deltaTime);
			}
		}
	}
	public class BodyTilt : OffsetModifier
	{
		[Tooltip("Speed of tilting")]
		public float tiltSpeed = 6f;

		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity = 0.07f;

		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		private float tiltAngle;

		private Vector3 lastForward;

		protected override void Start()
		{
			base.Start();
			lastForward = base.transform.forward;
		}

		protected override void OnModifyOffset()
		{
			Quaternion quaternion = Quaternion.FromToRotation(lastForward, base.transform.forward);
			float angle = 0f;
			Vector3 axis = Vector3.zero;
			quaternion.ToAngleAxis(out angle, out axis);
			if (axis.y > 0f)
			{
				angle = 0f - angle;
			}
			angle *= tiltSensitivity * 0.01f;
			angle /= base.deltaTime;
			angle = Mathf.Clamp(angle, -1f, 1f);
			tiltAngle = Mathf.Lerp(tiltAngle, angle, base.deltaTime * tiltSpeed);
			float num = Mathf.Abs(tiltAngle) / 1f;
			if (tiltAngle < 0f)
			{
				poseRight.Apply(ik.solver, num);
			}
			else
			{
				poseLeft.Apply(ik.solver, num);
			}
			lastForward = base.transform.forward;
		}
	}
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		public abstract class HitPoint
		{
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			private float length;

			private float crossFadeSpeed;

			private float lastTime;

			public bool inProgress => timer < length;

			protected float crossFader { get; private set; }

			protected float timer { get; private set; }

			protected Vector3 force { get; private set; }

			protected Vector3 point { get; private set; }

			public void Hit(Vector3 force, Vector3 point)
			{
				if (length == 0f)
				{
					length = GetLength();
				}
				if (length <= 0f)
				{
					UnityEngine.Debug.LogError("Hit Point WeightCurve length is zero.");
					return;
				}
				if (timer < 1f)
				{
					crossFader = 0f;
				}
				crossFadeSpeed = ((crossFadeTime > 0f) ? (1f / crossFadeTime) : 0f);
				CrossFadeStart();
				timer = 0f;
				this.force = force;
				this.point = point;
			}

			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
				float num = Time.time - lastTime;
				lastTime = Time.time;
				if (!(timer >= length))
				{
					timer = Mathf.Clamp(timer + num, 0f, length);
					if (crossFadeSpeed > 0f)
					{
						crossFader = Mathf.Clamp(crossFader + num * crossFadeSpeed, 0f, 1f);
					}
					else
					{
						crossFader = 1f;
					}
					OnApply(solver, weight);
				}
			}

			protected abstract float GetLength();

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}

		[Serializable]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				private Vector3 lastValue;

				private Vector3 current;

				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
					current = Vector3.Lerp(lastValue, offset * weight, crossFader);
					solver.GetEffector(effector).positionOffset += current;
				}

				public void CrossFadeStart()
				{
					lastValue = current;
				}
			}

			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			protected override float GetLength()
			{
				float num = ((offsetInForceDirection.keys.Length != 0) ? offsetInForceDirection.keys[offsetInForceDirection.length - 1].time : 0f);
				float min = ((offsetInUpDirection.keys.Length != 0) ? offsetInUpDirection.keys[offsetInUpDirection.length - 1].time : 0f);
				return Mathf.Clamp(num, min, num);
			}

			protected override void CrossFadeStart()
			{
				EffectorLink[] array = effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				Vector3 vector = solver.GetRoot().up * base.force.magnitude;
				Vector3 offset = offsetInForceDirection.Evaluate(base.timer) * base.force + offsetInUpDirection.Evaluate(base.timer) * vector;
				offset *= weight;
				EffectorLink[] array = effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Apply(solver, offset, base.crossFader);
				}
			}
		}

		[Serializable]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			public class BoneLink
			{
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				private Quaternion lastValue = Quaternion.identity;

				private Quaternion current = Quaternion.identity;

				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
					current = Quaternion.Lerp(lastValue, Quaternion.Lerp(Quaternion.identity, offset, weight), crossFader);
					bone.rotation = current * bone.rotation;
				}

				public void CrossFadeStart()
				{
					lastValue = current;
				}
			}

			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			private Rigidbody rigidbody;

			protected override float GetLength()
			{
				if (aroundCenterOfMass.keys.Length == 0)
				{
					return 0f;
				}
				return aroundCenterOfMass.keys[aroundCenterOfMass.length - 1].time;
			}

			protected override void CrossFadeStart()
			{
				BoneLink[] array = boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				if (rigidbody == null)
				{
					rigidbody = collider.GetComponent<Rigidbody>();
				}
				if (rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - rigidbody.worldCenterOfMass);
					Quaternion offset = Quaternion.AngleAxis(aroundCenterOfMass.Evaluate(base.timer) * weight, axis);
					BoneLink[] array = boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Apply(solver, offset, base.crossFader);
					}
				}
			}
		}

		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		public bool inProgress
		{
			get
			{
				HitPointEffector[] array = effectorHitPoints;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].inProgress)
					{
						return true;
					}
				}
				HitPointBone[] array2 = boneHitPoints;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i].inProgress)
					{
						return true;
					}
				}
				return false;
			}
		}

		protected override void OnModifyOffset()
		{
			HitPointEffector[] array = effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(ik.solver, weight);
			}
			HitPointBone[] array2 = boneHitPoints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Apply(ik.solver, weight);
			}
		}

		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
			if (ik == null)
			{
				UnityEngine.Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			HitPointEffector[] array = effectorHitPoints;
			foreach (HitPointEffector hitPointEffector in array)
			{
				if (hitPointEffector.collider == collider)
				{
					hitPointEffector.Hit(force, point);
				}
			}
			HitPointBone[] array2 = boneHitPoints;
			foreach (HitPointBone hitPointBone in array2)
			{
				if (hitPointBone.collider == collider)
				{
					hitPointBone.Hit(force, point);
				}
			}
		}
	}
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		public abstract class Offset
		{
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			private float length;

			private float crossFadeSpeed;

			private float lastTime;

			protected float crossFader { get; private set; }

			protected float timer { get; private set; }

			protected Vector3 force { get; private set; }

			protected Vector3 point { get; private set; }

			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
				if (length == 0f)
				{
					length = GetLength(curves);
				}
				if (length <= 0f)
				{
					UnityEngine.Debug.LogError("Hit Point WeightCurve length is zero.");
					return;
				}
				if (timer < 1f)
				{
					crossFader = 0f;
				}
				crossFadeSpeed = ((crossFadeTime > 0f) ? (1f / crossFadeTime) : 0f);
				CrossFadeStart();
				timer = 0f;
				this.force = force;
				this.point = point;
			}

			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				float num = Time.time - lastTime;
				lastTime = Time.time;
				if (!(timer >= length))
				{
					timer = Mathf.Clamp(timer + num, 0f, length);
					if (crossFadeSpeed > 0f)
					{
						crossFader = Mathf.Clamp(crossFader + num * crossFadeSpeed, 0f, 1f);
					}
					else
					{
						crossFader = 1f;
					}
					OnApply(ik, curves, weight);
				}
			}

			protected abstract float GetLength(AnimationCurve[] curves);

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}

		[Serializable]
		public class PositionOffset : Offset
		{
			[Serializable]
			public class PositionOffsetLink
			{
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				private Vector3 lastValue;

				private Vector3 current;

				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
					current = Vector3.Lerp(lastValue, offset * weight, crossFader);
					ik.solver.AddPositionOffset(positionOffset, current);
				}

				public void CrossFadeStart()
				{
					lastValue = current;
				}
			}

			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex = 1;

			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			protected override float GetLength(AnimationCurve[] curves)
			{
				float num = ((curves[forceDirCurveIndex].keys.Length != 0) ? curves[forceDirCurveIndex].keys[curves[forceDirCurveIndex].length - 1].time : 0f);
				float min = ((curves[upDirCurveIndex].keys.Length != 0) ? curves[upDirCurveIndex].keys[curves[upDirCurveIndex].length - 1].time : 0f);
				return Mathf.Clamp(num, min, num);
			}

			protected override void CrossFadeStart()
			{
				PositionOffsetLink[] array = offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				Vector3 vector = ik.transform.up * base.force.magnitude;
				Vector3 offset = curves[forceDirCurveIndex].Evaluate(base.timer) * base.force + curves[upDirCurveIndex].Evaluate(base.timer) * vector;
				offset *= weight;
				PositionOffsetLink[] array = offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Apply(ik, offset, base.crossFader);
				}
			}
		}

		[Serializable]
		public class RotationOffset : Offset
		{
			[Serializable]
			public class RotationOffsetLink
			{
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				private Quaternion lastValue = Quaternion.identity;

				private Quaternion current = Quaternion.identity;

				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
					current = Quaternion.Lerp(lastValue, Quaternion.Lerp(Quaternion.identity, offset, weight), crossFader);
					ik.solver.AddRotationOffset(rotationOffset, current);
				}

				public void CrossFadeStart()
				{
					lastValue = current;
				}
			}

			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			private Rigidbody rigidbody;

			protected override float GetLength(AnimationCurve[] curves)
			{
				if (curves[curveIndex].keys.Length == 0)
				{
					return 0f;
				}
				return curves[curveIndex].keys[curves[curveIndex].length - 1].time;
			}

			protected override void CrossFadeStart()
			{
				RotationOffsetLink[] array = offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				if (collider == null)
				{
					UnityEngine.Debug.LogError("No collider assigned for a HitPointBone in the HitReaction component.");
					return;
				}
				if (rigidbody == null)
				{
					rigidbody = collider.GetComponent<Rigidbody>();
				}
				if (rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - rigidbody.worldCenterOfMass);
					Quaternion offset = Quaternion.AngleAxis(curves[curveIndex].Evaluate(base.timer) * weight, axis);
					RotationOffsetLink[] array = offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Apply(ik, offset, base.crossFader);
					}
				}
			}
		}

		public AnimationCurve[] offsetCurves;

		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		protected override void OnModifyOffset()
		{
			PositionOffset[] array = positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(ik, offsetCurves, weight);
			}
			RotationOffset[] array2 = rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Apply(ik, offsetCurves, weight);
			}
		}

		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
			if (ik == null)
			{
				UnityEngine.Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			PositionOffset[] array = positionOffsets;
			foreach (PositionOffset positionOffset in array)
			{
				if (positionOffset.collider == collider)
				{
					positionOffset.Hit(force, offsetCurves, point);
				}
			}
			RotationOffset[] array2 = rotationOffsets;
			foreach (RotationOffset rotationOffset in array2)
			{
				if (rotationOffset.collider == collider)
				{
					rotationOffset.Hit(force, offsetCurves, point);
				}
			}
		}
	}
	public class Inertia : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;
			}

			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Tooltip("The speed to follow the Transform")]
			public float speed = 10f;

			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration = 3f;

			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Tooltip("gravity applied to the Body")]
			public float gravity;

			private Vector3 delta;

			private Vector3 lazyPoint;

			private Vector3 direction;

			private Vector3 lastPosition;

			private bool firstUpdate = true;

			public void Reset()
			{
				if (!(transform == null))
				{
					lazyPoint = transform.position;
					lastPosition = transform.position;
					direction = Vector3.zero;
				}
			}

			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
				if (!(transform == null))
				{
					if (firstUpdate)
					{
						Reset();
						firstUpdate = false;
					}
					direction = Vector3.Lerp(direction, (transform.position - lazyPoint) / deltaTime * 0.01f, deltaTime * acceleration);
					lazyPoint += direction * deltaTime * speed;
					delta = transform.position - lastPosition;
					lazyPoint += delta * matchVelocity;
					lazyPoint.y += gravity * deltaTime;
					EffectorLink[] array = effectorLinks;
					foreach (EffectorLink effectorLink in array)
					{
						solver.GetEffector(effectorLink.effector).positionOffset += (lazyPoint - transform.position) * effectorLink.weight * weight;
					}
					lastPosition = transform.position;
				}
			}
		}

		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		public void ResetBodies()
		{
			lastTime = Time.time;
			Body[] array = bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
		}

		protected override void OnModifyOffset()
		{
			Body[] array = bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(ik.solver, weight, base.deltaTime);
			}
			ApplyLimits(limits);
		}
	}
	public class LookAtController : MonoBehaviour
	{
		public LookAtIK ik;

		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Range(0f, 1f)]
		public float weight = 1f;

		public Vector3 offset;

		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime = 0.3f;

		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime = 0.3f;

		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget = true;

		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta = 3f;

		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta = 3f;

		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed = 3f;

		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot = Vector3.up;

		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance = 1f;

		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle = 45f;

		private Transform lastTarget;

		private float switchWeight;

		private float switchWeightV;

		private float weightV;

		private Vector3 lastPosition;

		private Vector3 dir;

		private bool lastSmoothTowardsTarget;

		private Vector3 pivot => ik.transform.position + ik.transform.rotation * pivotOffsetFromRoot;

		private void Start()
		{
			lastPosition = ik.solver.IKPosition;
			dir = ik.solver.IKPosition - pivot;
		}

		private void LateUpdate()
		{
			if (target != lastTarget)
			{
				if (lastTarget == null && target != null)
				{
					lastPosition = target.position;
					dir = target.position - pivot;
					ik.solver.IKPosition = target.position + offset;
				}
				else
				{
					lastPosition = ik.solver.IKPosition;
					dir = ik.solver.IKPosition - pivot;
				}
				switchWeight = 0f;
				lastTarget = target;
			}
			ik.solver.IKPositionWeight = Mathf.SmoothDamp(ik.solver.IKPositionWeight, (target != null) ? weight : 0f, ref weightV, weightSmoothTime);
			if (ik.solver.IKPositionWeight >= 0.999f)
			{
				ik.solver.IKPositionWeight = 1f;
			}
			if (ik.solver.IKPositionWeight <= 0.001f)
			{
				ik.solver.IKPositionWeight = 0f;
			}
			if (!(ik.solver.IKPositionWeight <= 0f))
			{
				switchWeight = Mathf.SmoothDamp(switchWeight, 1f, ref switchWeightV, targetSwitchSmoothTime);
				if (switchWeight >= 0.999f)
				{
					switchWeight = 1f;
				}
				if (target != null)
				{
					ik.solver.IKPosition = Vector3.Lerp(lastPosition, target.position + offset, switchWeight);
				}
				if (smoothTurnTowardsTarget != lastSmoothTowardsTarget)
				{
					dir = ik.solver.IKPosition - pivot;
					lastSmoothTowardsTarget = smoothTurnTowardsTarget;
				}
				if (smoothTurnTowardsTarget)
				{
					Vector3 b = ik.solver.IKPosition - pivot;
					dir = Vector3.Slerp(dir, b, Time.deltaTime * slerpSpeed);
					dir = Vector3.RotateTowards(dir, b, Time.deltaTime * maxRadiansDelta, maxMagnitudeDelta);
					ik.solver.IKPosition = pivot + dir;
				}
				ApplyMinDistance();
				RootRotation();
			}
		}

		private void ApplyMinDistance()
		{
			Vector3 vector = pivot;
			Vector3 vector2 = ik.solver.IKPosition - vector;
			vector2 = vector2.normalized * Mathf.Max(vector2.magnitude, minDistance);
			ik.solver.IKPosition = vector + vector2;
		}

		private void RootRotation()
		{
			float num = Mathf.Lerp(180f, maxRootAngle, ik.solver.IKPositionWeight);
			if (num < 180f)
			{
				Vector3 vector = Quaternion.Inverse(ik.transform.rotation) * (ik.solver.IKPosition - pivot);
				float num2 = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float angle = 0f;
				if (num2 > num)
				{
					angle = num2 - num;
				}
				if (num2 < 0f - num)
				{
					angle = num2 + num;
				}
				ik.transform.rotation = Quaternion.AngleAxis(angle, ik.transform.up) * ik.transform.rotation;
			}
		}
	}
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		public class OffsetLimits
		{
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Tooltip("The limits")]
			public float minX;

			[Tooltip("The limits")]
			public float maxX;

			[Tooltip("The limits")]
			public float minY;

			[Tooltip("The limits")]
			public float maxY;

			[Tooltip("The limits")]
			public float minZ;

			[Tooltip("The limits")]
			public float maxZ;

			public void Apply(IKEffector e, Quaternion rootRotation)
			{
				Vector3 vector = Quaternion.Inverse(rootRotation) * e.positionOffset;
				if (spring <= 0f)
				{
					if (x)
					{
						vector.x = Mathf.Clamp(vector.x, minX, maxX);
					}
					if (y)
					{
						vector.y = Mathf.Clamp(vector.y, minY, maxY);
					}
					if (z)
					{
						vector.z = Mathf.Clamp(vector.z, minZ, maxZ);
					}
				}
				else
				{
					if (x)
					{
						vector.x = SpringAxis(vector.x, minX, maxX);
					}
					if (y)
					{
						vector.y = SpringAxis(vector.y, minY, maxY);
					}
					if (z)
					{
						vector.z = SpringAxis(vector.z, minZ, maxZ);
					}
				}
				e.positionOffset = rootRotation * vector;
			}

			private float SpringAxis(float value, float min, float max)
			{
				if (value > min && value < max)
				{
					return value;
				}
				if (value < min)
				{
					return Spring(value, min, negative: true);
				}
				return Spring(value, max, negative: false);
			}

			private float Spring(float value, float limit, bool negative)
			{
				float num = value - limit;
				float num2 = num * spring;
				if (negative)
				{
					return value + Mathf.Clamp(0f - num2, 0f, 0f - num);
				}
				return value - Mathf.Clamp(num2, 0f, num);
			}
		}

		[Tooltip("The master weight")]
		public float weight = 1f;

		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		protected float lastTime;

		protected float deltaTime => Time.time - lastTime;

		protected abstract void OnModifyOffset();

		protected virtual void Start()
		{
			StartCoroutine(Initiate());
		}

		private IEnumerator Initiate()
		{
			while (ik == null)
			{
				yield return null;
			}
			IKSolverFullBodyBiped solver = ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(ModifyOffset));
			lastTime = Time.time;
		}

		private void ModifyOffset()
		{
			if (base.enabled && !(weight <= 0f) && !(deltaTime <= 0f) && !(ik == null))
			{
				weight = Mathf.Clamp(weight, 0f, 1f);
				OnModifyOffset();
				lastTime = Time.time;
			}
		}

		protected void ApplyLimits(OffsetLimits[] limits)
		{
			foreach (OffsetLimits offsetLimits in limits)
			{
				offsetLimits.Apply(ik.solver.GetEffector(offsetLimits.effector), base.transform.rotation);
			}
		}

		protected virtual void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(ModifyOffset));
			}
		}
	}
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Tooltip("The master weight")]
		public float weight = 1f;

		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		private float lastTime;

		protected float deltaTime => Time.time - lastTime;

		protected abstract void OnModifyOffset();

		protected virtual void Start()
		{
			StartCoroutine(Initiate());
		}

		private IEnumerator Initiate()
		{
			while (ik == null)
			{
				yield return null;
			}
			IKSolverVR solver = ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(ModifyOffset));
			lastTime = Time.time;
		}

		private void ModifyOffset()
		{
			if (base.enabled && !(weight <= 0f) && !(deltaTime <= 0f) && !(ik == null))
			{
				weight = Mathf.Clamp(weight, 0f, 1f);
				OnModifyOffset();
				lastTime = Time.time;
			}
		}

		protected virtual void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverVR solver = ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(ModifyOffset));
			}
		}
	}
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			public FullBodyBipedEffector effector;

			public Vector3 offset;

			public Vector3 pin;

			public Vector3 pinWeight;

			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
				solver.GetEffector(effector).positionOffset += rotation * offset * weight;
				Vector3 vector = solver.GetRoot().position + rotation * pin - solver.GetEffector(effector).bone.position;
				Vector3 vector2 = pinWeight * Mathf.Abs(weight);
				solver.GetEffector(effector).positionOffset = new Vector3(Mathf.Lerp(solver.GetEffector(effector).positionOffset.x, vector.x, vector2.x), Mathf.Lerp(solver.GetEffector(effector).positionOffset.y, vector.y, vector2.y), Mathf.Lerp(solver.GetEffector(effector).positionOffset.z, vector.z, vector2.z));
			}
		}

		public EffectorLink[] effectorLinks = new EffectorLink[0];

		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
			for (int i = 0; i < effectorLinks.Length; i++)
			{
				effectorLinks[i].Apply(solver, weight, solver.GetRoot().rotation);
			}
		}

		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
			for (int i = 0; i < effectorLinks.Length; i++)
			{
				effectorLinks[i].Apply(solver, weight, rotation);
			}
		}
	}
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		public class Avoider
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;
			}

			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn = 0.1f;

			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut = 0.3f;

			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			private Vector3 offset;

			private Vector3 offsetTarget;

			private Vector3 offsetV;

			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
				offsetTarget = GetOffsetTarget(solver);
				float smoothTime = ((offsetTarget.sqrMagnitude > offset.sqrMagnitude) ? smoothTimeIn : smoothTimeOut);
				offset = Vector3.SmoothDamp(offset, offsetTarget, ref offsetV, smoothTime);
				EffectorLink[] array = effectors;
				foreach (EffectorLink effectorLink in array)
				{
					solver.GetEffector(effectorLink.effector).positionOffset += offset * weight * effectorLink.weight;
				}
			}

			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				Vector3 zero = Vector3.zero;
				Transform[] array = raycastFrom;
				foreach (Transform transform in array)
				{
					zero += Raycast(transform.position, raycastTo.position + zero);
				}
				return zero;
			}

			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				Vector3 direction = to - from;
				float magnitude = direction.magnitude;
				RaycastHit hitInfo;
				if (raycastRadius <= 0f)
				{
					Physics.Raycast(from, direction, out hitInfo, magnitude, layers);
				}
				else
				{
					Physics.SphereCast(from, raycastRadius, direction, out hitInfo, magnitude, layers);
				}
				if (hitInfo.collider == null)
				{
					return Vector3.zero;
				}
				return Vector3.Project(-direction.normalized * (magnitude - hitInfo.distance), hitInfo.normal);
			}
		}

		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		protected override void OnModifyOffset()
		{
			Avoider[] array = avoiders;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Solve(ik.solver, weight);
			}
		}
	}
	public class Recoil : OffsetModifier
	{
		[Serializable]
		public class RecoilOffset
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;
			}

			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity = 1f;

			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag = 0.2f;

			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			private Vector3 additiveOffset;

			private Vector3 lastOffset;

			public void Start()
			{
				if (!(additivity <= 0f))
				{
					additiveOffset = Vector3.ClampMagnitude(lastOffset * additivity, maxAdditiveOffsetMag);
				}
			}

			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
				additiveOffset = Vector3.Lerp(Vector3.zero, additiveOffset, timeLeft / length);
				lastOffset = rotation * (offset * masterWeight) + rotation * additiveOffset;
				EffectorLink[] array = effectorLinks;
				foreach (EffectorLink effectorLink in array)
				{
					solver.GetEffector(effectorLink.effector).positionOffset += lastOffset * effectorLink.weight;
				}
			}
		}

		[Serializable]
		public enum Handedness
		{
			Right,
			Left
		}

		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded = true;

		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom = 0.1f;

		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[HideInInspector]
		public Quaternion rotationOffset = Quaternion.identity;

		private float magnitudeMlp = 1f;

		private float endTime = -1f;

		private Quaternion handRotation;

		private Quaternion secondaryHandRelativeRotation;

		private Quaternion randomRotation;

		private float length = 1f;

		private bool initiated;

		private float blendWeight;

		private float w;

		private Quaternion primaryHandRotation = Quaternion.identity;

		private bool handRotationsSet;

		private Vector3 aimIKAxis;

		public bool isFinished => Time.time > endTime;

		private IKEffector primaryHandEffector
		{
			get
			{
				if (handedness == Handedness.Right)
				{
					return ik.solver.rightHandEffector;
				}
				return ik.solver.leftHandEffector;
			}
		}

		private IKEffector secondaryHandEffector
		{
			get
			{
				if (handedness == Handedness.Right)
				{
					return ik.solver.leftHandEffector;
				}
				return ik.solver.rightHandEffector;
			}
		}

		private Transform primaryHand => primaryHandEffector.bone;

		private Transform secondaryHand => secondaryHandEffector.bone;

		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
			if (handedness == Handedness.Left)
			{
				primaryHandRotation = leftHandRotation;
			}
			else
			{
				primaryHandRotation = rightHandRotation;
			}
			handRotationsSet = true;
		}

		public void Fire(float magnitude)
		{
			float num = magnitude * UnityEngine.Random.value * magnitudeRandom;
			magnitudeMlp = magnitude + num;
			randomRotation = Quaternion.Euler(rotationRandom * UnityEngine.Random.value);
			RecoilOffset[] array = offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Start();
			}
			if (Time.time < endTime)
			{
				blendWeight = 0f;
			}
			else
			{
				blendWeight = 1f;
			}
			length = recoilWeight.keys[^1].time;
			endTime = Time.time + length;
		}

		protected override void OnModifyOffset()
		{
			if (aimIK != null)
			{
				aimIKAxis = aimIK.solver.axis;
			}
			if (Time.time >= endTime)
			{
				rotationOffset = Quaternion.identity;
				return;
			}
			if (!initiated && ik != null)
			{
				initiated = true;
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(AfterFBBIK));
				if (aimIK != null)
				{
					IKSolverAim solver2 = aimIK.solver;
					solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(AfterAimIK));
				}
			}
			blendTime = Mathf.Max(blendTime, 0f);
			if (blendTime > 0f)
			{
				blendWeight = Mathf.Min(blendWeight + Time.deltaTime * (1f / blendTime), 1f);
			}
			else
			{
				blendWeight = 1f;
			}
			float b = recoilWeight.Evaluate(length - (endTime - Time.time)) * magnitudeMlp;
			w = Mathf.Lerp(w, b, blendWeight);
			Quaternion quaternion = ((aimIK != null && aimIK.solver.transform != null && !aimIKSolvedLast) ? Quaternion.LookRotation(aimIK.solver.IKPosition - aimIK.solver.transform.position, ik.references.root.up) : ik.references.root.rotation);
			quaternion = randomRotation * quaternion;
			RecoilOffset[] array = offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(ik.solver, quaternion, w, length, endTime - Time.time);
			}
			if (!handRotationsSet)
			{
				primaryHandRotation = primaryHand.rotation;
			}
			handRotationsSet = false;
			rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(randomRotation * primaryHandRotation * handRotationOffset), w);
			handRotation = rotationOffset * primaryHandRotation;
			if (twoHanded)
			{
				Vector3 vector = Quaternion.Inverse(primaryHand.rotation) * (secondaryHand.position - primaryHand.position);
				secondaryHandRelativeRotation = Quaternion.Inverse(primaryHand.rotation) * secondaryHand.rotation;
				Vector3 vector2 = primaryHand.position + primaryHandEffector.positionOffset + handRotation * vector;
				secondaryHandEffector.positionOffset += vector2 - (secondaryHand.position + secondaryHandEffector.positionOffset);
			}
			if (aimIK != null && aimIKSolvedLast)
			{
				aimIK.solver.axis = Quaternion.Inverse(ik.references.root.rotation) * Quaternion.Inverse(rotationOffset) * aimIKAxis;
			}
		}

		private void AfterFBBIK()
		{
			if (!(Time.time >= endTime))
			{
				primaryHand.rotation = handRotation;
				if (twoHanded)
				{
					secondaryHand.rotation = primaryHand.rotation * secondaryHandRelativeRotation;
				}
			}
		}

		private void AfterAimIK()
		{
			if (aimIKSolvedLast)
			{
				aimIK.solver.axis = aimIKAxis;
			}
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (ik != null && initiated)
			{
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(AfterFBBIK));
				if (aimIK != null)
				{
					IKSolverAim solver2 = aimIK.solver;
					solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(AfterAimIK));
				}
			}
		}
	}
	public class ShoulderRotator : MonoBehaviour
	{
		[Tooltip("Weight of shoulder rotation")]
		public float weight = 1.5f;

		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset = 0.2f;

		private FullBodyBipedIK ik;

		private bool skip;

		private void Start()
		{
			ik = GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = ik.solver;
			solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(RotateShoulders));
		}

		private void RotateShoulders()
		{
			if (!(ik == null) && !(ik.solver.IKPositionWeight <= 0f))
			{
				if (skip)
				{
					skip = false;
					return;
				}
				RotateShoulder(FullBodyBipedChain.LeftArm, weight, offset);
				RotateShoulder(FullBodyBipedChain.RightArm, weight, offset);
				skip = true;
				ik.solver.Update();
			}
		}

		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
			Quaternion b = Quaternion.FromToRotation(GetParentBoneMap(chain).swingDirection, ik.solver.GetEndEffector(chain).position - GetParentBoneMap(chain).transform.position);
			Vector3 vector = ik.solver.GetEndEffector(chain).position - ik.solver.GetLimbMapping(chain).bone1.position;
			float num = ik.solver.GetChain(chain).nodes[0].length + ik.solver.GetChain(chain).nodes[1].length;
			float num2 = vector.magnitude / num - 1f + offset;
			num2 = Mathf.Clamp(num2 * weight, 0f, 1f);
			Quaternion quaternion = Quaternion.Lerp(Quaternion.identity, b, num2 * ik.solver.GetEndEffector(chain).positionWeight * ik.solver.IKPositionWeight);
			ik.solver.GetLimbMapping(chain).parentBone.rotation = quaternion * ik.solver.GetLimbMapping(chain).parentBone.rotation;
		}

		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return ik.solver.GetLimbMapping(chain).GetBoneMap(IKMappingLimb.BoneMapType.Parent);
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverFullBodyBiped solver = ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(RotateShoulders));
			}
		}
	}
	public static class VRIKCalibrator
	{
		[Serializable]
		public class Settings
		{
			[Tooltip("Multiplies character scale")]
			public float scaleMlp = 1f;

			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward = Vector3.forward;

			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp = Vector3.up;

			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward = Vector3.forward;

			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp = Vector3.up;

			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward = Vector3.forward;

			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp = Vector3.up;

			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward = Vector3.forward;

			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp = Vector3.up;

			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Range(0f, 1f)]
			public float pelvisPositionWeight = 1f;

			[Range(0f, 1f)]
			public float pelvisRotationWeight = 1f;
		}

		[Serializable]
		public class CalibrationData
		{
			[Serializable]
			public class Target
			{
				public bool used;

				public Vector3 localPosition;

				public Quaternion localRotation;

				public Target(Transform t)
				{
					used = t != null;
					if (used)
					{
						localPosition = t.localPosition;
						localRotation = t.localRotation;
					}
				}

				public void SetTo(Transform t)
				{
					if (used)
					{
						t.localPosition = localPosition;
						t.localRotation = localRotation;
					}
				}
			}

			public float scale;

			public Target head;

			public Target leftHand;

			public Target rightHand;

			public Target pelvis;

			public Target leftFoot;

			public Target rightFoot;

			public Target leftLegGoal;

			public Target rightLegGoal;

			public Vector3 pelvisTargetRight;

			public float pelvisPositionWeight;

			public float pelvisRotationWeight;
		}

		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
			float num = (ik.solver.spine.headTarget.position.y - ik.references.root.position.y) / (ik.references.head.position.y - ik.references.root.position.y);
			ik.references.root.localScale *= num * settings.scaleMlp;
		}

		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null)
		{
			if (!ik.solver.initiated)
			{
				UnityEngine.Debug.LogError("Can not calibrate before VRIK has initiated.");
				return null;
			}
			if (headTracker == null)
			{
				UnityEngine.Debug.LogError("Can not calibrate VRIK without the head tracker.");
				return null;
			}
			CalibrationData calibrationData = new CalibrationData();
			ik.solver.FixTransforms();
			Vector3 position = headTracker.position + headTracker.rotation * Quaternion.LookRotation(settings.headTrackerForward, settings.headTrackerUp) * settings.headOffset;
			ik.references.root.position = new Vector3(position.x, ik.references.root.position.y, position.z);
			Vector3 forward = headTracker.rotation * settings.headTrackerForward;
			forward.y = 0f;
			ik.references.root.rotation = Quaternion.LookRotation(forward);
			Transform transform = ((ik.solver.spine.headTarget == null) ? new GameObject("Head Target").transform : ik.solver.spine.headTarget);
			transform.position = position;
			transform.rotation = ik.references.head.rotation;
			transform.parent = headTracker;
			ik.solver.spine.headTarget = transform;
			float num = (transform.position.y - ik.references.root.position.y) / (ik.references.head.position.y - ik.references.root.position.y);
			ik.references.root.localScale *= num * settings.scaleMlp;
			if (bodyTracker != null)
			{
				Transform transform2 = ((ik.solver.spine.pelvisTarget == null) ? new GameObject("Pelvis Target").transform : ik.solver.spine.pelvisTarget);
				transform2.position = ik.references.pelvis.position;
				transform2.rotation = ik.references.pelvis.rotation;
				transform2.parent = bodyTracker;
				ik.solver.spine.pelvisTarget = transform2;
				ik.solver.spine.pelvisPositionWeight = settings.pelvisPositionWeight;
				ik.solver.spine.pelvisRotationWeight = settings.pelvisRotationWeight;
				ik.solver.plantFeet = false;
				ik.solver.spine.maxRootAngle = 180f;
			}
			else if (leftFootTracker != null && rightFootTracker != null)
			{
				ik.solver.spine.maxRootAngle = 0f;
			}
			if (leftHandTracker != null)
			{
				Transform transform3 = ((ik.solver.leftArm.target == null) ? new GameObject("Left Hand Target").transform : ik.solver.leftArm.target);
				transform3.position = leftHandTracker.position + leftHandTracker.rotation * Quaternion.LookRotation(settings.handTrackerForward, settings.handTrackerUp) * settings.handOffset;
				transform3.rotation = QuaTools.MatchRotation(upAxis: Vector3.Cross(ik.solver.leftArm.wristToPalmAxis, ik.solver.leftArm.palmToThumbAxis), targetRotation: leftHandTracker.rotation * Quaternion.LookRotation(settings.handTrackerForward, settings.handTrackerUp), targetforwardAxis: settings.handTrackerForward, targetUpAxis: settings.handTrackerUp, forwardAxis: ik.solver.leftArm.wristToPalmAxis);
				transform3.parent = leftHandTracker;
				ik.solver.leftArm.target = transform3;
				ik.solver.leftArm.positionWeight = 1f;
				ik.solver.leftArm.rotationWeight = 1f;
			}
			else
			{
				ik.solver.leftArm.positionWeight = 0f;
				ik.solver.leftArm.rotationWeight = 0f;
			}
			if (rightHandTracker != null)
			{
				Transform transform4 = ((ik.solver.rightArm.target == null) ? new GameObject("Right Hand Target").transform : ik.solver.rightArm.target);
				transform4.position = rightHandTracker.position + rightHandTracker.rotation * Quaternion.LookRotation(settings.handTrackerForward, settings.handTrackerUp) * settings.handOffset;
				transform4.rotation = QuaTools.MatchRotation(upAxis: -Vector3.Cross(ik.solver.rightArm.wristToPalmAxis, ik.solver.rightArm.palmToThumbAxis), targetRotation: rightHandTracker.rotation * Quaternion.LookRotation(settings.handTrackerForward, settings.handTrackerUp), targetforwardAxis: settings.handTrackerForward, targetUpAxis: settings.handTrackerUp, forwardAxis: ik.solver.rightArm.wristToPalmAxis);
				transform4.parent = rightHandTracker;
				ik.solver.rightArm.target = transform4;
				ik.solver.rightArm.positionWeight = 1f;
				ik.solver.rightArm.rotationWeight = 1f;
			}
			else
			{
				ik.solver.rightArm.positionWeight = 0f;
				ik.solver.rightArm.rotationWeight = 0f;
			}
			if (leftFootTracker != null)
			{
				CalibrateLeg(settings, leftFootTracker, ik.solver.leftLeg, (ik.references.leftToes != null) ? ik.references.leftToes : ik.references.leftFoot, ik.references.root.forward, isLeft: true);
			}
			if (rightFootTracker != null)
			{
				CalibrateLeg(settings, rightFootTracker, ik.solver.rightLeg, (ik.references.rightToes != null) ? ik.references.rightToes : ik.references.rightFoot, ik.references.root.forward, isLeft: false);
			}
			bool num2 = bodyTracker != null || (leftFootTracker != null && rightFootTracker != null);
			VRIKRootController vRIKRootController = ik.references.root.GetComponent<VRIKRootController>();
			if (num2)
			{
				if (vRIKRootController == null)
				{
					vRIKRootController = ik.references.root.gameObject.AddComponent<VRIKRootController>();
				}
				vRIKRootController.Calibrate();
			}
			else if (vRIKRootController != null)
			{
				UnityEngine.Object.Destroy(vRIKRootController);
			}
			ik.solver.spine.minHeadHeight = 0f;
			ik.solver.locomotion.weight = ((bodyTracker == null && leftFootTracker == null && rightFootTracker == null) ? 1f : 0f);
			calibrationData.scale = ik.references.root.localScale.y;
			calibrationData.head = new CalibrationData.Target(ik.solver.spine.headTarget);
			calibrationData.pelvis = new CalibrationData.Target(ik.solver.spine.pelvisTarget);
			calibrationData.leftHand = new CalibrationData.Target(ik.solver.leftArm.target);
			calibrationData.rightHand = new CalibrationData.Target(ik.solver.rightArm.target);
			calibrationData.leftFoot = new CalibrationData.Target(ik.solver.leftLeg.target);
			calibrationData.rightFoot = new CalibrationData.Target(ik.solver.rightLeg.target);
			calibrationData.leftLegGoal = new CalibrationData.Target(ik.solver.leftLeg.bendGoal);
			calibrationData.rightLegGoal = new CalibrationData.Target(ik.solver.rightLeg.bendGoal);
			calibrationData.pelvisTargetRight = vRIKRootController.pelvisTargetRight;
			calibrationData.pelvisPositionWeight = ik.solver.spine.pelvisPositionWeight;
			calibrationData.pelvisRotationWeight = ik.solver.spine.pelvisRotationWeight;
			return calibrationData;
		}

		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
			string text = (isLeft ? "Left" : "Right");
			Transform transform = ((leg.target == null) ? new GameObject(text + " Foot Target").transform : leg.target);
			Quaternion quaternion = tracker.rotation * Quaternion.LookRotation(settings.footTrackerForward, settings.footTrackerUp);
			Vector3 vector = quaternion * Vector3.forward;
			vector.y = 0f;
			quaternion = Quaternion.LookRotation(vector);
			float x = (isLeft ? settings.footInwardOffset : (0f - settings.footInwardOffset));
			transform.position = tracker.position + quaternion * new Vector3(x, 0f, settings.footForwardOffset);
			transform.position = new Vector3(transform.position.x, lastBone.position.y, transform.position.z);
			transform.rotation = lastBone.rotation;
			Vector3 vector2 = AxisTools.GetAxisVectorToDirection(lastBone, rootForward);
			if (Vector3.Dot(lastBone.rotation * vector2, rootForward) < 0f)
			{
				vector2 = -vector2;
			}
			Vector3 vector3 = Quaternion.Inverse(Quaternion.LookRotation(transform.rotation * vector2)) * vector;
			float num = Mathf.Atan2(vector3.x, vector3.z) * 57.29578f;
			float num2 = (isLeft ? settings.footHeadingOffset : (0f - settings.footHeadingOffset));
			transform.rotation = Quaternion.AngleAxis(num + num2, Vector3.up) * transform.rotation;
			transform.parent = tracker;
			leg.target = transform;
			leg.positionWeight = 1f;
			leg.rotationWeight = 1f;
			Transform transform2 = ((leg.bendGoal == null) ? new GameObject(text + " Leg Bend Goal").transform : leg.bendGoal);
			transform2.position = lastBone.position + quaternion * Vector3.forward + quaternion * Vector3.up;
			transform2.parent = tracker;
			leg.bendGoal = transform2;
			leg.bendGoalWeight = 1f;
		}

		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null)
		{
			if (!ik.solver.initiated)
			{
				UnityEngine.Debug.LogError("Can not calibrate before VRIK has initiated.");
				return;
			}
			if (headTracker == null)
			{
				UnityEngine.Debug.LogError("Can not calibrate VRIK without the head tracker.");
				return;
			}
			ik.solver.FixTransforms();
			Transform transform = ((ik.solver.spine.headTarget == null) ? new GameObject("Head Target").transform : ik.solver.spine.headTarget);
			transform.parent = headTracker;
			data.head.SetTo(transform);
			ik.solver.spine.headTarget = transform;
			ik.references.root.localScale = data.scale * Vector3.one;
			if (bodyTracker != null)
			{
				Transform transform2 = ((ik.solver.spine.pelvisTarget == null) ? new GameObject("Pelvis Target").transform : ik.solver.spine.pelvisTarget);
				transform2.parent = bodyTracker;
				data.pelvis.SetTo(transform2);
				ik.solver.spine.pelvisTarget = transform2;
				ik.solver.spine.pelvisPositionWeight = data.pelvisPositionWeight;
				ik.solver.spine.pelvisRotationWeight = data.pelvisRotationWeight;
				ik.solver.plantFeet = false;
				ik.solver.spine.maxRootAngle = 180f;
			}
			else if (leftFootTracker != null && rightFootTracker != null)
			{
				ik.solver.spine.maxRootAngle = 0f;
			}
			if (leftHandTracker != null)
			{
				Transform transform3 = ((ik.solver.leftArm.target == null) ? new GameObject("Left Hand Target").transform : ik.solver.leftArm.target);
				transform3.parent = leftHandTracker;
				data.leftHand.SetTo(transform3);
				ik.solver.leftArm.target = transform3;
				ik.solver.leftArm.positionWeight = 1f;
				ik.solver.leftArm.rotationWeight = 1f;
			}
			else
			{
				ik.solver.leftArm.positionWeight = 0f;
				ik.solver.leftArm.rotationWeight = 0f;
			}
			if (rightHandTracker != null)
			{
				Transform transform4 = ((ik.solver.rightArm.target == null) ? new GameObject("Right Hand Target").transform : ik.solver.rightArm.target);
				transform4.parent = rightHandTracker;
				data.rightHand.SetTo(transform4);
				ik.solver.rightArm.target = transform4;
				ik.solver.rightArm.positionWeight = 1f;
				ik.solver.rightArm.rotationWeight = 1f;
			}
			else
			{
				ik.solver.rightArm.positionWeight = 0f;
				ik.solver.rightArm.rotationWeight = 0f;
			}
			if (leftFootTracker != null)
			{
				CalibrateLeg(data, leftFootTracker, ik.solver.leftLeg, (ik.references.leftToes != null) ? ik.references.leftToes : ik.references.leftFoot, ik.references.root.forward, isLeft: true);
			}
			if (rightFootTracker != null)
			{
				CalibrateLeg(data, rightFootTracker, ik.solver.rightLeg, (ik.references.rightToes != null) ? ik.references.rightToes : ik.references.rightFoot, ik.references.root.forward, isLeft: false);
			}
			bool num = bodyTracker != null || (leftFootTracker != null && rightFootTracker != null);
			VRIKRootController vRIKRootController = ik.references.root.GetComponent<VRIKRootController>();
			if (num)
			{
				if (vRIKRootController == null)
				{
					vRIKRootController = ik.references.root.gameObject.AddComponent<VRIKRootController>();
				}
				vRIKRootController.Calibrate(data);
			}
			else if (vRIKRootController != null)
			{
				UnityEngine.Object.Destroy(vRIKRootController);
			}
			ik.solver.spine.minHeadHeight = 0f;
			ik.solver.locomotion.weight = ((bodyTracker == null && leftFootTracker == null && rightFootTracker == null) ? 1f : 0f);
		}

		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
			string text = (isLeft ? "Left" : "Right");
			Transform transform = ((leg.target == null) ? new GameObject(text + " Foot Target").transform : leg.target);
			transform.parent = tracker;
			if (isLeft)
			{
				data.leftFoot.SetTo(transform);
			}
			else
			{
				data.rightFoot.SetTo(transform);
			}
			leg.target = transform;
			leg.positionWeight = 1f;
			leg.rotationWeight = 1f;
			Transform transform2 = ((leg.bendGoal == null) ? new GameObject(text + " Leg Bend Goal").transform : leg.bendGoal);
			transform2.parent = tracker;
			if (isLeft)
			{
				data.leftLegGoal.SetTo(transform2);
			}
			else
			{
				data.rightLegGoal.SetTo(transform2);
			}
			leg.bendGoal = transform2;
			leg.bendGoalWeight = 1f;
		}
	}
	public class VRIKRootController : MonoBehaviour
	{
		private Transform pelvisTarget;

		private Transform leftFootTarget;

		private Transform rightFootTarget;

		private VRIK ik;

		public Vector3 pelvisTargetRight { get; private set; }

		private void Awake()
		{
			ik = GetComponent<VRIK>();
			IKSolverVR solver = ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(OnPreUpdate));
			Calibrate();
		}

		public void Calibrate()
		{
			if (ik == null)
			{
				UnityEngine.Debug.LogError("No VRIK found on VRIKRootController's GameObject.", base.transform);
				return;
			}
			pelvisTarget = ik.solver.spine.pelvisTarget;
			leftFootTarget = ik.solver.leftLeg.target;
			rightFootTarget = ik.solver.rightLeg.target;
			if (pelvisTarget != null)
			{
				pelvisTargetRight = Quaternion.Inverse(pelvisTarget.rotation) * ik.references.root.right;
			}
		}

		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
			if (ik == null)
			{
				UnityEngine.Debug.LogError("No VRIK found on VRIKRootController's GameObject.", base.transform);
				return;
			}
			pelvisTarget = ik.solver.spine.pelvisTarget;
			leftFootTarget = ik.solver.leftLeg.target;
			rightFootTarget = ik.solver.rightLeg.target;
			if (pelvisTarget != null)
			{
				pelvisTargetRight = data.pelvisTargetRight;
			}
		}

		private void OnPreUpdate()
		{
			if (base.enabled)
			{
				if (pelvisTarget != null)
				{
					ik.references.root.position = new Vector3(pelvisTarget.position.x, ik.references.root.position.y, pelvisTarget.position.z);
					Vector3 forward = Vector3.Cross(pelvisTarget.rotation * pelvisTargetRight, ik.references.root.up);
					forward.y = 0f;
					ik.references.root.rotation = Quaternion.LookRotation(forward);
					ik.references.pelvis.position = Vector3.Lerp(ik.references.pelvis.position, pelvisTarget.position, ik.solver.spine.pelvisPositionWeight);
					ik.references.pelvis.rotation = Quaternion.Slerp(ik.references.pelvis.rotation, pelvisTarget.rotation, ik.solver.spine.pelvisRotationWeight);
				}
				else if (leftFootTarget != null && rightFootTarget != null)
				{
					ik.references.root.position = Vector3.Lerp(leftFootTarget.position, rightFootTarget.position, 0.5f);
				}
			}
		}

		private void OnDestroy()
		{
			if (ik != null)
			{
				IKSolverVR solver = ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(OnPreUpdate));
			}
		}
	}
}
namespace DG.Tweening
{
	public static class DOTweenModuleAudio
	{
		public static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			if (endValue < 0f)
			{
				endValue = 0f;
			}
			else if (endValue > 1f)
			{
				endValue = 1f;
			}
			return DOTween.To(() => target.volume, delegate(float x)
			{
				target.volume = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			return DOTween.To(() => target.pitch, delegate(float x)
			{
				target.pitch = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return DOTween.To(delegate
			{
				target.GetFloat(floatName, out var value);
				return value;
			}, delegate(float x)
			{
				target.SetFloat(floatName, x);
			}, endValue, duration).SetTarget(target);
		}

		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		public static int DOFlip(this AudioMixer target)
		{
			return DOTween.Flip(target);
		}

		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		public static int DOPause(this AudioMixer target)
		{
			return DOTween.Pause(target);
		}

		public static int DOPlay(this AudioMixer target)
		{
			return DOTween.Play(target);
		}

		public static int DOPlayBackwards(this AudioMixer target)
		{
			return DOTween.PlayBackwards(target);
		}

		public static int DOPlayForward(this AudioMixer target)
		{
			return DOTween.PlayForward(target);
		}

		public static int DORestart(this AudioMixer target)
		{
			return DOTween.Restart(target);
		}

		public static int DORewind(this AudioMixer target)
		{
			return DOTween.Rewind(target);
		}

		public static int DOSmoothRewind(this AudioMixer target)
		{
			return DOTween.SmoothRewind(target);
		}

		public static int DOTogglePause(this AudioMixer target)
		{
			return DOTween.TogglePause(target);
		}
	}
	public static class DOTweenModulePhysics
	{
		public static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		}

		public static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		}

		public static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z, snapping).SetTarget(target);
		}

		public static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(() => target.rotation, target.MoveRotation, endValue, duration);
			tweenerCore.SetTarget(target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(() => target.rotation, target.MoveRotation, towards, duration).SetTarget(target).SetSpecialStartupMode(SpecialStartupMode.SetLookAt);
			tweenerCore.plugOptions.axisConstraint = axisConstraint;
			tweenerCore.plugOptions.up = ((!up.HasValue) ? Vector3.up : up.Value);
			return tweenerCore;
		}

		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			float startPosY = 0f;
			float offsetY = -1f;
			bool offsetYSet = false;
			Sequence s = DOTween.Sequence();
			Tween yTween = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, jumpPower, 0f), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.OnStart(delegate
				{
					startPosY = target.position.y;
				});
			s.Append(DOTween.To(() => target.position, target.MovePosition, new Vector3(endValue.x, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)).Join(DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, 0f, endValue.z), duration).SetOptions(AxisConstraint.Z, snapping).SetEase(Ease.Linear)).Join(yTween)
				.SetTarget(target)
				.SetEase(DOTween.defaultEaseType);
			yTween.OnUpdate(delegate
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 position = target.position;
				position.y += DOVirtual.EasedValue(0f, offsetY, yTween.ElapsedPercentage(), Ease.OutQuad);
				target.MovePosition(position);
			});
			return s;
		}

		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			if (resolution < 1)
			{
				resolution = 1;
			}
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => target.position, target.MovePosition, new DG.Tweening.Plugins.Core.PathCore.Path(pathType, path, resolution, gizmoColor), duration).SetTarget(target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			if (resolution < 1)
			{
				resolution = 1;
			}
			Transform trans = target.transform;
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => trans.localPosition, delegate(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}, new DG.Tweening.Plugins.Core.PathCore.Path(pathType, path, resolution, gizmoColor), duration).SetTarget(target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => target.position, target.MovePosition, path, duration).SetTarget(target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			Transform trans = target.transform;
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => trans.localPosition, delegate(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}, path, duration).SetTarget(target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}
	}
	public static class DOTweenModulePhysics2D
	{
		public static Tweener DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, new Vector2(endValue, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		}

		public static Tweener DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.position, target.MovePosition, new Vector2(0f, endValue), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		}

		public static Tweener DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return DOTween.To(() => target.rotation, target.MoveRotation, endValue, duration).SetTarget(target);
		}

		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			float startPosY = 0f;
			float offsetY = -1f;
			bool offsetYSet = false;
			Sequence s = DOTween.Sequence();
			Tween yTween = DOTween.To(() => target.position, delegate(Vector2 x)
			{
				target.position = x;
			}, new Vector2(0f, jumpPower), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.OnStart(delegate
				{
					startPosY = target.position.y;
				});
			s.Append(DOTween.To(() => target.position, delegate(Vector2 x)
			{
				target.position = x;
			}, new Vector2(endValue.x, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)).Join(yTween).SetTarget(target)
				.SetEase(DOTween.defaultEaseType);
			yTween.OnUpdate(delegate
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 vector = target.position;
				vector.y += DOVirtual.EasedValue(0f, offsetY, yTween.ElapsedPercentage(), Ease.OutQuad);
				target.MovePosition(vector);
			});
			return s;
		}
	}
	public static class DOTweenModuleSprite
	{
		public static Tweener DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return DOTween.To(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return DOTween.ToAlpha(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			endValue -= target.color;
			Color to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(() => to, delegate(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}, endValue, duration).Blendable().SetTarget(target);
		}
	}
	public static class DOTweenModuleUI
	{
		public static class Utils
		{
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				Vector2 vector = new Vector2(from.rect.width * 0.5f + from.rect.xMin, from.rect.height * 0.5f + from.rect.yMin);
				Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(null, from.position);
				screenPoint += vector;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(to, screenPoint, null, out var localPoint);
				Vector2 vector2 = new Vector2(to.rect.width * 0.5f + to.rect.xMin, to.rect.height * 0.5f + to.rect.yMin);
				return to.anchoredPosition + localPoint - vector2;
			}
		}

		public static Tweener DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return DOTween.To(() => target.alpha, delegate(float x)
			{
				target.alpha = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOColor(this Graphic target, Color endValue, float duration)
		{
			return DOTween.To(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFade(this Graphic target, float endValue, float duration)
		{
			return DOTween.ToAlpha(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOColor(this Image target, Color endValue, float duration)
		{
			return DOTween.To(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFade(this Image target, float endValue, float duration)
		{
			return DOTween.ToAlpha(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFillAmount(this Image target, float endValue, float duration)
		{
			if (endValue > 1f)
			{
				endValue = 1f;
			}
			else if (endValue < 0f)
			{
				endValue = 0f;
			}
			return DOTween.To(() => target.fillAmount, delegate(float x)
			{
				target.fillAmount = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Tweener DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => new Vector2(target.flexibleWidth, target.flexibleHeight), delegate(Vector2 x)
			{
				target.flexibleWidth = x.x;
				target.flexibleHeight = x.y;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => new Vector2(target.minWidth, target.minHeight), delegate(Vector2 x)
			{
				target.minWidth = x.x;
				target.minHeight = x.y;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => new Vector2(target.preferredWidth, target.preferredHeight), delegate(Vector2 x)
			{
				target.preferredWidth = x.x;
				target.preferredHeight = x.y;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOColor(this Outline target, Color endValue, float duration)
		{
			return DOTween.To(() => target.effectColor, delegate(Color x)
			{
				target.effectColor = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFade(this Outline target, float endValue, float duration)
		{
			return DOTween.ToAlpha(() => target.effectColor, delegate(Color x)
			{
				target.effectColor = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return DOTween.To(() => target.effectDistance, delegate(Vector2 x)
			{
				target.effectDistance = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
			{
				target.anchoredPosition = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
			{
				target.anchoredPosition = x;
			}, new Vector2(endValue, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
			{
				target.anchoredPosition = x;
			}, new Vector2(0f, endValue), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
			{
				target.anchoredPosition3D = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
			{
				target.anchoredPosition3D = x;
			}, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
			{
				target.anchoredPosition3D = x;
			}, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		}

		public static Tweener DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
			{
				target.anchoredPosition3D = x;
			}, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z, snapping).SetTarget(target);
		}

		public static Tweener DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchorMax, delegate(Vector2 x)
			{
				target.anchorMax = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.anchorMin, delegate(Vector2 x)
			{
				target.anchorMin = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return DOTween.To(() => target.pivot, delegate(Vector2 x)
			{
				target.pivot = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return DOTween.To(() => target.pivot, delegate(Vector2 x)
			{
				target.pivot = x;
			}, new Vector2(endValue, 0f), duration).SetOptions(AxisConstraint.X).SetTarget(target);
		}

		public static Tweener DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return DOTween.To(() => target.pivot, delegate(Vector2 x)
			{
				target.pivot = x;
			}, new Vector2(0f, endValue), duration).SetOptions(AxisConstraint.Y).SetTarget(target);
		}

		public static Tweener DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.sizeDelta, delegate(Vector2 x)
			{
				target.sizeDelta = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return DOTween.Punch(() => target.anchoredPosition, delegate(Vector3 x)
			{
				target.anchoredPosition = x;
			}, punch, duration, vibrato, elasticity).SetTarget(target).SetOptions(snapping);
		}

		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return DOTween.Shake(() => target.anchoredPosition, delegate(Vector3 x)
			{
				target.anchoredPosition = x;
			}, duration, strength, vibrato, randomness, ignoreZAxis: true, fadeOut).SetTarget(target).SetSpecialStartupMode(SpecialStartupMode.SetShake)
				.SetOptions(snapping);
		}

		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return DOTween.Shake(() => target.anchoredPosition, delegate(Vector3 x)
			{
				target.anchoredPosition = x;
			}, duration, strength, vibrato, randomness, fadeOut).SetTarget(target).SetSpecialStartupMode(SpecialStartupMode.SetShake)
				.SetOptions(snapping);
		}

		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			float startPosY = 0f;
			float offsetY = -1f;
			bool offsetYSet = false;
			Sequence s = DOTween.Sequence();
			Tween t = DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
			{
				target.anchoredPosition = x;
			}, new Vector2(0f, jumpPower), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.OnStart(delegate
				{
					startPosY = target.anchoredPosition.y;
				});
			s.Append(DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
			{
				target.anchoredPosition = x;
			}, new Vector2(endValue.x, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)).Join(t).SetTarget(target)
				.SetEase(DOTween.defaultEaseType);
			s.OnUpdate(delegate
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector2 anchoredPosition = target.anchoredPosition;
				anchoredPosition.y += DOVirtual.EasedValue(0f, offsetY, s.ElapsedDirectionalPercentage(), Ease.OutQuad);
				target.anchoredPosition = anchoredPosition;
			});
			return s;
		}

		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => new Vector2(target.horizontalNormalizedPosition, target.verticalNormalizedPosition), delegate(Vector2 x)
			{
				target.horizontalNormalizedPosition = x.x;
				target.verticalNormalizedPosition = x.y;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.horizontalNormalizedPosition, delegate(float x)
			{
				target.horizontalNormalizedPosition = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.verticalNormalizedPosition, delegate(float x)
			{
				target.verticalNormalizedPosition = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return DOTween.To(() => target.value, delegate(float x)
			{
				target.value = x;
			}, endValue, duration).SetOptions(snapping).SetTarget(target);
		}

		public static Tweener DOColor(this Text target, Color endValue, float duration)
		{
			return DOTween.To(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOFade(this Text target, float endValue, float duration)
		{
			return DOTween.ToAlpha(() => target.color, delegate(Color x)
			{
				target.color = x;
			}, endValue, duration).SetTarget(target);
		}

		public static Tweener DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			return DOTween.To(() => target.text, delegate(string x)
			{
				target.text = x;
			}, endValue, duration).SetOptions(richTextEnabled, scrambleMode, scrambleChars).SetTarget(target);
		}

		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			endValue -= target.color;
			Color to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(() => to, delegate(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}, endValue, duration).Blendable().SetTarget(target);
		}

		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			endValue -= target.color;
			Color to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(() => to, delegate(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}, endValue, duration).Blendable().SetTarget(target);
		}

		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			endValue -= target.color;
			Color to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(() => to, delegate(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}, endValue, duration).Blendable().SetTarget(target);
		}
	}
	public static class DOTweenModuleUnityVersion
	{
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.SetColor(property, gradientColorKey.color);
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, property, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForCompletion(t);
		}

		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForRewind(t);
		}

		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForKill(t);
		}

		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForElapsedLoops(t, elapsedLoops);
		}

		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForPosition(t, position);
		}

		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForStart(t);
		}
	}
	public static class DOTweenCYInstruction
	{
		public class WaitForCompletion : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return !t.IsComplete();
					}
					return false;
				}
			}

			public WaitForCompletion(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForRewind : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						if (t.playedOnce)
						{
							return t.position * (float)(t.CompletedLoops() + 1) > 0f;
						}
						return true;
					}
					return false;
				}
			}

			public WaitForRewind(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForKill : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting => t.active;

			public WaitForKill(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly int elapsedLoops;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return t.CompletedLoops() < elapsedLoops;
					}
					return false;
				}
			}

			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
				t = tween;
				this.elapsedLoops = elapsedLoops;
			}
		}

		public class WaitForPosition : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly float position;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return t.position * (float)(t.CompletedLoops() + 1) < position;
					}
					return false;
				}
			}

			public WaitForPosition(Tween tween, float position)
			{
				t = tween;
				this.position = position;
			}
		}

		public class WaitForStart : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return !t.playedOnce;
					}
					return false;
				}
			}

			public WaitForStart(Tween tween)
			{
				t = tween;
			}
		}
	}
	public static class DOTweenModuleUtils
	{
		public static class Physics
		{
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
				if (options.isRigidbody)
				{
					((Rigidbody)t.target).rotation = newRot;
				}
				else
				{
					trans.rotation = newRot;
				}
			}

			public static bool HasRigidbody2D(Component target)
			{
				return target.GetComponent<Rigidbody2D>() != null;
			}

			public static bool HasRigidbody(Component target)
			{
				return target.GetComponent<Rigidbody>() != null;
			}

			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				Rigidbody rigidbody = (tweenRigidbody ? target.GetComponent<Rigidbody>() : null);
				if (tweenRigidbody && rigidbody != null)
				{
					return isLocal ? rigidbody.DOLocalPath(path, duration, pathMode) : rigidbody.DOPath(path, duration, pathMode);
				}
				return isLocal ? target.transform.DOLocalPath(path, duration, pathMode) : target.transform.DOPath(path, duration, pathMode);
			}
		}

		private static bool _initialized;

		public static void Init()
		{
			if (!_initialized)
			{
				_initialized = true;
				DOTweenExternalCommand.SetOrientationOnPath += Physics.SetOrientationOnPath;
			}
		}
	}
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		public bool targetIsSelf = true;

		public GameObject targetGO;

		public bool tweenTargetIsTargetGO = true;

		public float delay;

		public float duration = 1f;

		public Ease easeType = Ease.OutQuad;

		public AnimationCurve easeCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public LoopType loopType;

		public int loops = 1;

		public string id = "";

		public bool isRelative;

		public bool isFrom;

		public bool isIndependentUpdate;

		public bool autoKill = true;

		public bool isActive = true;

		public bool isValid;

		public Component target;

		public DOTweenAnimationType animationType;

		public TargetType targetType;

		public TargetType forcedTargetType;

		public bool autoPlay = true;

		public bool useTargetAsV3;

		public float endValueFloat;

		public Vector3 endValueV3;

		public Vector2 endValueV2;

		public Color endValueColor = new Color(1f, 1f, 1f, 1f);

		public string endValueString = "";

		public Rect endValueRect = new Rect(0f, 0f, 0f, 0f);

		public Transform endValueTransform;

		public bool optionalBool0;

		public float optionalFloat0;

		public int optionalInt0;

		public RotateMode optionalRotationMode;

		public ScrambleMode optionalScrambleMode;

		public string optionalString;

		private bool _tweenCreated;

		private int _playCount = -1;

		private void Awake()
		{
			if (isActive && isValid && (animationType != DOTweenAnimationType.Move || !useTargetAsV3))
			{
				CreateTween();
				_tweenCreated = true;
			}
		}

		private void Start()
		{
			if (!_tweenCreated && isActive && isValid)
			{
				CreateTween();
				_tweenCreated = true;
			}
		}

		private void OnDestroy()
		{
			if (tween != null && tween.IsActive())
			{
				tween.Kill();
			}
			tween = null;
		}

		public void CreateTween()
		{
			GameObject tweenGO = GetTweenGO();
			if (target == null || tweenGO == null)
			{
				if (targetIsSelf && target == null)
				{
					UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This DOTweenAnimation's target is NULL, because the animation was created with a DOTween Pro version older than 0.9.255. To fix this, exit Play mode then simply select this object, and it will update automatically", base.gameObject);
				}
				else
				{
					UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This DOTweenAnimation's target/GameObject is unset: the tween will not be created.", base.gameObject);
				}
				return;
			}
			if (forcedTargetType != 0)
			{
				this.targetType = forcedTargetType;
			}
			if (this.targetType == TargetType.Unset)
			{
				this.targetType = TypeToDOTargetType(target.GetType());
			}
			switch (animationType)
			{
			case DOTweenAnimationType.Move:
				if (useTargetAsV3)
				{
					isRelative = false;
					if (endValueTransform == null)
					{
						UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This tween's TO target is NULL, a Vector3 of (0,0,0) will be used instead", base.gameObject);
						endValueV3 = Vector3.zero;
					}
					else if (this.targetType == TargetType.RectTransform)
					{
						RectTransform rectTransform = endValueTransform as RectTransform;
						if (rectTransform == null)
						{
							UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This tween's TO target should be a RectTransform, a Vector3 of (0,0,0) will be used instead", base.gameObject);
							endValueV3 = Vector3.zero;
						}
						else
						{
							RectTransform rectTransform2 = target as RectTransform;
							if (rectTransform2 == null)
							{
								UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This tween's target and TO target are not of the same type. Please reassign the values", base.gameObject);
							}
							else
							{
								endValueV3 = DOTweenModuleUI.Utils.SwitchToRectTransform(rectTransform, rectTransform2);
							}
						}
					}
					else
					{
						endValueV3 = endValueTransform.position;
					}
				}
				switch (this.targetType)
				{
				case TargetType.Transform:
					tween = ((Transform)target).DOMove(endValueV3, duration, optionalBool0);
					break;
				case TargetType.RectTransform:
					tween = ((RectTransform)target).DOAnchorPos3D(endValueV3, duration, optionalBool0);
					break;
				case TargetType.Rigidbody:
					tween = ((Rigidbody)target).DOMove(endValueV3, duration, optionalBool0);
					break;
				case TargetType.Rigidbody2D:
					tween = ((Rigidbody2D)target).DOMove(endValueV3, duration, optionalBool0);
					break;
				}
				break;
			case DOTweenAnimationType.LocalMove:
				tween = tweenGO.transform.DOLocalMove(endValueV3, duration, optionalBool0);
				break;
			case DOTweenAnimationType.Rotate:
				switch (this.targetType)
				{
				case TargetType.Transform:
					tween = ((Transform)target).DORotate(endValueV3, duration, optionalRotationMode);
					break;
				case TargetType.Rigidbody:
					tween = ((Rigidbody)target).DORotate(endValueV3, duration, optionalRotationMode);
					break;
				case TargetType.Rigidbody2D:
					tween = ((Rigidbody2D)target).DORotate(endValueFloat, duration);
					break;
				}
				break;
			case DOTweenAnimationType.LocalRotate:
				tween = tweenGO.transform.DOLocalRotate(endValueV3, duration, optionalRotationMode);
				break;
			case DOTweenAnimationType.Scale:
				_ = this.targetType;
				tween = tweenGO.transform.DOScale(optionalBool0 ? new Vector3(endValueFloat, endValueFloat, endValueFloat) : endValueV3, duration);
				break;
			case DOTweenAnimationType.UIWidthHeight:
				tween = ((RectTransform)target).DOSizeDelta(optionalBool0 ? new Vector2(endValueFloat, endValueFloat) : endValueV2, duration);
				break;
			case DOTweenAnimationType.Color:
				isRelative = false;
				switch (this.targetType)
				{
				case TargetType.Renderer:
					tween = ((Renderer)target).material.DOColor(endValueColor, duration);
					break;
				case TargetType.Light:
					tween = ((Light)target).DOColor(endValueColor, duration);
					break;
				case TargetType.SpriteRenderer:
					tween = ((SpriteRenderer)target).DOColor(endValueColor, duration);
					break;
				case TargetType.Image:
					tween = ((Image)target).DOColor(endValueColor, duration);
					break;
				case TargetType.Text:
					tween = ((Text)target).DOColor(endValueColor, duration);
					break;
				}
				break;
			case DOTweenAnimationType.Fade:
				isRelative = false;
				switch (this.targetType)
				{
				case TargetType.Renderer:
					tween = ((Renderer)target).material.DOFade(endValueFloat, duration);
					break;
				case TargetType.Light:
					tween = ((Light)target).DOIntensity(endValueFloat, duration);
					break;
				case TargetType.SpriteRenderer:
					tween = ((SpriteRenderer)target).DOFade(endValueFloat, duration);
					break;
				case TargetType.Image:
					tween = ((Image)target).DOFade(endValueFloat, duration);
					break;
				case TargetType.Text:
					tween = ((Text)target).DOFade(endValueFloat, duration);
					break;
				case TargetType.CanvasGroup:
					tween = ((CanvasGroup)target).DOFade(endValueFloat, duration);
					break;
				}
				break;
			case DOTweenAnimationType.Text:
			{
				TargetType targetType = this.targetType;
				if (targetType == TargetType.Text)
				{
					tween = ((Text)target).DOText(endValueString, duration, optionalBool0, optionalScrambleMode, optionalString);
				}
				break;
			}
			case DOTweenAnimationType.PunchPosition:
				switch (this.targetType)
				{
				case TargetType.Transform:
					tween = ((Transform)target).DOPunchPosition(endValueV3, duration, optionalInt0, optionalFloat0, optionalBool0);
					break;
				case TargetType.RectTransform:
					tween = ((RectTransform)target).DOPunchAnchorPos(endValueV3, duration, optionalInt0, optionalFloat0, optionalBool0);
					break;
				}
				break;
			case DOTweenAnimationType.PunchScale:
				tween = tweenGO.transform.DOPunchScale(endValueV3, duration, optionalInt0, optionalFloat0);
				break;
			case DOTweenAnimationType.PunchRotation:
				tween = tweenGO.transform.DOPunchRotation(endValueV3, duration, optionalInt0, optionalFloat0);
				break;
			case DOTweenAnimationType.ShakePosition:
				switch (this.targetType)
				{
				case TargetType.Transform:
					tween = ((Transform)target).DOShakePosition(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool0);
					break;
				case TargetType.RectTransform:
					tween = ((RectTransform)target).DOShakeAnchorPos(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool0);
					break;
				}
				break;
			case DOTweenAnimationType.ShakeScale:
				tween = tweenGO.transform.DOShakeScale(duration, endValueV3, optionalInt0, optionalFloat0);
				break;
			case DOTweenAnimationType.ShakeRotation:
				tween = tweenGO.transform.DOShakeRotation(duration, endValueV3, optionalInt0, optionalFloat0);
				break;
			case DOTweenAnimationType.CameraAspect:
				tween = ((Camera)target).DOAspect(endValueFloat, duration);
				break;
			case DOTweenAnimationType.CameraBackgroundColor:
				tween = ((Camera)target).DOColor(endValueColor, duration);
				break;
			case DOTweenAnimationType.CameraFieldOfView:
				tween = ((Camera)target).DOFieldOfView(endValueFloat, duration);
				break;
			case DOTweenAnimationType.CameraOrthoSize:
				tween = ((Camera)target).DOOrthoSize(endValueFloat, duration);
				break;
			case DOTweenAnimationType.CameraPixelRect:
				tween = ((Camera)target).DOPixelRect(endValueRect, duration);
				break;
			case DOTweenAnimationType.CameraRect:
				tween = ((Camera)target).DORect(endValueRect, duration);
				break;
			}
			if (tween == null)
			{
				return;
			}
			if (isFrom)
			{
				((Tweener)tween).From(isRelative);
			}
			else
			{
				tween.SetRelative(isRelative);
			}
			GameObject gameObject = ((targetIsSelf || !tweenTargetIsTargetGO) ? base.gameObject : targetGO);
			tween.SetTarget(gameObject).SetDelay(delay).SetLoops(loops, loopType)
				.SetAutoKill(autoKill)
				.OnKill(delegate
				{
					tween = null;
				});
			if (isSpeedBased)
			{
				tween.SetSpeedBased();
			}
			if (easeType == Ease.INTERNAL_Custom)
			{
				tween.SetEase(easeCurve);
			}
			else
			{
				tween.SetEase(easeType);
			}
			if (!string.IsNullOrEmpty(id))
			{
				tween.SetId(id);
			}
			tween.SetUpdate(isIndependentUpdate);
			if (hasOnStart)
			{
				if (onStart != null)
				{
					tween.OnStart(onStart.Invoke);
				}
			}
			else
			{
				onStart = null;
			}
			if (hasOnPlay)
			{
				if (onPlay != null)
				{
					tween.OnPlay(onPlay.Invoke);
				}
			}
			else
			{
				onPlay = null;
			}
			if (hasOnUpdate)
			{
				if (onUpdate != null)
				{
					tween.OnUpdate(onUpdate.Invoke);
				}
			}
			else
			{
				onUpdate = null;
			}
			if (hasOnStepComplete)
			{
				if (onStepComplete != null)
				{
					tween.OnStepComplete(onStepComplete.Invoke);
				}
			}
			else
			{
				onStepComplete = null;
			}
			if (hasOnComplete)
			{
				if (onComplete != null)
				{
					tween.OnComplete(onComplete.Invoke);
				}
			}
			else
			{
				onComplete = null;
			}
			if (hasOnRewind)
			{
				if (onRewind != null)
				{
					tween.OnRewind(onRewind.Invoke);
				}
			}
			else
			{
				onRewind = null;
			}
			if (autoPlay)
			{
				tween.Play();
			}
			else
			{
				tween.Pause();
			}
			if (hasOnTweenCreated && onTweenCreated != null)
			{
				onTweenCreated.Invoke();
			}
		}

		public override void DOPlay()
		{
			DOTween.Play(base.gameObject);
		}

		public override void DOPlayBackwards()
		{
			DOTween.PlayBackwards(base.gameObject);
		}

		public override void DOPlayForward()
		{
			DOTween.PlayForward(base.gameObject);
		}

		public override void DOPause()
		{
			DOTween.Pause(base.gameObject);
		}

		public override void DOTogglePause()
		{
			DOTween.TogglePause(base.gameObject);
		}

		public override void DORewind()
		{
			_playCount = -1;
			DOTweenAnimation[] components = base.gameObject.GetComponents<DOTweenAnimation>();
			for (int num = components.Length - 1; num > -1; num--)
			{
				Tween tween = components[num].tween;
				if (tween != null && tween.IsInitialized())
				{
					components[num].tween.Rewind();
				}
			}
		}

		public override void DORestart(bool fromHere = false)
		{
			_playCount = -1;
			if (tween == null)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 1)
				{
					DG.Tweening.Core.Debugger.LogNullTween(tween);
				}
				return;
			}
			if (fromHere && isRelative)
			{
				ReEvaluateRelativeTween();
			}
			DOTween.Restart(base.gameObject);
		}

		public override void DOComplete()
		{
			DOTween.Complete(base.gameObject);
		}

		public override void DOKill()
		{
			DOTween.Kill(base.gameObject);
			tween = null;
		}

		public void DOPlayById(string id)
		{
			DOTween.Play(base.gameObject, id);
		}

		public void DOPlayAllById(string id)
		{
			DOTween.Play(id);
		}

		public void DOPauseAllById(string id)
		{
			DOTween.Pause(id);
		}

		public void DOPlayBackwardsById(string id)
		{
			DOTween.PlayBackwards(base.gameObject, id);
		}

		public void DOPlayBackwardsAllById(string id)
		{
			DOTween.PlayBackwards(id);
		}

		public void DOPlayForwardById(string id)
		{
			DOTween.PlayForward(base.gameObject, id);
		}

		public void DOPlayForwardAllById(string id)
		{
			DOTween.PlayForward(id);
		}

		public void DOPlayNext()
		{
			DOTweenAnimation[] components = GetComponents<DOTweenAnimation>();
			while (_playCount < components.Length - 1)
			{
				_playCount++;
				DOTweenAnimation dOTweenAnimation = components[_playCount];
				if (dOTweenAnimation != null && dOTweenAnimation.tween != null && !dOTweenAnimation.tween.IsPlaying() && !dOTweenAnimation.tween.IsComplete())
				{
					dOTweenAnimation.tween.Play();
					break;
				}
			}
		}

		public void DORewindAndPlayNext()
		{
			_playCount = -1;
			DOTween.Rewind(base.gameObject);
			DOPlayNext();
		}

		public void DORewindAllById(string id)
		{
			_playCount = -1;
			DOTween.Rewind(id);
		}

		public void DORestartById(string id)
		{
			_playCount = -1;
			DOTween.Restart(base.gameObject, id);
		}

		public void DORestartAllById(string id)
		{
			_playCount = -1;
			DOTween.Restart(id);
		}

		public List<Tween> GetTweens()
		{
			List<Tween> list = new List<Tween>();
			DOTweenAnimation[] components = GetComponents<DOTweenAnimation>();
			foreach (DOTweenAnimation dOTweenAnimation in components)
			{
				list.Add(dOTweenAnimation.tween);
			}
			return list;
		}

		public static TargetType TypeToDOTargetType(Type t)
		{
			string text = t.ToString();
			int num = text.LastIndexOf(".");
			if (num != -1)
			{
				text = text.Substring(num + 1);
			}
			if (text.IndexOf("Renderer") != -1 && text != "SpriteRenderer")
			{
				text = "Renderer";
			}
			return (TargetType)Enum.Parse(typeof(TargetType), text);
		}

		public Tween CreateEditorPreview()
		{
			if (Application.isPlaying)
			{
				return null;
			}
			CreateTween();
			return tween;
		}

		private GameObject GetTweenGO()
		{
			if (!targetIsSelf)
			{
				return targetGO;
			}
			return base.gameObject;
		}

		private void ReEvaluateRelativeTween()
		{
			GameObject tweenGO = GetTweenGO();
			if (tweenGO == null)
			{
				UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This DOTweenAnimation's target/GameObject is unset: the tween will not be created.", base.gameObject);
			}
			else if (animationType == DOTweenAnimationType.Move)
			{
				((Tweener)tween).ChangeEndValue(tweenGO.transform.position + endValueV3, snapStartValue: true);
			}
			else if (animationType == DOTweenAnimationType.LocalMove)
			{
				((Tweener)tween).ChangeEndValue(tweenGO.transform.localPosition + endValueV3, snapStartValue: true);
			}
		}
	}
	public static class DOTweenAnimationExtensions
	{
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return t is T;
		}
	}
	public static class DOTweenProShortcuts
	{
		static DOTweenProShortcuts()
		{
			new SpiralPlugin();
		}

		public static Tweener DOSpiral(this Transform target, float duration, Vector3? axis = null, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			if (Mathf.Approximately(speed, 0f))
			{
				speed = 1f;
			}
			if (!axis.HasValue || axis == Vector3.zero)
			{
				axis = Vector3.forward;
			}
			TweenerCore<Vector3, Vector3, SpiralOptions> tweenerCore = DOTween.To(SpiralPlugin.Get(), () => target.localPosition, delegate(Vector3 x)
			{
				target.localPosition = x;
			}, axis.Value, duration).SetTarget(target);
			tweenerCore.plugOptions.mode = mode;
			tweenerCore.plugOptions.speed = speed;
			tweenerCore.plugOptions.frequency = frequency;
			tweenerCore.plugOptions.depth = depth;
			tweenerCore.plugOptions.snapping = snapping;
			return tweenerCore;
		}

		public static Tweener DOSpiral(this Rigidbody target, float duration, Vector3? axis = null, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			if (Mathf.Approximately(speed, 0f))
			{
				speed = 1f;
			}
			if (!axis.HasValue || axis == Vector3.zero)
			{
				axis = Vector3.forward;
			}
			TweenerCore<Vector3, Vector3, SpiralOptions> tweenerCore = DOTween.To(SpiralPlugin.Get(), () => target.position, target.MovePosition, axis.Value, duration).SetTarget(target);
			tweenerCore.plugOptions.mode = mode;
			tweenerCore.plugOptions.speed = speed;
			tweenerCore.plugOptions.frequency = frequency;
			tweenerCore.plugOptions.depth = depth;
			tweenerCore.plugOptions.snapping = snapping;
			return tweenerCore;
		}
	}
}
