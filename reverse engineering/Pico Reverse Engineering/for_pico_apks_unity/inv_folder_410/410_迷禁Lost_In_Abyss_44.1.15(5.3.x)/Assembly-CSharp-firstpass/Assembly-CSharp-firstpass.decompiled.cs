using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class Loom : MonoBehaviour
{
	public struct DelayedQueueItem
	{
		public float time;

		public Action action;
	}

	public static int maxThreads = 8;

	private static int numThreads;

	private static Loom _current;

	private int _count;

	private static bool initialized;

	private List<Action> _actions = new List<Action>();

	private List<DelayedQueueItem> _delayed = new List<DelayedQueueItem>();

	private List<DelayedQueueItem> _currentDelayed = new List<DelayedQueueItem>();

	private List<Action> _currentActions = new List<Action>();

	public static Loom Current
	{
		get
		{
			Initialize();
			return _current;
		}
	}

	private void Awake()
	{
		_current = this;
		initialized = true;
	}

	public static void Initialize()
	{
		if (!initialized && Application.isPlaying)
		{
			initialized = true;
			string text = "Instance";
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				gameObject = new GameObject();
				gameObject.name = text;
			}
			_current = gameObject.AddComponent<Loom>();
		}
	}

	public static void QueueOnMainThread(Action action)
	{
		QueueOnMainThread(action, 0f);
	}

	public static void QueueOnMainThread(Action action, float time)
	{
		if (time != 0f)
		{
			lock (Current._delayed)
			{
				Current._delayed.Add(new DelayedQueueItem
				{
					time = Time.time + time,
					action = action
				});
				return;
			}
		}
		lock (Current._actions)
		{
			Current._actions.Add(action);
		}
	}

	public static Thread RunAsync(Action a)
	{
		Initialize();
		while (numThreads >= maxThreads)
		{
			Thread.Sleep(1);
		}
		Interlocked.Increment(ref numThreads);
		ThreadPool.QueueUserWorkItem(RunAction, a);
		return null;
	}

	private static void RunAction(object action)
	{
		try
		{
			((Action)action)();
		}
		catch
		{
		}
		finally
		{
			Interlocked.Decrement(ref numThreads);
		}
	}

	private void OnDisable()
	{
		if (_current == this)
		{
			_current = null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		lock (_actions)
		{
			_currentActions.Clear();
			_currentActions.AddRange(_actions);
			_actions.Clear();
		}
		foreach (Action currentAction in _currentActions)
		{
			currentAction();
		}
		lock (_delayed)
		{
			_currentDelayed.Clear();
			_currentDelayed.AddRange(_delayed.Where((DelayedQueueItem d) => d.time <= Time.time));
			foreach (DelayedQueueItem item in _currentDelayed)
			{
				_delayed.Remove(item);
			}
		}
		foreach (DelayedQueueItem item2 in _currentDelayed)
		{
			item2.action();
		}
	}
}
public class OutLog : MonoBehaviour
{
	private static List<string> mLines = new List<string>();

	private static List<string> mWriteTxt = new List<string>();

	private string outpath;

	public int _screenLogMaxCount = 8;

	public bool _isInputLogOnScreen;

	public Color _color = Color.red;

	public string ip = "127.0.0.1";

	public int point = 60000;

	private UdpClient udpClient;

	private IPEndPoint iPEndPoint;

	private void Awake()
	{
		iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), point);
		udpClient = new UdpClient();
		outpath = Application.persistentDataPath + "/outLog.txt";
		UnityEngine.Debug.Log("path:" + outpath);
		if (File.Exists(outpath))
		{
			File.Delete(outpath);
		}
		Application.RegisterLogCallback(HandleLog);
	}

	private void Update()
	{
		if (mWriteTxt.Count <= 0)
		{
			return;
		}
		string[] array = mWriteTxt.ToArray();
		foreach (string text in array)
		{
			using (StreamWriter streamWriter = new StreamWriter(outpath, append: true, Encoding.UTF8))
			{
				streamWriter.WriteLine(text);
			}
			mWriteTxt.Remove(text);
		}
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
		switch (type)
		{
		case LogType.Error:
		case LogType.Log:
			Log(logString);
			break;
		case LogType.Warning:
			return;
		}
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(logString);
			udpClient.Send(bytes, bytes.Length, iPEndPoint);
		}
		catch (Exception)
		{
		}
	}

	public void Log(params object[] objs)
	{
		string text = "";
		for (int i = 0; i < objs.Length; i++)
		{
			text = ((i != 0) ? (text + ", " + objs[i].ToString()) : (text + objs[i].ToString()));
		}
		if (Application.isPlaying)
		{
			if (mLines.Count > _screenLogMaxCount)
			{
				mLines.RemoveAt(0);
			}
			mLines.Add(text);
		}
	}

	private void OnGUI()
	{
		if (_isInputLogOnScreen)
		{
			GUI.color = _color;
			int num = 0;
			int num2 = mLines.Count - 1;
			while (num2 >= 0 && num < _screenLogMaxCount)
			{
				num++;
				GUILayout.Label(mLines[num2]);
				num2--;
			}
		}
	}
}
public class UdpServer : MonoBehaviour
{
	public int _point = 60000;

	private Thread _thread;

	private Socket newsock;

	private IPEndPoint ip;

	private int recv;

	private byte[] data;

	private List<string> _dataList;

	private Vector2 startScrollPos = Vector2.zero;

	private float buttonHight = 30f;

	private GUIStyle _labelStyle;

	private void Start()
	{
		Loom.Initialize();
		_dataList = new List<string>();
		_labelStyle = new GUIStyle();
		Screen.SetResolution(960, 640, fullscreen: false);
		ip = new IPEndPoint(IPAddress.Any, _point);
		newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		newsock.SendTimeout = 5000;
		newsock.ReceiveTimeout = 5000;
		newsock.Bind(ip);
		UnityEngine.Debug.Log("This is a Server,host name is " + Dns.GetHostName());
		UnityEngine.Debug.Log("Waiting for a client");
		_thread = new Thread(BeginListening);
		_thread.Start();
	}

	private void BeginListening()
	{
		EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
		while (true)
		{
			if (newsock.Available == 0)
			{
				Thread.Sleep(200);
				continue;
			}
			int available = newsock.Available;
			if (available > 3000)
			{
				available *= 3;
			}
			data = new byte[25000];
			recv = newsock.ReceiveFrom(data, ref remoteEP);
			string str = "IP：" + remoteEP.ToString() + "    时间：" + DateTime.Now.ToLongTimeString().ToString() + "\n" + Encoding.Default.GetString(data, 0, recv);
			Loom.QueueOnMainThread(delegate
			{
				_dataList.Add(str);
			});
		}
	}

	private new void SendMessage(string message)
	{
		_ = new byte[1024];
		UnityEngine.Debug.Log("This is a client,host name is" + Dns.GetHostName());
		_ = ip;
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		ip = new IPEndPoint(IPAddress.Parse("192.168.1.120"), 12346);
		socket.SendTo(Encoding.ASCII.GetBytes(message), ip);
		UnityEngine.Debug.Log("Stopping Client.");
		socket.Close();
	}

	private void OnGUI()
	{
		GUILayout.BeginHorizontal();
		GUILayout.Label("端口号", GUILayout.Width(40f), GUILayout.Height(buttonHight));
		_point = int.Parse(GUILayout.TextField(_point.ToString(), GUILayout.Width(60f), GUILayout.Height(buttonHight)));
		if (GUILayout.Button("监听", GUILayout.Height(buttonHight)))
		{
			StopListening();
			ip = new IPEndPoint(IPAddress.Any, _point);
			newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			newsock.Bind(ip);
			UnityEngine.Debug.Log("This is a Server,host name is " + Dns.GetHostName());
			UnityEngine.Debug.Log("Waiting for a client");
			_thread = new Thread(BeginListening);
			_thread.Start();
		}
		if (GUILayout.Button("停止", GUILayout.Height(buttonHight)))
		{
			StopListening();
		}
		if (GUILayout.Button("清理", GUILayout.Height(buttonHight)))
		{
			_dataList.Clear();
		}
		GUILayout.Button("Count " + _dataList.Count, GUILayout.Height(buttonHight), GUILayout.Width(140f));
		GUILayout.EndHorizontal();
		GUILayout.Space(10f);
		startScrollPos = GUILayout.BeginScrollView(startScrollPos, GUILayout.Width(Screen.width), GUILayout.Height((float)Screen.height - 2f * buttonHight));
		for (int num = _dataList.Count; num > 0; num--)
		{
			string text = _dataList[num - 1];
			if (!(text == "") && text != null && text.Length >= 1)
			{
				if (text.Contains("Debug:LogError(Object)"))
				{
					_labelStyle.normal.textColor = Color.red;
				}
				else if (text.Contains("Debug:LogWarning(Object)"))
				{
					_labelStyle.normal.textColor = Color.yellow;
				}
				else
				{
					_labelStyle.normal.textColor = Color.white;
				}
				GUILayout.Label(text, _labelStyle);
			}
		}
		GUILayout.EndScrollView();
	}

	private void OnApplicationQuit()
	{
		StopListening();
	}

	private void StopListening()
	{
		_dataList.Clear();
		if (_thread != null)
		{
			_thread.Abort();
		}
		if (newsock != null)
		{
			newsock.Close();
		}
	}
}
namespace DG.Tweening;

public static class DOTweenModulePhysics
{
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(endValue, 0f, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, endValue, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, 0f, endValue), duration);
		tweenerCore.SetOptions(AxisConstraint.Z, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(() => target.rotation, target.MoveRotation, endValue, duration);
		tweenerCore.SetTarget(target);
		tweenerCore.plugOptions.rotateMode = mode;
		return tweenerCore;
	}

	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
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

	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(() => target.alpha, delegate(float x)
		{
			target.alpha = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.To(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.ToAlpha(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.To(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.ToAlpha(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		if (endValue > 1f)
		{
			endValue = 1f;
		}
		else if (endValue < 0f)
		{
			endValue = 0f;
		}
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(() => target.fillAmount, delegate(float x)
		{
			target.fillAmount = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
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
		sequence.SetTarget(target);
		return sequence;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => new Vector2(target.flexibleWidth, target.flexibleHeight), delegate(Vector2 x)
		{
			target.flexibleWidth = x.x;
			target.flexibleHeight = x.y;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => new Vector2(target.minWidth, target.minHeight), delegate(Vector2 x)
		{
			target.minWidth = x.x;
			target.minHeight = x.y;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => new Vector2(target.preferredWidth, target.preferredHeight), delegate(Vector2 x)
		{
			target.preferredWidth = x.x;
			target.preferredHeight = x.y;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.To(() => target.effectColor, delegate(Color x)
		{
			target.effectColor = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.ToAlpha(() => target.effectColor, delegate(Color x)
		{
			target.effectColor = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.effectDistance, delegate(Vector2 x)
		{
			target.effectDistance = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
		{
			target.anchoredPosition = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
		{
			target.anchoredPosition = x;
		}, new Vector2(endValue, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition, delegate(Vector2 x)
		{
			target.anchoredPosition = x;
		}, new Vector2(0f, endValue), duration);
		tweenerCore.SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
		{
			target.anchoredPosition3D = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
		{
			target.anchoredPosition3D = x;
		}, new Vector3(endValue, 0f, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.X, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
		{
			target.anchoredPosition3D = x;
		}, new Vector3(0f, endValue, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.anchoredPosition3D, delegate(Vector3 x)
		{
			target.anchoredPosition3D = x;
		}, new Vector3(0f, 0f, endValue), duration);
		tweenerCore.SetOptions(AxisConstraint.Z, snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.anchorMax, delegate(Vector2 x)
		{
			target.anchorMax = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.anchorMin, delegate(Vector2 x)
		{
			target.anchorMin = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.pivot, delegate(Vector2 x)
		{
			target.pivot = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.pivot, delegate(Vector2 x)
		{
			target.pivot = x;
		}, new Vector2(endValue, 0f), duration);
		tweenerCore.SetOptions(AxisConstraint.X).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.pivot, delegate(Vector2 x)
		{
			target.pivot = x;
		}, new Vector2(0f, endValue), duration);
		tweenerCore.SetOptions(AxisConstraint.Y).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.sizeDelta, delegate(Vector2 x)
		{
			target.sizeDelta = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
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

	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(() => target.value, delegate(float x)
		{
			target.value = x;
		}, endValue, duration);
		tweenerCore.SetOptions(snapping).SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.To(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, CultureInfo culture = null)
	{
		CultureInfo cInfo = ((!addThousandsSeparator) ? null : (culture ?? CultureInfo.InvariantCulture));
		TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(() => fromValue, delegate(int x)
		{
			fromValue = x;
			target.text = (addThousandsSeparator ? fromValue.ToString("N0", cInfo) : fromValue.ToString());
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTween.ToAlpha(() => target.color, delegate(Color x)
		{
			target.color = x;
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
	{
		if (endValue == null)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogWarning("You can't pass a NULL string to DOText: an empty string will be used instead to avoid errors");
			}
			endValue = "";
		}
		TweenerCore<string, string, StringOptions> tweenerCore = DOTween.To(() => target.text, delegate(string x)
		{
			target.text = x;
		}, endValue, duration);
		tweenerCore.SetOptions(richTextEnabled, scrambleMode, scrambleChars).SetTarget(target);
		return tweenerCore;
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

	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		TweenerCore<Vector2, Vector2, CircleOptions> tweenerCore = DOTween.To(CirclePlugin.Get(), () => target.anchoredPosition, delegate(Vector2 x)
		{
			target.anchoredPosition = x;
		}, center, duration);
		tweenerCore.SetOptions(endValueDegrees, relativeCenter, snapping).SetTarget(target);
		return tweenerCore;
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
		sequence.SetTarget(target);
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
		sequence.SetTarget(target);
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

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		if (!target.HasProperty(propertyID))
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyID);
			}
			return null;
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.GetTextureOffset(propertyID), delegate(Vector2 x)
		{
			target.SetTextureOffset(propertyID, x);
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		if (!target.HasProperty(propertyID))
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyID);
			}
			return null;
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.GetTextureScale(propertyID), delegate(Vector2 x)
		{
			target.SetTextureScale(propertyID, x);
		}, endValue, duration);
		tweenerCore.SetTarget(target);
		return tweenerCore;
	}

	public static async Task AsyncWaitForCompletion(this Tween t)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active && !t.IsComplete())
			{
				await Task.Yield();
			}
		}
	}

	public static async Task AsyncWaitForRewind(this Tween t)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active && (!t.playedOnce || t.position * (float)(t.CompletedLoops() + 1) > 0f))
			{
				await Task.Yield();
			}
		}
	}

	public static async Task AsyncWaitForKill(this Tween t)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active)
			{
				await Task.Yield();
			}
		}
	}

	public static async Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active && t.CompletedLoops() < elapsedLoops)
			{
				await Task.Yield();
			}
		}
	}

	public static async Task AsyncWaitForPosition(this Tween t, float position)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active && t.position * (float)(t.CompletedLoops() + 1) < position)
			{
				await Task.Yield();
			}
		}
	}

	public static async Task AsyncWaitForStart(this Tween t)
	{
		if (!t.active)
		{
			if (DG.Tweening.Core.Debugger.logPriority > 0)
			{
				DG.Tweening.Core.Debugger.LogInvalidTween(t);
			}
		}
		else
		{
			while (t.active && !t.playedOnce)
			{
				await Task.Yield();
			}
		}
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
			return false;
		}

		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return target.GetComponent<Rigidbody>() != null;
		}

		[Preserve]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
		{
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> result = null;
			bool flag = false;
			if (tweenRigidbody)
			{
				Rigidbody component = target.GetComponent<Rigidbody>();
				if (component != null)
				{
					flag = true;
					result = (isLocal ? component.DOLocalPath(path, duration, pathMode) : component.DOPath(path, duration, pathMode));
				}
			}
			if (!flag)
			{
				result = (isLocal ? target.transform.DOLocalPath(path, duration, pathMode) : target.transform.DOPath(path, duration, pathMode));
			}
			return result;
		}
	}

	private static bool _initialized;

	[Preserve]
	public static void Init()
	{
		if (!_initialized)
		{
			_initialized = true;
			DOTweenExternalCommand.SetOrientationOnPath += Physics.SetOrientationOnPath;
		}
	}

	[Preserve]
	private static void Preserver()
	{
		AppDomain.CurrentDomain.GetAssemblies();
		typeof(MonoBehaviour).GetMethod("Stub");
	}
}
[AddComponentMenu("DOTween/DOTween Animation")]
public class DOTweenAnimation : ABSAnimationComponent
{
	public enum AnimationType
	{
		None,
		Move,
		LocalMove,
		Rotate,
		LocalRotate,
		Scale,
		Color,
		Fade,
		Text,
		PunchPosition,
		PunchRotation,
		PunchScale,
		ShakePosition,
		ShakeRotation,
		ShakeScale,
		CameraAspect,
		CameraBackgroundColor,
		CameraFieldOfView,
		CameraOrthoSize,
		CameraPixelRect,
		CameraRect,
		UIWidthHeight
	}

	public enum TargetType
	{
		Unset,
		Camera,
		CanvasGroup,
		Image,
		Light,
		RectTransform,
		Renderer,
		SpriteRenderer,
		Rigidbody,
		Rigidbody2D,
		Text,
		Transform,
		tk2dBaseSprite,
		tk2dTextMesh,
		TextMeshPro,
		TextMeshProUGUI
	}

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

	public bool autoGenerate = true;

	public bool isActive = true;

	public bool isValid;

	public Component target;

	public AnimationType animationType;

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

	public bool optionalBool1;

	public float optionalFloat0;

	public int optionalInt0;

	public RotateMode optionalRotationMode;

	public ScrambleMode optionalScrambleMode;

	public string optionalString;

	private bool _tweenAutoGenerationCalled;

	private int _playCount = -1;

	public static event Action<DOTweenAnimation> OnReset;

	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
		if (DOTweenAnimation.OnReset != null)
		{
			DOTweenAnimation.OnReset(anim);
		}
	}

	private void Awake()
	{
		if (isActive && autoGenerate && (animationType != AnimationType.Move || !useTargetAsV3))
		{
			CreateTween(regenerateIfExists: false, autoPlay);
			_tweenAutoGenerationCalled = true;
		}
	}

	private void Start()
	{
		if (!_tweenAutoGenerationCalled && isActive && autoGenerate)
		{
			CreateTween(regenerateIfExists: false, autoPlay);
			_tweenAutoGenerationCalled = true;
		}
	}

	private void Reset()
	{
		Dispatch_OnReset(this);
	}

	private void OnDestroy()
	{
		if (tween != null && tween.active)
		{
			tween.Kill();
		}
		tween = null;
	}

	public void RewindThenRecreateTween()
	{
		if (tween != null && tween.active)
		{
			tween.Rewind();
		}
		CreateTween(regenerateIfExists: true, andPlay: false);
	}

	public void RewindThenRecreateTweenAndPlay()
	{
		if (tween != null && tween.active)
		{
			tween.Rewind();
		}
		CreateTween(regenerateIfExists: true);
	}

	public void RecreateTween()
	{
		CreateTween(regenerateIfExists: true, andPlay: false);
	}

	public void RecreateTweenAndPlay()
	{
		CreateTween(regenerateIfExists: true);
	}

	public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
	{
		if (!isValid)
		{
			if (regenerateIfExists)
			{
				UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This DOTweenAnimation isn't valid and its tween won't be created", base.gameObject);
			}
			return;
		}
		if (tween != null)
		{
			if (tween.active)
			{
				if (!regenerateIfExists)
				{
					return;
				}
				tween.Kill();
			}
			tween = null;
		}
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
			targetType = forcedTargetType;
		}
		if (targetType == TargetType.Unset)
		{
			targetType = TypeToDOTargetType(target.GetType());
		}
		switch (animationType)
		{
		case AnimationType.Move:
			if (useTargetAsV3)
			{
				isRelative = false;
				if (endValueTransform == null)
				{
					UnityEngine.Debug.LogWarning($"{base.gameObject.name} :: This tween's TO target is NULL, a Vector3 of (0,0,0) will be used instead", base.gameObject);
					endValueV3 = Vector3.zero;
				}
				else if (targetType == TargetType.RectTransform)
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
			switch (targetType)
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
				tween = ((Transform)target).DOMove(endValueV3, duration, optionalBool0);
				break;
			}
			break;
		case AnimationType.LocalMove:
			tween = tweenGO.transform.DOLocalMove(endValueV3, duration, optionalBool0);
			break;
		case AnimationType.Rotate:
			switch (targetType)
			{
			case TargetType.Transform:
				tween = ((Transform)target).DORotate(endValueV3, duration, optionalRotationMode);
				break;
			case TargetType.Rigidbody:
				tween = ((Rigidbody)target).DORotate(endValueV3, duration, optionalRotationMode);
				break;
			case TargetType.Rigidbody2D:
				tween = ((Transform)target).DORotate(endValueV3, duration, optionalRotationMode);
				break;
			}
			break;
		case AnimationType.LocalRotate:
			tween = tweenGO.transform.DOLocalRotate(endValueV3, duration, optionalRotationMode);
			break;
		case AnimationType.Scale:
			_ = targetType;
			tween = tweenGO.transform.DOScale(optionalBool0 ? new Vector3(endValueFloat, endValueFloat, endValueFloat) : endValueV3, duration);
			break;
		case AnimationType.UIWidthHeight:
			tween = ((RectTransform)target).DOSizeDelta(optionalBool0 ? new Vector2(endValueFloat, endValueFloat) : endValueV2, duration);
			break;
		case AnimationType.Color:
			isRelative = false;
			switch (targetType)
			{
			case TargetType.Renderer:
				tween = ((Renderer)target).material.DOColor(endValueColor, duration);
				break;
			case TargetType.Light:
				tween = ((Light)target).DOColor(endValueColor, duration);
				break;
			case TargetType.Image:
				tween = ((Graphic)target).DOColor(endValueColor, duration);
				break;
			case TargetType.Text:
				tween = ((Text)target).DOColor(endValueColor, duration);
				break;
			}
			break;
		case AnimationType.Fade:
			isRelative = false;
			switch (targetType)
			{
			case TargetType.Renderer:
				tween = ((Renderer)target).material.DOFade(endValueFloat, duration);
				break;
			case TargetType.Light:
				tween = ((Light)target).DOIntensity(endValueFloat, duration);
				break;
			case TargetType.Image:
				tween = ((Graphic)target).DOFade(endValueFloat, duration);
				break;
			case TargetType.Text:
				tween = ((Text)target).DOFade(endValueFloat, duration);
				break;
			case TargetType.CanvasGroup:
				tween = ((CanvasGroup)target).DOFade(endValueFloat, duration);
				break;
			}
			break;
		case AnimationType.Text:
			if (targetType == TargetType.Text)
			{
				tween = ((Text)target).DOText(endValueString, duration, optionalBool0, optionalScrambleMode, optionalString);
			}
			break;
		case AnimationType.PunchPosition:
			switch (targetType)
			{
			case TargetType.Transform:
				tween = ((Transform)target).DOPunchPosition(endValueV3, duration, optionalInt0, optionalFloat0, optionalBool0);
				break;
			case TargetType.RectTransform:
				tween = ((RectTransform)target).DOPunchAnchorPos(endValueV3, duration, optionalInt0, optionalFloat0, optionalBool0);
				break;
			}
			break;
		case AnimationType.PunchScale:
			tween = tweenGO.transform.DOPunchScale(endValueV3, duration, optionalInt0, optionalFloat0);
			break;
		case AnimationType.PunchRotation:
			tween = tweenGO.transform.DOPunchRotation(endValueV3, duration, optionalInt0, optionalFloat0);
			break;
		case AnimationType.ShakePosition:
			switch (targetType)
			{
			case TargetType.Transform:
				tween = ((Transform)target).DOShakePosition(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool0, optionalBool1);
				break;
			case TargetType.RectTransform:
				tween = ((RectTransform)target).DOShakeAnchorPos(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool0, optionalBool1);
				break;
			}
			break;
		case AnimationType.ShakeScale:
			tween = tweenGO.transform.DOShakeScale(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool1);
			break;
		case AnimationType.ShakeRotation:
			tween = tweenGO.transform.DOShakeRotation(duration, endValueV3, optionalInt0, optionalFloat0, optionalBool1);
			break;
		case AnimationType.CameraAspect:
			tween = ((Camera)target).DOAspect(endValueFloat, duration);
			break;
		case AnimationType.CameraBackgroundColor:
			tween = ((Camera)target).DOColor(endValueColor, duration);
			break;
		case AnimationType.CameraFieldOfView:
			tween = ((Camera)target).DOFieldOfView(endValueFloat, duration);
			break;
		case AnimationType.CameraOrthoSize:
			tween = ((Camera)target).DOOrthoSize(endValueFloat, duration);
			break;
		case AnimationType.CameraPixelRect:
			tween = ((Camera)target).DOPixelRect(endValueRect, duration);
			break;
		case AnimationType.CameraRect:
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
		GameObject tweenTarget = GetTweenTarget();
		tween.SetTarget(tweenTarget).SetDelay(delay).SetLoops(loops, loopType)
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
		if (andPlay)
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

	public List<Tween> GetTweens()
	{
		List<Tween> list = new List<Tween>();
		DOTweenAnimation[] components = GetComponents<DOTweenAnimation>();
		foreach (DOTweenAnimation dOTweenAnimation in components)
		{
			if (dOTweenAnimation.tween != null && dOTweenAnimation.tween.active)
			{
				list.Add(dOTweenAnimation.tween);
			}
		}
		return list;
	}

	public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
	{
		if (TypeToDOTargetType(target.GetType()) != targetType)
		{
			UnityEngine.Debug.LogError("DOTweenAnimation ► SetAnimationTarget: the new target is of a different type from the one set in the Inspector");
			return;
		}
		target = tweenTarget;
		targetGO = target.gameObject;
		tweenTargetIsTargetGO = useTweenTargetGameObjectForGroupOperations;
	}

	public override void DOPlay()
	{
		DOTween.Play(GetTweenTarget());
	}

	public override void DOPlayBackwards()
	{
		DOTween.PlayBackwards(GetTweenTarget());
	}

	public override void DOPlayForward()
	{
		DOTween.PlayForward(GetTweenTarget());
	}

	public override void DOPause()
	{
		DOTween.Pause(GetTweenTarget());
	}

	public override void DOTogglePause()
	{
		DOTween.TogglePause(GetTweenTarget());
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

	public override void DORestart()
	{
		DORestart(fromHere: false);
	}

	public override void DORestart(bool fromHere)
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
		DOTween.Restart(GetTweenTarget());
	}

	public override void DOComplete()
	{
		DOTween.Complete(GetTweenTarget());
	}

	public override void DOKill()
	{
		DOTween.Kill(GetTweenTarget());
		tween = null;
	}

	public void DOPlayById(string id)
	{
		DOTween.Play(GetTweenTarget(), id);
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
		DOTween.PlayBackwards(GetTweenTarget(), id);
	}

	public void DOPlayBackwardsAllById(string id)
	{
		DOTween.PlayBackwards(id);
	}

	public void DOPlayForwardById(string id)
	{
		DOTween.PlayForward(GetTweenTarget(), id);
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
			if (dOTweenAnimation != null && dOTweenAnimation.tween != null && dOTweenAnimation.tween.active && !dOTweenAnimation.tween.IsPlaying() && !dOTweenAnimation.tween.IsComplete())
			{
				dOTweenAnimation.tween.Play();
				break;
			}
		}
	}

	public void DORewindAndPlayNext()
	{
		_playCount = -1;
		DOTween.Rewind(GetTweenTarget());
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
		DOTween.Restart(GetTweenTarget(), id);
	}

	public void DORestartAllById(string id)
	{
		_playCount = -1;
		DOTween.Restart(id);
	}

	public void DOKillById(string id)
	{
		DOTween.Kill(GetTweenTarget(), id);
	}

	public void DOKillAllById(string id)
	{
		DOTween.Kill(id);
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
		if (text == "RawImage" || text == "Graphic")
		{
			text = "Image";
		}
		return (TargetType)Enum.Parse(typeof(TargetType), text);
	}

	public Tween CreateEditorPreview()
	{
		if (Application.isPlaying)
		{
			return null;
		}
		CreateTween(regenerateIfExists: true, autoPlay);
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

	private GameObject GetTweenTarget()
	{
		if (!targetIsSelf && tweenTargetIsTargetGO)
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
		else if (animationType == AnimationType.Move)
		{
			((Tweener)tween).ChangeEndValue(tweenGO.transform.position + endValueV3, snapStartValue: true);
		}
		else if (animationType == AnimationType.LocalMove)
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
