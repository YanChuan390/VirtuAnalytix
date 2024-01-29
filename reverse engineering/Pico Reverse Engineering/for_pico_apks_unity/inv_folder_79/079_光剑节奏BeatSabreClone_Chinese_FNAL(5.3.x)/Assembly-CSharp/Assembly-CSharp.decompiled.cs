using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using ShatterToolkit;
using ShatterToolkit.Helpers;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public enum Pipeline
{
	HDRP,
	LWRP,
	Standard
}
public class SpinPlanet : MonoBehaviour
{
	public float speed = 4f;

	private void Update()
	{
		base.transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
public abstract class BaseStarDataRenderer
{
	public delegate void StarDataProgress(BaseStarDataRenderer renderer, float progress);

	public delegate void StarDataComplete(BaseStarDataRenderer renderer, Texture2D texture, bool success);

	public float density;

	public float imageSize;

	public float starRadius;

	protected float sphereRadius = 1f;

	public event StarDataProgress progressCallback;

	public event StarDataComplete completionCallback;

	public abstract IEnumerator ComputeStarData();

	protected void SendProgress(float progress)
	{
		if (this.progressCallback != null)
		{
			this.progressCallback(this, progress);
		}
	}

	protected void SendCompletion(Texture2D texture, bool success)
	{
		if (this.completionCallback != null)
		{
			this.completionCallback(this, texture, success);
		}
	}
}
public class CPUStarDataRenderer : BaseStarDataRenderer
{
	public override IEnumerator ComputeStarData()
	{
		SendProgress(0f);
		Texture2D tex = new Texture2D((int)imageSize, (int)imageSize, TextureFormat.RGBA32, mipChain: false);
		int tileSize = (int)imageSize;
		List<StarPoint> starPoints = GenerateRandomStarsPoints(density, tileSize, tileSize);
		SendProgress(0f);
		for (int yIndex = 0; yIndex < tileSize; yIndex++)
		{
			float yPosition = SphereUtility.PercentToHeight((float)yIndex / (float)(tileSize - 1));
			for (int i = 0; i < tileSize; i++)
			{
				float radAngle = SphereUtility.PercentToRadAngle((float)i / (float)(tileSize - 1));
				Vector3 spot = SphereUtility.SphericalToPoint(yPosition, radAngle);
				StarPoint starPoint = NearestStarPoint(spot, starPoints);
				Color color = new Color(PointAxisToPercent(starPoint.position.x), PointAxisToPercent(starPoint.position.y), PointAxisToPercent(starPoint.position.z), starPoint.noise);
				tex.SetPixel(i, yIndex, color);
			}
			float progress = (float)((yIndex + 1) * tileSize) / (float)(tileSize * tileSize);
			SendProgress(progress);
			yield return null;
		}
		tex.Apply(updateMipmaps: false);
		SendCompletion(tex, success: true);
	}

	private float PointAxisToPercent(float axis)
	{
		return Mathf.Clamp01((axis + 1f) / 2f);
	}

	private List<StarPoint> GenerateRandomStarsPoints(float density, int imageWidth, int imageHeight)
	{
		int num = Mathf.FloorToInt((float)imageWidth * (float)imageHeight * Mathf.Clamp(density, 0f, 1f));
		List<StarPoint> list = new List<StarPoint>(num + 1);
		float num2 = starRadius * 2.01f;
		for (int i = 0; i < num; i++)
		{
			Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (Vector3.Distance(list[j].position, onUnitSphere) < num2)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				StarPoint item = new StarPoint(onUnitSphere, UnityEngine.Random.Range(0.5f, 1f), 0f, 0f);
				list.Add(item);
			}
		}
		return list;
	}

	private StarPoint NearestStarPoint(Vector3 spot, List<StarPoint> starPoints)
	{
		StarPoint result = new StarPoint(Vector3.zero, 0f, 0f, 0f);
		if (starPoints == null)
		{
			return result;
		}
		float num = -1f;
		for (int i = 0; i < starPoints.Count; i++)
		{
			StarPoint starPoint = starPoints[i];
			float num2 = Vector3.Distance(spot, starPoint.position);
			if (num == -1f || num2 < num)
			{
				result = starPoint;
				num = num2;
			}
		}
		return result;
	}
}
public class MoonPositionHelper : MonoBehaviour
{
	[Tooltip("Adjust vertical position of moon at runtime. This value will override the shader value.")]
	[Range(0f, 1f)]
	public float verticalPosition;

	[Tooltip("Adjust horizontal position of moon at runtime. This value will override the shader value.")]
	[Range(0f, 1f)]
	public float horizontalPosition;

	private float currentVerticalPosition;

	private float currentHorizontalPosition;

	public Material moonMaterial;

	private void Start()
	{
		if (moonMaterial == null)
		{
			if ((bool)GetComponent<MeshRenderer>())
			{
				moonMaterial = GetComponent<MeshRenderer>().sharedMaterial;
			}
			else if (RenderSettings.skybox != null)
			{
				moonMaterial = RenderSettings.skybox;
			}
		}
		if (moonMaterial == null)
		{
			UnityEngine.Debug.LogError("Can't use MoonPositionHelper without a reference to skybox material");
			base.gameObject.SetActive(value: false);
		}
	}

	private void Update()
	{
		UpdateMoonData();
		if (currentVerticalPosition != verticalPosition || currentHorizontalPosition != horizontalPosition)
		{
			if (moonMaterial == null)
			{
				UnityEngine.Debug.LogError("Can't animate moon position without material reference");
				base.gameObject.SetActive(value: false);
			}
			else
			{
				UpdateMoonData();
				currentVerticalPosition = verticalPosition;
				currentHorizontalPosition = horizontalPosition;
			}
		}
	}

	public void UpdateMoonData()
	{
		float yPosition = SphereUtility.PercentToHeight(verticalPosition);
		float radAngle = SphereUtility.PercentToRadAngle(horizontalPosition);
		Vector3 star = SphereUtility.SphericalToPoint(yPosition, radAngle);
		float xRotationAngle = 0f;
		float yRotationAngle = 0f;
		SphereUtility.CalculateStarRotation(star, out xRotationAngle, out yRotationAngle);
		Vector4 value = new Vector4(star.x, star.y, star.z, 0f);
		Vector4 value2 = new Vector4(xRotationAngle, yRotationAngle, 0f, 0f);
		moonMaterial.SetVector("_MoonComputedPositionData", value);
		moonMaterial.SetVector("_MoonComputedRotationData", value2);
	}
}
public abstract class SphereUtility
{
	private const float k_HalfPI = (float)Math.PI / 2f;

	public static float RadiusAtHeight(float yPos)
	{
		return Mathf.Abs(Mathf.Cos(Mathf.Asin(yPos)));
	}

	public static Vector3 SphericalToPoint(float yPosition, float radAngle)
	{
		float num = RadiusAtHeight(yPosition);
		return new Vector3(num * Mathf.Cos(radAngle), yPosition, num * Mathf.Sin(radAngle));
	}

	public static float RadAngleToPercent(float radAngle)
	{
		return radAngle / ((float)Math.PI * 2f);
	}

	public static float PercentToRadAngle(float percent)
	{
		return percent * ((float)Math.PI * 2f);
	}

	public static float HeightToPercent(float yValue)
	{
		return yValue / 2f + 0.5f;
	}

	public static float PercentToHeight(float hPercent)
	{
		return Mathf.Lerp(-1f, 1f, hPercent);
	}

	public static float AngleToReachTarget(Vector2 point, float targetAngle)
	{
		float num = Atan2Positive(point.y, point.x);
		return (float)Math.PI * 2f - num + targetAngle;
	}

	public static float Atan2Positive(float y, float x)
	{
		float num = Mathf.Atan2(y, x);
		if (num < 0f)
		{
			num = (float)Math.PI + ((float)Math.PI + num);
		}
		return num;
	}

	public static Vector3 RotateAroundXAxis(Vector3 point, float angle)
	{
		Vector2 vector = Rotate2d(new Vector2(point.z, point.y), angle);
		return new Vector3(point.x, vector.y, vector.x);
	}

	public static Vector3 RotateAroundYAxis(Vector3 point, float angle)
	{
		Vector2 vector = Rotate2d(new Vector2(point.x, point.z), angle);
		return new Vector3(vector.x, point.y, vector.y);
	}

	public static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation)
	{
		return RotateAroundXAxis(RotateAroundYAxis(point, yAxisRotation), xAxisRotation);
	}

	public static Vector2 Rotate2d(Vector2 pos, float angle)
	{
		return Matrix2x2Mult(new Vector4(Mathf.Cos(angle), 0f - Mathf.Sin(angle), Mathf.Sin(angle), Mathf.Cos(angle)), pos);
	}

	public static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos)
	{
		return new Vector2(matrix[0] * pos[0] + matrix[1] * pos[1], matrix[2] * pos[0] + matrix[3] * pos[1]);
	}

	public static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle)
	{
		Vector3 point = new Vector3(star.x, star.y, star.z);
		yRotationAngle = AngleToReachTarget(new Vector2(point.x, point.z), (float)Math.PI / 2f);
		point = RotateAroundYAxis(point, yRotationAngle);
		xRotationAngle = AngleToReachTarget(new Vector3(point.z, point.y), 0f);
	}

	public static Vector2 DirectionToSphericalCoordinate(Vector3 direction)
	{
		Vector3 normalized = direction.normalized;
		float x = Atan2Positive(normalized.z, normalized.x);
		float num = 0f;
		float num2 = Vector3.Angle(direction, Vector3.up) * ((float)Math.PI / 180f);
		num = ((!(num2 <= (float)Math.PI / 2f)) ? (-1f * (num2 - (float)Math.PI / 2f)) : ((float)Math.PI / 2f - num2));
		return new Vector2(x, num);
	}
}
public class StarPoint
{
	public Vector3 position;

	public float noise;

	public float xRotation;

	public float yRotation;

	public StarPoint(Vector3 position, float noise, float xRotation, float yRotation)
	{
		this.position = position;
		this.noise = noise;
		this.xRotation = xRotation;
		this.yRotation = yRotation;
	}
}
public class LookAtTarget : MonoBehaviour
{
	[SerializeField]
	private Transform _target;

	[SerializeField]
	private float _speed = 0.5f;

	private Vector3 _lookAtTarget;

	private void Update()
	{
		_lookAtTarget = Vector3.Lerp(_lookAtTarget, _target.position, Time.deltaTime * _speed);
		base.transform.LookAt(_lookAtTarget);
	}
}
public class MouseMove : MonoBehaviour
{
	[SerializeField]
	private float _sensitivity = 0.5f;

	private Vector3 _originalPos;

	private void Start()
	{
		_originalPos = base.transform.position;
	}

	private void Update()
	{
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.x /= Screen.width;
		mousePosition.y /= Screen.height;
		mousePosition.x -= 0.5f;
		mousePosition.y -= 0.5f;
		mousePosition *= 2f * _sensitivity;
		base.transform.position = _originalPos + mousePosition;
	}
}
public class SwooshTest : MonoBehaviour
{
	[SerializeField]
	private AnimationClip _animation;

	private AnimationState _animationState;

	[SerializeField]
	private int _start;

	[SerializeField]
	private int _end;

	private float _startN;

	private float _endN;

	private float _time;

	private float _prevTime;

	private float _prevAnimTime;

	[SerializeField]
	private MeleeWeaponTrail _trail;

	private bool _firstFrame = true;

	private void Start()
	{
		float num = _animation.frameRate * _animation.length;
		_startN = (float)_start / num;
		_endN = (float)_end / num;
		_animationState = GetComponent<Animation>()[_animation.name];
		_trail.Emit = false;
	}

	private void Update()
	{
		_time += _animationState.normalizedTime - _prevAnimTime;
		if (_time > 1f || _firstFrame)
		{
			if (!_firstFrame)
			{
				_time -= 1f;
			}
			_firstFrame = false;
		}
		if (_prevTime < _startN && _time >= _startN)
		{
			_trail.Emit = true;
		}
		else if (_prevTime < _endN && _time >= _endN)
		{
			_trail.Emit = false;
		}
		_prevTime = _time;
		_prevAnimTime = _animationState.normalizedTime;
	}
}
public class Interpolate
{
	public enum EaseType
	{
		Linear,
		EaseInQuad,
		EaseOutQuad,
		EaseInOutQuad,
		EaseInCubic,
		EaseOutCubic,
		EaseInOutCubic,
		EaseInQuart,
		EaseOutQuart,
		EaseInOutQuart,
		EaseInQuint,
		EaseOutQuint,
		EaseInOutQuint,
		EaseInSine,
		EaseOutSine,
		EaseInOutSine,
		EaseInExpo,
		EaseOutExpo,
		EaseInOutExpo,
		EaseInCirc,
		EaseOutCirc,
		EaseInOutCirc
	}

	public delegate Vector3 ToVector3<T>(T v);

	public delegate float Function(float a, float b, float c, float d);

	private static Vector3 Identity(Vector3 v)
	{
		return v;
	}

	private static Vector3 TransformDotPosition(Transform t)
	{
		return t.position;
	}

	private static IEnumerable<float> NewTimer(float duration)
	{
		float elapsedTime = 0f;
		while (elapsedTime < duration)
		{
			yield return elapsedTime;
			elapsedTime += Time.deltaTime;
			if (elapsedTime >= duration)
			{
				yield return elapsedTime;
			}
		}
	}

	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		for (int i = start; i <= end; i += step)
		{
			yield return i;
		}
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		IEnumerable<float> driver = NewTimer(duration);
		return NewEase(ease, start, end, duration, driver);
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		IEnumerable<float> driver = NewCounter(0, slices + 1, 1);
		return NewEase(ease, start, end, slices + 1, driver);
	}

	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		Vector3 distance = end - start;
		foreach (float item in driver)
		{
			yield return Ease(ease, start, distance, item, total);
		}
	}

	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		start.x = ease(start.x, distance.x, elapsedTime, duration);
		start.y = ease(start.y, distance.y, elapsedTime, duration);
		start.z = ease(start.z, distance.z, elapsedTime, duration);
		return start;
	}

	public static Function Ease(EaseType type)
	{
		Function result = null;
		switch (type)
		{
		case EaseType.Linear:
			result = Linear;
			break;
		case EaseType.EaseInQuad:
			result = EaseInQuad;
			break;
		case EaseType.EaseOutQuad:
			result = EaseOutQuad;
			break;
		case EaseType.EaseInOutQuad:
			result = EaseInOutQuad;
			break;
		case EaseType.EaseInCubic:
			result = EaseInCubic;
			break;
		case EaseType.EaseOutCubic:
			result = EaseOutCubic;
			break;
		case EaseType.EaseInOutCubic:
			result = EaseInOutCubic;
			break;
		case EaseType.EaseInQuart:
			result = EaseInQuart;
			break;
		case EaseType.EaseOutQuart:
			result = EaseOutQuart;
			break;
		case EaseType.EaseInOutQuart:
			result = EaseInOutQuart;
			break;
		case EaseType.EaseInQuint:
			result = EaseInQuint;
			break;
		case EaseType.EaseOutQuint:
			result = EaseOutQuint;
			break;
		case EaseType.EaseInOutQuint:
			result = EaseInOutQuint;
			break;
		case EaseType.EaseInSine:
			result = EaseInSine;
			break;
		case EaseType.EaseOutSine:
			result = EaseOutSine;
			break;
		case EaseType.EaseInOutSine:
			result = EaseInOutSine;
			break;
		case EaseType.EaseInExpo:
			result = EaseInExpo;
			break;
		case EaseType.EaseOutExpo:
			result = EaseOutExpo;
			break;
		case EaseType.EaseInOutExpo:
			result = EaseInOutExpo;
			break;
		case EaseType.EaseInCirc:
			result = EaseInCirc;
			break;
		case EaseType.EaseOutCirc:
			result = EaseOutCirc;
			break;
		case EaseType.EaseInOutCirc:
			result = EaseInOutCirc;
			break;
		}
		return result;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		IEnumerable<float> steps = NewTimer(duration);
		return NewBezier<Transform>(ease, nodes, TransformDotPosition, duration, steps);
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		IEnumerable<float> steps = NewCounter(0, slices + 1, 1);
		return NewBezier<Transform>(ease, nodes, TransformDotPosition, slices + 1, steps);
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		IEnumerable<float> steps = NewTimer(duration);
		return NewBezier<Vector3>(ease, points, Identity, duration, steps);
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		IEnumerable<float> steps = NewCounter(0, slices + 1, 1);
		return NewBezier<Vector3>(ease, points, Identity, slices + 1, steps);
	}

	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		if (nodes.Count < 2)
		{
			yield break;
		}
		Vector3[] points = new Vector3[nodes.Count];
		foreach (float step in steps)
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				points[i] = toVector3((T)nodes[i]);
			}
			yield return Bezier(ease, points, step, maxStep);
		}
	}

	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		for (int num = points.Length - 1; num > 0; num--)
		{
			for (int i = 0; i < num; i++)
			{
				points[i].x = ease(points[i].x, points[i + 1].x - points[i].x, elapsedTime, duration);
				points[i].y = ease(points[i].y, points[i + 1].y - points[i].y, elapsedTime, duration);
				points[i].z = ease(points[i].z, points[i + 1].z - points[i].z, elapsedTime, duration);
			}
		}
		return points[0];
	}

	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return NewCatmullRom<Transform>(nodes, TransformDotPosition, slices, loop);
	}

	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return NewCatmullRom<Vector3>(points, Identity, slices, loop);
	}

	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		if (nodes.Count < 2)
		{
			yield break;
		}
		yield return toVector3((T)nodes[0]);
		int last = nodes.Count - 1;
		for (int current = 0; loop || current < last; current++)
		{
			if (loop && current > last)
			{
				current = 0;
			}
			int previous = ((current != 0) ? (current - 1) : (loop ? last : current));
			int start = current;
			int end = ((current != last) ? (current + 1) : ((!loop) ? current : 0));
			int next = ((end != last) ? (end + 1) : ((!loop) ? end : 0));
			int stepCount = slices + 1;
			for (int step = 1; step <= stepCount; step++)
			{
				yield return CatmullRom(toVector3((T)nodes[previous]), toVector3((T)nodes[start]), toVector3((T)nodes[end]), toVector3((T)nodes[next]), step, stepCount);
			}
		}
	}

	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		float num = elapsedTime / duration;
		float num2 = num * num;
		float num3 = num2 * num;
		return previous * (-0.5f * num3 + num2 - 0.5f * num) + start * (1.5f * num3 + -2.5f * num2 + 1f) + end * (-1.5f * num3 + 2f * num2 + 0.5f * num) + next * (0.5f * num3 - 0.5f * num2);
	}

	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * (elapsedTime / duration) + start;
	}

	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime + start;
	}

	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return (0f - distance) * elapsedTime * (elapsedTime - 2f) + start;
	}

	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 1f;
		return (0f - distance) / 2f * (elapsedTime * (elapsedTime - 2f) - 1f) + start;
	}

	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime + start;
	}

	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * (elapsedTime * elapsedTime * elapsedTime + 1f) + start;
	}

	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (elapsedTime * elapsedTime * elapsedTime + 2f) + start;
	}

	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
	}

	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return (0f - distance) * (elapsedTime * elapsedTime * elapsedTime * elapsedTime - 1f) + start;
	}

	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return (0f - distance) / 2f * (elapsedTime * elapsedTime * elapsedTime * elapsedTime - 2f) + start;
	}

	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
	}

	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * (elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + 1f) + start;
	}

	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + 2f) + start;
	}

	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return (0f - distance) * Mathf.Cos(elapsedTime / duration * ((float)Math.PI / 2f)) + distance + start;
	}

	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * Mathf.Sin(elapsedTime / duration * ((float)Math.PI / 2f)) + start;
	}

	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return (0f - distance) / 2f * (Mathf.Cos((float)Math.PI * elapsedTime / duration) - 1f) + start;
	}

	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * Mathf.Pow(2f, 10f * (elapsedTime / duration - 1f)) + start;
	}

	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * (0f - Mathf.Pow(2f, -10f * elapsedTime / duration) + 1f) + start;
	}

	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * Mathf.Pow(2f, 10f * (elapsedTime - 1f)) + start;
		}
		elapsedTime -= 1f;
		return distance / 2f * (0f - Mathf.Pow(2f, -10f * elapsedTime) + 2f) + start;
	}

	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return (0f - distance) * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) - 1f) + start;
	}

	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * Mathf.Sqrt(1f - elapsedTime * elapsedTime) + start;
	}

	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return (0f - distance) / 2f * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) - 1f) + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) + 1f) + start;
	}
}
public class MeleeWeaponTrail : MonoBehaviour
{
	[Serializable]
	public class Point
	{
		public float timeCreated;

		public Vector3 basePosition;

		public Vector3 tipPosition;
	}

	[SerializeField]
	private bool _emit = true;

	private bool _use = true;

	[SerializeField]
	private float _emitTime;

	[SerializeField]
	public Material _material;

	[SerializeField]
	private float _lifeTime = 1f;

	[SerializeField]
	private Color[] _colors;

	[SerializeField]
	private float[] _sizes;

	[SerializeField]
	private float _minVertexDistance = 0.1f;

	[SerializeField]
	private float _maxVertexDistance = 10f;

	private float _minVertexDistanceSqr;

	private float _maxVertexDistanceSqr;

	[SerializeField]
	private float _maxAngle = 3f;

	[SerializeField]
	private bool _autoDestruct;

	[SerializeField]
	private int subdivisions = 4;

	[SerializeField]
	private Transform _base;

	[SerializeField]
	private Transform _tip;

	private List<Point> _points = new List<Point>();

	private List<Point> _smoothedPoints = new List<Point>();

	private GameObject _trailObject;

	private Mesh _trailMesh;

	private Vector3 _lastPosition;

	public bool Emit
	{
		set
		{
			_emit = value;
		}
	}

	public bool Use
	{
		set
		{
			_use = value;
		}
	}

	private void Start()
	{
		_lastPosition = base.transform.position;
		_trailObject = new GameObject("Trail");
		_trailObject.transform.parent = null;
		_trailObject.transform.position = Vector3.zero;
		_trailObject.transform.rotation = Quaternion.identity;
		_trailObject.transform.localScale = Vector3.one;
		_trailObject.AddComponent(typeof(MeshFilter));
		_trailObject.AddComponent(typeof(MeshRenderer));
		_trailObject.GetComponent<Renderer>().material = _material;
		_trailMesh = new Mesh();
		_trailMesh.name = base.name + "TrailMesh";
		_trailObject.GetComponent<MeshFilter>().mesh = _trailMesh;
		_minVertexDistanceSqr = _minVertexDistance * _minVertexDistance;
		_maxVertexDistanceSqr = _maxVertexDistance * _maxVertexDistance;
	}

	private void OnDisable()
	{
		UnityEngine.Object.Destroy(_trailObject);
	}

	private void Update()
	{
		if (!_use)
		{
			return;
		}
		if (_emit && _emitTime != 0f)
		{
			_emitTime -= Time.deltaTime;
			if (_emitTime == 0f)
			{
				_emitTime = -1f;
			}
			if (_emitTime < 0f)
			{
				_emit = false;
			}
		}
		if (!_emit && _points.Count == 0 && _autoDestruct)
		{
			UnityEngine.Object.Destroy(_trailObject);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		float sqrMagnitude = (_lastPosition - base.transform.position).sqrMagnitude;
		if (_emit)
		{
			if (sqrMagnitude > _minVertexDistanceSqr)
			{
				bool flag = false;
				if (_points.Count < 3)
				{
					flag = true;
				}
				else
				{
					Vector3 from = _points[_points.Count - 2].tipPosition - _points[_points.Count - 3].tipPosition;
					Vector3 to = _points[_points.Count - 1].tipPosition - _points[_points.Count - 2].tipPosition;
					if (Vector3.Angle(from, to) > _maxAngle || sqrMagnitude > _maxVertexDistanceSqr)
					{
						flag = true;
					}
				}
				if (flag)
				{
					Point point = new Point();
					point.basePosition = _base.position;
					point.tipPosition = _tip.position;
					point.timeCreated = Time.time;
					_points.Add(point);
					_lastPosition = base.transform.position;
					if (_points.Count == 1)
					{
						_smoothedPoints.Add(point);
					}
					else if (_points.Count > 1)
					{
						for (int i = 0; i < 1 + subdivisions; i++)
						{
							_smoothedPoints.Add(point);
						}
					}
					if (_points.Count >= 4)
					{
						IEnumerable<Vector3> collection = Interpolate.NewCatmullRom(new Vector3[4]
						{
							_points[_points.Count - 4].tipPosition,
							_points[_points.Count - 3].tipPosition,
							_points[_points.Count - 2].tipPosition,
							_points[_points.Count - 1].tipPosition
						}, subdivisions, loop: false);
						IEnumerable<Vector3> collection2 = Interpolate.NewCatmullRom(new Vector3[4]
						{
							_points[_points.Count - 4].basePosition,
							_points[_points.Count - 3].basePosition,
							_points[_points.Count - 2].basePosition,
							_points[_points.Count - 1].basePosition
						}, subdivisions, loop: false);
						List<Vector3> list = new List<Vector3>(collection);
						List<Vector3> list2 = new List<Vector3>(collection2);
						float timeCreated = _points[_points.Count - 4].timeCreated;
						float timeCreated2 = _points[_points.Count - 1].timeCreated;
						for (int j = 0; j < list.Count; j++)
						{
							int num = _smoothedPoints.Count - (list.Count - j);
							if (num > -1 && num < _smoothedPoints.Count)
							{
								Point point2 = new Point();
								point2.basePosition = list2[j];
								point2.tipPosition = list[j];
								point2.timeCreated = Mathf.Lerp(timeCreated, timeCreated2, (float)j / (float)list.Count);
								_smoothedPoints[num] = point2;
							}
						}
					}
				}
				else
				{
					_points[_points.Count - 1].basePosition = _base.position;
					_points[_points.Count - 1].tipPosition = _tip.position;
					_smoothedPoints[_smoothedPoints.Count - 1].basePosition = _base.position;
					_smoothedPoints[_smoothedPoints.Count - 1].tipPosition = _tip.position;
				}
			}
			else
			{
				if (_points.Count > 0)
				{
					_points[_points.Count - 1].basePosition = _base.position;
					_points[_points.Count - 1].tipPosition = _tip.position;
				}
				if (_smoothedPoints.Count > 0)
				{
					_smoothedPoints[_smoothedPoints.Count - 1].basePosition = _base.position;
					_smoothedPoints[_smoothedPoints.Count - 1].tipPosition = _tip.position;
				}
			}
		}
		RemoveOldPoints(_points);
		if (_points.Count == 0)
		{
			_trailMesh.Clear();
		}
		RemoveOldPoints(_smoothedPoints);
		if (_smoothedPoints.Count == 0)
		{
			_trailMesh.Clear();
		}
		List<Point> smoothedPoints = _smoothedPoints;
		if (smoothedPoints.Count <= 1)
		{
			return;
		}
		Vector3[] array = new Vector3[smoothedPoints.Count * 2];
		Vector2[] array2 = new Vector2[smoothedPoints.Count * 2];
		int[] array3 = new int[(smoothedPoints.Count - 1) * 6];
		Color[] array4 = new Color[smoothedPoints.Count * 2];
		for (int k = 0; k < smoothedPoints.Count; k++)
		{
			Point point3 = smoothedPoints[k];
			float num2 = (Time.time - point3.timeCreated) / _lifeTime;
			Color color = Color.Lerp(Color.white, Color.clear, num2);
			if (_colors != null && _colors.Length != 0)
			{
				float num3 = num2 * (float)(_colors.Length - 1);
				float num4 = Mathf.Floor(num3);
				float num5 = Mathf.Clamp(Mathf.Ceil(num3), 1f, _colors.Length - 1);
				float t = Mathf.InverseLerp(num4, num5, num3);
				if (num4 >= (float)_colors.Length)
				{
					num4 = _colors.Length - 1;
				}
				if (num4 < 0f)
				{
					num4 = 0f;
				}
				if (num5 >= (float)_colors.Length)
				{
					num5 = _colors.Length - 1;
				}
				if (num5 < 0f)
				{
					num5 = 0f;
				}
				color = Color.Lerp(_colors[(int)num4], _colors[(int)num5], t);
			}
			float num6 = 0f;
			if (_sizes != null && _sizes.Length != 0)
			{
				float num7 = num2 * (float)(_sizes.Length - 1);
				float num8 = Mathf.Floor(num7);
				float num9 = Mathf.Clamp(Mathf.Ceil(num7), 1f, _sizes.Length - 1);
				float t2 = Mathf.InverseLerp(num8, num9, num7);
				if (num8 >= (float)_sizes.Length)
				{
					num8 = _sizes.Length - 1;
				}
				if (num8 < 0f)
				{
					num8 = 0f;
				}
				if (num9 >= (float)_sizes.Length)
				{
					num9 = _sizes.Length - 1;
				}
				if (num9 < 0f)
				{
					num9 = 0f;
				}
				num6 = Mathf.Lerp(_sizes[(int)num8], _sizes[(int)num9], t2);
			}
			Vector3 vector = point3.tipPosition - point3.basePosition;
			array[k * 2] = point3.basePosition - vector * (num6 * 0.5f);
			array[k * 2 + 1] = point3.tipPosition + vector * (num6 * 0.5f);
			array4[k * 2] = (array4[k * 2 + 1] = color);
			float x = (float)k / (float)smoothedPoints.Count;
			array2[k * 2] = new Vector2(x, 0f);
			array2[k * 2 + 1] = new Vector2(x, 1f);
			if (k > 0)
			{
				array3[(k - 1) * 6] = k * 2 - 2;
				array3[(k - 1) * 6 + 1] = k * 2 - 1;
				array3[(k - 1) * 6 + 2] = k * 2;
				array3[(k - 1) * 6 + 3] = k * 2 + 1;
				array3[(k - 1) * 6 + 4] = k * 2;
				array3[(k - 1) * 6 + 5] = k * 2 - 1;
			}
		}
		_trailMesh.Clear();
		_trailMesh.vertices = array;
		_trailMesh.colors = array4;
		_trailMesh.uv = array2;
		_trailMesh.triangles = array3;
	}

	private void RemoveOldPoints(List<Point> pointList)
	{
		List<Point> list = new List<Point>();
		foreach (Point point in pointList)
		{
			if (Time.time - point.timeCreated > _lifeTime)
			{
				list.Add(point);
			}
		}
		foreach (Point item in list)
		{
			pointList.Remove(item);
		}
	}
}
public class SplitProperty : MonoBehaviour
{
	public bool forMainSelect;

	public bool forCubeCut;

	public bool forCubeBreak;

	public void newGameObjectSpecialSet(Rigidbody newGameObject, Ball.BallCollisionInfo ballCollisionInfo = null)
	{
		if (forCubeCut)
		{
			newGameObject.GetComponent<FrageDisappear>().breaked = true;
			newGameObject.GetComponent<MeshCollider>().enabled = true;
			newGameObject.constraints = RigidbodyConstraints.None;
			if (ballCollisionInfo != null)
			{
				_ = newGameObject.GetComponent<MeshFilter>().mesh.bounds.center;
				_ = newGameObject.centerOfMass;
				float num = CalculateSumVolume(newGameObject.GetComponent<MeshFilter>().mesh, newGameObject.transform);
				float num2 = CalculateSumVolume(GetComponent<MeshFilter>().mesh, newGameObject.transform);
				newGameObject.mass = num / num2;
				Vector3 normalized = (-ballCollisionInfo.blade.waveDirection).normalized;
				Vector3 force = ballCollisionInfo.blade.waveDistancePerSecond * 6f * normalized + (newGameObject.worldCenterOfMass - base.transform.position).normalized * 60f;
				newGameObject.AddForce(force);
			}
			newGameObject.useGravity = true;
		}
		else if (forCubeBreak)
		{
			newGameObject.GetComponent<FrageDisappear>().breaked = true;
			newGameObject.constraints = RigidbodyConstraints.None;
			if (ballCollisionInfo != null)
			{
				_ = newGameObject.GetComponent<MeshFilter>().mesh.bounds.center;
				_ = newGameObject.centerOfMass;
				float num3 = CalculateSumVolume(newGameObject.GetComponent<MeshFilter>().mesh, newGameObject.transform);
				float num4 = CalculateSumVolume(GetComponent<MeshFilter>().mesh, newGameObject.transform);
				newGameObject.mass = 0.5f + 0.5f * num3 / num4;
				Vector3 normalized2 = (newGameObject.worldCenterOfMass - ballCollisionInfo.colliderPoint).normalized;
				Vector3 force2 = ballCollisionInfo.blade.waveDistancePerSecond * 8f * normalized2;
				newGameObject.AddForce(force2);
			}
			newGameObject.useGravity = true;
		}
	}

	private Vector3 CalVecticesCenter(Vector3[] vertices)
	{
		Vector3 zero = Vector3.zero;
		foreach (Vector3 vector in vertices)
		{
			zero += vector;
		}
		return zero / vertices.Length;
	}

	private float CalculateSumVolume(Mesh mesh, Transform t)
	{
		Vector3[] vertices = mesh.vertices;
		_ = mesh.triangles;
		float num = 0f;
		for (int i = 0; i < mesh.subMeshCount; i++)
		{
			int[] triangles = mesh.GetTriangles(i);
			for (int j = 0; j < triangles.Length; j += 3)
			{
				num += CalculateVolume(vertices[triangles[j]], vertices[triangles[j + 1]], vertices[triangles[j + 2]], t);
			}
		}
		return Mathf.Abs(num);
	}

	private float CalculateVolume(Vector3 pt0, Vector3 pt1, Vector3 pt2, Transform t)
	{
		pt0 = new Vector3(pt0.x * t.lossyScale.x, pt0.y * t.lossyScale.y, pt0.z * t.lossyScale.z);
		pt1 = new Vector3(pt1.x * t.lossyScale.x, pt1.y * t.lossyScale.y, pt1.z * t.lossyScale.z);
		pt2 = new Vector3(pt2.x * t.lossyScale.x, pt2.y * t.lossyScale.y, pt2.z * t.lossyScale.z);
		float num = pt2.x * pt1.y * pt0.z;
		float num2 = pt1.x * pt2.y * pt0.z;
		float num3 = pt2.x * pt0.y * pt1.z;
		float num4 = pt0.x * pt2.y * pt1.z;
		float num5 = pt1.x * pt0.y * pt2.z;
		float num6 = pt0.x * pt1.y * pt2.z;
		return 1f / 6f * (0f - num + num2 + num3 - num4 - num5 + num6);
	}
}
public class BallInfo
{
	public Vector2Int targetIndex { get; set; }

	public BallType ballType { get; set; }

	public BallDirection ballDirection { get; set; }

	public int bsTimeHitTimeIndex { get; set; }

	public bool isQSBall()
	{
		if (ballDirection == BallDirection.DownLeft || ballDirection == BallDirection.DownRight || ballDirection == BallDirection.UpLeft || ballDirection == BallDirection.UpRight)
		{
			return true;
		}
		return false;
	}

	public BallInfo getCopy()
	{
		return new BallInfo
		{
			targetIndex = new Vector2Int(targetIndex.x, targetIndex.y),
			ballType = ballType,
			ballDirection = ballDirection,
			bsTimeHitTimeIndex = bsTimeHitTimeIndex
		};
	}
}
public enum BallType
{
	LeftBall,
	RightBall,
	BlackBall
}
public enum BallDirection
{
	Up,
	Down,
	Left,
	Right,
	UpLeft,
	UpRight,
	DownLeft,
	DownRight,
	All
}
public class BsWallInfo
{
	public Vector3 originPos;

	public Vector3 targetPos;

	public Vector3 orTargetPos;

	public Vector3 hitPos;

	public int hitTimeIndex;

	public BsObstacles bsObstacles;
}
public class BsHipData
{
	public List<BsEvent> _events;

	public List<BsNotes> _notes;

	public List<BsObstacles> _obstacles;
}
public class BsEvent
{
	public float _time;

	public int _type;

	public int _value;
}
public class BsNotes
{
	public float _time;

	public int _lineIndex;

	public int _lineLayer;

	public int _type;

	public int _cutDirection;
}
public class BsObstacles
{
	public float _time;

	public int _lineIndex;

	public int _type;

	public int _width;

	public float _duration;
}
public class BsMusicBeatData
{
	public BsHipData selectedBsHipData;

	public Dictionary<int, List<BallInfo>> generatorDicBs;

	public Dictionary<int, BsEvent> BsEventDic;

	public Dictionary<int, List<BsWallInfo>> bsWallInfoDic;

	public int delayIndex;

	public int indexDistance;

	public float ballSpeed;

	public static float BsWallOrigin_Z = 70f;

	public static float BsWallOrigin_X_OR = -0.9f;

	public static float BsWallOrigin_X_OR_QX = -1.2f;

	public static float BsWallOrigin_X_Step = 0.45f;

	public static float BsWallOrigin_X_Step_QX = 0.6f;

	public static float BsWallOrigin_Y_Step = 0.45f;

	public static float BsWallOrigin_Y_Step_QX = 0.6f;

	public static float BsWallOrigin_Z_Target = -0.6f;

	public static float BsBall_QX_Shift = 0.075f;

	public static float BsWallWidthSlot = 0.08f;

	public static float JianSuBeiShu = 1f;

	public static float JiaSuBeiShu = 15f;

	public static float slowDistance = 13f;

	public static float BaseHeight = 0.7f;

	public InfoDat infoDat;

	public string selectedDifficultyName;

	public bool isInnerBs;

	public string floderPath;

	public static float rightWeiZhiPosZ = 9f;

	public bool checkBsMusicInfo()
	{
		try
		{
			foreach (DifficultyBeatmap difficultyBeatmap in infoDat._difficultyBeatmapSets[0]._difficultyBeatmaps)
			{
				if (isInnerBs)
				{
					JsonConvert.DeserializeObject<BsHipData>(Resources.Load<TextAsset>(Path.Combine(floderPath, Path.GetFileNameWithoutExtension(difficultyBeatmap._beatmapFilename))).text);
				}
				else
				{
					JsonConvert.DeserializeObject<BsHipData>(FileUtils.ReadFile(Path.Combine(Application.persistentDataPath, floderPath, difficultyBeatmap._beatmapFilename)));
				}
			}
		}
		catch (Exception message)
		{
			UnityEngine.Debug.LogError(message);
			return false;
		}
		return true;
	}

	public bool initBsMusic()
	{
		infoDat = UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo.infoDat;
		selectedDifficultyName = UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel;
		isInnerBs = UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo.loadType.type == 0;
		floderPath = UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo.fullpath;
		if (!checkBsMusicInfo())
		{
			return false;
		}
		string text = null;
		foreach (DifficultyBeatmap difficultyBeatmap in infoDat._difficultyBeatmapSets[0]._difficultyBeatmaps)
		{
			if (selectedDifficultyName == null || selectedDifficultyName.Equals(difficultyBeatmap._difficulty))
			{
				text = difficultyBeatmap._beatmapFilename;
				ballSpeed = ajudstBsSpeed(difficultyBeatmap._noteJumpMovementSpeed);
				break;
			}
		}
		if (isInnerBs)
		{
			string text2 = Resources.Load<TextAsset>(Path.Combine(floderPath, Path.GetFileNameWithoutExtension(text))).text;
			selectedBsHipData = JsonConvert.DeserializeObject<BsHipData>(text2);
		}
		else
		{
			string value = FileUtils.ReadFile(Path.Combine(Application.persistentDataPath, floderPath, text));
			selectedBsHipData = JsonConvert.DeserializeObject<BsHipData>(value);
		}
		generatorDicBs = new Dictionary<int, List<BallInfo>>();
		BsEventDic = new Dictionary<int, BsEvent>();
		bsWallInfoDic = new Dictionary<int, List<BsWallInfo>>();
		foreach (BsEvent @event in selectedBsHipData._events)
		{
			int key = Mathf.RoundToInt(@event._time * 60f / infoDat._beatsPerMinute * (float)MainPlayControl.timeIndexPerSeconds);
			BsEvent value2 = null;
			BsEventDic.TryGetValue(key, out value2);
			if (value2 == null)
			{
				BsEventDic.Add(Mathf.RoundToInt(@event._time * 60f / infoDat._beatsPerMinute * (float)MainPlayControl.timeIndexPerSeconds), @event);
			}
		}
		foreach (BsNotes note in selectedBsHipData._notes)
		{
			int num = Mathf.RoundToInt(note._time * 60f / infoDat._beatsPerMinute * (float)MainPlayControl.timeIndexPerSeconds);
			BallInfo ballInfo = getBallInfo(note, num);
			if (ballInfo != null)
			{
				generatorDicBs.TryGetValue(num, out var value3);
				if (value3 == null)
				{
					value3 = new List<BallInfo>();
					value3.Add(ballInfo);
					generatorDicBs.Add(num, value3);
				}
				else
				{
					value3.Add(ballInfo);
				}
			}
		}
		foreach (BsObstacles obstacle in selectedBsHipData._obstacles)
		{
			int num2 = Mathf.RoundToInt(obstacle._time * 60f / infoDat._beatsPerMinute * (float)MainPlayControl.timeIndexPerSeconds);
			BsWallInfo bsWallInfo = getBsWallInfo(obstacle, num2);
			if (bsWallInfo != null)
			{
				bsWallInfoDic.TryGetValue(num2, out var value4);
				if (value4 == null)
				{
					value4 = new List<BsWallInfo>();
					value4.Add(bsWallInfo);
					bsWallInfoDic.Add(num2, value4);
				}
				else
				{
					value4.Add(bsWallInfo);
				}
			}
		}
		delayIndex = 0;
		setDelayedTimeIndex();
		return true;
	}

	private float ajudstBsSpeed(float noteJumpMovementSpeed)
	{
		if (noteJumpMovementSpeed == 0f)
		{
			noteJumpMovementSpeed = 10f;
		}
		if (noteJumpMovementSpeed > 15f)
		{
			return 13f + UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj;
		}
		if (noteJumpMovementSpeed > 12f)
		{
			return 12f + UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj;
		}
		return noteJumpMovementSpeed + UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj;
	}

	private BallInfo getBallInfo(BsNotes bsNotes, int timeIndex)
	{
		BallInfo ballInfo = new BallInfo();
		if (bsNotes._type == 0)
		{
			ballInfo.ballType = BallType.LeftBall;
		}
		else if (bsNotes._type == 1)
		{
			ballInfo.ballType = BallType.RightBall;
		}
		else
		{
			ballInfo.ballType = BallType.BlackBall;
		}
		switch (bsNotes._cutDirection)
		{
		case 0:
			ballInfo.ballDirection = BallDirection.Up;
			break;
		case 1:
			ballInfo.ballDirection = BallDirection.Down;
			break;
		case 2:
			ballInfo.ballDirection = BallDirection.Left;
			break;
		case 3:
			ballInfo.ballDirection = BallDirection.Right;
			break;
		case 4:
			ballInfo.ballDirection = BallDirection.UpLeft;
			break;
		case 5:
			ballInfo.ballDirection = BallDirection.UpRight;
			break;
		case 6:
			ballInfo.ballDirection = BallDirection.DownLeft;
			break;
		case 7:
			ballInfo.ballDirection = BallDirection.DownRight;
			break;
		default:
			ballInfo.ballDirection = BallDirection.All;
			break;
		}
		int x = bsNotes._lineIndex + 1;
		int y = bsNotes._lineLayer + 1;
		ballInfo.targetIndex = new Vector2Int(x, y);
		ballInfo.bsTimeHitTimeIndex = timeIndex;
		return ballInfo;
	}

	private BsWallInfo getBsWallInfo(BsObstacles bsObstacles, int timeIndex)
	{
		return new BsWallInfo
		{
			bsObstacles = bsObstacles,
			originPos = new Vector3(adjustWallPosX(bsObstacles._lineIndex), 0f, BsWallOrigin_Z),
			targetPos = new Vector3(adjustWallPosX(bsObstacles._lineIndex), 0f, -0.2f - BsWall._durationBaseLegth * bsObstacles._duration),
			orTargetPos = new Vector3(adjustWallPosX(bsObstacles._lineIndex), 0f, -0.6f),
			hitPos = new Vector3(adjustWallPosX(bsObstacles._lineIndex), 0f, SavedGameSetting.hitDis),
			hitTimeIndex = timeIndex
		};
	}

	private float adjustWallPosX(int lineIndex)
	{
		float num = 0f;
		switch (lineIndex)
		{
		case 0:
			num = BsWall.BS_WALL_START_1;
			break;
		case 1:
			num = BsWall.BS_WALL_START_2;
			break;
		case 2:
			num = BsWall.BS_WALL_START_3;
			break;
		case 3:
			num = BsWall.BS_WALL_START_4;
			break;
		}
		return num + BsWallWidthSlot;
	}

	private void setDelayedTimeIndex()
	{
		foreach (KeyValuePair<int, List<BallInfo>> generatorDicB in generatorDicBs)
		{
			foreach (BallInfo item in generatorDicB.Value)
			{
				Vector3 bsBallOrPos = GetBsBallOrPos(item);
				Vector3 bsBallTargetPos = GetBsBallTargetPos(item);
				Vector3 bsBallHitPos = GetBsBallHitPos(item);
				if (!bsBallTargetPos.Equals(Vector3.zero))
				{
					float num = (bsBallHitPos - bsBallOrPos).magnitude - slowDistance;
					indexDistance = Convert.ToInt32(num / (ballSpeed * JiaSuBeiShu) * (float)MainPlayControl.timeIndexPerSeconds + slowDistance / (ballSpeed * JianSuBeiShu) * (float)MainPlayControl.timeIndexPerSeconds);
					int num2 = generatorDicB.Key - indexDistance;
					if (num2 < delayIndex)
					{
						delayIndex = num2;
					}
				}
			}
		}
		delayIndex -= 2 * MainPlayControl.timeIndexPerSeconds;
	}

	internal Vector3 GetBsBallOrPos(BallInfo ballInfo)
	{
		generatorDicBs.TryGetValue(ballInfo.bsTimeHitTimeIndex, out var value);
		float bsBallX = GetBsBallX(ballInfo, value);
		float bsBallY = GetBsBallY(ballInfo, value);
		return new Vector3(bsBallX, bsBallY, BsWallOrigin_Z);
	}

	private float GetBsBallX(BallInfo ballInfo, List<BallInfo> ballInfos)
	{
		int x = ballInfo.targetIndex.x;
		int y = ballInfo.targetIndex.y;
		float num = BsWallOrigin_X_OR + (float)(x - 1) * BsWallOrigin_X_Step + BsWallOrigin_X_Step / 2f;
		if (ballInfos == null || ballInfos.Count == 1)
		{
			return num;
		}
		switch (x)
		{
		case 1:
		{
			BallInfo bsBallInOneByIndex4 = GetBsBallInOneByIndex(ballInfos, 2, y);
			if (bsBallInOneByIndex4 != null && bsBallInOneByIndex4.isQSBall() && ballInfo.isQSBall())
			{
				return num - 3f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex4 != null && bsBallInOneByIndex4.isQSBall() && !ballInfo.isQSBall())
			{
				return num - 2f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex4 != null && !bsBallInOneByIndex4.isQSBall() && ballInfo.isQSBall())
			{
				return num - 1f * BsBall_QX_Shift;
			}
			int num4 = y + 1;
			if (num4 < 5)
			{
				BallInfo bsBallInOneByIndex5 = GetBsBallInOneByIndex(ballInfos, 2, num4);
				if (bsBallInOneByIndex5 != null && bsBallInOneByIndex5.isQSBall())
				{
					if (ballInfo.isQSBall())
					{
						return num - 3f * BsBall_QX_Shift;
					}
					return num - 2f * BsBall_QX_Shift;
				}
			}
			int num5 = y - 1;
			if (num5 <= 0)
			{
				break;
			}
			BallInfo bsBallInOneByIndex6 = GetBsBallInOneByIndex(ballInfos, 2, num5);
			if (bsBallInOneByIndex6 != null && bsBallInOneByIndex6.isQSBall())
			{
				if (ballInfo.isQSBall())
				{
					return num - 3f * BsBall_QX_Shift;
				}
				return num - 2f * BsBall_QX_Shift;
			}
			break;
		}
		case 2:
			if (ballInfo.isQSBall())
			{
				return num - 1f * BsBall_QX_Shift;
			}
			break;
		case 3:
			if (ballInfo.isQSBall())
			{
				return num + 1f * BsBall_QX_Shift;
			}
			break;
		case 4:
		{
			BallInfo bsBallInOneByIndex = GetBsBallInOneByIndex(ballInfos, 3, y);
			if (bsBallInOneByIndex != null && bsBallInOneByIndex.isQSBall() && ballInfo.isQSBall())
			{
				return num + 3f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex != null && bsBallInOneByIndex.isQSBall() && !ballInfo.isQSBall())
			{
				return num + 2f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex != null && !bsBallInOneByIndex.isQSBall() && ballInfo.isQSBall())
			{
				return num + 1f * BsBall_QX_Shift;
			}
			int num2 = y + 1;
			if (num2 < 5)
			{
				BallInfo bsBallInOneByIndex2 = GetBsBallInOneByIndex(ballInfos, 3, num2);
				if (bsBallInOneByIndex2 != null && bsBallInOneByIndex2.isQSBall())
				{
					if (ballInfo.isQSBall())
					{
						return num + 2f * BsBall_QX_Shift;
					}
					return num + 1f * BsBall_QX_Shift;
				}
			}
			int num3 = y - 1;
			if (num3 <= 0)
			{
				break;
			}
			BallInfo bsBallInOneByIndex3 = GetBsBallInOneByIndex(ballInfos, 3, num3);
			if (bsBallInOneByIndex3 != null && bsBallInOneByIndex3.isQSBall())
			{
				if (ballInfo.isQSBall())
				{
					return num + 3f * BsBall_QX_Shift;
				}
				return num + 2f * BsBall_QX_Shift;
			}
			break;
		}
		}
		return num;
	}

	private float GetBsBallY(BallInfo ballInfo, List<BallInfo> ballInfos)
	{
		int x = ballInfo.targetIndex.x;
		int y = ballInfo.targetIndex.y;
		float num = BaseHeight + UnitySingleton<GameContext>.Instance.savedGameSetting.CubeHeightAdj + (float)(ballInfo.targetIndex.y - 1) * BsWallOrigin_Y_Step + BsWallOrigin_Y_Step / 2f;
		if (ballInfos == null || ballInfos.Count == 1)
		{
			return num;
		}
		switch (y)
		{
		case 1:
		{
			BallInfo bsBallInOneByIndex2 = GetBsBallInOneByIndex(ballInfos, x, 2);
			if (bsBallInOneByIndex2 != null && bsBallInOneByIndex2.isQSBall() && ballInfo.isQSBall())
			{
				return num - 2f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex2 != null && bsBallInOneByIndex2.isQSBall() && !ballInfo.isQSBall())
			{
				return num - 1f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex2 != null && !bsBallInOneByIndex2.isQSBall() && ballInfo.isQSBall())
			{
				return num - 1f * BsBall_QX_Shift;
			}
			break;
		}
		case 2:
			if (ballInfo.isQSBall())
			{
				return num - 1f * BsBall_QX_Shift;
			}
			break;
		case 3:
			if (ballInfo.isQSBall())
			{
				return num + 1f * BsBall_QX_Shift;
			}
			break;
		case 4:
		{
			BallInfo bsBallInOneByIndex = GetBsBallInOneByIndex(ballInfos, x, 3);
			if (bsBallInOneByIndex != null && bsBallInOneByIndex.isQSBall() && ballInfo.isQSBall())
			{
				return num + 2f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex != null && bsBallInOneByIndex.isQSBall() && !ballInfo.isQSBall())
			{
				return num + 1f * BsBall_QX_Shift;
			}
			if (bsBallInOneByIndex != null && !bsBallInOneByIndex.isQSBall() && ballInfo.isQSBall())
			{
				return num + 1f * BsBall_QX_Shift;
			}
			break;
		}
		}
		return num;
	}

	private BallInfo GetBsBallInOneByIndex(List<BallInfo> ballInfos, int xIndex, int yIndex)
	{
		foreach (BallInfo ballInfo in ballInfos)
		{
			if (ballInfo.targetIndex.x == xIndex && ballInfo.targetIndex.y == yIndex)
			{
				return ballInfo;
			}
		}
		return null;
	}

	internal Vector3 GetBsBallTargetPos(BallInfo ballInfo)
	{
		generatorDicBs.TryGetValue(ballInfo.bsTimeHitTimeIndex, out var value);
		float bsBallX = GetBsBallX(ballInfo, value);
		float bsBallY = GetBsBallY(ballInfo, value);
		return new Vector3(bsBallX, bsBallY, BsWallOrigin_Z_Target);
	}

	internal Vector3 GetBsBallHitPos(BallInfo ballInfo)
	{
		generatorDicBs.TryGetValue(ballInfo.bsTimeHitTimeIndex, out var value);
		float bsBallX = GetBsBallX(ballInfo, value);
		float bsBallY = GetBsBallY(ballInfo, value);
		float hitDis = SavedGameSetting.hitDis;
		return new Vector3(bsBallX, bsBallY, hitDis);
	}

	internal List<BsWallInfo> GetBsObstaclesList(int timeIndex)
	{
		List<BsWallInfo> value = null;
		int key = timeIndex + indexDistance + delayIndex;
		bsWallInfoDic.TryGetValue(key, out value);
		return value;
	}

	internal List<BallInfo> GetBallInfoList(int timeIndex)
	{
		List<BallInfo> value = null;
		int key = timeIndex + indexDistance + delayIndex;
		generatorDicBs.TryGetValue(key, out value);
		return value;
	}

	internal BallFlyPos GetBsBallFlyPos(BallInfo ballInfo)
	{
		BallFlyPos ballFlyPos = new BallFlyPos();
		generatorDicBs.TryGetValue(ballInfo.bsTimeHitTimeIndex, out var value);
		int shiftY = getShiftY(ballInfo, value);
		int shiftX = getShiftX(ballInfo, value);
		BallInfo copy = ballInfo.getCopy();
		copy.targetIndex = new Vector2Int(shiftX, shiftY);
		float bsBallX = GetBsBallX(ballInfo, value);
		float bsBallX2 = GetBsBallX(copy, value);
		float bsBallY = GetBsBallY(ballInfo, value);
		float bsBallY2 = GetBsBallY(copy, value);
		ballFlyPos.originPos = new Vector3(bsBallX2, bsBallY2, BsWallOrigin_Z);
		ballFlyPos.jiaSuEndPos = new Vector3(bsBallX2, bsBallY2, slowDistance);
		ballFlyPos.rightWeiZhiPos = new Vector3(bsBallX, bsBallY, rightWeiZhiPosZ);
		ballFlyPos.originZRotation = GetZRoatateOriginByDirection(ballInfo.ballDirection, ballInfo.ballType);
		ballFlyPos.rightZRotation = GetZRoatateByDirection(ballInfo.ballDirection, ballInfo.ballType);
		ballFlyPos.rightFlyToLeft = false;
		ballFlyPos.leftFlyToRight = false;
		if (shiftX != ballInfo.targetIndex.x)
		{
			if (ballInfo.ballType == BallType.LeftBall)
			{
				ballFlyPos.rightFlyToLeft = true;
			}
			else
			{
				ballFlyPos.leftFlyToRight = true;
			}
		}
		return ballFlyPos;
	}

	private int getShiftX(BallInfo ballInfo, List<BallInfo> ballInfos)
	{
		int x = ballInfo.targetIndex.x;
		if (!isShiftX(ballInfos))
		{
			return x;
		}
		if (ballInfo.ballType == BallType.LeftBall)
		{
			if (ballInfo.targetIndex.x == 2)
			{
				return x - 1;
			}
			return x - 2;
		}
		if (ballInfo.ballType == BallType.RightBall)
		{
			if (ballInfo.targetIndex.x == 3)
			{
				return x + 1;
			}
			return x + 2;
		}
		return x;
	}

	private int getShiftY(BallInfo ballInfo, List<BallInfo> ballInfos)
	{
		int y = ballInfo.targetIndex.y;
		if (ballInfos == null)
		{
			return y;
		}
		if (y == 1)
		{
			return y;
		}
		return getBlewNum(ballInfo.targetIndex, ballInfos) + 1;
	}

	private int getBlewNum(Vector2Int targetIndex, List<BallInfo> ballInfos)
	{
		int num = 0;
		foreach (BallInfo ballInfo in ballInfos)
		{
			if (ballInfo.targetIndex.x == targetIndex.x && ballInfo.targetIndex.y < targetIndex.y)
			{
				num++;
			}
		}
		return num;
	}

	private bool isShiftX(List<BallInfo> ballInfos)
	{
		if (ballInfos == null || ballInfos.Count != 2)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		foreach (BallInfo ballInfo in ballInfos)
		{
			if (ballInfo.ballType == BallType.RightBall)
			{
				num2 = ballInfo.targetIndex.x;
			}
			if (ballInfo.ballType == BallType.LeftBall)
			{
				num = ballInfo.targetIndex.x;
			}
			if (ballInfo.ballType == BallType.RightBall && ballInfo.targetIndex.x < 3)
			{
				flag2 = true;
			}
			if (ballInfo.ballType == BallType.LeftBall && ballInfo.targetIndex.x > 2)
			{
				flag = true;
			}
		}
		if (!(flag && flag2) && (num != 2 || num2 != 1))
		{
			if (num == 4)
			{
				return num2 == 3;
			}
			return false;
		}
		return true;
	}

	public static float GetZRoatateByDirection(BallDirection direction, BallType ballType)
	{
		if (direction == BallDirection.All || ballType == BallType.BlackBall)
		{
			return 0f;
		}
		return direction switch
		{
			BallDirection.Up => 180f, 
			BallDirection.Left => 270f, 
			BallDirection.Right => 90f, 
			BallDirection.UpLeft => 225f, 
			BallDirection.UpRight => 135f, 
			BallDirection.DownLeft => 315f, 
			BallDirection.DownRight => 45f, 
			_ => 0f, 
		};
	}

	private float GetZRoatateOriginByDirection(BallDirection direction, BallType ballType)
	{
		if (direction == BallDirection.All || ballType == BallType.BlackBall)
		{
			return 0f;
		}
		return direction switch
		{
			BallDirection.Up => 180f, 
			BallDirection.Left => 270f, 
			BallDirection.Right => 90f, 
			BallDirection.UpLeft => 180f, 
			BallDirection.UpRight => 90f, 
			BallDirection.DownLeft => 270f, 
			BallDirection.DownRight => 0f, 
			_ => 0f, 
		};
	}
}
public class GameContext : UnitySingleton<GameContext>
{
	public MusicListManager musicListManager = new MusicListManager();

	public InGameSettings inGameSettings = new InGameSettings();

	public SavedGameSetting savedGameSetting;

	public BsMusicBeatData bsMusicBeatData = new BsMusicBeatData();

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void VibrateLeft()
	{
		PXR_Input.SetControllerVibration(1f, MainPlayControl.vibrateTime, PXR_Input.Controller.LeftController);
	}

	public static void VibrateRight()
	{
		PXR_Input.SetControllerVibration(1f, MainPlayControl.vibrateTime, PXR_Input.Controller.RightController);
	}
}
public class LookAt : MonoBehaviour
{
	public Transform CameraTrans;

	private void Start()
	{
		if (CameraTrans == null)
		{
			CameraTrans = UnityEngine.Object.FindObjectOfType<Camera>().transform;
		}
	}

	private void Update()
	{
		base.transform.LookAt(CameraTrans.position);
		base.transform.localRotation = Quaternion.Euler(0f, base.transform.localRotation.eulerAngles.y, 0f);
	}
}
public class MusicInfo
{
	public string fullpath { get; set; }

	public InfoDat infoDat { get; set; }

	public LoadType loadType { get; set; }
}
public class InfoDat
{
	public float _beatsPerMinute;

	public float _previewStartTime;

	public float _previewDuration;

	public string _songFilename;

	public string _songName;

	public string _coverImageFilename;

	public List<DifficultyBeatmapSet> _difficultyBeatmapSets;
}
public class DifficultyBeatmapSet
{
	public string _beatmapCharacteristicName;

	public List<DifficultyBeatmap> _difficultyBeatmaps;
}
public class DifficultyBeatmap
{
	public string _difficulty;

	public int _difficultyRank;

	public string _beatmapFilename;

	public float _noteJumpMovementSpeed;
}
public class MusicListManager
{
	public static string S_RootPath = "music";

	public static string S_InnerCCList = "S_InnerCCList";

	public static string S_NetworkList = "S_NetworkList";

	public List<MusicInfo> InnerCCList;

	public List<string> localNameList;

	public List<MusicCollectionItem> musicCollectionList;

	public void LoadMusic()
	{
		if (!UnitySingleton<GameContext>.Instance.inGameSettings.isMusicLoaded)
		{
			InnerCCList = new List<MusicInfo>();
			localNameList = new List<string>();
			musicCollectionList = new List<MusicCollectionItem>();
			LoadInnerCCList();
			UnitySingleton<GameContext>.Instance.inGameSettings.currentMusicListIndex = 0;
			UnitySingleton<GameContext>.Instance.inGameSettings.isMusicLoaded = true;
			LoadLocalList();
		}
	}

	private void LoadInnerCCList()
	{
		InnerCCList.Add(LoadSingleMusic("a921 (Roly Poly - Zounder)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("141 (Gangnam Style - greatyazer)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("c2d3 (Cry Cry - Zounder)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("5ad9 (To Zanarkand - Rigid)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("Harajuku Iyahoi - aggrogahu", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("8727 (Lemon - Stumi)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("19cca (Into the Night夜に駆ける - Fefy)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("12b77 (Moonlight - Dack)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("5b0 (aLIEz - bakuenjin)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("a059 (HOT - Joetastic)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("5ce7 (DDU-DU DDU-DU - Heisenberg)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("4f0f (BAAM - Bloodcloak)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("3d57 (Mr - kikaeaeon)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("2f59 (Gentleman - Radevirot)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("Luv Letter", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("473a (Everybody - kikaeaeon)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("flowerDance1", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("570 (Mr. Blue Sky - greatyazer)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("348 (Shake It Off - jovian)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("96a (Pacific Rim - yusinosama)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("23c3 (Without Me - ILLENIUM Remix - styngme)", new LoadType(0, null)));
		InnerCCList.Add(LoadSingleMusic("155 (Midnight City - bennydabeast)", new LoadType(0, null)));
		musicCollectionList.Add(new MusicCollectionItem(S_InnerCCList, InnerCCList));
	}

	public static MusicInfo LoadSingleMusic(string folderName, LoadType loadType)
	{
		MusicInfo musicInfo = new MusicInfo();
		string text = null;
		if (loadType.type == 0)
		{
			musicInfo.fullpath = Path.Combine(S_RootPath, folderName);
			text = Resources.Load<TextAsset>(Path.Combine(musicInfo.fullpath, "info")).text;
		}
		else
		{
			musicInfo.fullpath = Path.Combine(Application.persistentDataPath, S_RootPath, folderName, loadType.localPath);
			text = FileUtils.ReadFile(Path.Combine(musicInfo.fullpath, "info.dat"));
		}
		if (text == null)
		{
			return null;
		}
		try
		{
			InfoDat infoDat = JsonConvert.DeserializeObject<InfoDat>(text);
			musicInfo.infoDat = infoDat;
			musicInfo.loadType = loadType;
			return musicInfo;
		}
		catch (Exception message)
		{
			UnityEngine.Debug.LogError(message);
			return null;
		}
	}

	private void LoadLocalList()
	{
		List<string> subFoldNameList = FileUtils.GetSubFoldNameList(Path.Combine(Application.persistentDataPath, S_RootPath));
		if (subFoldNameList.Count == 0)
		{
			FileUtils.CreateFolder(Path.Combine(Application.persistentDataPath, S_RootPath, "default"));
			return;
		}
		foreach (string item in subFoldNameList)
		{
			List<string> subFoldNameList2 = FileUtils.GetSubFoldNameList(Path.Combine(Application.persistentDataPath, S_RootPath, item));
			List<MusicInfo> list = new List<MusicInfo>();
			foreach (string item2 in subFoldNameList2)
			{
				MusicInfo musicInfo = LoadSingleMusic(item, new LoadType(1, item2));
				if (musicInfo != null)
				{
					list.Add(musicInfo);
				}
			}
			if (list.Count > 0)
			{
				musicCollectionList.Add(new MusicCollectionItem(item, list));
			}
		}
	}
}
public class LoadType
{
	public int type;

	public string localPath;

	public LoadType(int type, string localPath)
	{
		this.type = type;
		this.localPath = localPath;
	}
}
public class MusicCollectionItem
{
	public string name;

	public List<MusicInfo> musicList;

	public MusicCollectionItem(string name, List<MusicInfo> musicList)
	{
		this.name = name;
		this.musicList = musicList;
	}
}
public class OnButtonPress : MonoBehaviour
{
	[Tooltip("Actions to check")]
	public InputAction action;

	public UnityEvent OnPress = new UnityEvent();

	public UnityEvent OnRelease = new UnityEvent();

	private void Awake()
	{
		action.started += Pressed;
		action.canceled += Released;
	}

	private void OnDestroy()
	{
		action.started -= Pressed;
		action.canceled -= Released;
	}

	private void OnEnable()
	{
		action.Enable();
	}

	private void OnDisable()
	{
		action.Disable();
	}

	private void Pressed(InputAction.CallbackContext context)
	{
		OnPress.Invoke();
	}

	private void Released(InputAction.CallbackContext context)
	{
		OnRelease.Invoke();
	}
}
public class InGameSettings
{
	public bool isMusicLoaded;

	public int currentMusicListIndex;

	public MusicInfo selectedMusicInfo;

	public string selectedLevel;

	public AudioClip selectedAudioClip;

	public bool returnFromGame;

	public bool isGameComplete;

	public int totalScore;

	public int maxLianJi;

	public int successfulHit;

	public int failedHit;
}
public class SavedGameSetting
{
	public int GameSceneIndex;

	public bool ExecriseMode;

	public float HitSoundAdj;

	public float CubeHeightAdj;

	public float CubeSpeedAdj;

	public int TotalPlays;

	public int EasyPlays;

	public int NormalPlays;

	public int HardPlays;

	public int ExpertPlays;

	public int ExpertPlusPlays;

	public int UnDonePlays;

	public int ExercisePlays;

	public int MaxHitInOnePlay;

	public float MaxRatioInOnePlay;

	public int MaxContinousHit;

	public string csn;

	public static float hitDis = 1.5f;

	public static SavedGameSetting CreateDefault()
	{
		return new SavedGameSetting
		{
			GameSceneIndex = 2,
			HitSoundAdj = 0.7f,
			ExecriseMode = false,
			CubeHeightAdj = 0f,
			CubeSpeedAdj = 0f,
			TotalPlays = 0,
			EasyPlays = 0,
			NormalPlays = 0,
			HardPlays = 0,
			ExpertPlays = 0,
			ExpertPlusPlays = 0,
			UnDonePlays = 0,
			ExercisePlays = 0,
			MaxHitInOnePlay = 0,
			MaxRatioInOnePlay = 0f,
			MaxContinousHit = 0
		};
	}
}
public class UnitySingleton<T> : MonoBehaviour where T : Component
{
	public bool IsDontDestroyOnLoad = true;

	private static T _instance;

	public static T Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = UnityEngine.Object.FindObjectOfType(typeof(T)) as T;
				if (_instance == null)
				{
					_instance = (T)new GameObject
					{
						hideFlags = HideFlags.HideAndDontSave
					}.AddComponent(typeof(T));
				}
			}
			return _instance;
		}
	}

	public virtual void Awake()
	{
		if (IsDontDestroyOnLoad)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		if (_instance == null)
		{
			_instance = this as T;
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
public class BtnSelectNoSee : MonoBehaviour
{
	public Button btnNoSee;

	private void Start()
	{
		Button[] componentsInChildren = base.transform.GetComponentsInChildren<Button>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].onClick.AddListener(selectNoSee);
		}
	}

	public void selectNoSee()
	{
		btnNoSee.Select();
	}
}
public class FileUtils
{
	public static string LYJ = "12345678901234567890123456789000";

	public static List<string> GetSubFoldNameList(string path)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		UnityEngine.Debug.Log("path:" + path);
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
			return list;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		for (int i = 0; i < directories.Length; i++)
		{
			list.Add(directories[i].Name);
		}
		return list;
	}

	internal static string ReadFileWithEncrypt(string fileName)
	{
		if (!File.Exists(fileName))
		{
			return null;
		}
		try
		{
			byte[] bytes = Decrypt(File.ReadAllBytes(fileName), LYJ);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
			deleteFile(fileName);
			return null;
		}
	}

	internal static void CreateFolder(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
		}
	}

	internal static void SaveFileWithEncrypt(string fileName, string content, string path)
	{
		if (path != null)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
		}
		if (!File.Exists(fileName))
		{
			File.Create(fileName).Close();
		}
		byte[] bytes = Encrypt(content, LYJ);
		File.WriteAllBytes(fileName, bytes);
	}

	public static void deleteFile(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
	}

	internal static string ReadFile(string fullPath)
	{
		if (!File.Exists(fullPath))
		{
			return null;
		}
		return File.ReadAllText(fullPath);
	}

	internal static string CheckEggOgg(string filepath, string fullpath, InfoDat infoDat)
	{
		if (File.Exists(Path.Combine(fullpath, infoDat._songFilename)))
		{
			return filepath;
		}
		string text = Path.GetExtension(infoDat._songFilename);
		if (text == ".egg")
		{
			text = ".ogg";
		}
		else if (text == ".ogg")
		{
			text = ".egg";
		}
		filepath = "file://" + Path.Combine(fullpath, Path.GetFileNameWithoutExtension(infoDat._songFilename) + text);
		return filepath;
	}

	public static byte[] Encrypt(string Text, string sKey)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(sKey);
		ICryptoTransform cryptoTransform = new RijndaelManaged
		{
			Key = bytes,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateEncryptor();
		byte[] bytes2 = Encoding.UTF8.GetBytes(Text);
		return cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length);
	}

	public static byte[] Decrypt(byte[] _EncryptArray, string sKey)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(sKey);
		return new RijndaelManaged
		{
			Key = bytes,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(_EncryptArray, 0, _EncryptArray.Length);
	}
}
public abstract class EnvHit : MonoBehaviour
{
	public abstract void LeftHit();

	public abstract void RightHit();
}
public class JYScreenFade : MonoBehaviour
{
	public float fadeTime = 5f;

	public Color fadeColor = new Color(0f, 0f, 0f, 1f);

	public int renderQueue = 5000;

	private MeshRenderer fadeMeshRenderer;

	private MeshFilter fadeMeshFilter;

	private Material fadeMaterial;

	private bool isFading;

	private float currentAlpha;

	private float nowFadeAlpha;

	private void Awake()
	{
		CreateFadeMesh();
		SetCurrentAlpha(0f);
	}

	public void StartEndFade()
	{
		StartCoroutine(ScreenFade(0f, 1f));
	}

	private void OnDestroy()
	{
		DestoryFadeMesh();
	}

	private void CreateFadeMesh()
	{
		fadeMaterial = new Material(Shader.Find("PXR_SDK/PXR_Fade"));
		fadeMeshFilter = base.gameObject.AddComponent<MeshFilter>();
		fadeMeshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		fadeMeshFilter.mesh = mesh;
		Vector3[] array = new Vector3[4];
		float num = 2f;
		float num2 = 2f;
		float z = 1f;
		array[0] = new Vector3(0f - num, 0f - num2, z);
		array[1] = new Vector3(num, 0f - num2, z);
		array[2] = new Vector3(0f - num, num2, z);
		array[3] = new Vector3(num, num2, z);
		mesh.vertices = array;
		mesh.triangles = new int[6] { 0, 2, 1, 2, 3, 1 };
		mesh.normals = new Vector3[4]
		{
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward
		};
		mesh.uv = new Vector2[4]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
	}

	private void DestoryFadeMesh()
	{
		if (fadeMeshRenderer != null)
		{
			UnityEngine.Object.Destroy(fadeMeshRenderer);
		}
		if (fadeMaterial != null)
		{
			UnityEngine.Object.Destroy(fadeMaterial);
		}
		if (fadeMeshFilter != null)
		{
			UnityEngine.Object.Destroy(fadeMeshFilter);
		}
	}

	public void SetCurrentAlpha(float alpha)
	{
		currentAlpha = alpha;
		SetMaterialAlpha();
	}

	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		float elapsedTime = 0f;
		while (elapsedTime < fadeTime)
		{
			elapsedTime += Time.deltaTime;
			nowFadeAlpha = Mathf.Lerp(startAlpha, endAlpha, Mathf.Clamp01(elapsedTime / fadeTime));
			SetMaterialAlpha();
			yield return new WaitForEndOfFrame();
		}
		SceneManager.LoadScene(0);
	}

	private void SetMaterialAlpha()
	{
		Color color = fadeColor;
		color.a = Mathf.Max(currentAlpha, nowFadeAlpha);
		isFading = color.a > 0f;
		if (fadeMaterial != null)
		{
			fadeMaterial.color = color;
			fadeMaterial.renderQueue = renderQueue;
			fadeMeshRenderer.material = fadeMaterial;
			fadeMeshRenderer.enabled = isFading;
		}
	}
}
public class SixAutioHip : MonoBehaviour
{
	private static float LightState_0_duiration = 8f;

	private static float LightState_1_duiration = 1f;

	private static float LightState_2_duiration = 0.5f;

	private static float RotateTime = 2f;

	private static float NRotateTime = 6f;

	private List<WuXingItem> wuXingItems;

	private int LightState;

	private float LightStateStartTime;

	private int RotateState;

	private float RotateStateStartTime;

	private int CurrentJ;

	private int TargetJ;

	private void Start()
	{
		wuXingItems = new List<WuXingItem>();
		wuXingItems.Add(base.transform.Find("Zi").GetComponent<WuXingItem>());
		wuXingItems.Add(base.transform.Find("Lan").GetComponent<WuXingItem>());
		wuXingItems.Add(base.transform.Find("Lv").GetComponent<WuXingItem>());
		wuXingItems.Add(base.transform.Find("Huang").GetComponent<WuXingItem>());
		wuXingItems.Add(base.transform.Find("Hong").GetComponent<WuXingItem>());
		SetLight(0);
		SetRotate(0);
	}

	private void Update()
	{
		LightChange();
		Rotate();
	}

	private void SetLight(int nextState)
	{
		LightState = nextState;
		LightStateStartTime = Time.time;
		switch (nextState)
		{
		case 0:
		{
			foreach (WuXingItem wuXingItem in wuXingItems)
			{
				wuXingItem.SetLightSingle(turnOn: true);
			}
			return;
		}
		case 1:
		{
			foreach (WuXingItem wuXingItem2 in wuXingItems)
			{
				wuXingItem2.SetLightSingle(turnOn: false);
			}
			return;
		}
		}
		foreach (WuXingItem wuXingItem3 in wuXingItems)
		{
			if (nextState > wuXingItem3.index)
			{
				wuXingItem3.SetLightSingle(turnOn: true);
			}
			else
			{
				wuXingItem3.SetLightSingle(turnOn: false);
			}
		}
	}

	private void LightChange()
	{
		if (LightState == 0 && Time.time - LightStateStartTime > LightState_0_duiration)
		{
			SetLight(1);
		}
		else if (LightState == 1 && Time.time - LightStateStartTime > LightState_1_duiration)
		{
			SetLight(2);
		}
		else if (LightState > 1 && LightState < 6 && Time.time - LightStateStartTime > LightState_2_duiration)
		{
			LightState++;
			SetLight(LightState);
		}
		else if (LightState == 6 && Time.time - LightStateStartTime > LightState_2_duiration)
		{
			SetLight(0);
		}
	}

	private void SetRotate(int nextState)
	{
		RotateState = nextState;
		RotateStateStartTime = Time.time;
		switch (nextState)
		{
		case 0:
			CurrentJ = TargetJ;
			base.transform.rotation = Quaternion.Euler(0f, 0f, CurrentJ);
			break;
		case 1:
			TargetJ = CurrentJ + 60;
			break;
		}
	}

	private void Rotate()
	{
		if (RotateState == 0 && Time.time - RotateStateStartTime > NRotateTime)
		{
			SetRotate(1);
		}
		else if (RotateState == 1)
		{
			float num = Time.time - RotateStateStartTime;
			if (num < RotateTime)
			{
				Quaternion a = Quaternion.Euler(0f, 0f, CurrentJ);
				Quaternion b = Quaternion.Euler(0f, 0f, TargetJ);
				base.transform.rotation = Quaternion.Slerp(a, b, num / RotateTime);
			}
			else
			{
				SetRotate(0);
			}
		}
	}
}
public class WuXingItem : MonoBehaviour
{
	public int index;

	internal void SetLightSingle(bool turnOn)
	{
		base.transform.Find("Rot90/An").gameObject.SetActive(!turnOn);
		base.transform.Find("Rot90/Liang").gameObject.SetActive(turnOn);
	}
}
public class YuanHuanHit : EnvHit
{
	private List<Animator> leftHits;

	private List<Animator> rightHits;

	private void Start()
	{
		leftHits = new List<Animator>();
		int childCount = base.transform.Find("WeiDengsLeft").childCount;
		for (int i = 0; i < childCount; i++)
		{
			leftHits.Add(base.transform.Find("WeiDengsLeft").GetChild(i).GetComponent<Animator>());
		}
		rightHits = new List<Animator>();
		int childCount2 = base.transform.Find("WeiDengsRight").childCount;
		for (int j = 0; j < childCount2; j++)
		{
			rightHits.Add(base.transform.Find("WeiDengsRight").GetChild(j).GetComponent<Animator>());
		}
	}

	public override void LeftHit()
	{
		foreach (Animator leftHit in leftHits)
		{
			leftHit.Play("HitHip", 0, 0f);
		}
	}

	public override void RightHit()
	{
		foreach (Animator rightHit in rightHits)
		{
			rightHit.Play("HitHip", 0, 0f);
		}
	}
}
public class WuDongEnvHit : EnvHit
{
	public Animator leftHip;

	public Animator rightHip;

	public override void LeftHit()
	{
		leftHip.Play("Larger", 0, 0f);
	}

	public override void RightHit()
	{
		rightHip.Play("Larger", 0, 0f);
	}
}
public class AudioManager : UnitySingleton<AudioManager>
{
	private UnityWebRequest uwr1;

	private UnityWebRequest uwr2;

	private UnityWebRequest uwr3;

	private UnityWebRequest uwr4;

	public new void Awake()
	{
		base.Awake();
	}

	private void Start()
	{
		IEnumerator routine = loadZiDingYi();
		StartCoroutine(routine);
		IEnumerator routine2 = loadZiDingYiWav();
		StartCoroutine(routine2);
		IEnumerator routine3 = loadZiDingYiFail();
		StartCoroutine(routine3);
		IEnumerator routine4 = loadZiDingYiFailwav();
		StartCoroutine(routine4);
		float hitSoundAdj = UnitySingleton<GameContext>.Instance.savedGameSetting.HitSoundAdj;
		setVolume(hitSoundAdj, "hit");
		setVolume(hitSoundAdj, "hitFail");
	}

	private IEnumerator loadZiDingYi()
	{
		string uri = "file://" + Path.Combine(Application.persistentDataPath, "hit.mp3");
		if (!File.Exists(Path.Combine(Application.persistentDataPath, "hit.mp3")))
		{
			yield break;
		}
		using (uwr1 = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.MPEG))
		{
			UnityEngine.Debug.Log("start read music:" + DateTime.Now.ToString());
			yield return uwr1.SendWebRequest();
			if (uwr1.isNetworkError)
			{
				UnityEngine.Debug.LogError(uwr1.error);
				yield break;
			}
			foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
			{
				if (!componentInChild.gameObject.name.Equals("hit"))
				{
					continue;
				}
				try
				{
					AudioClip content = DownloadHandlerAudioClip.GetContent(uwr1);
					if (content != null)
					{
						componentInChild.GetComponent<AudioSource>().clip = content;
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.Log(message);
				}
			}
		}
	}

	private IEnumerator loadZiDingYiWav()
	{
		string uri = "file://" + Path.Combine(Application.persistentDataPath, "hit.wav");
		if (!File.Exists(Path.Combine(Application.persistentDataPath, "hit.wav")))
		{
			yield break;
		}
		using (uwr2 = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.WAV))
		{
			UnityEngine.Debug.Log("start read music:" + DateTime.Now.ToString());
			yield return uwr2.SendWebRequest();
			if (uwr2.isNetworkError)
			{
				UnityEngine.Debug.LogError(uwr2.error);
				yield break;
			}
			foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
			{
				if (!componentInChild.gameObject.name.Equals("hit"))
				{
					continue;
				}
				try
				{
					AudioClip content = DownloadHandlerAudioClip.GetContent(uwr2);
					if (content != null)
					{
						componentInChild.GetComponent<AudioSource>().clip = content;
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.Log(message);
				}
			}
		}
	}

	private IEnumerator loadZiDingYiFail()
	{
		string uri = "file://" + Path.Combine(Application.persistentDataPath, "hitFail.mp3");
		if (!File.Exists(Path.Combine(Application.persistentDataPath, "hitFail.mp3")))
		{
			yield break;
		}
		using (uwr3 = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.MPEG))
		{
			UnityEngine.Debug.Log("start read music:" + DateTime.Now.ToString());
			yield return uwr3.SendWebRequest();
			if (uwr3.isNetworkError)
			{
				UnityEngine.Debug.LogError(uwr3.error);
				yield break;
			}
			foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
			{
				if (!componentInChild.gameObject.name.Equals("hitFail"))
				{
					continue;
				}
				try
				{
					AudioClip content = DownloadHandlerAudioClip.GetContent(uwr3);
					if (content != null)
					{
						componentInChild.GetComponent<AudioSource>().clip = content;
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.Log(message);
				}
			}
		}
	}

	private IEnumerator loadZiDingYiFailwav()
	{
		string uri = "file://" + Path.Combine(Application.persistentDataPath, "hitFail.wav");
		if (!File.Exists(Path.Combine(Application.persistentDataPath, "hitFail.wav")))
		{
			yield break;
		}
		using (uwr4 = UnityWebRequestMultimedia.GetAudioClip(uri, AudioType.WAV))
		{
			UnityEngine.Debug.Log("start read music:" + DateTime.Now.ToString());
			yield return uwr4.SendWebRequest();
			if (uwr4.isNetworkError)
			{
				UnityEngine.Debug.LogError(uwr4.error);
				yield break;
			}
			foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
			{
				if (!componentInChild.gameObject.name.Equals("hitFail"))
				{
					continue;
				}
				try
				{
					AudioClip content = DownloadHandlerAudioClip.GetContent(uwr4);
					if (content != null)
					{
						componentInChild.GetComponent<AudioSource>().clip = content;
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.Log(message);
				}
			}
		}
	}

	public void setVolume(float hitSound, string name)
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			if (componentInChild.gameObject.name.Equals(name))
			{
				componentInChild.GetComponent<AudioSource>().volume = hitSound;
				break;
			}
		}
	}

	public AudioSource GetAudioSource(string name)
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			if (componentInChild.gameObject.name.Equals(name))
			{
				return componentInChild.GetComponent<AudioSource>();
			}
		}
		return null;
	}

	private void DisableAll()
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			componentInChild.gameObject.SetActive(value: false);
		}
	}

	public void PlayMusicHit(float speed = -1f)
	{
		float pitch = 1f;
		if (speed > 80f)
		{
			speed = 80f;
		}
		if (speed > 0f)
		{
			pitch = 0.5f + speed * (3f / 160f);
		}
		PlayMusicOnce("hit", pitch);
	}

	public AudioSource PlayMainMusic(string name)
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			if (componentInChild.gameObject.name.Equals(name))
			{
				componentInChild.GetComponent<AudioSource>().Play();
				return componentInChild.GetComponent<AudioSource>();
			}
		}
		return null;
	}

	public void PlayMusicOnce(string name, float pitch = 1f)
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			if (componentInChild.gameObject.name.Equals(name))
			{
				componentInChild.GetComponent<AudioSource>().pitch = pitch;
				componentInChild.GetComponent<AudioSource>().Play();
				break;
			}
		}
	}

	public void StopPlayMusic(string name)
	{
		foreach (Transform componentInChild in base.transform.GetComponentInChildren<Transform>())
		{
			if (componentInChild.gameObject.name.Equals(name))
			{
				componentInChild.GetComponent<AudioSource>().Stop();
				break;
			}
		}
	}
}
public class BallGenerator : MonoBehaviour
{
	public GameObject Ball;

	public GameObject BsWall;

	public MainPlayControl mainPlayControl;

	public float SceneBaseHeight;

	private void Start()
	{
		mainPlayControl = GetComponent<MainPlayControl>();
	}

	private void Update()
	{
	}

	internal void GenerateUpdate()
	{
		List<BallInfo> ballInfoList = UnitySingleton<GameContext>.Instance.bsMusicBeatData.GetBallInfoList(mainPlayControl.timeIndex);
		if (ballInfoList != null)
		{
			foreach (BallInfo item in ballInfoList)
			{
				generateOneBall(item);
			}
		}
		List<BsWallInfo> bsObstaclesList = UnitySingleton<GameContext>.Instance.bsMusicBeatData.GetBsObstaclesList(mainPlayControl.timeIndex);
		if (bsObstaclesList == null)
		{
			return;
		}
		foreach (BsWallInfo item2 in bsObstaclesList)
		{
			generateBsWall(item2);
		}
	}

	private void generateOneBall(BallInfo ballInfo)
	{
		Vector3 bsBallTargetPos = UnitySingleton<GameContext>.Instance.bsMusicBeatData.GetBsBallTargetPos(ballInfo);
		Vector3 bsBallHitPos = UnitySingleton<GameContext>.Instance.bsMusicBeatData.GetBsBallHitPos(ballInfo);
		BallFlyPos bsBallFlyPos = UnitySingleton<GameContext>.Instance.bsMusicBeatData.GetBsBallFlyPos(ballInfo);
		Vector3 originPos = bsBallFlyPos.originPos;
		float originZRotation = bsBallFlyPos.originZRotation;
		float y = 0f;
		UnityEngine.Object.Instantiate(Ball, originPos, Quaternion.Euler(0f, y, originZRotation)).GetComponent<Ball>().SetBall(ballInfo, mainPlayControl, bsBallTargetPos, bsBallHitPos, bsBallFlyPos);
	}

	private void generateBsWall(BsWallInfo bsWallInfo)
	{
		GameObject obj = UnityEngine.Object.Instantiate(BsWall, bsWallInfo.originPos, Quaternion.Euler(0f, 0f, 0f));
		obj.GetComponent<BsWall>().initWall(bsWallInfo, UnitySingleton<GameContext>.Instance.bsMusicBeatData.ballSpeed);
		obj.GetComponent<BsWall>().mainPlayControl = mainPlayControl;
	}
}
public class BallFlyPos
{
	public Vector3 originPos;

	public Vector3 jiaSuEndPos;

	public Vector3 rightWeiZhiPos;

	public float originZRotation;

	public float rightZRotation;

	public bool leftFlyToRight;

	public bool rightFlyToLeft;
}
public class AdjBlade : MonoBehaviour
{
	public Blade blade;

	public void OnCollisionEnter(Collision collision)
	{
		blade.OnCollisionEnter(collision);
	}

	public void OnCollisionStay(Collision collision)
	{
		blade.OnCollisionStay(collision);
	}

	public void OnCollisionExit(Collision collision)
	{
		blade.OnCollisionExit(collision);
	}
}
public class Blade : MonoBehaviour
{
	public delegate void Enter(GameObject gameObject, Vector3 colliderPoint, Blade blade);

	public enum BladeType
	{
		LeftHand,
		RightHand
	}

	public float hengRayTopDisStep = 0.05f;

	public float yuPanBili = 1.5f;

	public BladeType bladeType;

	public Transform topDetectPoint;

	public Transform endDetectPoint;

	public BladeEffectManager bladeEffectManager;

	private List<Vector3> lastPosition;

	private float lastDeltaTime;

	public Vector3 lastTopDetectPoint;

	public Vector3 ThisTopDetectPoint;

	private Vector3 lastEndDetectPoint;

	private Vector3 ThisEndDetectPoint;

	public Vector3 waveDirection;

	public float waveDistancePerSecond;

	public float GroundHeght = -0.1f;

	public Enter enter { get; set; }

	private void Start()
	{
		lastPosition = new List<Vector3>();
	}

	private void Update()
	{
		checkGround();
		if (lastPosition.Count > 0)
		{
			detectByRay();
		}
		updateLastPosition();
		lastTopDetectPoint = ThisTopDetectPoint;
		ThisTopDetectPoint = topDetectPoint.position;
		lastEndDetectPoint = ThisEndDetectPoint;
		ThisEndDetectPoint = endDetectPoint.position;
		lastDeltaTime = Time.deltaTime;
		waveDirection = lastTopDetectPoint - ThisTopDetectPoint;
		if (ThisTopDetectPoint == Vector3.zero || lastTopDetectPoint == Vector3.zero)
		{
			waveDistancePerSecond = 0f;
		}
		else
		{
			waveDistancePerSecond = waveDirection.magnitude / lastDeltaTime;
		}
		detectByHengRay();
		yuPanHengRay();
		yuPanHengRay(houXiang: true);
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (bladeType.Equals(BladeType.LeftHand) && collision.gameObject.tag.Equals("RightBlade") && collision.contacts.Length != 0)
		{
			bladeEffectManager.bladeTouch(collision.contacts[0].point);
		}
		else if (collision.gameObject.tag.Equals("ball") && collision.contacts.Length != 0)
		{
			enter?.Invoke(collision.gameObject, collision.contacts[0].point, this);
		}
	}

	public void OnCollisionStay(Collision collision)
	{
		if (bladeType.Equals(BladeType.LeftHand) && collision.gameObject.tag.Equals("RightBlade") && collision.contacts.Length != 0)
		{
			bladeEffectManager.bladeTouch(collision.contacts[0].point);
		}
		else if (collision.gameObject.tag.Equals("ball") && collision.contacts.Length != 0)
		{
			enter?.Invoke(collision.gameObject, collision.contacts[0].point, this);
		}
	}

	public void OnCollisionExit(Collision collision)
	{
		if (bladeType.Equals(BladeType.LeftHand) && collision.gameObject.tag.Equals("RightBlade") && collision.contacts.Length != 0)
		{
			bladeEffectManager.bladeTouchExit(collision.contacts[0].point);
		}
		else if (collision.gameObject.tag.Equals("ball") && collision.contacts.Length != 0)
		{
			enter?.Invoke(collision.gameObject, collision.contacts[0].point, this);
		}
	}

	public void detectByRay()
	{
		for (int i = 1; i <= 9; i++)
		{
			Vector3 zero = Vector3.zero;
			zero = base.transform.Find("LengthAdj/AdjBlade/MoreDected/point" + i).position;
			for (int j = 0; j < 9; j++)
			{
				Vector3 vector = lastPosition[j];
				float magnitude = (zero - vector).magnitude;
				Vector3 direction = zero - vector;
				RaycastHit[] array = Physics.RaycastAll(vector, direction, magnitude);
				if (array.Length == 0)
				{
					continue;
				}
				RaycastHit[] array2 = array;
				for (int k = 0; k < array2.Length; k++)
				{
					RaycastHit raycastHit = array2[k];
					if (raycastHit.collider.gameObject.tag.Equals("ball"))
					{
						enter?.Invoke(raycastHit.collider.gameObject, raycastHit.point, this);
					}
				}
			}
		}
	}

	private void yuPanHengRay(bool houXiang = false)
	{
		if (ThisTopDetectPoint.Equals(Vector3.zero) || ThisEndDetectPoint.Equals(Vector3.zero) || ThisTopDetectPoint.Equals(Vector3.zero) || lastTopDetectPoint.Equals(Vector3.zero) || waveDistancePerSecond < 0.1f || yuPanBili < 0.02f)
		{
			return;
		}
		float num = ((waveDistancePerSecond / 50f > 1f) ? 1f : (waveDistancePerSecond / 50f));
		if (num < 0.05f)
		{
			num = 0.05f;
		}
		Vector3 vector = ThisTopDetectPoint + (ThisTopDetectPoint - lastTopDetectPoint).normalized * yuPanBili * num;
		Vector3 vector2 = ThisEndDetectPoint + (ThisEndDetectPoint - lastEndDetectPoint).normalized * yuPanBili * num;
		if (houXiang)
		{
			vector = lastTopDetectPoint + (lastTopDetectPoint - ThisTopDetectPoint).normalized * yuPanBili * num;
			vector2 = lastEndDetectPoint + (lastEndDetectPoint - ThisEndDetectPoint).normalized * yuPanBili * num;
		}
		Vector3 direction = vector - vector2;
		float magnitude = (ThisTopDetectPoint - ThisEndDetectPoint).magnitude;
		RaycastHit[] array = Physics.RaycastAll(vector2, direction, magnitude);
		if (array.Length != 0)
		{
			RaycastHit[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				RaycastHit raycastHit = array2[i];
				if (raycastHit.collider.gameObject.tag.Equals("ball"))
				{
					enter?.Invoke(raycastHit.collider.gameObject, raycastHit.point, this);
				}
			}
		}
		float magnitude2 = (vector - ThisTopDetectPoint).magnitude;
		if (houXiang)
		{
			magnitude2 = (vector - lastTopDetectPoint).magnitude;
		}
		if (magnitude2 < hengRayTopDisStep)
		{
			return;
		}
		for (float num2 = hengRayTopDisStep; num2 < magnitude2; num2 += hengRayTopDisStep)
		{
			Vector3 vector3 = Vector3.Lerp(lastEndDetectPoint, vector2, num2 / magnitude2);
			Vector3 vector4 = Vector3.Lerp(lastTopDetectPoint, vector, num2 / magnitude2);
			if (houXiang)
			{
				vector3 = Vector3.Lerp(ThisEndDetectPoint, vector2, num2 / magnitude2);
				vector4 = Vector3.Lerp(ThisTopDetectPoint, vector, num2 / magnitude2);
			}
			Vector3 direction2 = vector4 - vector3;
			RaycastHit[] array3 = Physics.RaycastAll(vector3, direction2, magnitude);
			if (array3.Length == 0)
			{
				continue;
			}
			RaycastHit[] array2 = array3;
			for (int i = 0; i < array2.Length; i++)
			{
				RaycastHit raycastHit2 = array2[i];
				if (raycastHit2.collider.gameObject.tag.Equals("ball"))
				{
					enter?.Invoke(raycastHit2.collider.gameObject, raycastHit2.point, this);
				}
			}
		}
	}

	private void detectByHengRay()
	{
		if (ThisTopDetectPoint.Equals(Vector3.zero) || ThisEndDetectPoint.Equals(Vector3.zero) || ThisTopDetectPoint.Equals(Vector3.zero) || lastTopDetectPoint.Equals(Vector3.zero))
		{
			return;
		}
		float magnitude = (ThisTopDetectPoint - ThisEndDetectPoint).magnitude;
		float magnitude2 = (ThisTopDetectPoint - lastTopDetectPoint).magnitude;
		if (magnitude2 < hengRayTopDisStep)
		{
			return;
		}
		for (float num = hengRayTopDisStep; num < magnitude2; num += hengRayTopDisStep)
		{
			Vector3 vector = Vector3.Lerp(lastEndDetectPoint, ThisEndDetectPoint, num / magnitude2);
			Vector3 direction = Vector3.Lerp(lastTopDetectPoint, ThisTopDetectPoint, num / magnitude2) - vector;
			RaycastHit[] array = Physics.RaycastAll(vector, direction, magnitude);
			if (array.Length == 0)
			{
				continue;
			}
			RaycastHit[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				RaycastHit raycastHit = array2[i];
				if (raycastHit.collider.gameObject.tag.Equals("ball"))
				{
					enter?.Invoke(raycastHit.collider.gameObject, raycastHit.point, this);
				}
			}
		}
	}

	public void updateLastPosition()
	{
		lastPosition.Clear();
		for (int i = 1; i <= 9; i++)
		{
			lastPosition.Add(base.transform.Find("LengthAdj/AdjBlade/MoreDected/point" + i).position);
		}
	}

	private void checkGround()
	{
		Vector3 position = topDetectPoint.position;
		Vector3 position2 = endDetectPoint.position;
		if (position.y > GroundHeght)
		{
			if (bladeType.Equals(BladeType.LeftHand))
			{
				bladeEffectManager.bladeGroundTouchLeftExit();
			}
			else
			{
				bladeEffectManager.bladeGroundTouchRightExit();
			}
		}
		else if (position.y < GroundHeght)
		{
			if (bladeType.Equals(BladeType.LeftHand))
			{
				bladeEffectManager.bladeGroundTouchLeft(GetIntersectWithLineAndPlane(position, position2));
			}
			else
			{
				bladeEffectManager.bladeGroundTouchRight(GetIntersectWithLineAndPlane(position, position2));
			}
		}
	}

	private Vector3 GetIntersectWithLineAndPlane(Vector3 top, Vector3 end)
	{
		Vector3 vector = top - end;
		Vector3 rhs = new Vector3(0f, 1f, 0f);
		return Vector3.Dot(new Vector3(0f, GroundHeght, 0f) - top, rhs) / Vector3.Dot(vector.normalized, rhs) * vector.normalized + top;
	}
}
public class BladeEffectManager : MonoBehaviour
{
	public GameObject bladeTouchEffect;

	public GameObject bladeGroundTouchLeftEffect;

	public GameObject bladeGroundTouchRightEffect;

	public float detectTimeLimit = 0.5f;

	private float bladeTouchEffectStartTime;

	private float bladeGroundTouchLeftStartTime;

	private float bladeGroundTouchRightStartTime;

	private void Start()
	{
		bladeTouchEffectStartTime = 0f;
		bladeGroundTouchLeftStartTime = 0f;
		bladeGroundTouchRightStartTime = 0f;
		bladeTouchEffect.SetActive(value: false);
		bladeGroundTouchLeftEffect.SetActive(value: false);
		bladeGroundTouchRightEffect.SetActive(value: false);
	}

	private void Update()
	{
		if (bladeTouchEffect.activeInHierarchy)
		{
			bladeTouchEffectStartTime += Time.deltaTime;
			if (bladeTouchEffectStartTime > detectTimeLimit)
			{
				bladeTouchEffectStartTime = 0f;
				bladeTouchEffect.SetActive(value: false);
			}
		}
		if (bladeGroundTouchLeftEffect.activeInHierarchy)
		{
			bladeGroundTouchLeftStartTime += Time.deltaTime;
			if (bladeGroundTouchLeftStartTime > detectTimeLimit)
			{
				bladeGroundTouchLeftStartTime = 0f;
				bladeGroundTouchLeftEffect.SetActive(value: false);
			}
		}
		if (bladeGroundTouchRightEffect.activeInHierarchy)
		{
			bladeGroundTouchRightStartTime += Time.deltaTime;
			if (bladeGroundTouchRightStartTime > detectTimeLimit)
			{
				bladeGroundTouchRightStartTime = 0f;
				bladeGroundTouchRightEffect.SetActive(value: false);
			}
		}
	}

	public void bladeGroundTouchLeft(Vector3 point)
	{
		if (!bladeGroundTouchLeftEffect.activeInHierarchy)
		{
			bladeGroundTouchLeftEffect.SetActive(value: true);
		}
		bladeGroundTouchLeftStartTime = 0f;
		point.y = 0f;
		bladeGroundTouchLeftEffect.transform.position = point;
	}

	public void bladeGroundTouchLeftExit()
	{
		bladeGroundTouchLeftEffect.SetActive(value: false);
		bladeGroundTouchLeftStartTime = 0f;
	}

	public void bladeGroundTouchRight(Vector3 point)
	{
		if (!bladeGroundTouchRightEffect.activeInHierarchy)
		{
			bladeGroundTouchRightEffect.SetActive(value: true);
		}
		bladeGroundTouchRightStartTime = 0f;
		point.y = 0f;
		bladeGroundTouchRightEffect.transform.position = point;
	}

	public void bladeGroundTouchRightExit()
	{
		bladeGroundTouchRightEffect.SetActive(value: false);
		bladeGroundTouchRightStartTime = 0f;
	}

	internal void bladeTouch(Vector3 point)
	{
		if (!bladeTouchEffect.activeInHierarchy)
		{
			bladeTouchEffect.SetActive(value: true);
		}
		bladeTouchEffectStartTime = 0f;
		bladeTouchEffect.transform.position = point;
		GameContext.VibrateLeft();
		GameContext.VibrateRight();
	}

	internal void bladeTouchExit(Vector3 point)
	{
		bladeTouchEffect.SetActive(value: false);
		bladeTouchEffectStartTime = 0f;
	}
}
public class Ball : MonoBehaviour
{
	public class BallCollisionInfo
	{
		public Vector3 colliderPoint;

		public Blade blade;

		public BallCollisionInfo(Vector3 colliderPoint, Blade blade)
		{
			this.colliderPoint = colliderPoint;
			this.blade = blade;
		}
	}

	public static float endDis = 0.1f;

	public static string RedColorHex = "961305";

	public static string RedColorLiangHex = "E9736B";

	public static string BlueColorHex = "020B90";

	public static string BlueColorLiangHex = "6B71E9";

	public GameObject showBall;

	public GameObject zhaDan;

	public Transform hipScore;

	public GameObject hipScoreLeft;

	public GameObject hipScoreRight;

	public GameObject hipScoreFail;

	private MainPlayControl mainPlayControl;

	public bool explosed;

	private bool fly;

	private int flyDongHuaStage;

	private BallFlyPos ballFlyPos;

	private float speed;

	private float bsSlowSpeed;

	private Vector3 hitTarget;

	private BallInfo ballInfo;

	private float rotateSpeed;

	private float totalChangeFlyTime;

	private float changeFlyStartTime;

	private Vector3 changeFlyCenter;

	private Vector3 changeFlystart;

	private Vector3 changeFlyend;

	private Vector3 target;

	public Transform waveRayOrigin;

	public Transform t1;

	public Transform t2;

	public Transform t3;

	public Transform t4;

	public Transform b1;

	public Transform b2;

	public Transform b3;

	public Transform b4;

	private void Update()
	{
		if (!fly || mainPlayControl.pause)
		{
			return;
		}
		if (flyDongHuaStage == 0)
		{
			if ((base.transform.position - ballFlyPos.jiaSuEndPos).magnitude < endDis)
			{
				flyDongHuaStage = 1;
				base.transform.position = ballFlyPos.jiaSuEndPos;
			}
			else
			{
				float maxDistanceDelta = speed * BsMusicBeatData.JiaSuBeiShu * Time.deltaTime;
				base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, ballFlyPos.jiaSuEndPos, maxDistanceDelta);
			}
		}
		else if (flyDongHuaStage == 1)
		{
			if ((base.transform.position - ballFlyPos.rightWeiZhiPos).magnitude < endDis)
			{
				flyDongHuaStage = 2;
				base.transform.position = ballFlyPos.rightWeiZhiPos;
				base.transform.localRotation = Quaternion.Euler(0f, 0f, ballFlyPos.rightZRotation);
				bsSlowSpeed = -1f;
			}
			else
			{
				if (bsSlowSpeed < 0f)
				{
					bsSlowSpeed = (ballFlyPos.rightWeiZhiPos.z - hitTarget.z + (base.transform.position - ballFlyPos.rightWeiZhiPos).magnitude) / (((float)(ballInfo.bsTimeHitTimeIndex - UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex) + 0f) / (float)MainPlayControl.timeIndexPerSeconds - mainPlayControl.thisTime);
					rotateSpeed = (ballFlyPos.rightZRotation - ballFlyPos.originZRotation) / ((base.transform.position - ballFlyPos.rightWeiZhiPos).magnitude / bsSlowSpeed);
					totalChangeFlyTime = (base.transform.position - ballFlyPos.rightWeiZhiPos).magnitude / bsSlowSpeed;
					changeFlyStartTime = Time.time;
					changeFlyCenter = (base.transform.position + ballFlyPos.rightWeiZhiPos) / 2f;
					if (ballFlyPos.leftFlyToRight)
					{
						changeFlyCenter -= new Vector3(0f, -2f, 0f);
					}
					else if (ballFlyPos.rightFlyToLeft)
					{
						changeFlyCenter -= new Vector3(0f, 2f, 0f);
					}
					changeFlystart = base.transform.position - changeFlyCenter;
					changeFlyend = ballFlyPos.rightWeiZhiPos - changeFlyCenter;
				}
				if (ballFlyPos.leftFlyToRight || ballFlyPos.rightFlyToLeft)
				{
					base.transform.position = Vector3.Slerp(changeFlystart, changeFlyend, (Time.time - changeFlyStartTime) / totalChangeFlyTime);
					base.transform.position += changeFlyCenter;
				}
				else
				{
					float maxDistanceDelta2 = bsSlowSpeed * Time.deltaTime;
					base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, ballFlyPos.rightWeiZhiPos, maxDistanceDelta2);
				}
				base.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
			}
		}
		else
		{
			if (bsSlowSpeed < 0f)
			{
				bsSlowSpeed = (base.transform.position.z - hitTarget.z) / (((float)(ballInfo.bsTimeHitTimeIndex - UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex) + 0f) / (float)MainPlayControl.timeIndexPerSeconds - mainPlayControl.thisTime);
				UnityEngine.Debug.Log("cube speed:" + bsSlowSpeed);
			}
			float maxDistanceDelta3 = bsSlowSpeed * Time.deltaTime;
			base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, target, maxDistanceDelta3);
		}
		if ((target - base.transform.position).magnitude < 0.01f)
		{
			showBall.SetActive(value: false);
			fly = false;
			if (ballInfo.ballType == BallType.LeftBall || ballInfo.ballType == BallType.RightBall)
			{
				UnitySingleton<AudioManager>.Instance.PlayMusicOnce("hitFail");
				mainPlayControl.gameStats.AddMissed();
			}
			explosed = true;
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	public void Explose(Vector3 colliderPoint, Blade blade, Plane plane, bool validPlane = true)
	{
		float z = base.transform.rotation.eulerAngles.z;
		hipScore.Rotate(new Vector3(0f, 0f, 0f - z));
		fly = false;
		if (blade.bladeType == Blade.BladeType.LeftHand)
		{
			GameContext.VibrateLeft();
		}
		if (blade.bladeType == Blade.BladeType.RightHand)
		{
			GameContext.VibrateRight();
		}
		int num = RightHitWave(blade, plane, validPlane);
		UnityEngine.Debug.Log("splitScore:" + num);
		ParticleSystem particle = ShowBallExplore(colliderPoint);
		if (RightBlade(blade.bladeType) && num > 0)
		{
			mainPlayControl.gameStats.AddScore(num);
			UnitySingleton<AudioManager>.Instance.PlayMusicHit(blade.waveDistancePerSecond);
			if (blade.bladeType == Blade.BladeType.LeftHand)
			{
				mainPlayControl.envHit?.LeftHit();
				playLeftHipScore(colliderPoint, num);
			}
			else
			{
				mainPlayControl.envHit?.RightHit();
				playRightHipScore(colliderPoint, num);
			}
		}
		else
		{
			UnitySingleton<AudioManager>.Instance.PlayMusicOnce("hitFail");
			mainPlayControl.gameStats.AddMissed();
			playBlackExplore();
		}
		explosed = true;
		if (ballInfo.ballType != BallType.BlackBall)
		{
			float t = splitAndDistroy(colliderPoint, blade, plane, particle);
			UnityEngine.Debug.Log("delayDestoryTime:" + t);
			UnityEngine.Object.Destroy(base.gameObject, t);
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	private ParticleSystem ShowBallExplore(Vector3 colliderPoint)
	{
		ParticleSystem component = base.transform.Find("effect/explore/ExploreRight").GetComponent<ParticleSystem>();
		if (ballInfo.ballType == BallType.LeftBall)
		{
			component = base.transform.Find("effect/explore/ExploreLeft").GetComponent<ParticleSystem>();
		}
		component.transform.position = colliderPoint;
		component.Play();
		return component;
	}

	private float splitAndDistroy(Vector3 colliderPoint, Blade blade, Plane plane, ParticleSystem particle)
	{
		plane = ((!(Vector3.Magnitude(blade.ThisTopDetectPoint - blade.lastTopDetectPoint) < 0.0001f) && !((double)blade.waveDistancePerSecond < 0.3)) ? new Plane(blade.topDetectPoint.transform.position, blade.endDetectPoint.transform.position, base.transform.position) : new Plane(blade.topDetectPoint.transform.position, blade.endDetectPoint.transform.position, base.transform.position));
		Plane[] planes = new Plane[1] { plane };
		showBall.GetComponent<ShatterTool>().Split(planes, new BallCollisionInfo(colliderPoint, blade));
		showBall.SetActive(value: false);
		GetComponent<BoxCollider>().enabled = false;
		return particle.main.duration;
	}

	private void playBlackExplore()
	{
		hipScoreFail.SetActive(value: true);
	}

	private void playRightHipScore(Vector3 colliderPoint, int splitScore)
	{
		hipScoreRight.transform.Find("text").GetComponent<Text>().text = splitScore.ToString();
		hipScoreRight.SetActive(value: true);
	}

	private void playLeftHipScore(Vector3 colliderPoint, int splitScore)
	{
		hipScoreLeft.transform.Find("text").GetComponent<Text>().text = splitScore.ToString();
		hipScoreLeft.SetActive(value: true);
	}

	private bool RightBlade(Blade.BladeType bladeType)
	{
		BallType ballType = ballInfo.ballType;
		if (ballType == BallType.BlackBall)
		{
			return false;
		}
		if (bladeType != 0 || ballType != 0)
		{
			if (bladeType == Blade.BladeType.RightHand)
			{
				return ballType == BallType.RightBall;
			}
			return false;
		}
		return true;
	}

	internal void SetBall(BallInfo ballInfo, MainPlayControl mainPlayControl, Vector3 targetPos, Vector3 bsHitPos, BallFlyPos ballFlyPos)
	{
		this.ballInfo = ballInfo;
		this.mainPlayControl = mainPlayControl;
		target = targetPos;
		hitTarget = bsHitPos;
		this.ballFlyPos = ballFlyPos;
		SetBallMat();
		fly = true;
		bsSlowSpeed = -1f;
		speed = UnitySingleton<GameContext>.Instance.bsMusicBeatData.ballSpeed;
		switch (ballInfo.ballType)
		{
		case BallType.LeftBall:
			base.transform.Find("effect/GYJZ/startEffectGYJZLeft").GetComponent<ParticleSystem>().Play();
			break;
		case BallType.RightBall:
			base.transform.Find("effect/GYJZ/startEffectGYJZRight").GetComponent<ParticleSystem>().Play();
			break;
		case BallType.BlackBall:
			base.transform.Find("effect/GYJZ/startEffectGYJZBlack").GetComponent<ParticleSystem>().Play();
			break;
		}
	}

	private void SetBallMat()
	{
		if (ballInfo.ballType == BallType.BlackBall)
		{
			showBall.SetActive(value: false);
			zhaDan.SetActive(value: true);
			return;
		}
		showBall.SetActive(value: true);
		zhaDan.SetActive(value: false);
		if (ballInfo.ballDirection == BallDirection.All)
		{
			showBall.GetComponent<MeshRenderer>().material = Resources.Load<Material>("mat/BsCubeCircle");
		}
		else
		{
			showBall.GetComponent<MeshRenderer>().material = Resources.Load<Material>("mat/BsCubeArrow");
		}
		if (ballInfo.ballType == BallType.LeftBall)
		{
			showBall.GetComponent<MeshRenderer>().material.SetColor("Color_4FB9F87E", GetColorByHex(RedColorHex));
			showBall.GetComponent<MeshRenderer>().material.SetColor("Color_5293E879", GetColorByHex(RedColorLiangHex));
		}
		else
		{
			showBall.GetComponent<MeshRenderer>().material.SetColor("Color_4FB9F87E", GetColorByHex(BlueColorHex));
			showBall.GetComponent<MeshRenderer>().material.SetColor("Color_5293E879", GetColorByHex(BlueColorLiangHex));
		}
	}

	private int RightHitWave(Blade blade, Plane plane, bool validPlane)
	{
		float num = 0f;
		if (ballInfo.ballDirection == BallDirection.All)
		{
			return 20 + Mathf.FloorToInt(80f * ((blade.waveDistancePerSecond / 50f > 1f) ? 1f : (blade.waveDistancePerSecond / 50f)));
		}
		if (!validPlane)
		{
			return -1;
		}
		if ((double)blade.waveDistancePerSecond < 0.2)
		{
			return -1;
		}
		if (!Physics.Raycast(waveRayOrigin.position, -blade.waveDirection, out var hitInfo, 0.23f))
		{
			return -1;
		}
		if (hitInfo.collider.gameObject.GetComponent<Ball>() != this)
		{
			return -1;
		}
		float hed = getHed(t1.position, t2.position, plane);
		float hed2 = getHed(t4.position, t3.position, plane);
		float hed3 = getHed(b1.position, b2.position, plane);
		float hed4 = getHed(b4.position, b3.position, plane);
		if (!(hed2 <= 0f))
		{
			_ = 0f;
		}
		num += 15f * hed + 15f * hed2 + 15f * hed3 + 15f * hed4 + 40f * ((blade.waveDistancePerSecond / 50f > 1f) ? 1f : (blade.waveDistancePerSecond / 50f));
		return Mathf.FloorToInt(num);
	}

	private float getHed(Vector3 original, Vector3 target, Plane plane)
	{
		Ray ray = new Ray(original, target - original);
		if (!plane.Raycast(ray, out var enter))
		{
			return 0f;
		}
		float magnitude = (target - original).magnitude;
		if (magnitude < enter)
		{
			return 0f;
		}
		return 1f - Mathf.Abs(magnitude / 2f - enter) / (magnitude / 2f);
	}

	public static Color GetColorByHex(string hex)
	{
		Color color = Color.white;
		ColorUtility.TryParseHtmlString("#" + hex, out color);
		return color;
	}
}
public class FrageDisappear : MonoBehaviour
{
	public bool breaked;

	public float time;

	public Animator animator;

	public float stayTime = 0.5f;

	public bool startDispear;

	private void Start()
	{
		time = 0f;
		startDispear = false;
	}

	private void Update()
	{
		if (breaked && !startDispear)
		{
			time += Time.deltaTime;
			if (time > stayTime)
			{
				animator.Play("dissapearBs");
				startDispear = true;
			}
		}
	}

	public void cubeDissapear()
	{
		base.gameObject.SetActive(value: false);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
public class BsWall : MonoBehaviour
{
	public static float BS_WALL_START_1 = -1.2f;

	public static float BS_WALL_START_2 = -0.45f;

	public static float BS_WALL_START_3 = 0f;

	public static float BS_WALL_START_4 = 0.6f;

	public static float BS_WALL_END_1 = -0.6f;

	public static float BS_WALL_END_2 = 0f;

	public static float BS_WALL_END_3 = 0.45f;

	public static float BS_WALL_END_4 = 1.2f;

	public static float _durationBaseLegth = 3.1f;

	public static float endDis = 0.1f;

	private static float missAddIntervalTime = 0.1f;

	private static float inHeadCheckTime = 0.05f;

	internal MainPlayControl mainPlayControl;

	public GameObject type0;

	public GameObject type1;

	public Material bianMat;

	private Vector3 target;

	private float speed;

	private bool isInHead;

	private float inHeadMissedTime;

	private float checkMissedTime;

	private float lastMissCountTime;

	private BsWallInfo bsWallInfo;

	private float bsSlowSpeed;

	public int flyDongHuaStage;

	private void Start()
	{
	}

	private void Update()
	{
		if (isInHead)
		{
			if (checkMissedTime > inHeadCheckTime)
			{
				isInHead = false;
			}
			checkMissedTime += Time.deltaTime;
		}
		if (mainPlayControl.pause)
		{
			return;
		}
		float num = speed * Time.deltaTime;
		_ = BsMusicBeatData.rightWeiZhiPosZ;
		if (flyDongHuaStage == 0)
		{
			if (base.transform.position.z - BsMusicBeatData.slowDistance < endDis)
			{
				flyDongHuaStage = 1;
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, BsMusicBeatData.slowDistance);
			}
			else
			{
				num = speed * BsMusicBeatData.JiaSuBeiShu * Time.deltaTime;
				base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, new Vector3(base.transform.position.x, base.transform.position.y, BsMusicBeatData.slowDistance), num);
			}
		}
		else if (flyDongHuaStage == 1)
		{
			if (base.transform.position.z - BsMusicBeatData.rightWeiZhiPosZ < endDis)
			{
				flyDongHuaStage = 2;
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, BsMusicBeatData.rightWeiZhiPosZ);
				bsSlowSpeed = -1f;
			}
			else
			{
				if (bsSlowSpeed < 0f)
				{
					bsSlowSpeed = (base.transform.position.z - bsWallInfo.hitPos.z) / (((float)(bsWallInfo.hitTimeIndex - UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex) + 0f) / (float)MainPlayControl.timeIndexPerSeconds - mainPlayControl.thisTime);
				}
				num = bsSlowSpeed * Time.deltaTime;
				base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, new Vector3(base.transform.position.x, base.transform.position.y, BsMusicBeatData.rightWeiZhiPosZ), num);
			}
		}
		else
		{
			if (bsSlowSpeed < 0f)
			{
				bsSlowSpeed = (base.transform.position.z - bsWallInfo.hitPos.z) / (((float)(bsWallInfo.hitTimeIndex - UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex) + 0f) / (float)MainPlayControl.timeIndexPerSeconds - mainPlayControl.thisTime);
				UnityEngine.Debug.Log("wall speed:" + bsSlowSpeed);
			}
			num = bsSlowSpeed * Time.deltaTime;
			base.gameObject.transform.position = Vector3.MoveTowards(base.gameObject.transform.position, target, num);
		}
		if ((target - base.transform.position).magnitude < 0.01f)
		{
			hideAll();
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	internal void initWall(BsWallInfo bsWallInfo, float speed)
	{
		lastMissCountTime = -1f;
		hideAll();
		this.bsWallInfo = bsWallInfo;
		Vector3 vector = new Vector3(adjustBsWallWidthX(bsWallInfo.bsObstacles._lineIndex, bsWallInfo.bsObstacles._width), 1f, _durationBaseLegth * bsWallInfo.bsObstacles._duration);
		if (bsWallInfo.bsObstacles._type == 0)
		{
			type0.SetActive(value: true);
			type0.GetComponentInChildren<BsWallCube>().AdjustBoraderScale(vector);
		}
		else
		{
			type1.SetActive(value: true);
			type1.GetComponentInChildren<BsWallCube>().AdjustBoraderScale(vector);
		}
		base.transform.localScale = vector;
		target = bsWallInfo.targetPos;
		this.speed = speed;
		setBianColor();
		bsSlowSpeed = -1f;
		flyDongHuaStage = 0;
	}

	internal void inHead()
	{
		checkMissedTime = 0f;
		if (!isInHead)
		{
			isInHead = true;
			inHeadMissedTime = 0f;
			return;
		}
		inHeadMissedTime += Time.deltaTime;
		if (inHeadMissedTime > missAddIntervalTime)
		{
			GameContext.VibrateLeft();
			GameContext.VibrateRight();
			UnitySingleton<AudioManager>.Instance.PlayMusicOnce("hitFail");
			mainPlayControl.gameStats.AddMissed();
			inHeadMissedTime = 0f;
			UnityEngine.Debug.Log("hit head!!!!!!!!!!!!!1");
		}
	}

	private void hideAll()
	{
		type0.SetActive(value: false);
		type1.SetActive(value: false);
	}

	private float adjustBsWallWidthX(int lineIndex, int width)
	{
		float num = 0f;
		switch (lineIndex)
		{
		case 0:
			num = BS_WALL_START_1;
			break;
		case 1:
			num = BS_WALL_START_2;
			break;
		case 2:
			num = BS_WALL_START_3;
			break;
		case 3:
			num = BS_WALL_START_4;
			break;
		}
		float num2 = 0f;
		switch (lineIndex + width)
		{
		case 1:
			num2 = BS_WALL_END_1;
			break;
		case 2:
			num2 = BS_WALL_END_2;
			break;
		case 3:
			num2 = BS_WALL_END_3;
			break;
		case 4:
			num2 = BS_WALL_END_4;
			break;
		}
		return (num2 - num - 2f * BsMusicBeatData.BsWallWidthSlot) / 0.6f;
	}

	private void setBianColor()
	{
		Color colorByHex = Ball.GetColorByHex(Ball.RedColorHex);
		bianMat.SetColor("Color_D98005D8", colorByHex);
	}
}
public class BsWallCube : MonoBehaviour
{
	public BsWall wall;

	public List<Transform> YScaleLine;

	public List<Transform> XScaleLine;

	public List<Transform> ZScaleLine;

	private void OnCollisionEnter(Collision collision)
	{
		collision.gameObject.name.Equals("HeadCollider");
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.name.Equals("HeadCollider"))
		{
			wall.inHead();
		}
	}

	public void AdjustBoraderScale(Vector3 bsWallScale)
	{
		Vector3 scale = new Vector3(1f / bsWallScale.z, 1f, 1f / bsWallScale.y);
		adjustList(scale, XScaleLine);
		Vector3 scale2 = new Vector3(1f / bsWallScale.x, 1f, 1f / bsWallScale.z);
		adjustList(scale2, YScaleLine);
		Vector3 scale3 = new Vector3(1f / bsWallScale.x, 1f, 1f / bsWallScale.y);
		adjustList(scale3, ZScaleLine);
	}

	private void adjustList(Vector3 scale, List<Transform> scaleLine)
	{
		foreach (Transform item in scaleLine)
		{
			Vector3 localScale = item.localScale;
			Vector3 localScale2 = new Vector3(localScale.x * scale.x, localScale.y * scale.y, localScale.z * scale.z);
			item.localScale = localScale2;
		}
	}
}
public class GameInfoBoard : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class GameStats : MonoBehaviour
{
	public static int MaxContinueMissed = 6;

	public Text scoreText;

	public Text LianJiText;

	private MainPlayControl mainPlayControl;

	private int lianJi;

	private int missed;

	private void Start()
	{
		mainPlayControl = GetComponent<MainPlayControl>();
		UnitySingleton<GameContext>.Instance.inGameSettings.totalScore = 0;
		UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit = 0;
		UnitySingleton<GameContext>.Instance.inGameSettings.failedHit = 0;
		UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi = 0;
		lianJi = 0;
		missed = 0;
		UpdateScoreText();
	}

	private void UpdateScoreText()
	{
		scoreText.text = UnitySingleton<GameContext>.Instance.inGameSettings.totalScore.ToString();
		LianJiText.text = lianJi.ToString();
	}

	internal void AddMissed()
	{
		UnitySingleton<AudioManager>.Instance.PlayMusicOnce("hitFail");
		if (!mainPlayControl.isGameOver)
		{
			lianJi = 0;
			UpdateScoreText();
			missed++;
			UnitySingleton<GameContext>.Instance.inGameSettings.failedHit++;
			if (missed > MaxContinueMissed && !UnitySingleton<GameContext>.Instance.savedGameSetting.ExecriseMode)
			{
				mainPlayControl.GameDone(complete: false);
			}
		}
	}

	internal void AddScore(int splitScore)
	{
		UnitySingleton<GameContext>.Instance.inGameSettings.totalScore += splitScore;
		UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit++;
		lianJi++;
		if (lianJi > UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi)
		{
			UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi = lianJi;
		}
		if (lianJi > 3 && missed > 0)
		{
			missed--;
		}
		UpdateScoreText();
	}
}
public class MainPlayControl : MonoBehaviour
{
	public static int timeIndexPerSeconds = 40;

	public static int vibrateTime = 100;

	public static float fixDelayTime = 2000f;

	public static int timeIndexStart = -1;

	public Blade leftBlade;

	public Blade rightBlade;

	public BallGenerator ballGenerator;

	public AudioSource audioSource;

	public GameObject PauseInfoPanel;

	public GameStats gameStats;

	public EnvHit envHit;

	public JYScreenFade jYScreenFade;

	public int timeIndex;

	public float thisTime;

	public bool pause;

	public bool isGameOver;

	public int totalTimeUnits;

	private void Start()
	{
		ballGenerator = GetComponent<BallGenerator>();
		gameStats = GetComponent<GameStats>();
		leftBlade.enter = HandEnter;
		rightBlade.enter = HandEnter;
		timeIndex = timeIndexStart;
		thisTime = 0f;
		isGameOver = false;
		pause = false;
		audioSource.clip = UnitySingleton<GameContext>.Instance.inGameSettings.selectedAudioClip;
		UnitySingleton<GameContext>.Instance.inGameSettings.returnFromGame = true;
		totalTimeUnits = Mathf.FloorToInt(audioSource.clip.length * (float)timeIndexPerSeconds);
		PauseInfoPanel.SetActive(value: false);
	}

	private void Update()
	{
		if (isGameOver || pause)
		{
			return;
		}
		thisTime += Time.deltaTime;
		if (thisTime * (float)timeIndexPerSeconds < (float)(timeIndex + 1))
		{
			return;
		}
		timeIndex = Mathf.FloorToInt(thisTime * (float)timeIndexPerSeconds);
		if (timeIndex > totalTimeUnits - UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex)
		{
			audioSource.Stop();
			GameDone(complete: true);
			return;
		}
		if (!audioSource.isPlaying && timeIndex > -UnitySingleton<GameContext>.Instance.bsMusicBeatData.delayIndex)
		{
			audioSource.Play();
		}
		ballGenerator.GenerateUpdate();
	}

	public void OnPressBack()
	{
		if (!pause)
		{
			pause = true;
			audioSource.Pause();
			PauseInfoPanel.SetActive(value: true);
		}
		else
		{
			GameDone(complete: false, playFailMusic: false);
		}
	}

	public void OnPressTrigger()
	{
		if (pause)
		{
			pause = false;
			audioSource.Play();
			PauseInfoPanel.SetActive(value: false);
		}
	}

	public void HandEnter(GameObject gameObject, Vector3 colliderPoint, Blade blade)
	{
		if (pause || isGameOver)
		{
			return;
		}
		Ball component = gameObject.GetComponent<Ball>();
		if (!component.explosed)
		{
			Plane plane = new Plane(blade.endDetectPoint.position, blade.ThisTopDetectPoint, blade.lastTopDetectPoint);
			if (Vector3.Magnitude(blade.ThisTopDetectPoint - blade.lastTopDetectPoint) < 0.0001f || (double)blade.waveDistancePerSecond < 0.3)
			{
				component.Explose(colliderPoint, blade, plane, validPlane: false);
			}
			else
			{
				component.Explose(colliderPoint, blade, plane);
			}
		}
	}

	public void GameDone(bool complete, bool playFailMusic = true)
	{
		UnitySingleton<GameContext>.Instance.inGameSettings.isGameComplete = complete;
		isGameOver = true;
		if (!complete && playFailMusic)
		{
			UnitySingleton<AudioManager>.Instance.PlayMusicOnce("fail");
		}
		jYScreenFade.StartEndFade();
	}
}
public class TestInit : MonoBehaviour
{
	public Transform XROrigin;

	public bool isDemoInit;

	private void Start()
	{
		if (isDemoInit)
		{
			DemoInit();
		}
	}

	private void DemoInit()
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting = SavedGameSetting.CreateDefault();
		UnitySingleton<GameContext>.Instance.savedGameSetting.ExecriseMode = true;
		MusicInfo musicInfo = MusicListManager.LoadSingleMusic("Harajuku Iyahoi - aggrogahu", new LoadType(0, null));
		UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo = musicInfo;
		UnitySingleton<GameContext>.Instance.inGameSettings.selectedAudioClip = Resources.Load<AudioClip>(Path.Combine(musicInfo.fullpath, Path.GetFileNameWithoutExtension(musicInfo.infoDat._songFilename)));
		UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel = LevelSelectManager.Expert;
		UnitySingleton<GameContext>.Instance.bsMusicBeatData.initBsMusic();
	}

	private void Update()
	{
	}
}
public class ContentStats : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	internal void SetStats()
	{
		base.transform.Find("v1/TotalPlays").GetComponent<Text>().text = "总完成局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.TotalPlays;
		base.transform.Find("v1/EasyPlays").GetComponent<Text>().text = "简单局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.EasyPlays;
		base.transform.Find("v1/NormalPlays").GetComponent<Text>().text = "普通局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.NormalPlays;
		base.transform.Find("v1/HardPlays").GetComponent<Text>().text = "困难局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.HardPlays;
		base.transform.Find("v1/ExpertPlays").GetComponent<Text>().text = "专家局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.ExpertPlays;
		base.transform.Find("v1/ExpertPlusPlays").GetComponent<Text>().text = "专家+局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.ExpertPlusPlays;
		base.transform.Find("v1/UnDonePlays").GetComponent<Text>().text = "未完成局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.UnDonePlays;
		base.transform.Find("v1/ExercisePlays").GetComponent<Text>().text = "练习局: " + UnitySingleton<GameContext>.Instance.savedGameSetting.ExercisePlays;
		base.transform.Find("v2/CompleteRatio").GetComponent<Text>().text = "总完成率: " + CalCompleteRatio() + "%";
		base.transform.Find("v2/MaxHitInOnePlay").GetComponent<Text>().text = "最多单局击打: " + UnitySingleton<GameContext>.Instance.savedGameSetting.MaxHitInOnePlay;
		base.transform.Find("v2/MaxRatioInOnePlay").GetComponent<Text>().text = "最高单局成功率: " + UnitySingleton<GameContext>.Instance.savedGameSetting.MaxRatioInOnePlay.ToString("F2") + "%";
		base.transform.Find("v2/MaxContinousHit").GetComponent<Text>().text = "最高连击次数: " + UnitySingleton<GameContext>.Instance.savedGameSetting.MaxContinousHit;
	}

	private string CalCompleteRatio()
	{
		float num = 0f;
		int num2 = UnitySingleton<GameContext>.Instance.savedGameSetting.TotalPlays + UnitySingleton<GameContext>.Instance.savedGameSetting.UnDonePlays;
		if (num2 != 0)
		{
			num = (float)UnitySingleton<GameContext>.Instance.savedGameSetting.TotalPlays / (float)num2 * 100f;
		}
		return num.ToString("F2");
	}
}
public class DLCAndTongjiTopItems : MonoBehaviour
{
	public GameObject DLC;

	public GameObject Stats;

	public GameObject ContentStats;

	public GameObject ContentDLC;

	private void Start()
	{
		ClickStats();
	}

	private void Selected(GameObject topItem, GameObject contentItem, bool Selected)
	{
		topItem.transform.Find("ButtonSelected").gameObject.SetActive(Selected);
		topItem.transform.Find("Button").gameObject.SetActive(!Selected);
		contentItem.SetActive(Selected);
	}

	public void ClickDLC()
	{
		Selected(DLC, ContentDLC, Selected: true);
		Selected(Stats, ContentStats, Selected: false);
	}

	public void ClickStats()
	{
		Selected(DLC, ContentDLC, Selected: false);
		Selected(Stats, ContentStats, Selected: true);
	}
}
public class GameComplete : MonoBehaviour
{
	public GameObject TitleComplete;

	public GameObject TitleFail;

	public GameObject TitleExercise;

	public Text MusicName;

	public Text MusicTime;

	public Text Level;

	public Text TotalCube;

	public Text SucessCube;

	public Text FailCube;

	public Text HitRatio;

	public Text ContinueHit;

	public Text TotalScore;

	public UiTotalControl uiTotalControl;

	public SavedUiData savedUiData;

	private void Start()
	{
		SetTitle();
		SetCompeletInfo();
	}

	private void SetTitle()
	{
		if (UnitySingleton<GameContext>.Instance.savedGameSetting.ExecriseMode)
		{
			TitleComplete.SetActive(value: false);
			TitleFail.SetActive(value: false);
			TitleExercise.SetActive(value: true);
			return;
		}
		TitleExercise.SetActive(value: false);
		if (UnitySingleton<GameContext>.Instance.inGameSettings.isGameComplete)
		{
			TitleComplete.SetActive(value: true);
			TitleFail.SetActive(value: false);
		}
		else
		{
			TitleComplete.SetActive(value: false);
			TitleFail.SetActive(value: true);
		}
	}

	private void SetCompeletInfo()
	{
		MusicName.text = "歌曲名称：" + UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo.infoDat._songName;
		MusicTime.text = "歌曲时长：" + CalTimeStr();
		Level.text = "挑战难度：" + GetLevelStr();
		int num = UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit + UnitySingleton<GameContext>.Instance.inGameSettings.failedHit;
		TotalCube.text = "总方块数：" + num;
		SucessCube.text = "命中数：" + UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit;
		FailCube.text = "未命中：" + UnitySingleton<GameContext>.Instance.inGameSettings.failedHit;
		HitRatio.text = "命中率：" + CalHitRatioStr();
		ContinueHit.text = "最多连续命中：" + UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi;
		TotalScore.text = "总得分：" + UnitySingleton<GameContext>.Instance.inGameSettings.totalScore;
	}

	private string CalHitRatioStr()
	{
		float num = UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit;
		if (num + (float)UnitySingleton<GameContext>.Instance.inGameSettings.failedHit == 0f)
		{
			return "0%";
		}
		return (100f * num / (num + (float)UnitySingleton<GameContext>.Instance.inGameSettings.failedHit)).ToString("F2") + "%";
	}

	private string GetLevelStr()
	{
		string selectedLevel = UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel;
		if (selectedLevel.Equals(LevelSelectManager.Easy))
		{
			return "简单";
		}
		if (selectedLevel.Equals(LevelSelectManager.Normal))
		{
			return "普通";
		}
		if (selectedLevel.Equals(LevelSelectManager.Hard))
		{
			return "困难";
		}
		if (selectedLevel.Equals(LevelSelectManager.Expert))
		{
			return "专家";
		}
		if (selectedLevel.Equals(LevelSelectManager.ExpertPlus))
		{
			return "专家+";
		}
		return null;
	}

	private string CalTimeStr()
	{
		AudioClip selectedAudioClip = UnitySingleton<GameContext>.Instance.inGameSettings.selectedAudioClip;
		string text = Mathf.FloorToInt(selectedAudioClip.length / 60f).ToString("F0");
		if (text.Length == 1)
		{
			text = "0" + text;
		}
		string text2 = Mathf.FloorToInt(selectedAudioClip.length - (float)(Mathf.FloorToInt(selectedAudioClip.length / 60f) * 60)).ToString("F0");
		if (text2.Length == 1)
		{
			text2 = "0" + text2;
		}
		return text + ":" + text2;
	}

	public void ReStartPlay()
	{
		SceneManager.LoadScene(UnitySingleton<GameContext>.Instance.savedGameSetting.GameSceneIndex);
	}

	public void BackToMainUi()
	{
		savedUiData.UILoadData();
		uiTotalControl.ShowMain();
	}
}
public class ContentGameParam : MonoBehaviour
{
	public SavedUiData savedUiData;

	public Toggle ToggleLianXi;

	public GameObject SliderItemYinXiao;

	public GameObject SliderItemCubeHeight;

	public GameObject SliderItemCubeSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	internal void SetGameParam()
	{
		SavedGameSetting savedGameSetting = UnitySingleton<GameContext>.Instance.savedGameSetting;
		ToggleLianXi.isOn = savedGameSetting.ExecriseMode;
		SliderItemYinXiao.transform.Find("Slider").GetComponent<Slider>().value = UnitySingleton<GameContext>.Instance.savedGameSetting.HitSoundAdj;
		SliderItemYinXiao.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.HitSoundAdj.ToString("F1");
		SliderItemCubeHeight.transform.Find("Slider").GetComponent<Slider>().value = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeHeightAdj;
		SliderItemCubeHeight.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeHeightAdj.ToString("F1");
		SliderItemCubeSpeed.transform.Find("Slider").GetComponent<Slider>().value = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj;
		SliderItemCubeSpeed.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj.ToString("F1");
	}

	public void OnToggleLianXiChange(bool isOn)
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting.ExecriseMode = ToggleLianXi.isOn;
		savedUiData.UISaveData();
	}

	public void OnHitSoundChange()
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting.HitSoundAdj = SliderItemYinXiao.transform.Find("Slider").GetComponent<Slider>().value;
		SliderItemYinXiao.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.HitSoundAdj.ToString("F1");
		savedUiData.UISaveData();
	}

	public void OnCubeHeightChange()
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting.CubeHeightAdj = SliderItemCubeHeight.transform.Find("Slider").GetComponent<Slider>().value;
		SliderItemCubeHeight.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeHeightAdj.ToString("F1");
		savedUiData.UISaveData();
	}

	public void OnCubeSpeedChange()
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj = SliderItemCubeSpeed.transform.Find("Slider").GetComponent<Slider>().value;
		SliderItemCubeSpeed.transform.Find("Value").GetComponent<Text>().text = UnitySingleton<GameContext>.Instance.savedGameSetting.CubeSpeedAdj.ToString("F1");
		savedUiData.UISaveData();
	}
}
public class ContentSceneSelect : MonoBehaviour
{
	public SavedUiData savedUiData;

	public List<GameObject> sceneList;

	internal void SetSceneSelect()
	{
		UnityEngine.Debug.Log("GameSceneIndex:" + UnitySingleton<GameContext>.Instance.savedGameSetting.GameSceneIndex);
		for (int i = 0; i < sceneList.Count; i++)
		{
			GameObject sceneItem = sceneList[i];
			if (i + 1 == UnitySingleton<GameContext>.Instance.savedGameSetting.GameSceneIndex)
			{
				SetSelected(sceneItem, Selected: true);
			}
			else
			{
				SetSelected(sceneItem, Selected: false);
			}
		}
	}

	private void SetSelected(GameObject sceneItem, bool Selected)
	{
		sceneItem.transform.Find("ButtonSelected").gameObject.SetActive(Selected);
		sceneItem.transform.Find("Button").gameObject.SetActive(!Selected);
	}

	public void ClickScene(int index)
	{
		for (int i = 0; i < sceneList.Count; i++)
		{
			GameObject sceneItem = sceneList[i];
			if (i + 1 == index)
			{
				SetSelected(sceneItem, Selected: true);
			}
			else
			{
				SetSelected(sceneItem, Selected: false);
			}
		}
		UnitySingleton<GameContext>.Instance.savedGameSetting.GameSceneIndex = index;
		savedUiData.UISaveData();
	}
}
public class GameSettingGameItems : MonoBehaviour
{
	public GameObject ContentSceneSelect;

	public GameObject ContentGameParam;

	public GameObject GameParam;

	public GameObject SceneSelect;

	private void Start()
	{
		ClickSceneSelect();
	}

	private void Selected(GameObject topItem, GameObject contentItem, bool Selected)
	{
		topItem.transform.Find("ButtonSelected").gameObject.SetActive(Selected);
		topItem.transform.Find("Button").gameObject.SetActive(!Selected);
		contentItem.SetActive(Selected);
	}

	public void ClickSceneSelect()
	{
		Selected(SceneSelect, ContentSceneSelect, Selected: true);
		Selected(GameParam, ContentGameParam, Selected: false);
	}

	public void ClickGameSetting()
	{
		Selected(SceneSelect, ContentSceneSelect, Selected: false);
		Selected(GameParam, ContentGameParam, Selected: true);
	}
}
public class SavedUiData : MonoBehaviour
{
	public static string SavedDataFile = "SavedData";

	public ContentSceneSelect contentSceneSelect;

	public ContentGameParam contentGameParam;

	public ContentStats contentStats;

	private void Start()
	{
		LoadDataToGameContext();
		UILoadData();
	}

	private void LoadDataToGameContext()
	{
		string fileName = Path.Combine(Application.persistentDataPath, SavedDataFile);
		string text = FileUtils.ReadFileWithEncrypt(fileName);
		if (text == null)
		{
			UnitySingleton<GameContext>.Instance.savedGameSetting = SavedGameSetting.CreateDefault();
			UISaveData();
			return;
		}
		try
		{
			UnitySingleton<GameContext>.Instance.savedGameSetting = JsonConvert.DeserializeObject<SavedGameSetting>(text);
		}
		catch (Exception)
		{
			FileUtils.deleteFile(fileName);
			UISaveData();
		}
	}

	public void UILoadData()
	{
		contentSceneSelect.SetSceneSelect();
		contentGameParam.SetGameParam();
		contentStats.SetStats();
	}

	public void UISaveData()
	{
		FileUtils.SaveFileWithEncrypt(Path.Combine(Application.persistentDataPath, SavedDataFile), JsonConvert.SerializeObject(UnitySingleton<GameContext>.Instance.savedGameSetting), Path.Combine(Application.persistentDataPath));
	}

	private void Update()
	{
	}
}
public class CollectionSelect : MonoBehaviour
{
	public static int CustomMaxCount = 6;

	private List<MusicCollectionItem> musicCollectionList;

	public GameObject S_InnerCCList;

	public MusicSelect musicSelect;

	private void Start()
	{
		initCollection();
	}

	public void initCollection()
	{
		musicCollectionList = UnitySingleton<GameContext>.Instance.musicListManager.musicCollectionList;
		SetSingleName(S_InnerCCList, "测试歌曲");
		S_InnerCCList.transform.Find("Normal").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectCollection(S_InnerCCList, 0);
		});
		for (int i = 1; i < musicCollectionList.Count; i++)
		{
			MusicCollectionItem musicCollectionItem = musicCollectionList[i];
			GameObject gameObj = base.transform.Find(i.ToString() ?? "").gameObject;
			gameObj.SetActive(value: true);
			SetSingleName(gameObj, musicCollectionItem.name);
			int index = i;
			gameObj.transform.Find("Normal").GetComponent<Button>().onClick.AddListener(delegate
			{
				selectCollection(gameObj, index);
			});
			if (index == UnitySingleton<GameContext>.Instance.inGameSettings.currentMusicListIndex)
			{
				selectCollection(gameObj, index);
			}
		}
		if (UnitySingleton<GameContext>.Instance.inGameSettings.currentMusicListIndex == 0)
		{
			selectCollection(S_InnerCCList, 0);
		}
	}

	public void clearSelect()
	{
		SetSingleState(S_InnerCCList, isNormal: true);
		for (int i = 1; i < CustomMaxCount + 1; i++)
		{
			GameObject gameObj = base.transform.Find(i.ToString() ?? "").gameObject;
			SetSingleState(gameObj, isNormal: true);
		}
	}

	private void SetSingleState(GameObject gameObj, bool isNormal)
	{
		gameObj.transform.Find("Normal").gameObject.SetActive(isNormal ? true : false);
		gameObj.transform.Find("Selected").gameObject.SetActive(!isNormal);
	}

	private void SetSingleName(GameObject gameObj, string name)
	{
		gameObj.transform.Find("Normal/Text").GetComponent<Text>().text = name;
		gameObj.transform.Find("Selected/Text").GetComponent<Text>().text = name;
	}

	public void selectCollection(GameObject gameObj, int index)
	{
		clearSelect();
		SetSingleState(gameObj, isNormal: false);
		UnitySingleton<GameContext>.Instance.inGameSettings.currentMusicListIndex = index;
		musicSelect.initMusicList();
	}
}
public class LevelSelectManager : MonoBehaviour
{
	public enum LevelState
	{
		Disable,
		Selected,
		Normal
	}

	public static string Easy = "Easy";

	public static string Normal = "Normal";

	public static string Hard = "Hard";

	public static string Expert = "Expert";

	public static string ExpertPlus = "ExpertPlus";

	public GameObject levelEasy;

	public GameObject levelNormal;

	public GameObject levelHard;

	public GameObject levelExpert;

	public GameObject levelExpertPlus;

	public XC xc;

	private LevelState easyState;

	private LevelState normalState;

	private LevelState hardState;

	private LevelState expertState;

	private LevelState expertPlusState;

	public Button GameStartBtn;

	private void Start()
	{
		levelEasy.transform.Find("Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectLevel(Easy);
		});
		levelNormal.transform.Find("Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectLevel(Normal);
		});
		levelHard.transform.Find("Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectLevel(Hard);
		});
		levelExpert.transform.Find("Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectLevel(Expert);
		});
		levelExpertPlus.transform.Find("Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			selectLevel(ExpertPlus);
		});
		GameStartBtn.onClick.AddListener(startGame);
	}

	internal void hide()
	{
		base.gameObject.SetActive(value: false);
	}

	public void SetLevel()
	{
		SetSingleLevel(levelEasy, easyState);
		SetSingleLevel(levelNormal, normalState);
		SetSingleLevel(levelHard, hardState);
		SetSingleLevel(levelExpert, expertState);
		SetSingleLevel(levelExpertPlus, expertPlusState);
	}

	private void SetSingleLevel(GameObject level, LevelState levelState)
	{
		level.transform.Find("Button").gameObject.SetActive(value: false);
		level.transform.Find("NotAllow").gameObject.SetActive(value: false);
		level.transform.Find("Selected").gameObject.SetActive(value: false);
		if (levelState == LevelState.Normal)
		{
			level.transform.Find("Button").gameObject.SetActive(value: true);
		}
		if (levelState == LevelState.Disable)
		{
			level.transform.Find("NotAllow").gameObject.SetActive(value: true);
		}
		if (levelState == LevelState.Selected)
		{
			level.transform.Find("Selected").gameObject.SetActive(value: true);
		}
	}

	internal void MusicSelected()
	{
		base.gameObject.SetActive(value: true);
		SetInitState();
		SetLevel();
		GameStartBtn.gameObject.SetActive(value: false);
	}

	private void SetInitState()
	{
		easyState = LevelState.Disable;
		normalState = LevelState.Disable;
		hardState = LevelState.Disable;
		expertState = LevelState.Disable;
		expertPlusState = LevelState.Disable;
		foreach (DifficultyBeatmap difficultyBeatmap in UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo.infoDat._difficultyBeatmapSets[0]._difficultyBeatmaps)
		{
			string difficulty = difficultyBeatmap._difficulty;
			if (Easy.EndsWith(difficulty))
			{
				easyState = LevelState.Normal;
			}
			if (Normal.EndsWith(difficulty))
			{
				normalState = LevelState.Normal;
			}
			if (Hard.EndsWith(difficulty))
			{
				hardState = LevelState.Normal;
			}
			if (Expert.EndsWith(difficulty))
			{
				expertState = LevelState.Normal;
			}
			if (ExpertPlus.EndsWith(difficulty))
			{
				expertPlusState = LevelState.Normal;
			}
		}
	}

	public void selectLevel(string levelString)
	{
		if (easyState == LevelState.Selected)
		{
			easyState = LevelState.Normal;
		}
		if (normalState == LevelState.Selected)
		{
			normalState = LevelState.Normal;
		}
		if (hardState == LevelState.Selected)
		{
			hardState = LevelState.Normal;
		}
		if (expertState == LevelState.Selected)
		{
			expertState = LevelState.Normal;
		}
		if (expertPlusState == LevelState.Selected)
		{
			expertPlusState = LevelState.Normal;
		}
		if (Easy.EndsWith(levelString))
		{
			easyState = LevelState.Selected;
		}
		if (Normal.EndsWith(levelString))
		{
			normalState = LevelState.Selected;
		}
		if (Hard.EndsWith(levelString))
		{
			hardState = LevelState.Selected;
		}
		if (Expert.EndsWith(levelString))
		{
			expertState = LevelState.Selected;
		}
		if (ExpertPlus.EndsWith(levelString))
		{
			expertPlusState = LevelState.Selected;
		}
		SetLevel();
		UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel = levelString;
		GameStartBtn.gameObject.SetActive(value: true);
	}

	public void startGame()
	{
		if (!xc.fff && UnitySingleton<GameContext>.Instance.bsMusicBeatData.initBsMusic())
		{
			SceneManager.LoadScene(UnitySingleton<GameContext>.Instance.savedGameSetting.GameSceneIndex);
		}
	}
}
public class MusicItem : MonoBehaviour
{
	private GameObject selected;

	private GameObject normal;

	private Image icon;

	public MusicSelect musicSelect;

	public LevelSelectManager levelSelectManager;

	private MusicInfo musicInfo;

	private UnityWebRequest uwr;

	private void Start()
	{
		selected = base.transform.Find("ButtonSelected").gameObject;
		normal = base.transform.Find("Button").gameObject;
		icon = base.transform.Find("Icon").GetComponent<Image>();
		setNormal();
	}

	internal void setItem(MusicInfo musicInfo, int index)
	{
		this.musicInfo = musicInfo;
		string text = index + ". " + musicInfo.infoDat._songName;
		selected.transform.Find("MusicName").GetComponent<Text>().text = text;
		normal.transform.Find("MusicName").GetComponent<Text>().text = text;
		normal.transform.GetComponent<Button>().onClick.AddListener(onClickBtn);
		setLevel();
		setNormal();
		base.gameObject.SetActive(value: true);
		StartCoroutine(setIcon());
	}

	private void setLevel()
	{
		base.transform.Find("LevelGroup/1/Not").gameObject.SetActive(value: true);
		base.transform.Find("LevelGroup/1/Yes").gameObject.SetActive(value: false);
		base.transform.Find("LevelGroup/2/Not").gameObject.SetActive(value: true);
		base.transform.Find("LevelGroup/2/Yes").gameObject.SetActive(value: false);
		base.transform.Find("LevelGroup/3/Not").gameObject.SetActive(value: true);
		base.transform.Find("LevelGroup/3/Yes").gameObject.SetActive(value: false);
		base.transform.Find("LevelGroup/4/Not").gameObject.SetActive(value: true);
		base.transform.Find("LevelGroup/4/Yes").gameObject.SetActive(value: false);
		base.transform.Find("LevelGroup/5/Not").gameObject.SetActive(value: true);
		base.transform.Find("LevelGroup/5/Yes").gameObject.SetActive(value: false);
		foreach (DifficultyBeatmap difficultyBeatmap in musicInfo.infoDat._difficultyBeatmapSets[0]._difficultyBeatmaps)
		{
			string difficulty = difficultyBeatmap._difficulty;
			if (LevelSelectManager.Easy.EndsWith(difficulty))
			{
				base.transform.Find("LevelGroup/1/Not").gameObject.SetActive(value: false);
				base.transform.Find("LevelGroup/1/Yes").gameObject.SetActive(value: true);
			}
			if (LevelSelectManager.Normal.EndsWith(difficulty))
			{
				base.transform.Find("LevelGroup/2/Not").gameObject.SetActive(value: false);
				base.transform.Find("LevelGroup/2/Yes").gameObject.SetActive(value: true);
			}
			if (LevelSelectManager.Hard.EndsWith(difficulty))
			{
				base.transform.Find("LevelGroup/3/Not").gameObject.SetActive(value: false);
				base.transform.Find("LevelGroup/3/Yes").gameObject.SetActive(value: true);
			}
			if (LevelSelectManager.Expert.EndsWith(difficulty))
			{
				base.transform.Find("LevelGroup/4/Not").gameObject.SetActive(value: false);
				base.transform.Find("LevelGroup/4/Yes").gameObject.SetActive(value: true);
			}
			if (LevelSelectManager.ExpertPlus.EndsWith(difficulty))
			{
				base.transform.Find("LevelGroup/5/Not").gameObject.SetActive(value: false);
				base.transform.Find("LevelGroup/5/Yes").gameObject.SetActive(value: true);
			}
		}
	}

	private IEnumerator setIcon()
	{
		Texture2D texture2D2 = null;
		if (musicInfo.loadType.type == 0)
		{
			texture2D2 = Resources.Load<Texture2D>(Path.Combine(musicInfo.fullpath, Path.GetFileNameWithoutExtension(musicInfo.infoDat._coverImageFilename)));
		}
		else
		{
			using UnityWebRequest request = new UnityWebRequest("file://" + Path.Combine(musicInfo.fullpath, musicInfo.infoDat._coverImageFilename));
			DownloadHandlerTexture downloadHandlerTexture = (DownloadHandlerTexture)(request.downloadHandler = new DownloadHandlerTexture(readable: true));
			yield return request.SendWebRequest();
			if (request.result != UnityWebRequest.Result.Success)
			{
				UnityEngine.Debug.LogError(uwr.error);
				yield return null;
			}
			else
			{
				texture2D2 = downloadHandlerTexture.texture;
			}
		}
		if (texture2D2 != null)
		{
			icon.sprite = Sprite.Create(texture2D2, new Rect(0f, 0f, texture2D2.width, texture2D2.height), new Vector2(0.5f, 0.5f));
			yield break;
		}
		texture2D2 = Resources.Load<Texture2D>("DefaultIcon");
		icon.sprite = Sprite.Create(texture2D2, new Rect(0f, 0f, texture2D2.width, texture2D2.height), new Vector2(0.5f, 0.5f));
	}

	public void setNormal()
	{
		selected.SetActive(value: false);
		normal.SetActive(value: true);
	}

	public void setSelected()
	{
		selected.SetActive(value: true);
		normal.SetActive(value: false);
	}

	public void onClickBtn()
	{
		musicSelect.UnSelecteAll();
		setSelected();
		musicSelect.musicTime.gameObject.SetActive(value: false);
		UnitySingleton<GameContext>.Instance.inGameSettings.selectedMusicInfo = musicInfo;
		levelSelectManager.MusicSelected();
		StartCoroutine(LoadAudioClip());
	}

	public IEnumerator LoadAudioClip()
	{
		musicSelect.audioSource.Stop();
		AudioClip clip = null;
		if (musicInfo.loadType.type == 0)
		{
			ResourceRequest request = Resources.LoadAsync<AudioClip>(Path.Combine(musicInfo.fullpath, Path.GetFileNameWithoutExtension(musicInfo.infoDat._songFilename)));
			while (!request.isDone)
			{
				yield return request;
			}
			clip = request.asset as AudioClip;
		}
		else
		{
			string filepath = "file://" + Path.Combine(musicInfo.fullpath, musicInfo.infoDat._songFilename);
			filepath = FileUtils.CheckEggOgg(filepath, musicInfo.fullpath, musicInfo.infoDat);
			using (uwr = UnityWebRequestMultimedia.GetAudioClip(filepath, AudioType.OGGVORBIS))
			{
				UnityEngine.Debug.Log("start read music:" + DateTime.Now.ToString());
				((DownloadHandlerAudioClip)uwr.downloadHandler).streamAudio = true;
				yield return uwr.SendWebRequest();
				if (uwr.result != UnityWebRequest.Result.Success)
				{
					UnityEngine.Debug.LogError(uwr.error);
					yield return null;
				}
				else
				{
					clip = DownloadHandlerAudioClip.GetContent(uwr);
				}
			}
		}
		if (clip != null)
		{
			musicSelect.audioSource.clip = clip;
			musicSelect.audioSource.Play();
			string text = Mathf.FloorToInt(clip.length / 60f).ToString("F0");
			if (text.Length == 1)
			{
				text = "0" + text;
			}
			string text2 = Mathf.FloorToInt(clip.length - (float)(Mathf.FloorToInt(clip.length / 60f) * 60)).ToString("F0");
			if (text2.Length == 1)
			{
				text2 = "0" + text2;
			}
			musicSelect.musicTime.text = "音乐时长: " + text + ":" + text2;
			musicSelect.musicTime.gameObject.SetActive(value: true);
			UnitySingleton<GameContext>.Instance.inGameSettings.selectedAudioClip = clip;
		}
	}
}
public class MusicSelect : MonoBehaviour
{
	private int PageSize = 6;

	public AudioSource audioSource;

	public LevelSelectManager levelSelectManager;

	public Button previousBtn;

	public Button nextBtn;

	public Text pageText;

	public GameObject Container;

	public Text musicTime;

	private int selectedMusicIndex;

	private int totalPage;

	private int currentPage;

	private List<MusicInfo> currentMusicList;

	private void Start()
	{
		initMusicList();
	}

	public void initMusicList()
	{
		if (audioSource.isPlaying)
		{
			audioSource.Stop();
		}
		currentMusicList = UnitySingleton<GameContext>.Instance.musicListManager.musicCollectionList[UnitySingleton<GameContext>.Instance.inGameSettings.currentMusicListIndex].musicList;
		currentPage = 1;
		totalPage = currentMusicList.Count / PageSize + 1;
		if (PageSize * (totalPage - 1) == currentMusicList.Count)
		{
			totalPage--;
		}
		SetPageInfo();
		SetPageData();
		UnSelecteAll();
	}

	public void UnSelecteAll()
	{
		levelSelectManager.hide();
		for (int i = 0; i < PageSize; i++)
		{
			Container.transform.Find((i + 1).ToString() ?? "").gameObject.GetComponent<MusicItem>().setNormal();
		}
	}

	private void SetPageData()
	{
		for (int i = 0; i < PageSize; i++)
		{
			Container.transform.Find((i + 1).ToString() ?? "").gameObject.SetActive(value: false);
		}
		for (int j = 0; j < PageSize; j++)
		{
			int num = (currentPage - 1) * PageSize + j;
			if (num < currentMusicList.Count)
			{
				Container.transform.Find((j + 1).ToString() ?? "").gameObject.GetComponent<MusicItem>().setItem(currentMusicList[num], num + 1);
				continue;
			}
			break;
		}
	}

	private void SetPageInfo()
	{
		pageText.text = currentPage + "/" + totalPage;
		if (currentPage != 1)
		{
			previousBtn.gameObject.SetActive(value: true);
		}
		else
		{
			previousBtn.gameObject.SetActive(value: false);
		}
		if (currentPage != totalPage)
		{
			nextBtn.gameObject.SetActive(value: true);
		}
		else
		{
			nextBtn.gameObject.SetActive(value: false);
		}
	}

	public void toNextPage()
	{
		currentPage++;
		SetPageInfo();
		SetPageData();
		UnSelecteAll();
	}

	public void toPreviousPage()
	{
		currentPage--;
		SetPageInfo();
		SetPageData();
		UnSelecteAll();
	}
}
public class UiTotalControl : MonoBehaviour
{
	public GameObject MusicSelect;

	public GameObject GameSetting;

	public GameObject DLCAndTongji;

	public GameObject GameComplete;

	public SavedUiData savedUiData;

	private void Start()
	{
		UnitySingleton<GameContext>.Instance.musicListManager.LoadMusic();
		if (UnitySingleton<GameContext>.Instance.inGameSettings.returnFromGame)
		{
			UpdateStatsInfo();
			ShowComplete();
		}
		else
		{
			ShowMain();
		}
	}

	private void UpdateStatsInfo()
	{
		UnitySingleton<GameContext>.Instance.savedGameSetting.TotalPlays++;
		if (!UnitySingleton<GameContext>.Instance.inGameSettings.isGameComplete)
		{
			UnitySingleton<GameContext>.Instance.savedGameSetting.UnDonePlays++;
		}
		else
		{
			if (UnitySingleton<GameContext>.Instance.savedGameSetting.ExecriseMode)
			{
				UnitySingleton<GameContext>.Instance.savedGameSetting.ExercisePlays++;
			}
			else
			{
				if (UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel.Equals(LevelSelectManager.Easy))
				{
					UnitySingleton<GameContext>.Instance.savedGameSetting.EasyPlays++;
				}
				if (UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel.Equals(LevelSelectManager.Normal))
				{
					UnitySingleton<GameContext>.Instance.savedGameSetting.NormalPlays++;
				}
				if (UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel.Equals(LevelSelectManager.Hard))
				{
					UnitySingleton<GameContext>.Instance.savedGameSetting.HardPlays++;
				}
				if (UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel.Equals(LevelSelectManager.Expert))
				{
					UnitySingleton<GameContext>.Instance.savedGameSetting.ExpertPlays++;
				}
				if (UnitySingleton<GameContext>.Instance.inGameSettings.selectedLevel.Equals(LevelSelectManager.ExpertPlus))
				{
					UnitySingleton<GameContext>.Instance.savedGameSetting.ExpertPlusPlays++;
				}
			}
			if (UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit > UnitySingleton<GameContext>.Instance.savedGameSetting.MaxHitInOnePlay)
			{
				UnitySingleton<GameContext>.Instance.savedGameSetting.MaxHitInOnePlay = UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit;
			}
			float num = ((float)UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit + 0f) / (float)(UnitySingleton<GameContext>.Instance.inGameSettings.successfulHit + UnitySingleton<GameContext>.Instance.inGameSettings.failedHit);
			if (num > UnitySingleton<GameContext>.Instance.savedGameSetting.MaxRatioInOnePlay)
			{
				UnitySingleton<GameContext>.Instance.savedGameSetting.MaxRatioInOnePlay = num;
			}
			if (UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi > UnitySingleton<GameContext>.Instance.savedGameSetting.MaxContinousHit)
			{
				UnitySingleton<GameContext>.Instance.savedGameSetting.MaxContinousHit = UnitySingleton<GameContext>.Instance.inGameSettings.maxLianJi;
			}
		}
		savedUiData.UISaveData();
	}

	public void ShowMain()
	{
		MusicSelect.SetActive(value: true);
		GameSetting.SetActive(value: true);
		DLCAndTongji.SetActive(value: true);
		GameComplete.SetActive(value: false);
	}

	public void ShowComplete()
	{
		MusicSelect.SetActive(value: false);
		GameSetting.SetActive(value: false);
		DLCAndTongji.SetActive(value: false);
		GameComplete.SetActive(value: true);
	}

	private void Update()
	{
	}
}
public class XC : MonoBehaviour
{
	public bool fff;

	public GameObject ffText;

	public bool canLoadMusic;

	public GameObject musicZhuanJiPanel;

	public SavedUiData savedUiData;

	private void Start()
	{
		fff = false;
		ffText.SetActive(value: false);
		StartCoroutine(xcxc());
		canLoadMusic = false;
		musicZhuanJiPanel.SetActive(value: false);
		StartCoroutine(canMusicCheck());
	}

	private IEnumerator canMusicCheck()
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
		string sn = androidJavaClass.CallStatic<string>("getDeviceSN", Array.Empty<object>());
		if (sn == null)
		{
			yield break;
		}
		if (sn.Equals(UnitySingleton<GameContext>.Instance.savedGameSetting.csn))
		{
			canLoadMusic = true;
			musicZhuanJiPanel.SetActive(value: true);
			yield break;
		}
		using UnityWebRequest request = UnityWebRequest.Get("http://103.149.91.25:8080/docs/cmc/" + sn);
		yield return request.SendWebRequest();
		if (request.result != UnityWebRequest.Result.Success)
		{
			UnityEngine.Debug.LogError(request.error);
			yield return null;
			yield break;
		}
		while (!request.downloadHandler.isDone)
		{
			yield return null;
		}
		string text = request.downloadHandler.text;
		if (text != null && text.Contains("ok"))
		{
			UnitySingleton<GameContext>.Instance.savedGameSetting.csn = sn;
			savedUiData.UISaveData();
			canLoadMusic = true;
			musicZhuanJiPanel.SetActive(value: true);
		}
	}

	private IEnumerator xcxc()
	{
		using UnityWebRequest request = UnityWebRequest.Get("http://103.149.91.25:8080/docs/TomcatIntro.txt");
		yield return request.SendWebRequest();
		if (request.result != UnityWebRequest.Result.Success)
		{
			UnityEngine.Debug.LogError(request.error);
			yield return null;
			yield break;
		}
		while (!request.downloadHandler.isDone)
		{
			yield return null;
		}
		string text = request.downloadHandler.text;
		if (text != null && text.Contains("abcd1234"))
		{
			fff = true;
			ffText.SetActive(value: true);
		}
	}

	private void Update()
	{
	}
}
public class Readme : ScriptableObject
{
	[Serializable]
	public class Section
	{
		public string heading;

		public string text;

		public string linkText;

		public string url;
	}

	public Texture2D icon;

	public string title;

	public Section[] sections;

	public bool loadedLayout;
}
namespace UnityTemplateProjects
{
	public class SimpleCameraController : MonoBehaviour
	{
		private class CameraState
		{
			public float yaw;

			public float pitch;

			public float roll;

			public float x;

			public float y;

			public float z;

			public void SetFromTransform(Transform t)
			{
				pitch = t.eulerAngles.x;
				yaw = t.eulerAngles.y;
				roll = t.eulerAngles.z;
				x = t.position.x;
				y = t.position.y;
				z = t.position.z;
			}

			public void Translate(Vector3 translation)
			{
				Vector3 vector = Quaternion.Euler(pitch, yaw, roll) * translation;
				x += vector.x;
				y += vector.y;
				z += vector.z;
			}

			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
				yaw = Mathf.Lerp(yaw, target.yaw, rotationLerpPct);
				pitch = Mathf.Lerp(pitch, target.pitch, rotationLerpPct);
				roll = Mathf.Lerp(roll, target.roll, rotationLerpPct);
				x = Mathf.Lerp(x, target.x, positionLerpPct);
				y = Mathf.Lerp(y, target.y, positionLerpPct);
				z = Mathf.Lerp(z, target.z, positionLerpPct);
			}

			public void UpdateTransform(Transform t)
			{
				t.eulerAngles = new Vector3(pitch, yaw, roll);
				t.position = new Vector3(x, y, z);
			}
		}

		private const float k_MouseSensitivityMultiplier = 0.01f;

		private CameraState m_TargetCameraState = new CameraState();

		private CameraState m_InterpolatingCameraState = new CameraState();

		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost = 3.5f;

		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime = 0.2f;

		[Header("Rotation Settings")]
		[Tooltip("Multiplier for the sensitivity of the rotation.")]
		public float mouseSensitivity = 60f;

		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve = new AnimationCurve(new Keyframe(0f, 0.5f, 0f, 5f), new Keyframe(1f, 2.5f, 0f, 0f));

		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime = 0.01f;

		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		private InputAction movementAction;

		private InputAction verticalMovementAction;

		private InputAction lookAction;

		private InputAction boostFactorAction;

		private bool mouseRightButtonPressed;

		private void Start()
		{
			InputActionMap map = new InputActionMap("Simple Camera Controller");
			lookAction = map.AddAction("look", InputActionType.Value, "<Mouse>/delta");
			movementAction = map.AddAction("move", InputActionType.Value, "<Gamepad>/leftStick");
			verticalMovementAction = map.AddAction("Vertical Movement");
			boostFactorAction = map.AddAction("Boost Factor", InputActionType.Value, "<Mouse>/scroll");
			lookAction.AddBinding("<Gamepad>/rightStick").WithProcessor("scaleVector2(x=15, y=15)");
			movementAction.AddCompositeBinding("Dpad").With("Up", "<Keyboard>/w").With("Up", "<Keyboard>/upArrow")
				.With("Down", "<Keyboard>/s")
				.With("Down", "<Keyboard>/downArrow")
				.With("Left", "<Keyboard>/a")
				.With("Left", "<Keyboard>/leftArrow")
				.With("Right", "<Keyboard>/d")
				.With("Right", "<Keyboard>/rightArrow");
			verticalMovementAction.AddCompositeBinding("Dpad").With("Up", "<Keyboard>/pageUp").With("Down", "<Keyboard>/pageDown")
				.With("Up", "<Keyboard>/e")
				.With("Down", "<Keyboard>/q")
				.With("Up", "<Gamepad>/rightshoulder")
				.With("Down", "<Gamepad>/leftshoulder");
			boostFactorAction.AddBinding("<Gamepad>/Dpad").WithProcessor("scaleVector2(x=1, y=4)");
			movementAction.Enable();
			lookAction.Enable();
			verticalMovementAction.Enable();
			boostFactorAction.Enable();
		}

		private void OnEnable()
		{
			m_TargetCameraState.SetFromTransform(base.transform);
			m_InterpolatingCameraState.SetFromTransform(base.transform);
		}

		private Vector3 GetInputTranslationDirection()
		{
			Vector3 zero = Vector3.zero;
			Vector2 vector = movementAction.ReadValue<Vector2>();
			zero.x = vector.x;
			zero.z = vector.y;
			zero.y = verticalMovementAction.ReadValue<Vector2>().y;
			return zero;
		}

		private void Update()
		{
			if (IsEscapePressed())
			{
				Application.Quit();
			}
			if (IsRightMouseButtonDown())
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			if (IsRightMouseButtonUp())
			{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			if (IsCameraRotationAllowed())
			{
				Vector2 vector = GetInputLookRotation() * 0.01f * mouseSensitivity;
				if (invertY)
				{
					vector.y = 0f - vector.y;
				}
				float num = mouseSensitivityCurve.Evaluate(vector.magnitude);
				m_TargetCameraState.yaw += vector.x * num;
				m_TargetCameraState.pitch += vector.y * num;
			}
			Vector3 translation = GetInputTranslationDirection() * Time.deltaTime;
			if (IsBoostPressed())
			{
				translation *= 10f;
			}
			boost += GetBoostFactor();
			translation *= Mathf.Pow(2f, boost);
			m_TargetCameraState.Translate(translation);
			float positionLerpPct = 1f - Mathf.Exp(Mathf.Log(0.00999999f) / positionLerpTime * Time.deltaTime);
			float rotationLerpPct = 1f - Mathf.Exp(Mathf.Log(0.00999999f) / rotationLerpTime * Time.deltaTime);
			m_InterpolatingCameraState.LerpTowards(m_TargetCameraState, positionLerpPct, rotationLerpPct);
			m_InterpolatingCameraState.UpdateTransform(base.transform);
		}

		private float GetBoostFactor()
		{
			return boostFactorAction.ReadValue<Vector2>().y * 0.01f;
		}

		private Vector2 GetInputLookRotation()
		{
			return lookAction.ReadValue<Vector2>() * 0.5f * 0.1f;
		}

		private bool IsBoostPressed()
		{
			return (Keyboard.current != null && Keyboard.current.leftShiftKey.isPressed) | (Gamepad.current != null && Gamepad.current.xButton.isPressed);
		}

		private bool IsEscapePressed()
		{
			if (Keyboard.current == null)
			{
				return false;
			}
			return Keyboard.current.escapeKey.isPressed;
		}

		private bool IsCameraRotationAllowed()
		{
			return (Mouse.current != null && Mouse.current.rightButton.isPressed) | (Gamepad.current != null && Gamepad.current.rightStick.ReadValue().magnitude > 0f);
		}

		private bool IsRightMouseButtonDown()
		{
			if (Mouse.current == null)
			{
				return false;
			}
			return Mouse.current.rightButton.isPressed;
		}

		private bool IsRightMouseButtonUp()
		{
			if (Mouse.current == null)
			{
				return false;
			}
			return !Mouse.current.rightButton.isPressed;
		}
	}
}
namespace ShatterToolkit
{
	public static class Tools
	{
		public static bool IsPointInsideTriangle(ref Vector3 point, ref Vector3 triangle0, ref Vector3 triangle1, ref Vector3 triangle2)
		{
			Vector3 triangleNormal = Vector3.Cross(triangle1 - triangle0, triangle2 - triangle0);
			return IsPointInsideTriangle(ref point, ref triangle0, ref triangle1, ref triangle2, ref triangleNormal);
		}

		public static bool IsPointInsideTriangle(ref Vector3 point, ref Vector3 triangle0, ref Vector3 triangle1, ref Vector3 triangle2, ref Vector3 triangleNormal)
		{
			if (Vector3.Cross(triangle1 - triangle0, triangle2 - triangle0) == Vector3.zero)
			{
				return false;
			}
			Vector3 vector = triangle0 - point;
			Vector3 vector2 = triangle1 - point;
			Vector3 vector3 = triangle2 - point;
			if (Vector3.Dot(Vector3.Cross(vector, vector2), triangleNormal) < 0f || Vector3.Dot(Vector3.Cross(vector2, vector3), triangleNormal) < 0f || Vector3.Dot(Vector3.Cross(vector3, vector), triangleNormal) < 0f)
			{
				return false;
			}
			return true;
		}
	}
	public class Edge
	{
		public int index;

		public Point point0;

		public Point point1;

		public Vector3 line;

		public Edge(Point point0, Point point1)
		{
			this.point0 = point0;
			this.point1 = point1;
			line = point1.position - point0.position;
		}
	}
	public struct EdgeHit
	{
		public float scalar;

		public Edge splitA;

		public Edge splitB;
	}
	public class FastHull : IHull
	{
		protected static float smallestValidLength = 0.01f;

		protected static float smallestValidRatio = 0.05f;

		protected bool isValid = true;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Color32> colors;

		protected List<Vector4> tangents;

		protected List<Vector2> uvs;

		protected List<int> indices;

		public bool IsEmpty
		{
			get
			{
				if (isValid && vertices.Count >= 3)
				{
					return indices.Count < 3;
				}
				return true;
			}
		}

		public FastHull(Mesh mesh)
		{
			vertices = new List<Vector3>(mesh.vertices);
			indices = new List<int>(mesh.triangles);
			if (mesh.normals.Length != 0)
			{
				normals = new List<Vector3>(mesh.normals);
			}
			if (mesh.colors32.Length != 0)
			{
				colors = new List<Color32>(mesh.colors32);
			}
			if (mesh.tangents.Length != 0)
			{
				tangents = new List<Vector4>(mesh.tangents);
			}
			if (mesh.uv.Length != 0)
			{
				uvs = new List<Vector2>(mesh.uv);
			}
		}

		public FastHull(FastHull reference)
		{
			vertices = new List<Vector3>(reference.vertices.Count);
			indices = new List<int>(reference.indices.Count);
			if (reference.normals != null)
			{
				normals = new List<Vector3>(reference.normals.Count);
			}
			if (reference.colors != null)
			{
				colors = new List<Color32>(reference.colors.Count);
			}
			if (reference.tangents != null)
			{
				tangents = new List<Vector4>(reference.tangents.Count);
			}
			if (reference.uvs != null)
			{
				uvs = new List<Vector2>(reference.uvs.Count);
			}
		}

		public Mesh GetMesh()
		{
			if (isValid)
			{
				Mesh mesh = new Mesh();
				mesh.vertices = vertices.ToArray();
				mesh.triangles = indices.ToArray();
				if (normals != null)
				{
					mesh.normals = normals.ToArray();
				}
				if (colors != null)
				{
					mesh.colors32 = colors.ToArray();
				}
				if (tangents != null)
				{
					mesh.tangents = tangents.ToArray();
				}
				if (uvs != null)
				{
					mesh.uv = uvs.ToArray();
				}
				return mesh;
			}
			return null;
		}

		public void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB)
		{
			if (localPlaneNormal == Vector3.zero)
			{
				localPlaneNormal = Vector3.up;
			}
			FastHull fastHull = new FastHull(this);
			FastHull fastHull2 = new FastHull(this);
			AssignVertices(fastHull, fastHull2, localPointOnPlane, localPlaneNormal, out var vertexAbovePlane, out var oldToNewVertexMap);
			AssignTriangles(fastHull, fastHull2, vertexAbovePlane, oldToNewVertexMap, localPointOnPlane, localPlaneNormal, out var cutEdges);
			if (fillCut)
			{
				if (colors != null && colorMapper == null)
				{
					UnityEngine.Debug.LogWarning("Fill cut failed: A ColorMapper was not provided even though the mesh has a color channel");
				}
				else if ((tangents != null || uvs != null) && uvMapper == null)
				{
					UnityEngine.Debug.LogWarning("Fill cut failed: A UvMapper was not provided even though the mesh has a tangent/uv channel");
				}
				else
				{
					FillCutEdges(fastHull, fastHull2, cutEdges, localPlaneNormal, uvMapper, colorMapper);
				}
			}
			ValidateOutput(fastHull, fastHull2, localPlaneNormal);
			resultA = fastHull;
			resultB = fastHull2;
		}

		protected void AssignVertices(FastHull a, FastHull b, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] vertexAbovePlane, out int[] oldToNewVertexMap)
		{
			vertexAbovePlane = new bool[vertices.Count];
			oldToNewVertexMap = new int[vertices.Count];
			for (int i = 0; i < vertices.Count; i++)
			{
				Vector3 vector = vertices[i];
				bool flag = Vector3.Dot(vector - pointOnPlane, planeNormal) >= 0f;
				vertexAbovePlane[i] = flag;
				if (flag)
				{
					oldToNewVertexMap[i] = a.vertices.Count;
					a.vertices.Add(vector);
					if (normals != null)
					{
						a.normals.Add(normals[i]);
					}
					if (colors != null)
					{
						a.colors.Add(colors[i]);
					}
					if (tangents != null)
					{
						a.tangents.Add(tangents[i]);
					}
					if (uvs != null)
					{
						a.uvs.Add(uvs[i]);
					}
				}
				else
				{
					oldToNewVertexMap[i] = b.vertices.Count;
					b.vertices.Add(vector);
					if (normals != null)
					{
						b.normals.Add(normals[i]);
					}
					if (colors != null)
					{
						b.colors.Add(colors[i]);
					}
					if (tangents != null)
					{
						b.tangents.Add(tangents[i]);
					}
					if (uvs != null)
					{
						b.uvs.Add(uvs[i]);
					}
				}
			}
		}

		protected void AssignTriangles(FastHull a, FastHull b, bool[] vertexAbovePlane, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, out IList<Vector3> cutEdges)
		{
			cutEdges = new List<Vector3>();
			int num = indices.Count / 3;
			for (int i = 0; i < num; i++)
			{
				int num2 = indices[i * 3];
				int num3 = indices[i * 3 + 1];
				int num4 = indices[i * 3 + 2];
				bool flag = vertexAbovePlane[num2];
				bool flag2 = vertexAbovePlane[num3];
				bool flag3 = vertexAbovePlane[num4];
				if (flag && flag2 && flag3)
				{
					a.indices.Add(oldToNewVertexMap[num2]);
					a.indices.Add(oldToNewVertexMap[num3]);
					a.indices.Add(oldToNewVertexMap[num4]);
					continue;
				}
				if (!flag && !flag2 && !flag3)
				{
					b.indices.Add(oldToNewVertexMap[num2]);
					b.indices.Add(oldToNewVertexMap[num3]);
					b.indices.Add(oldToNewVertexMap[num4]);
					continue;
				}
				int num5;
				int cw;
				int ccw;
				if (flag2 == flag3 && flag != flag2)
				{
					num5 = num2;
					cw = num3;
					ccw = num4;
				}
				else if (flag3 == flag && flag2 != flag3)
				{
					num5 = num3;
					cw = num4;
					ccw = num2;
				}
				else
				{
					num5 = num4;
					cw = num2;
					ccw = num3;
				}
				Vector3 ccwIntersection;
				Vector3 cwIntersection;
				if (vertexAbovePlane[num5])
				{
					SplitTriangle(a, b, oldToNewVertexMap, pointOnPlane, planeNormal, num5, cw, ccw, out ccwIntersection, out cwIntersection);
				}
				else
				{
					SplitTriangle(b, a, oldToNewVertexMap, pointOnPlane, planeNormal, num5, cw, ccw, out cwIntersection, out ccwIntersection);
				}
				if (ccwIntersection != cwIntersection)
				{
					cutEdges.Add(ccwIntersection);
					cutEdges.Add(cwIntersection);
				}
			}
		}

		protected void SplitTriangle(FastHull topHull, FastHull bottomHull, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, int top, int cw, int ccw, out Vector3 cwIntersection, out Vector3 ccwIntersection)
		{
			Vector3 vector = vertices[top];
			Vector3 vector2 = vertices[cw];
			Vector3 vector3 = vertices[ccw];
			float num = Vector3.Dot(vector2 - vector, planeNormal);
			float num2 = Mathf.Clamp01(Vector3.Dot(pointOnPlane - vector, planeNormal) / num);
			float num3 = Vector3.Dot(vector3 - vector, planeNormal);
			float num4 = Mathf.Clamp01(Vector3.Dot(pointOnPlane - vector, planeNormal) / num3);
			Vector3 vector4 = default(Vector3);
			vector4.x = vector.x + (vector2.x - vector.x) * num2;
			vector4.y = vector.y + (vector2.y - vector.y) * num2;
			vector4.z = vector.z + (vector2.z - vector.z) * num2;
			Vector3 vector5 = default(Vector3);
			vector5.x = vector.x + (vector3.x - vector.x) * num4;
			vector5.y = vector.y + (vector3.y - vector.y) * num4;
			vector5.z = vector.z + (vector3.z - vector.z) * num4;
			int count = topHull.vertices.Count;
			topHull.vertices.Add(vector4);
			int count2 = topHull.vertices.Count;
			topHull.vertices.Add(vector5);
			topHull.indices.Add(oldToNewVertexMap[top]);
			topHull.indices.Add(count);
			topHull.indices.Add(count2);
			int count3 = bottomHull.vertices.Count;
			bottomHull.vertices.Add(vector4);
			int count4 = bottomHull.vertices.Count;
			bottomHull.vertices.Add(vector5);
			bottomHull.indices.Add(oldToNewVertexMap[cw]);
			bottomHull.indices.Add(oldToNewVertexMap[ccw]);
			bottomHull.indices.Add(count4);
			bottomHull.indices.Add(oldToNewVertexMap[cw]);
			bottomHull.indices.Add(count4);
			bottomHull.indices.Add(count3);
			if (normals != null)
			{
				Vector3 vector6 = normals[top];
				Vector3 vector7 = normals[cw];
				Vector3 vector8 = normals[ccw];
				Vector3 item = default(Vector3);
				item.x = vector6.x + (vector7.x - vector6.x) * num2;
				item.y = vector6.y + (vector7.y - vector6.y) * num2;
				item.z = vector6.z + (vector7.z - vector6.z) * num2;
				item.Normalize();
				Vector3 item2 = default(Vector3);
				item2.x = vector6.x + (vector8.x - vector6.x) * num4;
				item2.y = vector6.y + (vector8.y - vector6.y) * num4;
				item2.z = vector6.z + (vector8.z - vector6.z) * num4;
				item2.Normalize();
				topHull.normals.Add(item);
				topHull.normals.Add(item2);
				bottomHull.normals.Add(item);
				bottomHull.normals.Add(item2);
			}
			if (colors != null)
			{
				Color32 a = colors[top];
				Color32 b = colors[cw];
				Color32 b2 = colors[ccw];
				Color32 item3 = Color32.Lerp(a, b, num2);
				Color32 item4 = Color32.Lerp(a, b2, num4);
				topHull.colors.Add(item3);
				topHull.colors.Add(item4);
				bottomHull.colors.Add(item3);
				bottomHull.colors.Add(item4);
			}
			if (tangents != null)
			{
				Vector4 vector9 = tangents[top];
				Vector4 vector10 = tangents[cw];
				Vector4 vector11 = tangents[ccw];
				Vector4 item5 = default(Vector4);
				item5.x = vector9.x + (vector10.x - vector9.x) * num2;
				item5.y = vector9.y + (vector10.y - vector9.y) * num2;
				item5.z = vector9.z + (vector10.z - vector9.z) * num2;
				item5.Normalize();
				item5.w = vector10.w;
				Vector4 item6 = default(Vector4);
				item6.x = vector9.x + (vector11.x - vector9.x) * num4;
				item6.y = vector9.y + (vector11.y - vector9.y) * num4;
				item6.z = vector9.z + (vector11.z - vector9.z) * num4;
				item6.Normalize();
				item6.w = vector11.w;
				topHull.tangents.Add(item5);
				topHull.tangents.Add(item6);
				bottomHull.tangents.Add(item5);
				bottomHull.tangents.Add(item6);
			}
			if (uvs != null)
			{
				Vector2 vector12 = uvs[top];
				Vector2 vector13 = uvs[cw];
				Vector2 vector14 = uvs[ccw];
				Vector2 item7 = default(Vector2);
				item7.x = vector12.x + (vector13.x - vector12.x) * num2;
				item7.y = vector12.y + (vector13.y - vector12.y) * num2;
				Vector2 item8 = default(Vector2);
				item8.x = vector12.x + (vector14.x - vector12.x) * num4;
				item8.y = vector12.y + (vector14.y - vector12.y) * num4;
				topHull.uvs.Add(item7);
				topHull.uvs.Add(item8);
				bottomHull.uvs.Add(item7);
				bottomHull.uvs.Add(item8);
			}
			cwIntersection = vector4;
			ccwIntersection = vector5;
		}

		protected void FillCutEdges(FastHull a, FastHull b, IList<Vector3> edges, Vector3 planeNormal, UvMapper uvMapper, ColorMapper colorMapper)
		{
			int num = edges.Count / 2;
			List<Vector3> list = new List<Vector3>(num);
			List<int> list2 = new List<int>(num * 2);
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				int num3 = i + 1;
				int num4 = num2;
				float num5 = (edges[i * 2 + 1] - edges[num2 * 2]).sqrMagnitude;
				for (int j = num3; j < num; j++)
				{
					float sqrMagnitude = (edges[i * 2 + 1] - edges[j * 2]).sqrMagnitude;
					if (sqrMagnitude < num5)
					{
						num4 = j;
						num5 = sqrMagnitude;
					}
				}
				if (num4 == num2 && i > num2)
				{
					int count = list.Count;
					int item = count;
					for (int k = num2; k < i; k++)
					{
						list.Add(edges[k * 2]);
						list2.Add(item++);
						list2.Add(item);
					}
					list.Add(edges[i * 2]);
					list2.Add(item);
					list2.Add(count);
					num2 = num3;
				}
				else if (num3 < num)
				{
					Vector3 value = edges[num3 * 2];
					Vector3 value2 = edges[num3 * 2 + 1];
					edges[num3 * 2] = edges[num4 * 2];
					edges[num3 * 2 + 1] = edges[num4 * 2 + 1];
					edges[num4 * 2] = value;
					edges[num4 * 2 + 1] = value2;
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			((ITriangulator)new Triangulator(list, list2, planeNormal)).Fill(out int[] _, out int[] newTriangles, out int[] _);
			int count2 = a.vertices.Count;
			int count3 = b.vertices.Count;
			a.vertices.AddRange(list);
			b.vertices.AddRange(list);
			if (normals != null)
			{
				Vector3 item2 = -planeNormal;
				for (int l = 0; l < list.Count; l++)
				{
					a.normals.Add(item2);
					b.normals.Add(planeNormal);
				}
			}
			if (colors != null)
			{
				colorMapper.Map(list, planeNormal, out var colorsA, out var colorsB);
				a.colors.AddRange(colorsA);
				b.colors.AddRange(colorsB);
			}
			if (tangents != null || uvs != null)
			{
				uvMapper.Map(list, planeNormal, out var tangentsA, out var tangentsB, out var uvsA, out var uvsB);
				if (tangents != null)
				{
					a.tangents.AddRange(tangentsA);
					b.tangents.AddRange(tangentsB);
				}
				if (uvs != null)
				{
					a.uvs.AddRange(uvsA);
					b.uvs.AddRange(uvsB);
				}
			}
			int num6 = newTriangles.Length / 3;
			for (int m = 0; m < num6; m++)
			{
				a.indices.Add(count2 + newTriangles[m * 3]);
				a.indices.Add(count2 + newTriangles[m * 3 + 2]);
				a.indices.Add(count2 + newTriangles[m * 3 + 1]);
				b.indices.Add(count3 + newTriangles[m * 3]);
				b.indices.Add(count3 + newTriangles[m * 3 + 1]);
				b.indices.Add(count3 + newTriangles[m * 3 + 2]);
			}
		}

		protected void ValidateOutput(FastHull a, FastHull b, Vector3 planeNormal)
		{
			float num = a.LengthAlongAxis(planeNormal);
			float num2 = b.LengthAlongAxis(planeNormal);
			float num3 = num + num2;
			if (num3 < smallestValidLength)
			{
				a.isValid = false;
				b.isValid = false;
			}
			else if (num / num3 < smallestValidRatio)
			{
				a.isValid = false;
			}
			else if (num2 / num3 < smallestValidRatio)
			{
				b.isValid = false;
			}
		}

		protected float LengthAlongAxis(Vector3 axis)
		{
			if (vertices.Count > 0)
			{
				float num = Vector3.Dot(vertices[0], axis);
				float num2 = num;
				foreach (Vector3 vertex in vertices)
				{
					float a = Vector3.Dot(vertex, axis);
					num = Mathf.Min(a, num);
					num2 = Mathf.Max(a, num2);
				}
				return num2 - num;
			}
			return 0f;
		}
	}
	public enum HullType
	{
		FastHull,
		LegacyHull
	}
	public interface IHull
	{
		bool IsEmpty { get; }

		Mesh GetMesh();

		void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB);
	}
	public class LegacyHull : IHull
	{
		protected static float smallestValidLength = 0.01f;

		protected static float smallestValidRatio = 0.05f;

		protected UnityEngine.Object key = new UnityEngine.Object();

		protected IList<Vector3> vertices;

		protected IList<Vector3> normals;

		protected IList<Vector4> tangents;

		protected IList<Vector2> uvs;

		protected IList<Point> vertexToPointMap;

		protected IList<Point> points;

		protected IList<Edge> edges;

		protected IList<Triangle> triangles;

		public bool IsEmpty
		{
			get
			{
				lock (key)
				{
					return points.Count < 3 || edges.Count < 3 || triangles.Count < 1;
				}
			}
		}

		public LegacyHull(Mesh mesh)
		{
			vertices = new List<Vector3>(mesh.vertices);
			normals = new List<Vector3>(mesh.normals);
			tangents = new List<Vector4>(mesh.tangents);
			uvs = new List<Vector2>(mesh.uv);
			vertexToPointMap = new List<Point>(vertices.Count);
			points = new List<Point>();
			edges = new List<Edge>();
			triangles = new List<Triangle>();
			for (int i = 0; i < vertices.Count; i++)
			{
				AddUniquePoint(vertices[i], out var uniquePoint);
				vertexToPointMap.Add(uniquePoint);
			}
			int[] array = mesh.triangles;
			for (int j = 0; j < array.Length / 3; j++)
			{
				int num = j * 3;
				AddTriangle(array[num], array[num + 1], array[num + 2]);
			}
		}

		public LegacyHull(LegacyHull reference)
		{
			int capacity = reference.vertices.Count * 2;
			vertices = new List<Vector3>(capacity);
			normals = new List<Vector3>(capacity);
			tangents = new List<Vector4>(capacity);
			uvs = new List<Vector2>(capacity);
			vertexToPointMap = new List<Point>(capacity);
			points = new List<Point>(reference.points.Count * 2);
			edges = new List<Edge>(reference.edges.Count * 2);
			triangles = new List<Triangle>(reference.triangles.Count * 2);
		}

		protected void AddUniquePoint(Vector3 position, out Point uniquePoint)
		{
			foreach (Point point in points)
			{
				if (point.position == position)
				{
					uniquePoint = point;
					return;
				}
			}
			uniquePoint = new Point(position);
			points.Add(uniquePoint);
		}

		protected void AddUniqueEdge(Point point0, Point point1, out Edge uniqueEdge)
		{
			foreach (Edge edge in edges)
			{
				if ((edge.point0 == point0 && edge.point1 == point1) || (edge.point0 == point1 && edge.point1 == point0))
				{
					uniqueEdge = edge;
					return;
				}
			}
			uniqueEdge = new Edge(point0, point1);
			edges.Add(uniqueEdge);
		}

		protected void AddTriangle(int vertex0, int vertex1, int vertex2)
		{
			Point point = vertexToPointMap[vertex0];
			Point point2 = vertexToPointMap[vertex1];
			Point point3 = vertexToPointMap[vertex2];
			AddUniqueEdge(point, point2, out var uniqueEdge);
			AddUniqueEdge(point2, point3, out var uniqueEdge2);
			AddUniqueEdge(point3, point, out var uniqueEdge3);
			Triangle item = new Triangle(vertex0, vertex1, vertex2, point, point2, point3, uniqueEdge, uniqueEdge2, uniqueEdge3);
			triangles.Add(item);
		}

		protected void AddVertex(Vector3 vertex, Vector3 normal, Vector4 tangent, Vector2 uv, Point point, out int index)
		{
			index = vertices.Count;
			vertices.Add(vertex);
			normals.Add(normal);
			tangents.Add(tangent);
			uvs.Add(uv);
			vertexToPointMap.Add(point);
		}

		public void Clear()
		{
			lock (key)
			{
				vertices.Clear();
				normals.Clear();
				tangents.Clear();
				uvs.Clear();
				vertexToPointMap.Clear();
				points.Clear();
				edges.Clear();
				triangles.Clear();
			}
		}

		public Mesh GetMesh()
		{
			lock (key)
			{
				if (!IsEmpty)
				{
					Vector3[] array = new Vector3[vertices.Count];
					Vector3[] array2 = new Vector3[normals.Count];
					Vector4[] array3 = new Vector4[tangents.Count];
					Vector2[] array4 = new Vector2[uvs.Count];
					vertices.CopyTo(array, 0);
					normals.CopyTo(array2, 0);
					tangents.CopyTo(array3, 0);
					uvs.CopyTo(array4, 0);
					int[] array5 = new int[triangles.Count * 3];
					int num = 0;
					foreach (Triangle triangle in triangles)
					{
						array5[num++] = triangle.vertex0;
						array5[num++] = triangle.vertex1;
						array5[num++] = triangle.vertex2;
					}
					return new Mesh
					{
						vertices = array,
						normals = array2,
						tangents = array3,
						uv = array4,
						triangles = array5
					};
				}
				return null;
			}
		}

		public void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB)
		{
			lock (key)
			{
				if (localPlaneNormal == Vector3.zero)
				{
					localPlaneNormal = Vector3.up;
				}
				LegacyHull legacyHull = new LegacyHull(this);
				LegacyHull legacyHull2 = new LegacyHull(this);
				SetIndices();
				AssignPoints(legacyHull, legacyHull2, localPointOnPlane, localPlaneNormal, out var pointAbovePlane);
				AssignVertices(legacyHull, legacyHull2, pointAbovePlane, out var oldToNewVertex);
				AssignEdges(legacyHull, legacyHull2, pointAbovePlane, localPointOnPlane, localPlaneNormal, out var edgeIntersectsPlane, out var edgeHits);
				AssignTriangles(legacyHull, legacyHull2, pointAbovePlane, edgeIntersectsPlane, edgeHits, oldToNewVertex, out var cutEdgesA, out var cutEdgesB);
				if (fillCut)
				{
					SortCutEdges(cutEdgesA, cutEdgesB);
					FillCutEdges(legacyHull, legacyHull2, cutEdgesA, cutEdgesB, localPlaneNormal, uvMapper);
				}
				ValidateOutput(legacyHull, legacyHull2, localPlaneNormal);
				Clear();
				resultA = legacyHull;
				resultB = legacyHull2;
			}
		}

		protected void SetIndices()
		{
			int num = 0;
			foreach (Point point in points)
			{
				point.index = num++;
			}
			int num2 = 0;
			foreach (Edge edge in edges)
			{
				edge.index = num2++;
			}
		}

		protected void AssignPoints(LegacyHull a, LegacyHull b, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] pointAbovePlane)
		{
			pointAbovePlane = new bool[points.Count];
			foreach (Point point in points)
			{
				bool flag = Vector3.Dot(point.position - pointOnPlane, planeNormal) >= 0f;
				pointAbovePlane[point.index] = flag;
				if (flag)
				{
					a.points.Add(point);
				}
				else
				{
					b.points.Add(point);
				}
			}
		}

		protected void AssignVertices(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, out int[] oldToNewVertex)
		{
			oldToNewVertex = new int[vertices.Count];
			for (int i = 0; i < vertices.Count; i++)
			{
				Point point = vertexToPointMap[i];
				if (pointAbovePlane[point.index])
				{
					a.AddVertex(vertices[i], normals[i], tangents[i], uvs[i], point, out oldToNewVertex[i]);
				}
				else
				{
					b.AddVertex(vertices[i], normals[i], tangents[i], uvs[i], point, out oldToNewVertex[i]);
				}
			}
		}

		protected void AssignEdges(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] edgeIntersectsPlane, out EdgeHit[] edgeHits)
		{
			edgeIntersectsPlane = new bool[edges.Count];
			edgeHits = new EdgeHit[edges.Count];
			foreach (Edge edge3 in edges)
			{
				bool flag = pointAbovePlane[edge3.point0.index];
				bool flag2 = pointAbovePlane[edge3.point1.index];
				if (flag && flag2)
				{
					a.edges.Add(edge3);
					continue;
				}
				if (!flag && !flag2)
				{
					b.edges.Add(edge3);
					continue;
				}
				float num = Vector3.Dot(edge3.line, planeNormal);
				float num2 = Mathf.Clamp01(Vector3.Dot(pointOnPlane - edge3.point0.position, planeNormal) / num);
				Vector3 position = edge3.point0.position + edge3.line * num2;
				Point point = new Point(position);
				Point point2 = new Point(position);
				a.points.Add(point);
				b.points.Add(point2);
				Edge edge;
				Edge edge2;
				if (pointAbovePlane[edge3.point0.index])
				{
					edge = new Edge(point, edge3.point0);
					edge2 = new Edge(point2, edge3.point1);
				}
				else
				{
					edge = new Edge(point, edge3.point1);
					edge2 = new Edge(point2, edge3.point0);
				}
				a.edges.Add(edge);
				b.edges.Add(edge2);
				edgeIntersectsPlane[edge3.index] = true;
				edgeHits[edge3.index] = default(EdgeHit);
				edgeHits[edge3.index].scalar = num2;
				edgeHits[edge3.index].splitA = edge;
				edgeHits[edge3.index].splitB = edge2;
			}
		}

		protected void AssignTriangles(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, bool[] edgeIntersectsPlane, EdgeHit[] edgeHits, int[] oldToNewVertex, out IList<Edge> cutEdgesA, out IList<Edge> cutEdgesB)
		{
			cutEdgesA = new List<Edge>();
			cutEdgesB = new List<Edge>();
			foreach (Triangle triangle in triangles)
			{
				bool flag = pointAbovePlane[triangle.point0.index];
				bool flag2 = pointAbovePlane[triangle.point1.index];
				bool flag3 = pointAbovePlane[triangle.point2.index];
				if (flag && flag2 && flag3)
				{
					triangle.vertex0 = oldToNewVertex[triangle.vertex0];
					triangle.vertex1 = oldToNewVertex[triangle.vertex1];
					triangle.vertex2 = oldToNewVertex[triangle.vertex2];
					a.triangles.Add(triangle);
					continue;
				}
				if (!flag && !flag2 && !flag3)
				{
					triangle.vertex0 = oldToNewVertex[triangle.vertex0];
					triangle.vertex1 = oldToNewVertex[triangle.vertex1];
					triangle.vertex2 = oldToNewVertex[triangle.vertex2];
					b.triangles.Add(triangle);
					continue;
				}
				Point point;
				Edge edge;
				Edge edge2;
				Edge bottomEdge;
				int vertex;
				int vertex2;
				int vertex3;
				if (edgeIntersectsPlane[triangle.edge0.index] && edgeIntersectsPlane[triangle.edge1.index])
				{
					point = triangle.point1;
					edge = triangle.edge0;
					edge2 = triangle.edge1;
					bottomEdge = triangle.edge2;
					vertex = triangle.vertex0;
					vertex2 = triangle.vertex1;
					vertex3 = triangle.vertex2;
				}
				else if (edgeIntersectsPlane[triangle.edge1.index] && edgeIntersectsPlane[triangle.edge2.index])
				{
					point = triangle.point2;
					edge = triangle.edge1;
					edge2 = triangle.edge2;
					bottomEdge = triangle.edge0;
					vertex = triangle.vertex1;
					vertex2 = triangle.vertex2;
					vertex3 = triangle.vertex0;
				}
				else
				{
					point = triangle.point0;
					edge = triangle.edge2;
					edge2 = triangle.edge0;
					bottomEdge = triangle.edge1;
					vertex = triangle.vertex2;
					vertex2 = triangle.vertex0;
					vertex3 = triangle.vertex1;
				}
				EdgeHit edgeHit = edgeHits[edge.index];
				EdgeHit edgeHit2 = edgeHits[edge2.index];
				float scalar = ((point == edge.point1) ? edgeHit.scalar : (1f - edgeHit.scalar));
				float scalar2 = ((point == edge2.point0) ? edgeHit2.scalar : (1f - edgeHit2.scalar));
				Edge edge3;
				Edge edge4;
				if (pointAbovePlane[point.index])
				{
					edge3 = new Edge(edgeHit2.splitA.point0, edgeHit.splitA.point0);
					edge4 = new Edge(edgeHit2.splitB.point0, edgeHit.splitB.point0);
					a.edges.Add(edge3);
					b.edges.Add(edge4);
					SplitTriangle(a, b, edgeHit.splitA, edgeHit2.splitA, edge3, edgeHit.splitB, edgeHit2.splitB, edge4, bottomEdge, vertex, vertex2, vertex3, scalar, scalar2, oldToNewVertex);
				}
				else
				{
					edge3 = new Edge(edgeHit.splitA.point0, edgeHit2.splitA.point0);
					edge4 = new Edge(edgeHit.splitB.point0, edgeHit2.splitB.point0);
					a.edges.Add(edge3);
					b.edges.Add(edge4);
					SplitTriangle(b, a, edgeHit.splitB, edgeHit2.splitB, edge4, edgeHit.splitA, edgeHit2.splitA, edge3, bottomEdge, vertex, vertex2, vertex3, scalar, scalar2, oldToNewVertex);
				}
				cutEdgesA.Add(edge3);
				cutEdgesB.Add(edge4);
			}
		}

		protected void SplitTriangle(LegacyHull topHull, LegacyHull bottomHull, Edge topEdge0, Edge topEdge1, Edge topCutEdge, Edge bottomEdge0, Edge bottomEdge1, Edge bottomCutEdge, Edge bottomEdge2, int vertex0, int vertex1, int vertex2, float scalar0, float scalar1, int[] oldToNewVertex)
		{
			Vector3 vector = normals[vertex0];
			Vector3 vector2 = normals[vertex1];
			Vector3 vector3 = normals[vertex2];
			Vector4 vector4 = tangents[vertex0];
			Vector4 vector5 = tangents[vertex1];
			Vector4 vector6 = tangents[vertex2];
			Vector2 vector7 = uvs[vertex0];
			Vector2 vector8 = uvs[vertex1];
			Vector2 vector9 = uvs[vertex2];
			Vector3 normal = default(Vector3);
			normal.x = vector.x + (vector2.x - vector.x) * scalar0;
			normal.y = vector.y + (vector2.y - vector.y) * scalar0;
			normal.z = vector.z + (vector2.z - vector.z) * scalar0;
			normal.Normalize();
			Vector3 normal2 = default(Vector3);
			normal2.x = vector2.x + (vector3.x - vector2.x) * scalar1;
			normal2.y = vector2.y + (vector3.y - vector2.y) * scalar1;
			normal2.z = vector2.z + (vector3.z - vector2.z) * scalar1;
			normal2.Normalize();
			Vector4 tangent = default(Vector4);
			tangent.x = vector4.x + (vector5.x - vector4.x) * scalar0;
			tangent.y = vector4.y + (vector5.y - vector4.y) * scalar0;
			tangent.z = vector4.z + (vector5.z - vector4.z) * scalar0;
			tangent.Normalize();
			tangent.w = vector4.w;
			Vector4 tangent2 = default(Vector4);
			tangent2.x = vector5.x + (vector6.x - vector5.x) * scalar1;
			tangent2.y = vector5.y + (vector6.y - vector5.y) * scalar1;
			tangent2.z = vector5.z + (vector6.z - vector5.z) * scalar1;
			tangent2.Normalize();
			tangent2.w = vector5.w;
			Vector2 uv = default(Vector2);
			uv.x = vector7.x + (vector8.x - vector7.x) * scalar0;
			uv.y = vector7.y + (vector8.y - vector7.y) * scalar0;
			Vector2 uv2 = default(Vector2);
			uv2.x = vector8.x + (vector9.x - vector8.x) * scalar1;
			uv2.y = vector8.y + (vector9.y - vector8.y) * scalar1;
			topHull.AddVertex(topEdge0.point0.position, normal, tangent, uv, topEdge0.point0, out var index);
			topHull.AddVertex(topEdge1.point0.position, normal2, tangent2, uv2, topEdge1.point0, out var index2);
			bottomHull.AddVertex(bottomEdge0.point0.position, normal, tangent, uv, bottomEdge0.point0, out var index3);
			bottomHull.AddVertex(bottomEdge1.point0.position, normal2, tangent2, uv2, bottomEdge1.point0, out var index4);
			Triangle item = new Triangle(index, oldToNewVertex[vertex1], index2, topEdge0.point0, topEdge0.point1, topEdge1.point0, topEdge0, topEdge1, topCutEdge);
			topHull.triangles.Add(item);
			Edge edge = new Edge(bottomEdge0.point1, bottomEdge1.point0);
			Triangle item2 = new Triangle(oldToNewVertex[vertex0], index3, index4, bottomEdge0.point1, bottomEdge0.point0, bottomEdge1.point0, bottomEdge0, bottomCutEdge, edge);
			Triangle item3 = new Triangle(oldToNewVertex[vertex0], index4, oldToNewVertex[vertex2], bottomEdge0.point1, bottomEdge1.point0, bottomEdge1.point1, edge, bottomEdge1, bottomEdge2);
			bottomHull.edges.Add(edge);
			bottomHull.triangles.Add(item2);
			bottomHull.triangles.Add(item3);
		}

		protected void SortCutEdges(IList<Edge> edgesA, IList<Edge> edgesB)
		{
			Edge edge = null;
			for (int i = 0; i < edgesA.Count; i++)
			{
				if (edge == null)
				{
					edge = edgesA[i];
					continue;
				}
				Edge edge2 = edgesA[i - 1];
				for (int j = i; j < edgesA.Count; j++)
				{
					Edge edge3 = edgesA[j];
					if (edge2.point1 == edge3.point0)
					{
						Edge value = edgesA[i];
						edgesA[i] = edge3;
						edgesA[j] = value;
						Edge value2 = edgesB[i];
						edgesB[i] = edgesB[j];
						edgesB[j] = value2;
						if (edge3.point1 == edge.point0)
						{
							edge = null;
						}
						break;
					}
				}
			}
		}

		protected void FillCutEdges(LegacyHull a, LegacyHull b, IList<Edge> edgesA, IList<Edge> edgesB, Vector3 planeNormal, UvMapper uvMapper)
		{
			int count = edgesA.Count;
			Vector3[] array = new Vector3[count];
			int[] array2 = new int[count * 2];
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				int num2 = i;
				int num3 = (i + 1) % count;
				Edge edge = edgesA[num2];
				Edge edge2 = edgesA[num3];
				array[i] = edge.point0.position;
				array2[i * 2] = num2;
				if (edge.point1 == edge2.point0)
				{
					array2[i * 2 + 1] = num3;
					continue;
				}
				array2[i * 2 + 1] = num;
				num = num3;
			}
			((ITriangulator)new Triangulator(array, array2, planeNormal)).Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges);
			Vector3 normal = -planeNormal;
			uvMapper.Map(array, planeNormal, out var tangentsA, out var tangentsB, out var uvsA, out var uvsB);
			int[] array3 = new int[count];
			int[] array4 = new int[count];
			for (int j = 0; j < count; j++)
			{
				a.AddVertex(array[j], normal, tangentsA[j], uvsA[j], edgesA[j].point0, out array3[j]);
				b.AddVertex(array[j], planeNormal, tangentsB[j], uvsB[j], edgesB[j].point0, out array4[j]);
			}
			for (int k = 0; k < newEdges.Length / 2; k++)
			{
				int index = newEdges[k * 2];
				int index2 = newEdges[k * 2 + 1];
				Edge item = new Edge(edgesA[index].point0, edgesA[index2].point0);
				Edge item2 = new Edge(edgesB[index].point0, edgesB[index2].point0);
				edgesA.Add(item);
				edgesB.Add(item2);
				a.edges.Add(item);
				b.edges.Add(item2);
			}
			for (int l = 0; l < newTriangles.Length / 3; l++)
			{
				int num4 = newTriangles[l * 3];
				int num5 = newTriangles[l * 3 + 1];
				int num6 = newTriangles[l * 3 + 2];
				int index3 = newTriangleEdges[l * 3];
				int index4 = newTriangleEdges[l * 3 + 1];
				int index5 = newTriangleEdges[l * 3 + 2];
				Triangle item3 = new Triangle(array3[num4], array3[num6], array3[num5], edgesA[num4].point0, edgesA[num6].point0, edgesA[num5].point0, edgesA[index5], edgesA[index4], edgesA[index3]);
				Triangle item4 = new Triangle(array4[num4], array4[num5], array4[num6], edgesB[num4].point0, edgesB[num5].point0, edgesB[num6].point0, edgesB[index3], edgesB[index4], edgesB[index5]);
				a.triangles.Add(item3);
				b.triangles.Add(item4);
			}
		}

		protected void ValidateOutput(LegacyHull a, LegacyHull b, Vector3 planeNormal)
		{
			float num = a.LengthAlongAxis(planeNormal);
			float num2 = b.LengthAlongAxis(planeNormal);
			float num3 = num + num2;
			if (num3 < smallestValidLength)
			{
				a.Clear();
				b.Clear();
			}
			else if (num / num3 < smallestValidRatio)
			{
				a.Clear();
			}
			else if (num2 / num3 < smallestValidRatio)
			{
				b.Clear();
			}
		}

		protected float LengthAlongAxis(Vector3 axis)
		{
			float num = 0f;
			float num2 = 0f;
			for (int i = 0; i < points.Count; i++)
			{
				float num3 = Vector3.Dot(points[i].position, axis);
				if (i == 0)
				{
					num = num3;
					num2 = num3;
				}
				else
				{
					num = Mathf.Min(num3, num);
					num2 = Mathf.Max(num3, num2);
				}
			}
			return num2 - num;
		}
	}
	public class Point
	{
		public int index;

		public Vector3 position;

		public Point(Vector3 position)
		{
			this.position = position;
		}
	}
	public class Triangle
	{
		public int vertex0;

		public int vertex1;

		public int vertex2;

		public Point point0;

		public Point point1;

		public Point point2;

		public Edge edge0;

		public Edge edge1;

		public Edge edge2;

		public Triangle(int vertex0, int vertex1, int vertex2, Point point0, Point point1, Point point2, Edge edge0, Edge edge1, Edge edge2)
		{
			this.vertex0 = vertex0;
			this.vertex1 = vertex1;
			this.vertex2 = vertex2;
			this.point0 = point0;
			this.point1 = point1;
			this.point2 = point2;
			this.edge0 = edge0;
			this.edge1 = edge1;
			this.edge2 = edge2;
		}
	}
	public interface ITriangulator
	{
		void Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges);
	}
	public class Triangulator : ITriangulator
	{
		protected List<Vector3> points;

		protected List<int> edges;

		protected List<int> triangles;

		protected List<int> triangleEdges;

		protected List<List<int>> loops;

		protected List<List<bool>> concavities;

		protected List<int> duplicateEdges;

		protected Vector3 planeNormal;

		protected int originalEdgeCount;

		public Triangulator(IList<Vector3> points, IList<int> edges, Vector3 planeNormal)
		{
			this.points = new List<Vector3>(points);
			this.edges = new List<int>(edges);
			triangles = new List<int>();
			triangleEdges = new List<int>();
			this.planeNormal = planeNormal;
			originalEdgeCount = this.edges.Count;
		}

		public void Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
		{
			FindLoops();
			FindConcavities();
			PrepareDuplicateEdges();
			for (int i = 0; i < loops.Count; i++)
			{
				List<int> list = loops[i];
				List<bool> list2 = concavities[i];
				int num = 0;
				int num2 = 0;
				while (list.Count >= 3)
				{
					int zero = ((num == 0) ? (list.Count - 1) : (num - 1));
					int num3 = num;
					int second = (num + 1) % list.Count;
					int third = (num + 2) % list.Count;
					if (list2[num3] || IsTriangleOverlappingLoop(num3, second, third, list, list2))
					{
						num++;
						num2++;
					}
					else
					{
						if (MergeLoops(num3, second, third, list, list2, out var swallowedLoopIndex))
						{
							if (swallowedLoopIndex < i)
							{
								i--;
							}
						}
						else
						{
							FillTriangle(zero, num3, second, third, list, list2);
						}
						num2 = 0;
					}
					if (num2 >= list.Count)
					{
						break;
					}
					if (num >= list.Count)
					{
						num = 0;
						num2 = 0;
					}
				}
				if (list.Count <= 2)
				{
					loops.RemoveAt(i);
					concavities.RemoveAt(i);
					i--;
				}
			}
			for (int j = 0; j < loops.Count; j++)
			{
				List<int> list3 = loops[j];
				List<bool> concavity = concavities[j];
				while (list3.Count >= 3)
				{
					FillTriangle(0, 1, 2, 3 % list3.Count, list3, concavity);
				}
			}
			RemoveDuplicateEdges();
			SetOutput(out newEdges, out newTriangles, out newTriangleEdges);
		}

		protected void FindLoops()
		{
			loops = new List<List<int>>();
			List<int> list = new List<int>(edges.Count / 2);
			for (int i = 0; i < edges.Count / 2; i++)
			{
				int num = i * 2;
				int num2 = edges[num];
				int num3 = edges[num + 1];
				if (list.Count >= 1)
				{
					int num4 = edges[num - 1];
					if (num2 != num4)
					{
						UnityEngine.Debug.LogError("The edges do not form an edge loop!");
					}
				}
				list.Add(num);
				if (num3 == edges[list[0]])
				{
					loops.Add(list);
					list = new List<int>();
				}
			}
		}

		protected void FindConcavities()
		{
			concavities = new List<List<bool>>();
			foreach (List<int> loop in loops)
			{
				List<bool> list = new List<bool>(loop.Count);
				for (int i = 0; i < loop.Count; i++)
				{
					int index = edges[loop[i]];
					int index2 = edges[loop[(i + 1) % loop.Count]];
					int index3 = edges[loop[(i + 2) % loop.Count]];
					Vector3 line = points[index2] - points[index];
					Vector3 line2 = points[index3] - points[index2];
					list.Add(IsLinePairConcave(ref line, ref line2));
				}
				concavities.Add(list);
			}
		}

		protected void PrepareDuplicateEdges()
		{
			duplicateEdges = new List<int>();
		}

		protected void ValidateConcavities()
		{
			for (int i = 0; i < loops.Count; i++)
			{
				IList<int> list = loops[i];
				IList<bool> list2 = concavities[i];
				for (int j = 0; j < list.Count; j++)
				{
					int index = edges[list[j]];
					int index2 = edges[list[(j + 1) % list.Count]];
					int index3 = edges[list[(j + 2) % list.Count]];
					Vector3 line = points[index2] - points[index];
					Vector3 line2 = points[index3] - points[index2];
					if (list2[j] != IsLinePairConcave(ref line, ref line2))
					{
						UnityEngine.Debug.LogError("Concavity not valid!");
					}
				}
			}
		}

		protected void UpdateConcavity(int index, List<int> loop, List<bool> concavity)
		{
			int num = loop[index];
			int num2 = loop[(index + 1) % loop.Count];
			Vector3 line = points[edges[num + 1]] - points[edges[num]];
			Vector3 line2 = points[edges[num2 + 1]] - points[edges[num2]];
			concavity[index] = IsLinePairConcave(ref line, ref line2);
		}

		protected bool IsLinePairConcave(ref Vector3 line0, ref Vector3 line1)
		{
			Vector3 rhs = Vector3.Cross(line0, planeNormal);
			return Vector3.Dot(line1, rhs) > 0f;
		}

		protected bool IsTriangleOverlappingLoop(int first, int second, int third, List<int> loop, List<bool> concavity)
		{
			int num = edges[loop[first]];
			int num2 = edges[loop[second]];
			int num3 = edges[loop[third]];
			Vector3 triangle = points[num];
			Vector3 triangle2 = points[num2];
			Vector3 triangle3 = points[num3];
			for (int i = 0; i < loop.Count; i++)
			{
				if (!concavity[i])
				{
					continue;
				}
				int num4 = edges[loop[i] + 1];
				if (num4 != num && num4 != num2 && num4 != num3)
				{
					Vector3 point = points[num4];
					if (Tools.IsPointInsideTriangle(ref point, ref triangle, ref triangle2, ref triangle3, ref planeNormal))
					{
						return true;
					}
				}
			}
			return false;
		}

		protected bool MergeLoops(int first, int second, int third, List<int> loop, List<bool> concavity, out int swallowedLoopIndex)
		{
			if (FindClosestPointInTriangle(first, second, third, loop, out var loopIndex, out var loopLocation))
			{
				InsertLoop(first, loop, concavity, loopLocation, loops[loopIndex], concavities[loopIndex]);
				loops.RemoveAt(loopIndex);
				concavities.RemoveAt(loopIndex);
				swallowedLoopIndex = loopIndex;
				return true;
			}
			swallowedLoopIndex = -1;
			return false;
		}

		protected bool FindClosestPointInTriangle(int first, int second, int third, List<int> loop, out int loopIndex, out int loopLocation)
		{
			Vector3 triangle = points[edges[loop[first]]];
			Vector3 triangle2 = points[edges[loop[second]]];
			Vector3 triangle3 = points[edges[loop[third]]];
			Vector3 rhs = Vector3.Cross(planeNormal, triangle2 - triangle);
			int num = -1;
			int num2 = 0;
			float num3 = 0f;
			for (int i = 0; i < loops.Count; i++)
			{
				IList<int> list = loops[i];
				IList<bool> list2 = concavities[i];
				if (list == loop)
				{
					continue;
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (!list2[j])
					{
						continue;
					}
					Vector3 point = points[edges[list[j] + 1]];
					if (Tools.IsPointInsideTriangle(ref point, ref triangle, ref triangle2, ref triangle3, ref planeNormal))
					{
						float num4 = Vector3.Dot(point - triangle, rhs);
						if (num4 < num3 || num == -1)
						{
							num = i;
							num2 = (j + 1) % list.Count;
							num3 = num4;
						}
					}
				}
			}
			loopIndex = num;
			loopLocation = num2;
			return num != -1;
		}

		protected void InsertLoop(int insertLocation, List<int> loop, List<bool> concavity, int otherAnchorLocation, List<int> otherLoop, List<bool> otherConcavity)
		{
			int item = edges[loop[insertLocation]];
			int item2 = edges[otherLoop[otherAnchorLocation]];
			int count = edges.Count;
			edges.Add(item2);
			edges.Add(item);
			int count2 = edges.Count;
			edges.Add(item);
			edges.Add(item2);
			duplicateEdges.Add(count2);
			int[] array = new int[otherLoop.Count + 2];
			bool[] array2 = new bool[otherConcavity.Count + 2];
			int num = 0;
			array[num] = count2;
			array2[num++] = false;
			for (int i = otherAnchorLocation; i < otherLoop.Count; i++)
			{
				array[num] = otherLoop[i];
				array2[num++] = otherConcavity[i];
			}
			for (int j = 0; j < otherAnchorLocation; j++)
			{
				array[num] = otherLoop[j];
				array2[num++] = otherConcavity[j];
			}
			array[num] = count;
			array2[num] = false;
			loop.InsertRange(insertLocation, array);
			concavity.InsertRange(insertLocation, array2);
			int index = ((insertLocation == 0) ? (loop.Count - 1) : (insertLocation - 1));
			UpdateConcavity(index, loop, concavity);
			UpdateConcavity(insertLocation, loop, concavity);
			UpdateConcavity(insertLocation + otherLoop.Count, loop, concavity);
			UpdateConcavity(insertLocation + otherLoop.Count + 1, loop, concavity);
		}

		protected void FillTriangle(int zero, int first, int second, int third, List<int> loop, List<bool> concavity)
		{
			int index = loop[zero];
			int num = loop[first];
			int num2 = loop[second];
			int num3 = loop[third];
			int num4 = edges[num];
			int item = edges[num2];
			int num5 = edges[num3];
			int num6;
			if (loop.Count != 3)
			{
				num6 = edges.Count;
				edges.Add(num4);
				edges.Add(num5);
			}
			else
			{
				num6 = num3;
			}
			triangles.Add(num4);
			triangles.Add(item);
			triangles.Add(num5);
			triangleEdges.Add(num);
			triangleEdges.Add(num2);
			triangleEdges.Add(num6);
			loop[second] = num6;
			loop.RemoveAt(first);
			Vector3 line = points[num4] - points[edges[index]];
			Vector3 line2 = points[num5] - points[num4];
			Vector3 line3 = points[edges[num3 + 1]] - points[num5];
			concavity[zero] = IsLinePairConcave(ref line, ref line2);
			concavity[second] = IsLinePairConcave(ref line2, ref line3);
			concavity.RemoveAt(first);
		}

		protected void RemoveDuplicateEdges()
		{
			for (int i = 0; i < duplicateEdges.Count; i++)
			{
				int num = duplicateEdges[i];
				edges.RemoveRange(num, 2);
				for (int j = 0; j < triangleEdges.Count; j++)
				{
					if (triangleEdges[j] >= num)
					{
						triangleEdges[j] -= 2;
					}
				}
				for (int k = i + 1; k < duplicateEdges.Count; k++)
				{
					if (duplicateEdges[k] >= num)
					{
						duplicateEdges[k] -= 2;
					}
				}
			}
		}

		protected void SetOutput(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
		{
			int num = edges.Count - originalEdgeCount;
			if (num > 0)
			{
				newEdges = new int[num];
				edges.CopyTo(originalEdgeCount, newEdges, 0, num);
			}
			else
			{
				newEdges = new int[0];
			}
			newTriangles = triangles.ToArray();
			newTriangleEdges = new int[triangleEdges.Count];
			for (int i = 0; i < triangleEdges.Count; i++)
			{
				newTriangleEdges[i] = triangleEdges[i] / 2;
			}
		}
	}
	public abstract class ColorMapper : MonoBehaviour
	{
		public abstract void Map(IList<Vector3> points, Vector3 planeNormal, out Color32[] colorsA, out Color32[] colorsB);
	}
	public abstract class UvMapper : MonoBehaviour
	{
		public abstract void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB);
	}
	[RequireComponent(typeof(MeshFilter))]
	public class ShatterTool : MonoBehaviour
	{
		[SerializeField]
		protected int generation = 1;

		[SerializeField]
		protected int generationLimit = 3;

		[SerializeField]
		protected int cuts = 2;

		[SerializeField]
		protected bool fillCut = true;

		[SerializeField]
		protected bool sendPreSplitMessage;

		[SerializeField]
		protected bool sendPostSplitMessage;

		[SerializeField]
		protected HullType internalHullType;

		protected bool isIntact = true;

		protected IHull hull;

		protected Vector3 center;

		private SplitProperty splitProperty;

		public int Generation
		{
			get
			{
				return generation;
			}
			set
			{
				generation = Mathf.Max(value, 1);
			}
		}

		public int GenerationLimit
		{
			get
			{
				return generationLimit;
			}
			set
			{
				generationLimit = Mathf.Max(value, 1);
			}
		}

		public int Cuts
		{
			get
			{
				return cuts;
			}
			set
			{
				cuts = Mathf.Max(value, 1);
			}
		}

		public bool FillCut
		{
			get
			{
				return fillCut;
			}
			set
			{
				fillCut = value;
			}
		}

		public bool SendPreSplitMessage
		{
			get
			{
				return sendPreSplitMessage;
			}
			set
			{
				sendPreSplitMessage = value;
			}
		}

		public bool SendPostSplitMessage
		{
			get
			{
				return sendPostSplitMessage;
			}
			set
			{
				sendPostSplitMessage = value;
			}
		}

		public HullType InternalHullType
		{
			get
			{
				return internalHullType;
			}
			set
			{
				internalHullType = value;
			}
		}

		public bool IsFirstGeneration => generation == 1;

		public bool IsLastGeneration => generation >= generationLimit;

		public Vector3 Center => base.transform.TransformPoint(center);

		protected void CalculateCenter()
		{
			center = GetComponent<MeshFilter>().sharedMesh.bounds.center;
		}

		public void Start()
		{
			Mesh sharedMesh = GetComponent<MeshFilter>().sharedMesh;
			splitProperty = GetComponent<SplitProperty>();
			if (hull == null)
			{
				if (internalHullType == HullType.FastHull)
				{
					hull = new FastHull(sharedMesh);
				}
				else if (internalHullType == HullType.LegacyHull)
				{
					hull = new LegacyHull(sharedMesh);
				}
			}
			CalculateCenter();
		}

		public void Shatter(Vector3 point, Ball.BallCollisionInfo ballCollisionInfo = null)
		{
			if (!IsLastGeneration)
			{
				generation++;
				Plane[] array = new Plane[cuts];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new Plane(UnityEngine.Random.onUnitSphere, point);
				}
				Split(array, ballCollisionInfo);
			}
		}

		public void Split(Plane[] planes, Ball.BallCollisionInfo ballCollisionInfo = null)
		{
			if (planes != null && planes.Length != 0 && isIntact && hull != null && !hull.IsEmpty)
			{
				UvMapper component = GetComponent<UvMapper>();
				ColorMapper component2 = GetComponent<ColorMapper>();
				if (sendPreSplitMessage)
				{
					SendMessage("PreSplit", planes, SendMessageOptions.DontRequireReceiver);
				}
				ConvertPlanesToLocalspace(planes, out var points, out var normals);
				CreateNewHulls(component, component2, points, normals, out var newHulls);
				CreateNewGameObjects(newHulls, out var newGameObjects, ballCollisionInfo);
				if (sendPostSplitMessage)
				{
					SendMessage("PostSplit", newGameObjects, SendMessageOptions.DontRequireReceiver);
				}
				base.gameObject.SetActive(value: false);
				generation--;
			}
		}

		protected void ConvertPlanesToLocalspace(Plane[] planes, out Vector3[] points, out Vector3[] normals)
		{
			points = new Vector3[planes.Length];
			normals = new Vector3[planes.Length];
			for (int i = 0; i < planes.Length; i++)
			{
				Plane plane = planes[i];
				Vector3 vector = base.transform.InverseTransformPoint(plane.normal * (0f - plane.distance));
				Vector3 vector2 = base.transform.InverseTransformDirection(plane.normal);
				vector2.Scale(base.transform.localScale);
				vector2.Normalize();
				points[i] = vector;
				normals[i] = vector2;
			}
		}

		protected void CreateNewHulls(UvMapper uvMapper, ColorMapper colorMapper, Vector3[] points, Vector3[] normals, out IList<IHull> newHulls)
		{
			newHulls = new List<IHull>();
			newHulls.Add(this.hull);
			for (int i = 0; i < points.Length; i++)
			{
				int count = newHulls.Count;
				for (int j = 0; j < count; j++)
				{
					IHull hull = newHulls[0];
					hull.Split(points[i], normals[i], fillCut, uvMapper, colorMapper, out var resultA, out var resultB);
					newHulls.Remove(hull);
					if (!resultA.IsEmpty)
					{
						newHulls.Add(resultA);
					}
					if (!resultB.IsEmpty)
					{
						newHulls.Add(resultB);
					}
				}
			}
		}

		protected void CreateNewGameObjects(IList<IHull> newHulls, out GameObject[] newGameObjects, Ball.BallCollisionInfo ballCollisionInfo = null)
		{
			Mesh[] array = new Mesh[newHulls.Count];
			float[] array2 = new float[newHulls.Count];
			float num = 0f;
			for (int i = 0; i < newHulls.Count; i++)
			{
				Mesh mesh = newHulls[i].GetMesh();
				Vector3 size = mesh.bounds.size;
				float num2 = size.x * size.y * size.z;
				array[i] = mesh;
				array2[i] = num2;
				num += num2;
			}
			GetComponent<MeshFilter>();
			GetComponent<MeshCollider>();
			Rigidbody component = GetComponent<Rigidbody>();
			newGameObjects = new GameObject[newHulls.Count];
			for (int j = 0; j < newHulls.Count; j++)
			{
				IHull hull = newHulls[j];
				Mesh sharedMesh = array[j];
				_ = array2[j];
				GameObject gameObject = UnityEngine.Object.Instantiate(base.gameObject);
				gameObject.transform.position = base.gameObject.transform.position;
				gameObject.transform.rotation = base.gameObject.transform.rotation;
				ShatterTool component2 = gameObject.GetComponent<ShatterTool>();
				if (component2 != null)
				{
					component2.hull = hull;
				}
				MeshFilter component3 = gameObject.GetComponent<MeshFilter>();
				if (component3 != null)
				{
					component3.sharedMesh = sharedMesh;
				}
				MeshCollider component4 = gameObject.GetComponent<MeshCollider>();
				if (component4 != null)
				{
					component4.sharedMesh = sharedMesh;
				}
				Rigidbody component5 = gameObject.GetComponent<Rigidbody>();
				if (component != null && component5 != null)
				{
					splitProperty?.newGameObjectSpecialSet(component5, ballCollisionInfo);
					if (!component5.isKinematic)
					{
						component5.velocity = component.GetPointVelocity(component5.worldCenterOfMass);
						component5.angularVelocity = component.angularVelocity;
					}
				}
				component2.CalculateCenter();
				newGameObjects[j] = gameObject;
			}
		}
	}
	public class SolidColorMapper : ColorMapper
	{
		public Color32 fillColor = Color.cyan;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Color32[] colorsA, out Color32[] colorsB)
		{
			Color32[] array = new Color32[points.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = fillColor;
			}
			colorsA = array;
			colorsB = array;
		}
	}
	public class TargetUvMapper : UvMapper
	{
		public Vector2 targetStart = Vector2.zero;

		public Vector2 targetSize = Vector2.one;

		public bool square;

		public bool centerMeshOrigo;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB)
		{
			Vector3 vector = Vector3.Cross(planeNormal, Vector3.up);
			if (vector == Vector3.zero)
			{
				vector = Vector3.Cross(planeNormal, Vector3.forward);
			}
			Vector3 rhs = Vector3.Cross(vector, planeNormal);
			vector.Normalize();
			rhs.Normalize();
			Vector4 vector2 = new Vector4(vector.x, vector.y, vector.z, 1f);
			Vector4 vector3 = new Vector4(vector.x, vector.y, vector.z, -1f);
			tangentsA = new Vector4[points.Count];
			tangentsB = new Vector4[points.Count];
			for (int i = 0; i < points.Count; i++)
			{
				tangentsA[i] = vector2;
				tangentsB[i] = vector3;
			}
			Vector2[] array = new Vector2[points.Count];
			Vector2 vector4 = Vector2.zero;
			Vector2 vector5 = Vector2.zero;
			for (int j = 0; j < points.Count; j++)
			{
				Vector3 lhs = points[j];
				array[j].x = Vector3.Dot(lhs, vector);
				array[j].y = Vector3.Dot(lhs, rhs);
				if (j == 0)
				{
					vector4 = array[j];
					vector5 = array[j];
				}
				else
				{
					vector4 = Vector2.Min(array[j], vector4);
					vector5 = Vector2.Max(array[j], vector5);
				}
			}
			Vector2 vector6 = vector5 - vector4;
			if (square)
			{
				float num = Mathf.Max(vector6.x, vector6.y);
				Vector2 vector7 = default(Vector2);
				vector7.x = (num - vector6.x) * 0.5f;
				vector7.y = (num - vector6.y) * 0.5f;
				vector4 -= vector7;
				vector5 += vector7;
			}
			if (centerMeshOrigo)
			{
				Vector2 vector8 = default(Vector2);
				vector8.x = Mathf.Max(Mathf.Abs(vector4.x), Mathf.Abs(vector5.x));
				vector8.y = Mathf.Max(Mathf.Abs(vector4.y), Mathf.Abs(vector5.y));
				vector4 = -vector8;
				vector5 = vector8;
			}
			Vector2 vector9 = vector5 - vector4;
			Vector2 vector10 = new Vector2(1f / vector9.x, 1f / vector9.y);
			for (int k = 0; k < points.Count; k++)
			{
				array[k].x = (array[k].x - vector4.x) * vector10.x;
				array[k].y = (array[k].y - vector4.y) * vector10.y;
				array[k].x = targetStart.x + targetSize.x * array[k].x;
				array[k].y = targetStart.y + targetSize.y * array[k].y;
			}
			uvsA = array;
			uvsB = array;
		}
	}
	public class WorldUvMapper : UvMapper
	{
		public Vector2 scale = Vector2.one;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB)
		{
			Vector3 vector = Vector3.Cross(planeNormal, Vector3.up);
			if (vector == Vector3.zero)
			{
				vector = Vector3.Cross(planeNormal, Vector3.forward);
			}
			Vector3 rhs = Vector3.Cross(vector, planeNormal);
			vector.Normalize();
			rhs.Normalize();
			Vector4 vector2 = new Vector4(vector.x, vector.y, vector.z, 1f);
			Vector4 vector3 = new Vector4(vector.x, vector.y, vector.z, -1f);
			tangentsA = new Vector4[points.Count];
			tangentsB = new Vector4[points.Count];
			for (int i = 0; i < points.Count; i++)
			{
				tangentsA[i] = vector2;
				tangentsB[i] = vector3;
			}
			Vector2[] array = new Vector2[points.Count];
			Vector2 vector4 = Vector2.zero;
			for (int j = 0; j < points.Count; j++)
			{
				Vector3 lhs = points[j];
				array[j].x = Vector3.Dot(lhs, vector);
				array[j].y = Vector3.Dot(lhs, rhs);
				vector4 = ((j != 0) ? Vector2.Min(array[j], vector4) : array[j]);
			}
			for (int k = 0; k < points.Count; k++)
			{
				array[k] -= vector4;
				array[k].x *= scale.x;
				array[k].y *= scale.y;
			}
			uvsA = array;
			uvsB = array;
		}
	}
}
namespace ShatterToolkit.Helpers
{
	[RequireComponent(typeof(ShatterTool))]
	public class HierarchyHandler : MonoBehaviour
	{
		public bool attachPieceToParent = true;

		public float maxPieceToParentDistance = 1f;

		public bool addRbToDetachedPieces = true;

		public bool attachChildrenToPieces = true;

		public float maxChildToPieceDistance = 1f;

		public bool addRbToDetachedChildren = true;

		protected Transform parent;

		protected Transform[] children;

		public void PreSplit(Plane[] planes)
		{
			if (base.transform.parent != null)
			{
				parent = base.transform.parent;
				base.transform.parent = null;
			}
			children = new Transform[base.transform.childCount];
			int num = 0;
			foreach (Transform item in base.transform)
			{
				children[num++] = item;
			}
			base.transform.DetachChildren();
		}

		public void PostSplit(GameObject[] newGameObjects)
		{
			ShatterTool[] array = new ShatterTool[newGameObjects.Length];
			for (int i = 0; i < newGameObjects.Length; i++)
			{
				array[i] = newGameObjects[i].GetComponent<ShatterTool>();
			}
			if (parent != null)
			{
				ShatterTool component = parent.GetComponent<ShatterTool>();
				if (component != null)
				{
					ShatterTool shatterTool = null;
					if (attachPieceToParent)
					{
						shatterTool = FindClosestPiece(component, array, maxPieceToParentDistance);
						if (shatterTool != null)
						{
							shatterTool.transform.parent = parent;
						}
					}
					if (addRbToDetachedPieces)
					{
						ShatterTool[] array2 = array;
						foreach (ShatterTool shatterTool2 in array2)
						{
							if (shatterTool2 != null && shatterTool2 != shatterTool)
							{
								shatterTool2.gameObject.AddComponent<Rigidbody>();
							}
						}
					}
				}
			}
			Transform[] array3 = children;
			foreach (Transform transform in array3)
			{
				ShatterTool component2 = transform.GetComponent<ShatterTool>();
				if (component2 != null)
				{
					ShatterTool shatterTool3 = FindClosestPiece(component2, array, maxChildToPieceDistance);
					if (attachChildrenToPieces && shatterTool3 != null)
					{
						transform.parent = shatterTool3.transform;
					}
					else if (addRbToDetachedChildren)
					{
						transform.gameObject.AddComponent<Rigidbody>();
					}
				}
			}
		}

		protected ShatterTool FindClosestPiece(ShatterTool reference, ShatterTool[] pieces, float maxDistance)
		{
			Vector3 center = reference.Center;
			float num = maxDistance * maxDistance;
			ShatterTool shatterTool = null;
			float num2 = 0f;
			foreach (ShatterTool shatterTool2 in pieces)
			{
				if (shatterTool2 != null)
				{
					float sqrMagnitude = (center - shatterTool2.Center).sqrMagnitude;
					if (sqrMagnitude < num && (sqrMagnitude < num2 || shatterTool == null))
					{
						shatterTool = shatterTool2;
						num2 = sqrMagnitude;
					}
				}
			}
			return shatterTool;
		}
	}
	[RequireComponent(typeof(ShatterTool))]
	public class PieceRemover : MonoBehaviour
	{
		public int startAtGeneration = 3;

		public float timeDelay = 5f;

		public bool whenOutOfViewOnly = true;

		protected ShatterTool shatterTool;

		protected Renderer renderer;

		protected float timeSinceInstantiated;

		private float collisionBoxTimer = 0.1f;

		public void Start()
		{
			shatterTool = GetComponent<ShatterTool>();
			renderer = GetComponent<Renderer>();
		}

		public void Update()
		{
			if (shatterTool.Generation >= startAtGeneration)
			{
				timeSinceInstantiated += Time.deltaTime;
				if (timeSinceInstantiated >= collisionBoxTimer)
				{
					UnityEngine.Object.Destroy(GetComponent<Collider>());
				}
				if (timeSinceInstantiated >= timeDelay && (!whenOutOfViewOnly || !renderer.isVisible))
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
		}
	}
	public class ShatterOnCollision : MonoBehaviour
	{
		public float requiredVelocity = 1f;

		public float cooldownTime = 0.5f;

		protected float timeSinceInstantiated;

		public void Update()
		{
			timeSinceInstantiated += Time.deltaTime;
		}

		public void OnCollisionEnter(Collision collision)
		{
			if (!(timeSinceInstantiated >= cooldownTime) || !(collision.relativeVelocity.magnitude >= requiredVelocity) || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("DestroyedSpike"))
			{
				return;
			}
			ContactPoint[] contacts = collision.contacts;
			for (int i = 0; i < contacts.Length; i++)
			{
				ContactPoint contactPoint = contacts[i];
				if (contactPoint.otherCollider == collision.collider)
				{
					contactPoint.thisCollider.SendMessage("Shatter", contactPoint.point, SendMessageOptions.DontRequireReceiver);
					break;
				}
			}
		}
	}
	public class MouseForce : MonoBehaviour
	{
		public float impulseScale = 25f;

		protected Rigidbody grabBody;

		protected Vector3 grabPoint;

		protected float grabDistance;

		public void Update()
		{
			GrabBody();
			ReleaseBody();
		}

		public void FixedUpdate()
		{
			MoveBody();
		}

		protected void GrabBody()
		{
			if (grabBody == null && Input.GetMouseButtonDown(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo) && hitInfo.rigidbody != null)
			{
				grabBody = hitInfo.rigidbody;
				grabPoint = grabBody.transform.InverseTransformPoint(hitInfo.point);
				grabDistance = hitInfo.distance;
			}
		}

		protected void ReleaseBody()
		{
			if (grabBody != null && Input.GetMouseButtonUp(0))
			{
				grabBody = null;
			}
		}

		protected void MoveBody()
		{
			if (grabBody != null)
			{
				Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, grabDistance);
				Vector3 vector = Camera.main.ScreenToWorldPoint(position);
				Vector3 vector2 = grabBody.transform.TransformPoint(grabPoint);
				UnityEngine.Debug.DrawLine(vector, vector2, Color.red);
				Vector3 force = (vector - vector2) * (impulseScale * Time.fixedDeltaTime);
				grabBody.AddForceAtPosition(force, vector2, ForceMode.Impulse);
			}
		}
	}
	public class MouseInstantiate : MonoBehaviour
	{
		public GameObject prefabToInstantiate;

		public float speed = 7f;

		public void Update()
		{
			if (Input.GetMouseButtonDown(0) && prefabToInstantiate != null)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Rigidbody component = UnityEngine.Object.Instantiate(prefabToInstantiate, ray.origin, Quaternion.identity).GetComponent<Rigidbody>();
				if (component != null)
				{
					component.velocity = ray.direction * speed;
				}
			}
		}
	}
	public class MouseShatter : MonoBehaviour
	{
		public void Update()
		{
			if (Input.GetMouseButtonDown(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo))
			{
				hitInfo.collider.SendMessage("Shatter", hitInfo.point, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	public class MouseSplit : MonoBehaviour
	{
		public int raycastCount = 5;

		protected bool started;

		protected Vector3 start;

		protected Vector3 end;

		public void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				start = Input.mousePosition;
				started = true;
			}
			if (!Input.GetMouseButtonUp(0) || !started)
			{
				return;
			}
			end = Input.mousePosition;
			Camera main = Camera.main;
			float nearClipPlane = main.nearClipPlane;
			Vector3 lhs = main.ScreenToWorldPoint(new Vector3(end.x, end.y, nearClipPlane)) - main.ScreenToWorldPoint(new Vector3(start.x, start.y, nearClipPlane));
			for (int i = 0; i < raycastCount; i++)
			{
				Ray ray = main.ScreenPointToRay(Vector3.Lerp(start, end, (float)i / (float)raycastCount));
				if (Physics.Raycast(ray, out var hitInfo))
				{
					Plane plane = new Plane(Vector3.Normalize(Vector3.Cross(lhs, ray.direction)), hitInfo.point);
					hitInfo.collider.SendMessage("Split", new Plane[1] { plane }, SendMessageOptions.DontRequireReceiver);
					break;
				}
			}
			started = false;
		}
	}
}
namespace ShatterToolkit.Examples
{
	[RequireComponent(typeof(MouseForce), typeof(MouseSplit), typeof(MouseShatter))]
	public class MouseGUI : MonoBehaviour
	{
		public int defaultSelection;

		protected MouseForce mouseForce;

		protected MouseSplit mouseSplit;

		protected MouseShatter mouseShatter;

		protected int toolbarSelection;

		protected string[] toolbarLabels = new string[3] { "Mouse force (Click and drag)", "Mouse split (Click and drag, release)", "Mouse shatter (Click)" };

		public void Awake()
		{
			mouseForce = GetComponent<MouseForce>();
			mouseSplit = GetComponent<MouseSplit>();
			mouseShatter = GetComponent<MouseShatter>();
			toolbarSelection = defaultSelection;
			SelectTool();
		}

		public void OnGUI()
		{
			toolbarSelection = GUI.Toolbar(new Rect(10f, 10f, Screen.width - 20, 20f), toolbarSelection, toolbarLabels);
			if (GUI.changed)
			{
				SelectTool();
			}
		}

		protected void SelectTool()
		{
			mouseForce.enabled = false;
			mouseSplit.enabled = false;
			mouseShatter.enabled = false;
			if (toolbarSelection == 0)
			{
				mouseForce.enabled = true;
			}
			else if (toolbarSelection == 1)
			{
				mouseSplit.enabled = true;
			}
			else if (toolbarSelection == 2)
			{
				mouseShatter.enabled = true;
			}
		}
	}
	public class SceneGUI : MonoBehaviour
	{
		protected int toolbarSelection;

		protected string[] toolbarLabels = new string[3] { "Basic scene", "UvMapping scene", "Wall scene" };

		public void Awake()
		{
			toolbarSelection = Application.loadedLevel;
		}

		public void OnGUI()
		{
			toolbarSelection = GUI.Toolbar(new Rect(10f, Screen.height - 30, Screen.width - 20, 20f), toolbarSelection, toolbarLabels);
			if (GUI.changed)
			{
				Application.LoadLevel(toolbarSelection);
			}
		}
	}
	public class OutlineCreator : MonoBehaviour
	{
		protected List<Vector3> points = new List<Vector3>();

		protected List<int> edges = new List<int>();

		protected List<int> triangles = new List<int>();

		protected List<int> triangleEdges = new List<int>();

		protected bool isTriangulated;

		protected bool isLoopClosed;

		protected int loopStart;

		public int LoopPointCount => points.Count - loopStart;

		public void Reset()
		{
			points.Clear();
			edges.Clear();
			triangles.Clear();
			triangleEdges.Clear();
			isTriangulated = false;
			isLoopClosed = false;
			loopStart = 0;
		}

		public void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (isTriangulated)
				{
					Reset();
				}
				Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
				Vector3 item = Camera.main.ScreenToWorldPoint(position);
				points.Add(item);
				if (LoopPointCount >= 2)
				{
					edges.Add(points.Count - 2);
					edges.Add(points.Count - 1);
				}
				isLoopClosed = false;
			}
			else if (Input.GetMouseButtonDown(1) && LoopPointCount >= 3)
			{
				edges.Add(points.Count - 1);
				edges.Add(loopStart);
				isLoopClosed = true;
				loopStart = points.Count;
			}
			if (Input.GetKeyDown(KeyCode.Space) && !isTriangulated && isLoopClosed)
			{
				((ITriangulator)new Triangulator(points, edges, Vector3.up)).Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges);
				edges.AddRange(newEdges);
				triangles.AddRange(newTriangles);
				triangleEdges.AddRange(newTriangleEdges);
				isTriangulated = true;
			}
		}

		public void OnGUI()
		{
			GUI.Box(new Rect(0f, 0f, 500f, 100f), "Please turn on Gizmos!\nCreate an outline by left-clicking in a clockwise order on the screen.\nRight-click to close a loop.\nCreate a hole by left-clicking in a counter-clockwise order inside a shape.\nBe careful not to overlap edges.\nPress SPACE to triangulate the closed loops!");
		}

		public void OnDrawGizmos()
		{
			Gizmos.color = Color.black;
			for (int i = 0; i < points.Count; i++)
			{
				Gizmos.DrawSphere(points[i], 0.1f);
			}
			for (int j = 0; j < edges.Count / 2; j++)
			{
				int num = j * 2;
				Gizmos.DrawLine(points[edges[num]], points[edges[num + 1]]);
			}
			for (int k = 0; k < triangles.Count / 3; k++)
			{
				int num2 = k * 3;
				Vector3 from = (points[triangles[num2]] + points[triangles[num2 + 1]] + points[triangles[num2 + 2]]) / 3f;
				Gizmos.color = Color.red;
				Gizmos.DrawLine(from, (points[edges[triangleEdges[num2] * 2]] + points[edges[triangleEdges[num2] * 2 + 1]]) * 0.5f);
				Gizmos.color = Color.green;
				Gizmos.DrawLine(from, (points[edges[triangleEdges[num2 + 1] * 2]] + points[edges[triangleEdges[num2 + 1] * 2 + 1]]) * 0.5f);
				Gizmos.color = Color.blue;
				Gizmos.DrawLine(from, (points[edges[triangleEdges[num2 + 2] * 2]] + points[edges[triangleEdges[num2 + 2] * 2 + 1]]) * 0.5f);
			}
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	public class RotateRigidbody : MonoBehaviour
	{
		public Vector3 axis = Vector3.up;

		public float angularVelocity = 7f;

		protected Rigidbody rb;

		public void Start()
		{
			rb = GetComponent<Rigidbody>();
		}

		public void FixedUpdate()
		{
			Quaternion quaternion = Quaternion.AngleAxis(angularVelocity * Time.fixedDeltaTime, axis);
			rb.MoveRotation(rb.rotation * quaternion);
		}
	}
}
namespace AudioVisualizer
{
	[Serializable]
	public class OnFrequencyEvent : UnityEvent<float>
	{
	}
	[Serializable]
	public class OnFrequencyChanged
	{
		public OnFrequencyEvent onChange;

		public float minValue;

		public float maxValue = 1f;
	}
	public class AudioEventListener : MonoBehaviour
	{
		public delegate void BeatEvent();

		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public int sampleBufferSize = 40;

		public float beatThreshold = 1.3f;

		public bool automatic = true;

		public bool debug;

		public UnityEvent OnBeat;

		public OnFrequencyChanged onFrequencyChanged;

		public static BeatEvent BeatDetected;

		private bool canDetect = true;

		private float lastFreq;

		private float lastVariance;

		private float[] sampleBuffer;

		private int index;

		private float avgEnergy;

		private float variance;

		private float varyPercent;

		private float frequency;

		private void Awake()
		{
			sampleBuffer = new float[sampleBufferSize];
			for (int i = 0; i < sampleBuffer.Length; i++)
			{
				sampleBuffer[i] = 0f;
			}
		}

		private void FixedUpdate()
		{
			if (automatic)
			{
				AutomaticDetection();
			}
			else
			{
				CustomDetection();
			}
			HandleFrequencyEvents();
		}

		private void HandleFrequencyEvents()
		{
			if (onFrequencyChanged != null)
			{
				float num = onFrequencyChanged.maxValue - onFrequencyChanged.minValue;
				float arg = onFrequencyChanged.minValue + num * GetNormalizedFrequency();
				onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		private void CustomDetection()
		{
			if (index >= sampleBuffer.Length)
			{
				index = 0;
			}
			frequency = AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange);
			sampleBuffer[index] = frequency;
			avgEnergy = GetAvgEnergy();
			if (frequency > beatThreshold * avgEnergy)
			{
				OnBeat.Invoke();
				if (BeatDetected != null)
				{
					BeatDetected();
					if (debug)
					{
						UnityEngine.Debug.Log("Beat Detected");
					}
				}
			}
			if (debug)
			{
				UnityEngine.Debug.Log("FreqVolume: " + frequency + " beatThreshold: " + beatThreshold * avgEnergy);
			}
			index++;
		}

		private void AutomaticDetection()
		{
			if (index >= sampleBuffer.Length)
			{
				index = 0;
			}
			frequency = AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange);
			sampleBuffer[index] = frequency;
			avgEnergy = GetAvgEnergy();
			variance = GetAvgVariance(avgEnergy);
			varyPercent = 1f - (avgEnergy - variance) / avgEnergy;
			beatThreshold = 1f + varyPercent;
			if (!canDetect && frequency < (2f - beatThreshold) * avgEnergy)
			{
				canDetect = true;
			}
			if (frequency > beatThreshold * avgEnergy && canDetect)
			{
				canDetect = false;
				lastFreq = frequency;
				lastVariance = varyPercent;
				OnBeat.Invoke();
				if (BeatDetected != null)
				{
					BeatDetected();
					if (debug)
					{
						UnityEngine.Debug.Log("Beat Detected");
					}
				}
			}
			if (debug)
			{
				UnityEngine.Debug.Log("Freq: " + frequency + " beatThreshold: " + beatThreshold * avgEnergy);
			}
			index++;
		}

		public float GetNormalizedFrequency()
		{
			float num = float.NegativeInfinity;
			float[] array = sampleBuffer;
			foreach (float b in array)
			{
				num = Mathf.Max(num, b);
			}
			return frequency / num;
		}

		private float GetAvgEnergy()
		{
			float num = 0f;
			for (int i = 0; i < sampleBuffer.Length; i++)
			{
				num += sampleBuffer[i];
			}
			return num / (float)sampleBuffer.Length;
		}

		private float GetAvgVariance(float avg)
		{
			float num = 0f;
			for (int i = 0; i < sampleBuffer.Length; i++)
			{
				float f = sampleBuffer[i] - avg;
				num += Mathf.Abs(f);
			}
			return num / (float)sampleBuffer.Length;
		}
	}
	public class AudioSampler : MonoBehaviour
	{
		public static AudioSampler instance;

		public List<AudioSource> audioSources;

		public bool debug;

		private Texture2D drawTexture;

		private Color startColor = Color.magenta;

		private Color endColor = Color.blue;

		private Gradient gradient;

		private float fMax;

		private List<string> debugLables = new List<string> { "SubBass", "Bass", "LowMid", "Mid", "UpperMid", "High", "VeryHigh", "Decibal" };

		private int samplesToTake = 1024;

		private void OnEnable()
		{
			if (instance == null)
			{
				instance = this;
			}
		}

		private void OnDisable()
		{
			instance = null;
		}

		private void Awake()
		{
			drawTexture = Texture2D.whiteTexture;
			gradient = PanelWaveform.GetColorGradient(startColor, endColor);
			if (audioSources.Count == 0)
			{
				if (GetComponent<AudioSource>() != null)
				{
					audioSources.Add(GetComponent<AudioSource>());
				}
				else
				{
					UnityEngine.Debug.LogError("Error! no audio sources attached to AudioSampler.css");
				}
			}
		}

		private void Start()
		{
			fMax = (float)AudioSettings.outputSampleRate / 2f;
		}

		private void OnGUI()
		{
			if (!debug)
			{
				return;
			}
			int num = 100;
			for (int i = 0; i < audioSources.Count; i++)
			{
				int num2 = (int)((float)Screen.width * 0.5f);
				int num3 = num * (i + 1);
				int num4 = (int)((float)num3 * 0.2f);
				int num5 = num2 / debugLables.Count;
				int width = 10;
				int num6 = num3 - num4;
				int num7 = 40;
				GUI.color = Color.white;
				GUI.Label(new Rect(0f, num6, 60f, 20f), "Source: " + i);
				for (int j = 0; j < debugLables.Count; j++)
				{
					float time = (float)j / (float)(debugLables.Count - 1);
					int num8 = num7 + num5 + num5 * j;
					Vector2 start = new Vector2(num8, num6);
					float num9 = Mathf.Clamp(GetFrequencyVol(i, (FrequencyRange)j) * 10f, 0f, 0.5f);
					float y = (float)num6 - (float)num * num9;
					Vector2 end = new Vector2(num8, y);
					DrawLine(start, end, width, gradient.Evaluate(time));
					GUI.Label(new Rect(num8, num6, 60f, 20f), debugLables[j]);
					GUI.Label(new Rect(num8, num6 + 20, 40f, 20f), num9.ToString("F3"));
				}
			}
		}

		private void DrawLine(Vector2 start, Vector2 end, int width, Color color)
		{
			GUI.color = color;
			Vector2 vector = end - start;
			float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
			if (vector.x < 0f)
			{
				num += 180f;
			}
			int num2 = (int)Mathf.Ceil(width / 2);
			if ((double)Vector2.Distance(start, end) > 0.1)
			{
				GUIUtility.RotateAroundPivot(num, start);
				GUI.DrawTexture(new Rect(start.x, start.y - (float)num2, vector.magnitude, width), drawTexture);
				GUIUtility.RotateAroundPivot(0f - num, start);
			}
		}

		public float[] GetAudioSamples(int audioSourceIndex)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				float[] outputData = audioSources[audioSourceIndex].GetOutputData(samplesToTake, 0);
				float[] array = NormalizeArray(outputData);
				for (int i = 0; i < outputData.Length; i++)
				{
					array[i] *= audioSources[audioSourceIndex].volume;
				}
				return array;
			}
			return new float[samplesToTake];
		}

		public float[] GetAudioSamples(int audioSourceIndex, int numBins, bool absoluteVal)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				float[] outputData = audioSources[audioSourceIndex].GetOutputData(numBins, 0);
				float[] array = NormalizeArray(outputData);
				for (int i = 0; i < outputData.Length; i++)
				{
					if (absoluteVal)
					{
						array[i] = Mathf.Abs(outputData[i]) * audioSources[audioSourceIndex].volume;
					}
					else
					{
						array[i] = outputData[i] * audioSources[audioSourceIndex].volume;
					}
				}
				return array;
			}
			return new float[numBins];
		}

		public float GetInstantEnergy(int audioSourceIndex)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				float[] audioSamples = GetAudioSamples(audioSourceIndex);
				float num = 0f;
				float[] array = audioSamples;
				foreach (float num2 in array)
				{
					num += num2 * num2;
				}
				return num * audioSources[audioSourceIndex].volume;
			}
			return 0f;
		}

		public float GetRMS(int audioSourceIndex)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				float[] outputData = audioSources[audioSourceIndex].GetOutputData(samplesToTake, 0);
				float num = 0f;
				for (int i = 0; i < samplesToTake; i++)
				{
					num += outputData[i] * outputData[i];
				}
				return Mathf.Sqrt(num / (float)samplesToTake) * audioSources[audioSourceIndex].volume;
			}
			return 0f;
		}

		public float GetFrequencyVol(int audioSourceIndex, FrequencyRange freqRange)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				Vector2 freqForRange = GetFreqForRange(freqRange);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[samplesToTake];
				audioSources[audioSourceIndex].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)samplesToTake / fMax);
				int num2 = (int)Mathf.Floor(y * (float)samplesToTake / fMax);
				float num3 = 0f;
				for (int i = num; i <= num2; i++)
				{
					if (i < array.Length)
					{
						num3 += Mathf.Abs(array[i]);
					}
				}
				num3 *= audioSources[audioSourceIndex].volume;
				return num3 / (float)(num2 - num + 1);
			}
			return 0f;
		}

		public float[] GetFrequencyData(int audioSourceIndex, FrequencyRange freqRange)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				Vector2 freqForRange = GetFreqForRange(freqRange);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[samplesToTake];
				audioSources[audioSourceIndex].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)samplesToTake / fMax);
				int num2 = (int)Mathf.Floor(y * (float)samplesToTake / fMax);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					list.Add(array[i] * audioSources[audioSourceIndex].volume);
				}
				return NormalizeArray(list.ToArray());
			}
			UnityEngine.Debug.LogWarning("warning: Audio Source: " + audioSourceIndex + " is muted");
			return new float[samplesToTake];
		}

		public float[] GetFrequencyData(int audioSourceIndex, FrequencyRange freqRange, int numBins, bool abs)
		{
			if (!audioSources[audioSourceIndex].mute)
			{
				Vector2 freqForRange = GetFreqForRange(freqRange);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[samplesToTake];
				audioSources[audioSourceIndex].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)samplesToTake / fMax);
				int num2 = (int)Mathf.Floor(y * (float)samplesToTake / fMax);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					float num3 = array[i];
					if (abs)
					{
						num3 = Mathf.Abs(array[i]);
					}
					list.Add(num3 * audioSources[audioSourceIndex].volume);
				}
				float[] binnedArray = GetBinnedArray(list.ToArray(), numBins);
				return NormalizeArray(binnedArray);
			}
			UnityEngine.Debug.LogWarning("warning: Audio Source: " + audioSourceIndex + " is muted");
			return new float[numBins];
		}

		private float[] GetBinnedArray(float[] input, int numBins)
		{
			float[] array = new float[numBins];
			if (numBins == input.Length)
			{
				return input;
			}
			if (numBins > input.Length)
			{
				int num = numBins / input.Length;
				for (int i = 0; i < numBins; i++)
				{
					int num2 = (i + 1) % num;
					array[i] = input[num2];
				}
			}
			if (numBins < input.Length)
			{
				int num3 = input.Length / numBins;
				for (int j = 0; j < numBins; j++)
				{
					float num4 = 0f;
					for (int k = 0; k < num3; k++)
					{
						int num5 = j * num3 + k;
						num4 += input[num5];
					}
					num4 /= (float)num3;
					array[j] = num4;
				}
			}
			return array;
		}

		private float[] NormalizeArray(float[] input)
		{
			float[] array = new float[input.Length];
			float num = float.NegativeInfinity;
			for (int i = 0; i < input.Length; i++)
			{
				num = Mathf.Max(num, Mathf.Abs(input[i]));
			}
			for (int j = 0; j < input.Length; j++)
			{
				array[j] = input[j] / num;
			}
			return array;
		}

		public static Vector2 GetFreqForRange(FrequencyRange freqRange)
		{
			return freqRange switch
			{
				FrequencyRange.SubBase => new Vector2(20f, 60f), 
				FrequencyRange.Bass => new Vector2(60f, 250f), 
				FrequencyRange.LowMidrange => new Vector2(250f, 500f), 
				FrequencyRange.Midrange => new Vector2(500f, 2000f), 
				FrequencyRange.UpperMidrange => new Vector2(2000f, 4000f), 
				FrequencyRange.High => new Vector2(4000f, 6000f), 
				FrequencyRange.VeryHigh => new Vector2(6000f, 20000f), 
				FrequencyRange.Decibal => new Vector2(0f, 20000f), 
				_ => Vector2.zero, 
			};
		}
	}
	public enum FrequencyRange
	{
		SubBase,
		Bass,
		LowMidrange,
		Midrange,
		UpperMidrange,
		High,
		VeryHigh,
		Decibal
	}
	public class CircleWaveform : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public List<GameObject> objects;

		public float rotationSpeed = 10f;

		public float radius = 10f;

		public float lerpSpeed = 10f;

		public bool useWaveform = true;

		private List<float> startAngles;

		private float angle;

		private float rotSpeed;

		private bool bumped;

		private float startRadius;

		private float sign = 1f;

		private void Awake()
		{
			startAngles = new List<float>();
			float num = 360f / (float)objects.Count;
			for (int i = 0; i < objects.Count; i++)
			{
				startAngles.Add((float)i * num);
			}
			rotSpeed = rotationSpeed;
			startRadius = radius;
		}

		private void Start()
		{
			PositionObjects();
		}

		private void Update()
		{
			PositionObjects();
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1f);
		}

		public void Boost(float multiplier)
		{
			Invoke("ResetSpeed", 0.1f);
			rotationSpeed *= multiplier;
		}

		private void ResetSpeed()
		{
			rotationSpeed = rotSpeed;
		}

		public void Bump(bool switchSign)
		{
			float num = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
			if (switchSign)
			{
				sign = 0f - sign;
			}
			radius = startRadius * num * sign;
		}

		private void PositionObjects()
		{
			angle += Time.smoothDeltaTime * rotationSpeed;
			for (int i = 0; i < objects.Count; i++)
			{
				float f = (angle + startAngles[i]) * ((float)Math.PI / 180f);
				float num = radius;
				if (useWaveform)
				{
					float num2 = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
					num = radius * num2;
				}
				float num3 = Mathf.Cos(f) * num;
				float num4 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * num3 + base.transform.up * num4;
				objects[i].transform.position = Vector3.Lerp(objects[i].transform.position, b, lerpSpeed * Time.smoothDeltaTime);
			}
		}
	}
	public class ColorChange : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public Color lowColor = Color.white;

		public Color highColor = Color.white;

		public float lerpSpeed = 10f;

		private Gradient gradient;

		private List<Material> materials;

		private float alpha;

		private void Awake()
		{
			gradient = PanelWaveform.GetColorGradient(lowColor, highColor);
			materials = new List<Material>();
			Material[] array = GetComponent<MeshRenderer>().materials;
			foreach (Material item in array)
			{
				materials.Add(item);
			}
			alpha = materials[0].color.a;
		}

		private void Update()
		{
			ColorPanel();
		}

		public void Reset()
		{
			gradient = PanelWaveform.GetColorGradient(lowColor, highColor);
		}

		private void ColorPanel()
		{
			float value = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
			value = Mathf.Clamp(value, 0f, 1f);
			Color b = gradient.Evaluate(value);
			Color color = Color.Lerp(materials[0].color, b, lerpSpeed * Time.deltaTime);
			float b2 = lowColor.a + (highColor.a - lowColor.a) * value;
			alpha = Mathf.Lerp(alpha, b2, lerpSpeed * Time.deltaTime);
			color.a = alpha;
			foreach (Material material in materials)
			{
				material.color = color;
			}
		}
	}
	public class CurveWaveform : LineWaveform
	{
		public AnimationCurve shapeCurve;

		public float curveAmplitude = 5f;

		public Vector3 curveDirection = Vector3.up;

		private void Update()
		{
			DrawLines();
		}

		private void DrawLines()
		{
			for (int i = 0; i < points.Count - 1; i++)
			{
				Vector3 position = points[i].position;
				Vector3 position2 = points[i + 1].position;
				Vector3 vector = position2 - position;
				int num = 0;
				int num2 = lineAtt.lineSegments;
				float[] array = ((frequencyRange != FrequencyRange.Decibal) ? AudioSampler.instance.GetFrequencyData(audioSource, frequencyRange, lineAtt.lineSegments, abs) : AudioSampler.instance.GetAudioSamples(audioSource, lineAtt.lineSegments, abs));
				if (snapEndpoints)
				{
					lines[i].SetPosition(0, position);
					lines[i].SetPosition(lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(lineAtt.lineSegments - 1);
					Vector3 position3 = position + vector * num3;
					float num4 = array[j];
					if (abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float num5;
					if (shapeCurve != null)
					{
						num5 = shapeCurve.Evaluate(num3) * curveAmplitude + num4 * waveformAmplitude;
					}
					else
					{
						UnityEngine.Debug.LogWarning("Warning: No Shape Curve set for CurveWaveform.cs on " + base.gameObject.name);
						num5 = num4 * waveformAmplitude;
					}
					position3 += points[i].transform.TransformDirection(curveDirection) * num5;
					lines[i].SetPosition(j, position3);
				}
			}
		}
	}
	public class LineWaveform : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public List<Transform> points;

		public LineAttributes lineAtt;

		public float waveformAmplitude = 5f;

		public float gizmosSize = 1f;

		public bool abs;

		public bool snapEndpoints = true;

		protected List<LineRenderer> lines;

		private void Start()
		{
			lines = new List<LineRenderer>();
			for (int i = 0; i < points.Count - 1; i++)
			{
				LineRenderer item = NewLine(lineAtt.startColor, lineAtt.endColor, lineAtt.startWidth, lineAtt.endWidth, lineAtt.lineSegments);
				lines.Add(item);
			}
		}

		private void Update()
		{
			DrawLines();
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < points.Count - 1; i++)
			{
				Vector3 position = points[i].position;
				Vector3 position2 = points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < points.Count; j++)
			{
				Gizmos.DrawSphere(points[j].position, gizmosSize);
			}
		}

		private void DrawLines()
		{
			for (int i = 0; i < points.Count - 1; i++)
			{
				Vector3 position = points[i].position;
				Vector3 position2 = points[i + 1].position;
				Vector3 vector = position2 - position;
				int num = 0;
				int num2 = lineAtt.lineSegments;
				float[] array = ((frequencyRange != FrequencyRange.Decibal) ? AudioSampler.instance.GetFrequencyData(audioSource, frequencyRange, lineAtt.lineSegments, abs) : AudioSampler.instance.GetAudioSamples(audioSource, lineAtt.lineSegments, abs));
				if (snapEndpoints)
				{
					lines[i].SetPosition(0, position);
					lines[i].SetPosition(lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(lineAtt.lineSegments - 1);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 position3 = position + vector * num3;
					float num5 = ((!abs) ? (array[num4] * waveformAmplitude) : (Mathf.Abs(array[num4]) * waveformAmplitude));
					position3 += points[i].up * num5;
					lines[i].SetPosition(j, position3);
				}
			}
		}

		public LineRenderer NewLine(Color color1, Color color2, float startWidth, float endWidth, int segments)
		{
			GameObject obj = new GameObject();
			obj.transform.SetParent(base.transform);
			obj.name = "Line";
			LineRenderer lineRenderer = obj.AddComponent<LineRenderer>();
			lineRenderer = obj.GetComponent<LineRenderer>();
			if (lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			}
			else
			{
				lineRenderer.material = lineAtt.lineMat;
			}
			lineRenderer.SetColors(color1, color2);
			lineRenderer.SetWidth(startWidth, endWidth);
			lineRenderer.SetVertexCount(segments);
			return lineRenderer;
		}

		public void OrientPoints()
		{
			for (int i = 0; i < points.Count - 1; i++)
			{
				points[i].LookAt(points[i + 1].position);
			}
		}

		public void RenamePoints(string name)
		{
			for (int i = 0; i < points.Count; i++)
			{
				points[i].gameObject.name = name + i;
			}
		}
	}
	[Serializable]
	public class LineAttributes
	{
		public Material lineMat;

		public Color startColor = Color.cyan;

		public Color endColor = Color.magenta;

		public float startWidth = 0.1f;

		public float endWidth = 0.1f;

		public int lineSegments = 36;
	}
	public class MaterialChange : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public Material lowMat;

		public Material highMat;

		public float lerpSpeed = 10f;

		private List<Material> materials;

		private Renderer renderer;

		private float lastAvg;

		private void Start()
		{
			renderer = GetComponent<Renderer>();
			materials = new List<Material>();
			Material[] array = GetComponent<MeshRenderer>().materials;
			foreach (Material item in array)
			{
				materials.Add(item);
			}
		}

		private void Update()
		{
			LerpMaterial();
		}

		private void LerpMaterial()
		{
			float value = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
			value = Mathf.Clamp(value, 0f, 1f);
			float value2 = Mathf.Lerp(lastAvg, value, lerpSpeed * Time.deltaTime);
			foreach (Material material in materials)
			{
				material.GetFloat("_Blend");
				material.SetFloat("_Blend", value2);
			}
			lastAvg = value;
		}
	}
	public class ObjectPositionWaveform : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public List<GameObject> objects;

		public Vector3 positionAxis = Vector3.up;

		public float maxHeight = 10f;

		public float lerpSpeed = 1f;

		public bool absoluteVal = true;

		private List<Vector3> startingPositions;

		private void Start()
		{
			startingPositions = new List<Vector3>();
			foreach (GameObject @object in objects)
			{
				Vector3 item = @object.transform.position - base.transform.position;
				startingPositions.Add(item);
			}
		}

		private void Update()
		{
			PositionObjects();
			for (int i = 0; i < objects.Count; i++)
			{
				UnityEngine.Debug.DrawLine(startingPositions[i], startingPositions[i] + objects[i].transform.up * maxHeight);
			}
		}

		private void PositionObjects()
		{
			float[] array = ((frequencyRange != FrequencyRange.Decibal) ? AudioSampler.instance.GetFrequencyData(audioSource, frequencyRange, objects.Count, absoluteVal) : AudioSampler.instance.GetAudioSamples(audioSource, objects.Count, absoluteVal));
			for (int i = 0; i < objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * sensitivity, 1f) * maxHeight;
				Vector3 vector = objects[i].transform.TransformDirection(positionAxis);
				Vector3 b = base.transform.position + startingPositions[i] + num * vector;
				objects[i].transform.position = Vector3.Lerp(objects[i].transform.position, b, Time.smoothDeltaTime * lerpSpeed);
			}
		}
	}
	public class ObjectScaleWaveform : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public List<GameObject> objects;

		public Vector3 scaleAxis = Vector3.up;

		public float maxHeight = 10f;

		public float lerpSpeed = 1f;

		public bool absoluteVal = true;

		private List<Vector3> startingScales;

		private List<Vector3> startingPositions;

		private void Start()
		{
			startingScales = new List<Vector3>();
			startingPositions = new List<Vector3>();
			foreach (GameObject @object in objects)
			{
				startingScales.Add(@object.transform.localScale);
				startingPositions.Add(@object.transform.position);
			}
		}

		private void Update()
		{
			ScaleObjects();
		}

		private void ScaleObjects()
		{
			float[] array = ((frequencyRange != FrequencyRange.Decibal) ? AudioSampler.instance.GetFrequencyData(audioSource, frequencyRange, objects.Count, absoluteVal) : AudioSampler.instance.GetAudioSamples(audioSource, objects.Count, absoluteVal));
			for (int i = 0; i < objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * sensitivity, 1f) * maxHeight;
				Vector3 b = startingScales[i] + num * base.transform.InverseTransformDirection(scaleAxis);
				objects[i].transform.localScale = Vector3.Lerp(objects[i].transform.localScale, b, Time.smoothDeltaTime * lerpSpeed);
				float y = (objects[i].transform.localScale - startingScales[i]).y;
				Vector3 vector = objects[i].transform.TransformDirection(scaleAxis);
				objects[i].transform.position = startingPositions[i] + y * vector * 0.5f;
			}
		}
	}
	public class PadWaveform : MonoBehaviour
	{
		public enum PadType
		{
			Ripple,
			DampWave,
			Wave,
			Bounce
		}

		public int audioSource;

		public int numLines = 20;

		public float radius = 10f;

		public float maxHeight = 3f;

		public int updateRate = 1;

		public PadType padType = PadType.Wave;

		public Color rippleColor = Color.white;

		public int rippleWidth = 3;

		public LineAttributes lineAttributes;

		public bool gizmos = true;

		private List<LineRenderer> lines = new List<LineRenderer>();

		private Gradient padGradient;

		private int updateCounter;

		private float fakeTimer;

		private void Start()
		{
			padGradient = PanelWaveform.GetColorGradient(lineAttributes.startColor, lineAttributes.endColor);
			for (int i = 0; i < numLines; i++)
			{
				float time = (float)i / (float)(numLines - 1);
				lines.Add(NewLine(padGradient.Evaluate(time)));
			}
			CreatePad();
			if (rippleWidth > numLines)
			{
				rippleWidth = numLines;
			}
		}

		private void FixedUpdate()
		{
			if (updateCounter >= updateRate)
			{
				switch (padType)
				{
				case PadType.Ripple:
					Ripple();
					break;
				case PadType.DampWave:
					DampWave();
					break;
				case PadType.Wave:
					Wave();
					break;
				case PadType.Bounce:
					Bounce();
					break;
				}
				updateCounter = 0;
			}
			updateCounter++;
		}

		public void SendRipple(float propegationTime)
		{
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(audioSource, lineAttributes.lineSegments, absoluteVal: true);
			StartCoroutine(RipIt(propegationTime, audioSamples));
		}

		private IEnumerator RipIt(float propegationTime, float[] rippleSamples)
		{
			float timer = 0f;
			float radiusStep = radius / (float)(numLines - 1);
			float angle = 0f;
			float angleStep = 360f / (float)lineAttributes.lineSegments;
			int maxIndex = numLines - 1;
			int halfWidth = rippleWidth / 2;
			float heightStep = 1f / (float)(halfWidth + 1);
			Gradient colorGradient = PanelWaveform.GetColorGradient(lineAttributes.startColor, rippleColor);
			Color[] rippleColors = new Color[maxIndex];
			float num = 1f / (float)(rippleWidth - 1);
			for (int i = 0; i < rippleWidth; i++)
			{
				float time = (float)i * num;
				rippleColors[i] = colorGradient.Evaluate(time);
			}
			Color[] lineColors = new Color[numLines];
			float[] heightDamp = new float[numLines];
			float num2 = maxHeight / (float)(numLines - 1);
			num = 1f / (float)(numLines - 1);
			for (int j = 0; j < numLines; j++)
			{
				float time = (float)j * num;
				lineColors[j] = padGradient.Evaluate(time);
				heightDamp[j] = maxHeight - (float)j * num2;
			}
			while (timer <= propegationTime)
			{
				float time = timer / propegationTime;
				int num3 = (int)(time * (float)maxIndex);
				int b = num3 - rippleWidth - 1;
				b = Mathf.Max(0, b);
				int a = num3 + rippleWidth;
				a = Mathf.Min(a, numLines);
				Vector3 position = Vector3.zero;
				for (int k = b; k < a; k++)
				{
					int num4 = Mathf.Abs(num3 - k);
					int num5 = rippleWidth - num4;
					float num6 = ((num4 > halfWidth) ? 0f : (1f - heightStep * (float)num4));
					float num7 = radiusStep * (float)k;
					if (k == num3 - rippleWidth - 1)
					{
						lines[k].SetColors(lineColors[num3], lineColors[num3]);
					}
					else
					{
						lines[k].SetColors(rippleColors[num5], rippleColors[num5]);
					}
					for (int l = 0; l < lineAttributes.lineSegments - 1; l++)
					{
						float f = (float)Math.PI / 180f * angle;
						float num8 = Mathf.Cos(f) * num7;
						float num9 = rippleSamples[l] * heightDamp[num3] * num6;
						float num10 = Mathf.Sin(f) * num7;
						Vector3 vector = base.transform.position + base.transform.right * num8 + base.transform.up * num9 + base.transform.forward * num10;
						lines[k].SetPosition(l, vector);
						angle += angleStep;
						if (l == 0)
						{
							position = vector;
						}
					}
					lines[k].SetPosition(lineAttributes.lineSegments - 1, position);
				}
				timer += Time.fixedDeltaTime;
				yield return null;
			}
		}

		private void Ripple()
		{
			float num = 360f / (float)lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(audioSource, lineAttributes.lineSegments, absoluteVal: true);
			float num2 = 0f;
			float num3 = radius / (float)(numLines - 1);
			Vector3 position = Vector3.zero;
			for (int i = 0; i < lineAttributes.lineSegments - 1; i++)
			{
				float f = (float)Math.PI / 180f * num2;
				float num4 = Mathf.Cos(f) * num3;
				float num5 = audioSamples[i] * maxHeight;
				float num6 = Mathf.Sin(f) * num3;
				Vector3 vector = base.transform.position + base.transform.right * num4 + base.transform.up * num5 + base.transform.forward * num6;
				lines[0].SetPosition(i, vector);
				num2 += num;
				if (i == 0)
				{
					position = vector;
				}
			}
			lines[0].SetPosition(lineAttributes.lineSegments - 1, position);
		}

		private void Wave()
		{
			float num = radius / (float)(numLines - 1);
			float num2 = 360f / (float)lineAttributes.lineSegments;
			for (int i = 0; i < numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				float[] audioSamples = AudioSampler.instance.GetAudioSamples(audioSource, lineAttributes.lineSegments, absoluteVal: true);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < lineAttributes.lineSegments - 1; j++)
				{
					float f = (float)Math.PI / 180f * num3;
					float num5 = Mathf.Cos(f) * num4;
					float num6 = audioSamples[j] * maxHeight;
					float num7 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * num5 + base.transform.up * num6 + base.transform.forward * num7;
					lines[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				lines[i].SetPosition(lineAttributes.lineSegments - 1, position);
			}
		}

		private void DampWave()
		{
			float num = radius / (float)(numLines - 1);
			float num2 = 360f / (float)lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(audioSource, lineAttributes.lineSegments, absoluteVal: true);
			for (int i = 0; i < numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 1f - (float)i / (float)(numLines - 1);
				for (int j = 0; j < lineAttributes.lineSegments - 1; j++)
				{
					float f = (float)Math.PI / 180f * num3;
					float num6 = Mathf.Cos(f) * num4;
					float num7 = audioSamples[j] * maxHeight * num5;
					float num8 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * num6 + base.transform.up * num7 + base.transform.forward * num8;
					lines[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				lines[i].SetPosition(lineAttributes.lineSegments - 1, position);
			}
		}

		private void Bounce()
		{
			float num = radius / (float)(numLines - 1);
			float num2 = 360f / (float)(lineAttributes.lineSegments - 1);
			for (int i = 0; i < numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				float num5 = AudioSampler.instance.GetAudioSamples(audioSource, numLines, absoluteVal: true)[i] * maxHeight;
				for (int j = 0; j < lineAttributes.lineSegments; j++)
				{
					float f = (float)Math.PI / 180f * num3;
					float num6 = Mathf.Cos(f) * num4;
					float num7 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * num6 + base.transform.up * num5 + base.transform.forward * num7;
					lines[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		private void OnDrawGizmos()
		{
			if (gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 1f);
			}
		}

		private void CreatePad()
		{
			float num = radius / (float)(numLines - 1);
			float num2 = 360f / (float)(lineAttributes.lineSegments - 1);
			for (int i = 0; i < numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				for (int j = 0; j < lineAttributes.lineSegments; j++)
				{
					float f = (float)Math.PI / 180f * num3;
					float num5 = Mathf.Cos(f) * num4;
					float num6 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * num5 + base.transform.forward * num6;
					lines[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		private LineRenderer NewLine(Color c)
		{
			GameObject obj = new GameObject();
			obj.transform.position = base.transform.position;
			obj.transform.rotation = base.transform.rotation;
			obj.hideFlags = HideFlags.HideInHierarchy;
			LineRenderer lineRenderer = obj.AddComponent<LineRenderer>();
			if (lineAttributes.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			}
			else
			{
				lineRenderer.material = lineAttributes.lineMat;
			}
			lineRenderer.SetColors(c, c);
			lineRenderer.SetWidth(lineAttributes.startWidth, lineAttributes.endWidth);
			lineRenderer.SetVertexCount(lineAttributes.lineSegments);
			return lineRenderer;
		}
	}
	[RequireComponent(typeof(RectTransform))]
	public class PanelWaveform : MonoBehaviour
	{
		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public Sprite sprite;

		public int numColumns = 10;

		public int numRows = 10;

		public int spacingX;

		public int spacingY;

		public Color bottomColor = Color.white;

		public Color topColor = Color.white;

		public int updateRate = 1;

		private int updateCounter;

		private List<GameObject> cells = new List<GameObject>();

		private Gradient colorGradient;

		private float widthPerImage;

		private float heightPerImage;

		private int lastCol;

		private int lastRow;

		private void Awake()
		{
			RectTransform component = GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(1f, 1f);
			component.anchoredPosition = new Vector2(1f, 1f);
			colorGradient = GetColorGradient(bottomColor, topColor);
		}

		private void Start()
		{
			CreateImages();
			SetWidthAndHeight();
		}

		private void FixedUpdate()
		{
			if (updateCounter >= updateRate)
			{
				DrawWaveform();
				updateCounter = 0;
			}
			if (lastCol != numColumns || lastRow != numRows)
			{
				Reset();
			}
			lastCol = numColumns;
			lastRow = numRows;
			updateCounter++;
		}

		public void Reset()
		{
			DestroyCells();
			CreateImages();
			SetWidthAndHeight();
		}

		private void DrawWaveform()
		{
			float[] array = ((frequencyRange != FrequencyRange.Decibal) ? AudioSampler.instance.GetFrequencyData(audioSource, frequencyRange, numColumns, abs: true) : AudioSampler.instance.GetAudioSamples(audioSource, numColumns, absoluteVal: true));
			int num = 0;
			for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < numColumns; j++)
				{
					float num2 = Mathf.Abs(array[j]) * sensitivity;
					float num3 = (float)i / (float)numRows;
					GameObject gameObject = cells[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(value: true);
					}
					else
					{
						gameObject.SetActive(value: false);
					}
					num++;
				}
			}
		}

		private void SetWidthAndHeight()
		{
			widthPerImage = GetComponent<RectTransform>().rect.width / (float)numColumns;
			heightPerImage = GetComponent<RectTransform>().rect.height / (float)numRows;
			if ((bool)base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				heightPerImage /= base.transform.parent.childCount;
			}
			if ((bool)base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				widthPerImage /= base.transform.parent.childCount;
			}
			if ((bool)base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				widthPerImage = component.cellSize.x / (float)numColumns;
				heightPerImage = component.cellSize.y / (float)numRows;
			}
		}

		private void CreateImages()
		{
			cells = new List<GameObject>();
			for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < numColumns; j++)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(value: true);
					gameObject.name = "Image_" + i + "x" + j;
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = sprite;
					image.rectTransform.pivot = new Vector2(0f, 0f);
					image.rectTransform.anchorMin = new Vector2(0f, 0f);
					image.rectTransform.anchorMax = new Vector2(0f, 0f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, widthPerImage - (float)(spacingX * 2));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, heightPerImage - (float)(spacingY * 2));
					float x = (float)j * widthPerImage;
					float y = (float)i * heightPerImage;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 0f);
					image.color = colorGradient.Evaluate((float)i / (float)numRows);
					cells.Add(gameObject);
				}
			}
		}

		public static Gradient GetColorGradient(Color startColor, Color endColor)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[2];
			array[0].color = startColor;
			array[0].time = 0f;
			array[1].color = endColor;
			array[1].time = 1f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[2];
			array2[0].alpha = startColor.a;
			array2[0].time = 0f;
			array2[1].alpha = endColor.a;
			array2[1].time = 1f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		private void DestroyCells()
		{
			foreach (GameObject cell in cells)
			{
				cell.SetActive(value: false);
			}
		}
	}
	public class SphereWaveform : MonoBehaviour
	{
		public enum RotationType
		{
			Uniform,
			Rand,
			Cross
		}

		public int audioSource;

		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		public float sensitivity = 2f;

		public List<GameObject> objects;

		public float rotationSpeed = 10f;

		public Vector3 rotationAxis = Vector3.up;

		public float radius = 10f;

		public float lerpSpeed = 1f;

		public bool useWaveform = true;

		public RotationType rotationType;

		private float rotSpeed;

		private float sign = 1f;

		private float startRadius;

		private List<Vector3> axes;

		private void Start()
		{
			if (rotationAxis == Vector3.zero)
			{
				UnityEngine.Debug.LogWarning("WARNING: rotation axis set to 0 on " + base.gameObject.name + " SphereWaveform.cs");
			}
			ObjectSphere.PlaceObjectsAroundSphere(objects, base.transform.position, radius);
			startRadius = radius;
			InitializeAxes();
			rotSpeed = rotationSpeed;
		}

		private void Update()
		{
			Rotate();
			if (useWaveform)
			{
				Waveform();
			}
			PositionObjects();
		}

		private void InitializeAxes()
		{
			axes = new List<Vector3>();
			switch (rotationType)
			{
			case RotationType.Rand:
			{
				foreach (GameObject @object in objects)
				{
					_ = @object;
					axes.Add(UnityEngine.Random.onUnitSphere);
				}
				break;
			}
			case RotationType.Cross:
			{
				foreach (GameObject object2 in objects)
				{
					Vector3 item = Vector3.Cross((object2.transform.position - base.transform.position).normalized, rotationAxis);
					axes.Add(item);
				}
				break;
			}
			}
		}

		private void Rotate()
		{
			switch (rotationType)
			{
			case RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case RotationType.Rand:
			case RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * rotationSpeed;
				for (int i = 0; i < objects.Count; i++)
				{
					objects[i].transform.RotateAround(base.transform.position, axes[i], angle);
				}
				break;
			}
			}
		}

		public void Boost(float multiplier)
		{
			Invoke("ResetSpeed", 0.1f);
			rotationSpeed *= multiplier;
		}

		private void ResetSpeed()
		{
			rotationSpeed = rotSpeed;
		}

		public void Bump(bool switchSign)
		{
			float num = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
			if (switchSign)
			{
				sign = 0f - sign;
			}
			radius = startRadius + num * sign;
		}

		private void Waveform()
		{
			float num = ((frequencyRange != FrequencyRange.Decibal) ? (AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity) : (AudioSampler.instance.GetRMS(audioSource) * sensitivity));
			radius = startRadius + num;
		}

		private void PositionObjects()
		{
			foreach (GameObject @object in objects)
			{
				Vector3 normalized = (@object.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * radius;
				@object.transform.position = Vector3.Lerp(@object.transform.position, b, Time.smoothDeltaTime * lerpSpeed);
			}
		}
	}
	public class CameraCircle : MonoBehaviour
	{
		public Transform target;

		public float rotationSpeed;

		public Vector3 rotationAxis;

		private void Start()
		{
		}

		private void Update()
		{
			base.transform.RotateAround(target.transform.position, rotationAxis, rotationSpeed * Time.smoothDeltaTime);
			base.transform.LookAt(target);
		}
	}
	public class CameraMovement : MonoBehaviour
	{
		public float speed;

		public float lerpSpeed;

		private void Update()
		{
			Vector3 vector = base.transform.right * speed;
			base.transform.position = Vector3.Lerp(base.transform.position, base.transform.position + vector, lerpSpeed * Time.smoothDeltaTime);
		}
	}
	public class ObjectCircle : MonoBehaviour
	{
		public List<GameObject> objects;

		public float radius;

		private float angle;

		private void Awake()
		{
			PositionObjects();
		}

		private void PositionObjects()
		{
			foreach (GameObject @object in objects)
			{
				@object.transform.position = base.transform.position;
				@object.transform.rotation = base.transform.rotation;
			}
			angle = 0f;
			float num = 360f / (float)objects.Count;
			for (int i = 0; i < objects.Count; i++)
			{
				float f = angle * ((float)Math.PI / 180f);
				float num2 = Mathf.Cos(f) * radius;
				float num3 = Mathf.Sin(f) * radius;
				Vector3 position = base.transform.position + base.transform.right * num2 + base.transform.up * num3;
				objects[i].transform.position = position;
				objects[i].transform.RotateAround(objects[i].transform.position, base.transform.forward, angle - 90f);
				angle += num;
			}
		}
	}
	public class ObjectSphere : MonoBehaviour
	{
		public List<GameObject> objectsToPlace;

		public float radius = 3f;

		private void Awake()
		{
			PlaceObjectsAroundSphere(objectsToPlace, base.transform.position, radius);
		}

		public static void PlaceObjectsAroundSphere(List<GameObject> objects, Vector3 origin, float radius)
		{
			Vector3[] pointsOnSphere = GetPointsOnSphere(objects.Count);
			for (int i = 0; i < objects.Count; i++)
			{
				Vector3 vector = pointsOnSphere[i];
				Vector3 vector2 = origin + vector.normalized * radius;
				Vector3 vector3 = vector2 - origin;
				objects[i].transform.position = vector2;
				objects[i].transform.LookAt(vector2 + vector3);
			}
		}

		public static Vector3[] GetPointsOnSphere(int numPoints)
		{
			Vector3[] array = new Vector3[numPoints];
			float num = (float)Math.PI * (3f - Mathf.Sqrt(5f));
			float num2 = 2f / (float)numPoints;
			for (int i = 0; i < numPoints; i++)
			{
				float num3 = (float)i * num2 - 1f + num2 / 2f;
				float num4 = Mathf.Sqrt(1f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}
	}
	public class ParticleController : MonoBehaviour
	{
		public List<ParticleSystem> particleSystems;

		public int updateRate;

		private int updateCounter;

		private void FixedUpdate()
		{
			updateCounter++;
			if (updateCounter <= updateRate)
			{
				return;
			}
			foreach (ParticleSystem particleSystem in particleSystems)
			{
				particleSystem.Play();
			}
			updateCounter = 0;
		}
	}
	public class Rotate : MonoBehaviour
	{
		public float speed;

		private void FixedUpdate()
		{
			base.transform.RotateAround(base.transform.position, base.transform.up, speed * Time.deltaTime);
		}
	}
}
