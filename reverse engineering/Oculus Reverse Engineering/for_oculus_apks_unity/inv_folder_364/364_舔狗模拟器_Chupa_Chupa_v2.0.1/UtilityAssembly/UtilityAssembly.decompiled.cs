using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public static class DateUtility
{
	private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public static int ToUnixTime(this DateTime self)
	{
		return (int)(self.ToUniversalTime() - UnixEpoch).TotalSeconds;
	}

	public static DateTime FromUnixTime(int unixTime)
	{
		return UnixEpoch.AddSeconds(unixTime);
	}
}
public static class EnumUtility
{
	public static void ExcuteActionInAllValue<T>(Action<T> action)
	{
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			action(value);
		}
	}

	public static List<T> GetAllInList<T>()
	{
		List<T> list = new List<T>();
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			list.Add(value);
		}
		return list;
	}

	public static bool ContainsKey<T>(string tagetKey)
	{
		foreach (T value in Enum.GetValues(typeof(T)))
		{
			if (value.ToString() == tagetKey)
			{
				return true;
			}
		}
		return false;
	}

	public static T GetRandom<T>()
	{
		return NoToType<T>(UnityEngine.Random.Range(0, GetTypeNum<T>()));
	}

	public static T KeyToType<T>(string targetKey)
	{
		return (T)Enum.Parse(typeof(T), targetKey);
	}

	public static T NoToType<T>(int targetNo)
	{
		return (T)Enum.ToObject(typeof(T), targetNo);
	}

	public static int GetTypeNum<T>()
	{
		return Enum.GetValues(typeof(T)).Length;
	}
}
public static class HashUtility
{
	public static string CalcMd5(string source)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
		{
			byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(source));
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
		}
		return stringBuilder.ToString();
	}
}
public static class MathfUtility
{
	public static void Clamp(ref Vector3 targetValue, ref Vector3 a, ref Vector3 b)
	{
		targetValue.x = Clamp(targetValue.x, a.x, b.x);
		targetValue.y = Clamp(targetValue.y, a.y, b.y);
		targetValue.z = Clamp(targetValue.z, a.z, b.z);
	}

	public static void Clamp(ref Vector2 targetValue, ref Vector2 a, ref Vector2 b)
	{
		targetValue.x = Clamp(targetValue.x, a.x, b.x);
		targetValue.y = Clamp(targetValue.y, a.y, b.y);
	}

	public static float Clamp(float targetValue, float a, float b)
	{
		if (a > b)
		{
			return Mathf.Clamp(targetValue, b, a);
		}
		return Mathf.Clamp(targetValue, a, b);
	}

	public static int Clamp(int targetValue, int a, int b)
	{
		if (a > b)
		{
			return Mathf.Clamp(targetValue, b, a);
		}
		return Mathf.Clamp(targetValue, a, b);
	}
}
