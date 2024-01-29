using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
public class CameraFlyScript : MonoBehaviour
{
	public float mainSpeed;

	public float shiftAdd;

	public float maxShift;

	public float camSens;

	private Vector3 lastMouse;

	private float totalRun;

	public CameraFlyScript()
	{
		mainSpeed = 100f;
		shiftAdd = 250f;
		maxShift = 1000f;
		camSens = 0.25f;
		lastMouse = new Vector3(255f, 255f, 255f);
		totalRun = 1f;
	}

	public virtual void Update()
	{
		lastMouse = Input.mousePosition - lastMouse;
		lastMouse = new Vector3((0f - lastMouse.y) * camSens, lastMouse.x * camSens, 0f);
		lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0f);
		transform.eulerAngles = lastMouse;
		lastMouse = Input.mousePosition;
		float num = 0f;
		Vector3 vector = GetBaseInput();
		if (Input.GetKey(KeyCode.LeftShift))
		{
			totalRun += Time.deltaTime;
			vector = vector * totalRun * shiftAdd;
			vector.x = Mathf.Clamp(vector.x, 0f - maxShift, maxShift);
			vector.y = Mathf.Clamp(vector.y, 0f - maxShift, maxShift);
			vector.z = Mathf.Clamp(vector.z, 0f - maxShift, maxShift);
		}
		else
		{
			totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
			vector *= mainSpeed;
		}
		vector *= Time.deltaTime;
		if (Input.GetKey(KeyCode.Space))
		{
			num = transform.position.y;
			transform.Translate(vector);
			float y = num;
			Vector3 position = transform.position;
			float num2 = (position.y = y);
			Vector3 vector3 = (transform.position = position);
		}
		else
		{
			transform.Translate(vector);
		}
	}

	private Vector3 GetBaseInput()
	{
		Vector3 result = default(Vector3);
		if (Input.GetKey(KeyCode.W))
		{
			result += new Vector3(0f, 0f, 1f);
		}
		if (Input.GetKey(KeyCode.S))
		{
			result += new Vector3(0f, 0f, -1f);
		}
		if (Input.GetKey(KeyCode.A))
		{
			result += new Vector3(-1f, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			result += new Vector3(1f, 0f, 0f);
		}
		return result;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class ViralFollower : MonoBehaviour
{
	private bool canMakeBonds;

	private ViralLeader leader;

	private Transform me;

	public float breakForce;

	private float bondHealth;

	[HideInInspector]
	public bool bonded;

	[HideInInspector]
	public int bondId;

	public TextMesh Hp;

	public ViralFollower()
	{
		canMakeBonds = true;
		breakForce = 50f;
	}

	public virtual void Start()
	{
		me = transform;
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public virtual void Update()
	{
		if (bonded)
		{
			canMakeBonds = ViralLeader.followerBonding;
			if (!GetComponent<Rigidbody>() || GetComponent<Rigidbody>().velocity != Vector3.zero)
			{
			}
			if (!(bondHealth > 0f))
			{
				leader.RemoveMe(bondId);
			}
		}
	}

	public virtual void BreakBond(float externalForce)
	{
		if (bonded)
		{
			if (!(externalForce < breakForce))
			{
				leader.RemoveMe(bondId);
			}
			else
			{
				bondHealth -= externalForce;
			}
			if ((bool)Hp)
			{
				Hp.text = bondHealth.ToString();
			}
		}
	}

	public virtual void RemoveMe()
	{
		Debug.Log("Removed : " + bondId);
		bondHealth = 0f;
		bonded = false;
		if ((bool)Hp)
		{
			Hp.text = bondHealth.ToString();
		}
	}

	public virtual void MakeBond(int id)
	{
		bondHealth = 100f;
		bondId = id;
		bonded = true;
		if ((bool)Hp)
		{
			Hp.text = bondHealth.ToString();
		}
	}

	public virtual void OnCollisionEnter(Collision obj)
	{
		if (bonded && obj.collider.transform.tag == "Follower" && canMakeBonds)
		{
			leader.BondThis(obj.transform);
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum bondType
{
	constant,
	delayed
}
[Serializable]
public class ViralLeader : MonoBehaviour
{
	public bool normalizeScale;

	public bondType Type;

	public bool canBreakFollowers;

	public bool followersCanBreak;

	public bool followersCanBond;

	public bool followersBreakWithParent;

	[NonSerialized]
	public static bool followerBonding = true;

	public int maxFollowers;

	public System.Collections.Generic.List<GameObject> followers;

	[NonSerialized]
	public static bool editingList;

	private Vector3 moveDirection;

	public float moveSpeed;

	public float turnSpeed;

	public float followersLinearSpeed;

	[NonSerialized]
	public static Transform last;

	private Transform me;

	public Transform indicator;

	public float indicatorOffset;

	public float bondDistance;

	public float bondDamping;

	public float vDirection;

	public float hDirection;

	private Quaternion wantedRotation;

	private Quaternion currentRotation;

	private float wantedRotationAngle;

	private float currentRotationAngle;

	private Vector3 wantedPosition;

	private bool isMoving;

	public ViralLeader()
	{
		Type = bondType.delayed;
		canBreakFollowers = true;
		followersCanBreak = true;
		maxFollowers = 10;
		followers = new System.Collections.Generic.List<GameObject>();
		moveSpeed = 10f;
		turnSpeed = 5f;
		followersLinearSpeed = 5f;
		indicatorOffset = 0.5f;
		bondDistance = 2f;
		bondDamping = 3f;
	}

	public virtual Transform ReturnLast()
	{
		return (followers.Count <= 0) ? me : followers[followers.Count - 1].transform;
	}

	public virtual void Start()
	{
		me = transform;
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public virtual bool Controller()
	{
		moveDirection = Vector3.zero;
		moveDirection = new Vector3(0f, 0f, vDirection);
		me.Translate(moveDirection * Time.deltaTime * moveSpeed);
		me.Rotate(Vector3.up * Time.deltaTime * hDirection * 100f * turnSpeed);
		return Mathf.Abs(hDirection + vDirection) > 0f;
	}

	public virtual void Update()
	{
		isMoving = Controller();
		Transform transform = null;
		Transform transform2 = null;
		Vector3 position = this.transform.position;
		Vector3 zero = Vector3.zero;
		for (int i = 0; i < followers.Count; i++)
		{
			transform = ((i != 0) ? followers[i - 1].transform : this.transform);
			transform2 = followers[i].transform;
			if (Type == bondType.constant)
			{
				ConstantMovement(transform, transform2);
			}
			else if (Type == bondType.delayed)
			{
				DelayedMovement(transform, transform2);
			}
		}
	}

	private void ConstantMovement(Transform prevFollower, Transform follower)
	{
		wantedRotationAngle = prevFollower.eulerAngles.y;
		currentRotationAngle = follower.transform.eulerAngles.y;
		currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, bondDamping * Time.deltaTime);
		currentRotation = Quaternion.Euler(0f, currentRotationAngle, 0f);
		follower.transform.position = prevFollower.position;
		follower.transform.position = follower.transform.position - currentRotation * Vector3.forward * bondDistance;
		follower.transform.LookAt(prevFollower);
	}

	private void DelayedMovement(Transform prevFollower, Transform follower)
	{
		wantedPosition = prevFollower.TransformPoint(0f, 0f, 0f - bondDistance);
		follower.transform.position = Vector3.Lerp(follower.transform.position, wantedPosition, Time.deltaTime * bondDamping);
		wantedRotation = Quaternion.LookRotation(prevFollower.position - follower.transform.position, prevFollower.up);
		follower.transform.rotation = Quaternion.Slerp(follower.transform.rotation, wantedRotation, Time.deltaTime * bondDamping);
	}

	public virtual void OnCollisionEnter(Collision obj)
	{
		if (!(obj.collider.transform.tag == "Follower"))
		{
			return;
		}
		if (!followers.Contains(obj.gameObject))
		{
			Debug.Log("Collided With : " + obj.gameObject.name + " : " + Time.time);
			if (followers.Count < maxFollowers)
			{
				BondThis(obj.gameObject.transform);
			}
		}
		else if (canBreakFollowers)
		{
			RemoveMe(((ViralFollower)obj.gameObject.GetComponent(typeof(ViralFollower))).bondId);
		}
	}

	public virtual void BondThis(Transform obj)
	{
		if (!followers.Contains(obj.gameObject) && followers.Count < maxFollowers && !editingList)
		{
			editingList = true;
			((ViralFollower)obj.gameObject.GetComponent(typeof(ViralFollower))).MakeBond(followers.Count);
			followers.Add(obj.gameObject);
			editingList = false;
		}
	}

	public virtual void RemoveMe(int id)
	{
		if (!followersCanBreak || editingList)
		{
			return;
		}
		editingList = true;
		if (followersBreakWithParent)
		{
			for (int num = followers.Count - 1; num > 0; num--)
			{
				ViralFollower viralFollower = (ViralFollower)followers[num].GetComponent(typeof(ViralFollower));
				viralFollower.RemoveMe();
				followers.RemoveAt(num);
				if (viralFollower.bondId == id)
				{
					break;
				}
			}
		}
		else
		{
			for (int num2 = followers.Count - 1; num2 > 0; num2--)
			{
				ViralFollower viralFollower = (ViralFollower)followers[num2].GetComponent(typeof(ViralFollower));
				if (viralFollower.bondId == id)
				{
					viralFollower.RemoveMe();
					followers.RemoveAt(num2);
					break;
				}
			}
		}
		editingList = false;
	}

	public virtual void RemoveAll()
	{
		editingList = true;
		for (int num = followers.Count - 1; num > 0; num--)
		{
			((ViralFollower)followers[num].GetComponent(typeof(ViralFollower))).RemoveMe();
			followers.RemoveAt(num);
		}
		editingList = false;
	}

	public virtual void MustBreak()
	{
		followersCanBreak = true;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class SchoolBubbles : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class $Start$9 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int $i$10;

			internal SchoolBubbles $self_$11;

			public $(SchoolBubbles self_)
			{
				$self_$11 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if ((bool)$self_$11.transform.parent && $self_$11._bubbleMultiplier > 0)
					{
						for ($i$10 = default(int); $i$10 < $self_$11._bubbleMultiplier; $i$10++)
						{
							UnityEngine.Object.Instantiate($self_$11.gameObject);
						}
					}
					if (!$self_$11.transform.parent)
					{
						$self_$11.CancelInvoke();
					}
					$self_$11.InvokeRepeating("Emit", $self_$11._emitEverySecond, $self_$11._emitEverySecond);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SchoolBubbles $self_$12;

		public $Start$9(SchoolBubbles self_)
		{
			$self_$12 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new $($self_$12);
		}
	}

	public SchoolController _controller;

	public ParticleSystem _bubbleParticles;

	public float _emitEverySecond;

	public int _bubbleMultiplier;

	public float _speedEmitMultiplier;

	public SchoolBubbles()
	{
		_emitEverySecond = 0.01f;
		_speedEmitMultiplier = 0.25f;
	}

	public virtual IEnumerator Start()
	{
		return new $Start$9(this).GetEnumerator();
	}

	public virtual void Emit()
	{
		int index = Random.Range(0, _controller._roamers.length - 1);
		SchoolChild schoolChild = _controller._roamers[index] as SchoolChild;
		_bubbleParticles.transform.rotation = schoolChild.transform.rotation;
		_bubbleParticles.transform.position = schoolChild.transform.position;
		_bubbleParticles.Emit((int)(schoolChild._speed * _speedEmitMultiplier));
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class fps : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	public fps()
	{
		updateInterval = 0.5f;
	}

	public virtual void Start()
	{
		if (!GetComponent<GUIText>())
		{
			MonoBehaviour.print("FramesPerSecond needs a GUIText component!");
			enabled = false;
		}
		else
		{
			timeleft = updateInterval;
		}
	}

	public virtual void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale / Time.deltaTime;
		frames++;
		if (!(timeleft > 0f))
		{
			GetComponent<GUIText>().text = string.Empty + (accum / (float)frames).ToString("f2");
			timeleft = updateInterval;
			accum = 0f;
			frames = 0;
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum option
{
	PerDuration,
	PerSecond
}
[Serializable]
public class DisplayFPS : MonoBehaviour
{
	public option PerSecond;

	private int fps;

	private int fpsCount;

	private float sec;

	public float duration;

	private float lastTime;

	public GUIStyle style;

	public DisplayFPS()
	{
		PerSecond = option.PerSecond;
		duration = 0.1f;
	}

	public virtual void Update()
	{
		if (PerSecond == option.PerSecond)
		{
			sec += Time.deltaTime;
			if (!(sec < 1f * Time.timeScale))
			{
				sec = 0f;
				fps = fpsCount;
				fpsCount = 0;
			}
			fpsCount++;
		}
		else if (!(lastTime < duration))
		{
			fpsCount = 0;
			sec = 0f;
			while (sec < 1f * Time.timeScale)
			{
				sec += Time.deltaTime;
				fpsCount++;
			}
			fps = fpsCount;
			lastTime = 0f;
		}
		else
		{
			lastTime += Time.deltaTime;
		}
	}

	public virtual void OnGUI()
	{
		float x = (float)Screen.width * 0.85f;
		int num = 10;
		GUI.Label(new Rect(x, num, 100f, 100f), "fps: " + fps, style);
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class WaveTest : MonoBehaviour
{
	public float scale;

	public float speed;

	public float noiseStrength;

	public float noiseWalk;

	public bool changeAxis;

	private Vector3[] baseHeight;

	public WaveTest()
	{
		scale = 10f;
		speed = 1f;
		noiseStrength = 4f;
		noiseWalk = 1f;
	}

	public virtual void Update()
	{
		Mesh mesh = ((MeshFilter)GetComponent(typeof(MeshFilter))).mesh;
		if (baseHeight == null)
		{
			baseHeight = mesh.vertices;
		}
		Vector3[] array = new Vector3[baseHeight.Length];
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 vector = baseHeight[i];
			if (!changeAxis)
			{
				vector.y += Mathf.Sin(Time.time * speed + baseHeight[i].x + baseHeight[i].y + baseHeight[i].z) * scale;
				vector.y += Mathf.PerlinNoise(baseHeight[i].x + noiseWalk, baseHeight[i].y + Mathf.Sin(Time.time * 0.1f)) * noiseStrength;
				array[i] = vector;
			}
			else
			{
				vector.z += Mathf.Sin(Time.time * speed + baseHeight[i].x + baseHeight[i].y + baseHeight[i].z) * scale;
				vector.z += Mathf.PerlinNoise(baseHeight[i].x + noiseWalk, baseHeight[i].y + Mathf.Sin(Time.time * 0.1f)) * noiseStrength;
				array[i] = vector;
			}
		}
		mesh.vertices = array;
		mesh.RecalculateNormals();
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class FPSCounter : MonoBehaviour
{
	public float updateInterval;

	public int x_location;

	public int y_location;

	private double lastInterval;

	private int frames;

	private float fps;

	public FPSCounter()
	{
		updateInterval = 0.5f;
		x_location = 5;
		y_location = 5;
	}

	public virtual void Awake()
	{
		useGUILayout = false;
	}

	public virtual void OnGUI()
	{
		GUI.Label(new Rect(Screen.width - x_location, Screen.height - y_location, 100f, 30f), "FPS: " + fps.ToString("f2"));
	}

	public virtual void Start()
	{
		lastInterval = Time.realtimeSinceStartup;
		frames = 0;
	}

	public virtual void Update()
	{
		frames++;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (!((double)realtimeSinceStartup <= lastInterval + (double)updateInterval))
		{
			fps = (float)((double)frames / ((double)realtimeSinceStartup - lastInterval));
			frames = 0;
			lastInterval = realtimeSinceStartup;
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class WavingAnimation Script : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Vector4 vector = GetComponent<Renderer>().material.GetVector("_WaveAndDistance");
		float w = vector.w;
		vector.x += Time.deltaTime * 0.1f * w;
		vector.y -= Time.deltaTime * 0.1f * w;
		GetComponent<Renderer>().material.SetVector("_WaveAndDistance", new Vector4(vector.x, vector.y, vector.z, vector.w));
	}

	public virtual void Main()
	{
	}
}
