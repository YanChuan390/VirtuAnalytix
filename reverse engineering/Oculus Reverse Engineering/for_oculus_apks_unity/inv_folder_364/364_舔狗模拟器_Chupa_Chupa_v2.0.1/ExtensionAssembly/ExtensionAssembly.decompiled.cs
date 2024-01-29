using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public static class AnimatorExtension
{
	public static IEnumerator Play(this Animator animator, int animationKey, Action callback)
	{
		animator.Play(animationKey, 0, 0f);
		yield return new WaitForSeconds(0.1f);
		yield return new WaitUntilAnimationFinished(animator);
		callback?.Invoke();
	}

	public static IEnumerator SetTrigger(this Animator animator, int triggerKey, Action callback)
	{
		animator.SetTrigger(triggerKey);
		yield return new WaitForSeconds(0.1f);
		yield return new WaitUntilAnimationFinished(animator);
		callback?.Invoke();
	}
}
public static class DictionaryExtension
{
	public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, TValue defaultValue)
	{
		if (source == null)
		{
			return defaultValue;
		}
		if (source.ContainsKey(key))
		{
			return source[key];
		}
		return defaultValue;
	}

	public static void SwapValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key1, TKey key2)
	{
		if (!dict.ContainsKey(key1))
		{
			UnityEngine.Debug.LogError(string.Concat(key1, "が存在しません"));
			return;
		}
		if (!dict.ContainsKey(key2))
		{
			UnityEngine.Debug.LogError(string.Concat(key2, "が存在しません"));
			return;
		}
		TValue value = dict[key1];
		dict[key1] = dict[key2];
		dict[key2] = value;
	}
}
public static class GameObjectExtension
{
	public static T AddOrGetComponent<T>(this GameObject gameObject) where T : Component
	{
		T val = gameObject.GetComponent<T>();
		if (val == null)
		{
			val = gameObject.AddComponent<T>();
		}
		return val;
	}

	public static void SetLayerInChildren(this GameObject gameObject, int layerNo)
	{
		if (gameObject == null)
		{
			return;
		}
		gameObject.layer = layerNo;
		foreach (Transform item in gameObject.transform)
		{
			item.gameObject.SetLayerInChildren(layerNo);
		}
	}

	public static void SetTagInChildren(this GameObject gameObject, string tagName)
	{
		if (gameObject == null)
		{
			return;
		}
		gameObject.tag = tagName;
		foreach (Transform item in gameObject.transform)
		{
			item.gameObject.SetTagInChildren(tagName);
		}
	}

	public static void SetMaterialInChildren(this GameObject gameObject, Material setMaterial)
	{
		if (gameObject == null)
		{
			return;
		}
		if ((bool)gameObject.GetComponent<Renderer>())
		{
			gameObject.GetComponent<Renderer>().material = setMaterial;
		}
		foreach (Transform item in gameObject.transform)
		{
			item.gameObject.SetMaterialInChildren(setMaterial);
		}
	}
}
public static class GizmoExtension
{
	public static void DrawArrow(Vector3 from, Vector3 to, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
		Gizmos.DrawLine(from, to);
		Vector3 forward = to - from;
		Vector3 upwards = new Vector3(0f, 0f, 1f);
		Vector3 vector = Quaternion.LookRotation(forward, upwards) * Quaternion.Euler(0f, 180f + arrowHeadAngle, 0f) * new Vector3(0f, 0f, 1f);
		Vector3 vector2 = Quaternion.LookRotation(forward, upwards) * Quaternion.Euler(0f, 180f - arrowHeadAngle, 0f) * new Vector3(0f, 0f, 1f);
		Gizmos.DrawLine(to, to + vector * arrowHeadLength);
		Gizmos.DrawLine(to, to + vector2 * arrowHeadLength);
	}
}
public static class ListExtension
{
	public static void RemoveDuplicate<T>(this List<T> list)
	{
		List<T> list2 = new List<T>();
		foreach (T item in list)
		{
			list2.AddToNotDuplicate(item);
		}
		list = list2;
	}

	public static void RemoveListRange<T>(this List<T> list, List<T> removeList)
	{
		foreach (T remove in removeList)
		{
			if (list.Contains(remove))
			{
				list.Remove(remove);
			}
		}
	}

	public static void AddToNotDuplicate<T>(this List<T> list, T t, bool isFirstPermit = false)
	{
		if (!list.Contains(t) || (isFirstPermit && t.Equals(list[0])))
		{
			list.Add(t);
		}
	}

	public static List<T> Shuffle<T>(this List<T> list)
	{
		for (int i = 0; i < list.Count; i++)
		{
			T value = list[i];
			int index = UnityEngine.Random.Range(0, list.Count);
			list[i] = list[index];
			list[index] = value;
		}
		return list;
	}

	public static T GetAndRemove<T>(this List<T> list, int targetNo)
	{
		if (list.Count <= targetNo || targetNo < 0)
		{
			UnityEngine.Debug.LogError("リストの範囲を超えています！(ListCount : " + list.Count + ", No : " + targetNo + ")");
		}
		T val = list[targetNo];
		list.Remove(val);
		return val;
	}

	public static T Pop<T>(this List<T> list)
	{
		return list.GetAndRemove(list.Count - 1);
	}

	public static T Dequeue<T>(this List<T> list)
	{
		return list.GetAndRemove(0);
	}

	public static T GetAtRandom<T>(this List<T> list)
	{
		if (list.Count == 0)
		{
			UnityEngine.Debug.LogError("リストが空です！");
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public static T GetAndRemoveAtRandom<T>(this List<T> list)
	{
		T atRandom = list.GetAtRandom();
		list.Remove(atRandom);
		return atRandom;
	}
}
public static class MonoBehaviorExtentsion
{
	public static IEnumerator DelayMethod<T1, T2, T3>(this MonoBehaviour mono, float waitTime, Action<T1, T2, T3> action, T1 t1, T2 t2, T3 t3)
	{
		yield return new WaitForSeconds(waitTime);
		action(t1, t2, t3);
	}

	public static IEnumerator DelayMethod<T1, T2>(this MonoBehaviour mono, float waitTime, Action<T1, T2> action, T1 t1, T2 t2)
	{
		yield return new WaitForSeconds(waitTime);
		action(t1, t2);
	}

	public static IEnumerator DelayMethod<T>(this MonoBehaviour mono, float waitTime, Action<T> action, T t)
	{
		yield return new WaitForSeconds(waitTime);
		action(t);
	}

	public static IEnumerator DelayMethod(this MonoBehaviour mono, float waitTime, Action action)
	{
		yield return new WaitForSeconds(waitTime);
		action();
	}

	private static IEnumerator WaitForSecondsIgnoreTimeScale(float time)
	{
		float targetTime = Time.realtimeSinceStartup + time;
		while (Time.realtimeSinceStartup < targetTime)
		{
			yield return new WaitForEndOfFrame();
		}
	}

	public static IEnumerator DelayMethodIgnoreTimeScale<T1, T2, T3>(this MonoBehaviour mono, float waitTime, Action<T1, T2, T3> action, T1 t1, T2 t2, T3 t3)
	{
		yield return WaitForSecondsIgnoreTimeScale(waitTime);
		action(t1, t2, t3);
	}

	public static IEnumerator DelayMethodIgnoreTimeScale<T1, T2>(this MonoBehaviour mono, float waitTime, Action<T1, T2> action, T1 t1, T2 t2)
	{
		yield return WaitForSecondsIgnoreTimeScale(waitTime);
		action(t1, t2);
	}

	public static IEnumerator DelayMethodIgnoreTimeScale<T>(this MonoBehaviour mono, float waitTime, Action<T> action, T t)
	{
		yield return WaitForSecondsIgnoreTimeScale(waitTime);
		action(t);
	}

	public static IEnumerator DelayMethodIgnoreTimeScale(this MonoBehaviour mono, float waitTime, Action action)
	{
		yield return WaitForSecondsIgnoreTimeScale(waitTime);
		action();
	}
}
public static class StringExtensions
{
	public static bool ToBool(this string self)
	{
		if (self == "true")
		{
			return true;
		}
		if (self == "false")
		{
			return false;
		}
		UnityEngine.Debug.LogWarning(self + "は真偽値に変換出来ません！");
		return false;
	}

	public static bool AnyEqual(this string self, params string[] targets)
	{
		foreach (string text in targets)
		{
			if (self == text)
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainsFormatInFront(this string self, string format)
	{
		if (self.Length < format.Length)
		{
			return false;
		}
		if (self.Substring(0, format.Length) != format)
		{
			return false;
		}
		return true;
	}

	public static bool IsNullOrEmpty(this string self)
	{
		return string.IsNullOrEmpty(self);
	}

	public static string[] Divide(this string self, string separator, bool shouldTrimSpace = false)
	{
		if (self.Length == 0)
		{
			return new string[0];
		}
		if (shouldTrimSpace)
		{
			separator = separator.Trim(' ', '\u3000');
		}
		return self.Split(new string[1] { separator }, StringSplitOptions.None);
	}

	public static int CountOf(this string self, params string[] strArray)
	{
		int num = 0;
		foreach (string value in strArray)
		{
			for (int num2 = self.IndexOf(value, 0); num2 != -1; num2 = self.IndexOf(value, num2 + 1))
			{
				num++;
			}
		}
		return num;
	}

	public static string Coloring(this string str, string color)
	{
		return $"<color={color}>{str}</color>";
	}

	public static string Red(this string str)
	{
		return str.Coloring("red");
	}

	public static string Green(this string str)
	{
		return str.Coloring("green");
	}

	public static string Blue(this string str)
	{
		return str.Coloring("blue");
	}

	public static string Resize(this string str, int size)
	{
		return $"<size={size}>{str}</size>";
	}

	public static string Medium(this string str)
	{
		return str.Resize(11);
	}

	public static string Small(this string str)
	{
		return str.Resize(9);
	}

	public static string Large(this string str)
	{
		return str.Resize(16);
	}

	public static string Bold(this string str)
	{
		return $"<b>{str}</b>";
	}

	public static string Italic(this string str)
	{
		return $"<i>{str}</i>";
	}
}
public static class TransformExtension
{
	public static void Reset(this Transform transform)
	{
		transform.position = Vector3.zero;
		transform.rotation = Quaternion.identity;
		transform.localScale = Vector3.one;
	}

	public static void ResetInLocal(this Transform transform)
	{
		transform.localPosition = Vector3.zero;
		transform.localRotation = Quaternion.identity;
		transform.localScale = Vector3.one;
	}

	public static void SetPosition(this Transform transform, float x, float y, float z)
	{
		transform.position = new Vector3(x, y, z);
	}

	public static void SetPositionX(this Transform transform, float x)
	{
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}

	public static void SetPositionY(this Transform transform, float y)
	{
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}

	public static void SetPositionZ(this Transform transform, float z)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}

	public static void SetLocalPosition(this Transform transform, float x, float y, float z)
	{
		transform.localPosition = new Vector3(x, y, z);
	}

	public static void SetLocalPositionX(this Transform transform, float x)
	{
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
	}

	public static void SetLocalPositionY(this Transform transform, float y)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
	}

	public static void SetLocalPositionZ(this Transform transform, float z)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
	}

	public static void AddPosition(this Transform transform, float x, float y, float z)
	{
		transform.position += new Vector3(x, y, z);
	}

	public static void AddPositionX(this Transform transform, float x)
	{
		transform.position += new Vector3(x, 0f, 0f);
	}

	public static void AddPositionY(this Transform transform, float y)
	{
		transform.position += new Vector3(0f, y, 0f);
	}

	public static void AddPositionZ(this Transform transform, float z)
	{
		transform.position += new Vector3(0f, 0f, z);
	}

	public static void AddLoacalPosition(this Transform transform, Vector3 vector3)
	{
		transform.localPosition += vector3;
	}

	public static void AddLoacalPosition(this Transform transform, float x, float y, float z)
	{
		transform.localPosition += new Vector3(x, y, z);
	}

	public static void AddLoacalPositionX(this Transform transform, float x)
	{
		transform.localPosition += new Vector3(x, 0f, 0f);
	}

	public static void AddLoacalPositionY(this Transform transform, float y)
	{
		transform.localPosition += new Vector3(0f, y, 0f);
	}

	public static void AddLoacalPositionZ(this Transform transform, float z)
	{
		transform.localPosition += new Vector3(0f, 0f, z);
	}

	public static void SetLocalScale(this Transform transform, float x, float y, float z)
	{
		transform.localScale = new Vector3(x, y, z);
	}

	public static void SetLocalScaleX(this Transform transform, float x)
	{
		transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
	}

	public static void SetLocalScaleY(this Transform transform, float y)
	{
		transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
	}

	public static void SetLocalScaleZ(this Transform transform, float z)
	{
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
	}

	public static void AddLoacalScale(this Transform transform, float x, float y, float z)
	{
		transform.localScale += new Vector3(x, y, z);
	}

	public static void AddLoacalScaleX(this Transform transform, float x)
	{
		transform.localScale += new Vector3(x, 0f, 0f);
	}

	public static void AddLoacalScaleY(this Transform transform, float y)
	{
		transform.localScale += new Vector3(0f, y, 0f);
	}

	public static void AddLoacalScaleZ(this Transform transform, float z)
	{
		transform.localScale += new Vector3(0f, 0f, z);
	}

	public static void SetEulerAngles(this Transform transform, float x, float y, float z)
	{
		transform.eulerAngles = new Vector3(x, y, z);
	}

	public static void SetEulerAngleX(this Transform transform, float x)
	{
		transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);
	}

	public static void SetEulerAngleY(this Transform transform, float y)
	{
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z);
	}

	public static void SetEulerAngleZ(this Transform transform, float z)
	{
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z);
	}

	public static void SetLocalEulerAngles(this Transform transform, float x, float y, float z)
	{
		transform.localEulerAngles = new Vector3(x, y, z);
	}

	public static void SetLocalEulerAngleX(this Transform transform, float x)
	{
		transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

	public static void SetLocalEulerAngleY(this Transform transform, float y)
	{
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);
	}

	public static void SetLocalEulerAngleZ(this Transform transform, float z)
	{
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);
	}

	public static void AddEulerAngles(this Transform transform, float x, float y, float z)
	{
		transform.eulerAngles += new Vector3(x, y, z);
	}

	public static void AddEulerAngleX(this Transform transform, float x)
	{
		transform.eulerAngles += new Vector3(x, 0f, 0f);
	}

	public static void AddEulerAngleY(this Transform transform, float y)
	{
		transform.eulerAngles += new Vector3(0f, y, 0f);
	}

	public static void AddEulerAngleZ(this Transform transform, float z)
	{
		transform.eulerAngles += new Vector3(0f, 0f, z);
	}

	public static void AddLoacalEulerAngles(this Transform transform, float x, float y, float z)
	{
		transform.localEulerAngles += new Vector3(x, y, z);
	}

	public static void AddLoacalEulerAngleX(this Transform transform, float x)
	{
		transform.localEulerAngles += new Vector3(x, 0f, 0f);
	}

	public static void AddLoacalEulerAngleY(this Transform transform, float y)
	{
		transform.localEulerAngles += new Vector3(0f, y, 0f);
	}

	public static void AddLoacalEulerAngleZ(this Transform transform, float z)
	{
		transform.localEulerAngles += new Vector3(0f, 0f, z);
	}

	public static void LookAt2D(this Transform self, Vector3 target, Vector2 forward)
	{
		self.rotation = self.GetForwardRotation2D(target, forward);
	}

	public static Quaternion GetForwardRotation2D(this Transform self, Vector3 target, Vector2 forward)
	{
		float forwardDiffPoint = GetForwardDiffPoint(forward);
		Vector3 vector = target - self.position;
		return Quaternion.AngleAxis(Mathf.Atan2(vector.y, vector.x) * 57.29578f - forwardDiffPoint, Vector3.forward);
	}

	private static float GetForwardDiffPoint(Vector2 forward)
	{
		if (object.Equals(forward, Vector2.up))
		{
			return 90f;
		}
		object.Equals(forward, Vector2.right);
		return 0f;
	}

	public static Transform SetChild(this Transform self, Transform child)
	{
		child.transform.SetParent(self);
		child.transform.Reset();
		return child;
	}

	public static Transform CreateChild(this Transform self, string childName)
	{
		return self.SetChild(new GameObject(childName).transform);
	}

	public static T CreateChild<T>(this Transform self, string childName) where T : Component
	{
		return self.CreateChild(childName).gameObject.AddComponent<T>();
	}

	public static Transform CreateChildFromOriginal(this Transform self, Transform original)
	{
		Transform transform = UnityEngine.Object.Instantiate(original);
		transform.name = original.name;
		return self.SetChild(transform);
	}

	public static T CreateChildFromOriginal<T>(this Transform self, Transform original)
	{
		return self.CreateChildFromOriginal(original).GetComponent<T>();
	}

	public static Transform CreateParent(this Transform self, string parentName)
	{
		Transform parent = self.parent;
		Transform transform = new GameObject(parentName).transform;
		transform.Reset();
		self.SetParent(transform);
		if (parent != null)
		{
			transform.transform.SetParent(parent);
		}
		return transform;
	}

	public static T CreateParent<T>(this Transform self, string parentName) where T : Component
	{
		return self.CreateParent(parentName).gameObject.AddComponent<T>();
	}

	public static List<GameObject> GetChildren(this GameObject gameObject)
	{
		List<GameObject> list = new List<GameObject>();
		foreach (Transform item in gameObject.transform)
		{
			list.Add(item.gameObject);
		}
		return list;
	}
}
public class WaitUntilAnimationFinished : CustomYieldInstruction
{
	private readonly Animator _animator;

	private readonly int _animationHash;

	public override bool keepWaiting
	{
		get
		{
			AnimatorStateInfo currentAnimatorStateInfo = _animator.GetCurrentAnimatorStateInfo(0);
			if (currentAnimatorStateInfo.fullPathHash != _animationHash)
			{
				return false;
			}
			return !(currentAnimatorStateInfo.normalizedTime >= 1f);
		}
	}

	public WaitUntilAnimationFinished(Animator animator)
	{
		_animator = animator;
		_animationHash = animator.GetCurrentAnimatorStateInfo(0).fullPathHash;
	}
}
