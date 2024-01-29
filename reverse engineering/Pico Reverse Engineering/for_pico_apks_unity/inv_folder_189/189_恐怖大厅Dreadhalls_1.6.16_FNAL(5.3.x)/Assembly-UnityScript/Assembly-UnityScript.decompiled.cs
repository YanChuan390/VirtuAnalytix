using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
public class AnimatedTextureUV : MonoBehaviour
{
	public int uvAnimationTileX;

	public int uvAnimationTileY;

	public float framesPerSecond;

	public AnimatedTextureUV()
	{
		uvAnimationTileX = 5;
		uvAnimationTileY = 12;
		framesPerSecond = 10f;
	}

	public virtual void Update()
	{
		int num = (int)(Time.time * framesPerSecond);
		num %= uvAnimationTileX * uvAnimationTileY;
		Vector2 value = new Vector2(1f / (float)uvAnimationTileX, 1f / (float)uvAnimationTileY);
		int num2 = num % uvAnimationTileX;
		int num3 = num / uvAnimationTileX;
		Vector2 value2 = new Vector2((float)num2 * value.x, 1f - value.y - (float)num3 * value.y);
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", value2);
		GetComponent<Renderer>().material.SetTextureScale("_MainTex", value);
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class ClickToPlay : MonoBehaviour
{
	public virtual void OnMouseDown()
	{
		GetComponent<AudioSource>().Play();
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public class DemoUI : MonoBehaviour
{
	private string[] choices;

	public Response choice;

	public GameObject[] characters;

	public DemoUI()
	{
		choices = new string[5] { "Very Fast", "Fast", "Normal", "Slow", "Very Slow" };
		choice = Response.Normal;
	}

	public virtual void OnGUI()
	{
		GUI.Label(new Rect(30f, 5f, 100f, 100f), "Responsiveness");
		Response response = choice;
		choice = (Response)GUI.SelectionGrid(new Rect(25f, 25f, 100f, 100f), (int)choice, choices, 1);
		if (choice != response)
		{
			int i = 0;
			GameObject[] array = characters;
			for (int length = array.Length; i < length; i++)
			{
				array[i].BroadcastMessage("SetResponse", choice);
			}
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
public class SimpleSyncMove : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public Vector3 rangeMinimum;

	public Vector3 rangeMaximum;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncMove()
	{
		motionScale = 10f;
		rangeMinimum = new Vector3(0f, 0f, 0f);
		rangeMaximum = new Vector3(0f, -1f, 0f);
	}

	public virtual void Start()
	{
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		Vector3 vector = default(Vector3);
		Vector3 vector2 = rangeMaximum - rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		mouth.localPosition = vector;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum JawAxis
{
	X,
	Y,
	Z
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
[ExecuteInEditMode]
public class SimpleSyncRotation : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public float rangeMinimum;

	public float rangeMaximum;

	public Vector3 origRot;

	public JawAxis jawAxis;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncRotation()
	{
		motionScale = 10f;
		rangeMaximum = 1f;
		jawAxis = JawAxis.X;
	}

	public virtual void Start()
	{
		origRot = transform.localEulerAngles;
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		float num = default(float);
		float num2 = rangeMaximum - rangeMinimum;
		num = num2 * ssVolume.intensity * motionScale + rangeMinimum;
		switch (jawAxis)
		{
		case JawAxis.X:
			num += origRot.x;
			mouth.localEulerAngles = new Vector3(num, mouth.localEulerAngles.y, mouth.localEulerAngles.z);
			break;
		case JawAxis.Y:
			num += origRot.y;
			mouth.localEulerAngles = new Vector3(mouth.localEulerAngles.x, num, mouth.localEulerAngles.z);
			break;
		case JawAxis.Z:
			num += origRot.z;
			mouth.localEulerAngles = new Vector3(mouth.localEulerAngles.x, mouth.localEulerAngles.y, num);
			break;
		}
	}

	public virtual void Main()
	{
	}
}
[Serializable]
[RequireComponent(typeof(SimpleSyncVolume))]
public class SimpleSyncScale : MonoBehaviour
{
	public Transform mouth;

	public float motionScale;

	public Vector3 rangeMinimum;

	public Vector3 rangeMaximum;

	private SimpleSyncVolume ssVolume;

	public SimpleSyncScale()
	{
		motionScale = 10f;
		rangeMinimum = new Vector3(1f, 0.01f, 1f);
		rangeMaximum = Vector3.one;
	}

	public virtual void Start()
	{
		ssVolume = (SimpleSyncVolume)GetComponent(typeof(SimpleSyncVolume));
		if (!mouth)
		{
			mouth = transform;
		}
	}

	public virtual void Update()
	{
		Vector3 vector = default(Vector3);
		Vector3 vector2 = rangeMaximum - rangeMinimum;
		vector = vector2 * ssVolume.intensity * motionScale + rangeMinimum;
		mouth.localScale = vector;
	}

	public virtual void Main()
	{
	}
}
[Serializable]
public enum Response
{
	VeryFast,
	Fast,
	Normal,
	Slow,
	VerySlow
}
[Serializable]
[RequireComponent(typeof(AudioSource))]
public class SimpleSyncVolume : MonoBehaviour
{
	[HideInInspector]
	public float intensity;

	public Response response;

	public int micSampleRate;

	public int delay;

	private int winWidth;

	private float[] samples;

	public SimpleSyncVolume()
	{
		response = Response.Normal;
		micSampleRate = 44100;
		delay = 1;
		winWidth = 8192;
	}

	public virtual void Start()
	{
		SetResponse(response);
	}

	public virtual void SetResponse(Response r)
	{
		response = r;
		switch (r)
		{
		case Response.VeryFast:
			winWidth = 1024;
			break;
		case Response.Fast:
			winWidth = 2048;
			break;
		case Response.Normal:
			winWidth = 4096;
			break;
		case Response.Slow:
			winWidth = 8192;
			break;
		case Response.VerySlow:
			winWidth = 16384;
			break;
		}
		samples = new float[winWidth];
	}

	public virtual void Update()
	{
		if (!GetComponent<AudioSource>().isPlaying)
		{
			intensity = 0f;
			return;
		}
		float num = 10000000f;
		float num2 = -10000000f;
		GetComponent<AudioSource>().GetOutputData(samples, 0);
		float num3 = 0f;
		for (int i = 0; i < winWidth; i++)
		{
			float num4 = Mathf.Abs(samples[i]);
			if (!(num4 >= num))
			{
				num = num4;
			}
			if (!(num4 <= num2))
			{
				num2 = num4;
			}
			num3 += num4;
		}
		num3 /= (float)winWidth;
		intensity = num3;
	}

	public virtual void Main()
	{
	}
}
