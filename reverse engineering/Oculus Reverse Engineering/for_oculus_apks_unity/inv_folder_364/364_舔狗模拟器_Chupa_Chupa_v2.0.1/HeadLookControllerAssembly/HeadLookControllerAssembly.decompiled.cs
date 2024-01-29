using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class CursorHit : MonoBehaviour
{
	public HeadLookController headLook;

	private float offset = 1.5f;

	private void LateUpdate()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			offset += Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			offset -= Time.deltaTime;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo))
		{
			base.transform.position = hitInfo.point + offset * Vector3.up;
		}
		headLook.target = base.transform.position;
	}
}
[Serializable]
public class BendingSegment
{
	public Transform firstTransform;

	public Transform lastTransform;

	public float thresholdAngleDifference;

	public float bendingMultiplier = 0.6f;

	public float maxAngleDifference = 30f;

	public float maxBendingAngle = 80f;

	public float responsiveness = 5f;

	internal float angleH;

	internal float angleV;

	internal Vector3 dirUp;

	internal Vector3 referenceLookDir;

	internal Vector3 referenceUpDir;

	internal int chainLength;

	internal Quaternion[] origRotations;
}
[Serializable]
public class NonAffectedJoints
{
	public Transform joint;

	public float effect;
}
public class HeadLookController : MonoBehaviour
{
	public Transform rootNode;

	public BendingSegment[] segments;

	public NonAffectedJoints[] nonAffectedJoints;

	public Vector3 headLookVector = Vector3.forward;

	public Vector3 headUpVector = Vector3.up;

	public Vector3 target = Vector3.zero;

	public float effect = 1f;

	public bool overrideAnimation;

	private void Start()
	{
		if (rootNode == null)
		{
			rootNode = base.transform;
		}
		BendingSegment[] array = segments;
		foreach (BendingSegment bendingSegment in array)
		{
			Quaternion quaternion = Quaternion.Inverse(bendingSegment.firstTransform.parent.rotation);
			bendingSegment.referenceLookDir = quaternion * rootNode.rotation * headLookVector.normalized;
			bendingSegment.referenceUpDir = quaternion * rootNode.rotation * headUpVector.normalized;
			bendingSegment.angleH = 0f;
			bendingSegment.angleV = 0f;
			bendingSegment.dirUp = bendingSegment.referenceUpDir;
			bendingSegment.chainLength = 1;
			Transform transform = bendingSegment.lastTransform;
			while (transform != bendingSegment.firstTransform && transform != transform.root)
			{
				bendingSegment.chainLength++;
				transform = transform.parent;
			}
			bendingSegment.origRotations = new Quaternion[bendingSegment.chainLength];
			transform = bendingSegment.lastTransform;
			for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
			{
				bendingSegment.origRotations[num] = transform.localRotation;
				transform = transform.parent;
			}
		}
	}

	private void LateUpdate()
	{
		if (Time.deltaTime == 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[nonAffectedJoints.Length];
		for (int i = 0; i < nonAffectedJoints.Length; i++)
		{
			{
				IEnumerator enumerator = nonAffectedJoints[i].joint.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						Transform transform = (Transform)enumerator.Current;
						array[i] = transform.position - nonAffectedJoints[i].joint.position;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		BendingSegment[] array2 = segments;
		foreach (BendingSegment bendingSegment in array2)
		{
			Transform transform2 = bendingSegment.lastTransform;
			if (overrideAnimation)
			{
				for (int num = bendingSegment.chainLength - 1; num >= 0; num--)
				{
					transform2.localRotation = bendingSegment.origRotations[num];
					transform2 = transform2.parent;
				}
			}
			Quaternion rotation = bendingSegment.firstTransform.parent.rotation;
			Quaternion quaternion = Quaternion.Inverse(rotation);
			Vector3 normalized = (target - bendingSegment.lastTransform.position).normalized;
			Vector3 vector = quaternion * normalized;
			float f = AngleAroundAxis(bendingSegment.referenceLookDir, vector, bendingSegment.referenceUpDir);
			Vector3 axis = Vector3.Cross(bendingSegment.referenceUpDir, vector);
			float f2 = AngleAroundAxis(vector - Vector3.Project(vector, bendingSegment.referenceUpDir), vector, axis);
			float f3 = Mathf.Max(0f, Mathf.Abs(f) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f);
			float f4 = Mathf.Max(0f, Mathf.Abs(f2) - bendingSegment.thresholdAngleDifference) * Mathf.Sign(f2);
			f = Mathf.Max(Mathf.Abs(f3) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f) - bendingSegment.maxAngleDifference) * Mathf.Sign(f) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f2 = Mathf.Max(Mathf.Abs(f4) * Mathf.Abs(bendingSegment.bendingMultiplier), Mathf.Abs(f2) - bendingSegment.maxAngleDifference) * Mathf.Sign(f2) * Mathf.Sign(bendingSegment.bendingMultiplier);
			f = Mathf.Clamp(f, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			f2 = Mathf.Clamp(f2, 0f - bendingSegment.maxBendingAngle, bendingSegment.maxBendingAngle);
			Vector3 axis2 = Vector3.Cross(bendingSegment.referenceUpDir, bendingSegment.referenceLookDir);
			bendingSegment.angleH = Mathf.Lerp(bendingSegment.angleH, f, Time.deltaTime * bendingSegment.responsiveness);
			bendingSegment.angleV = Mathf.Lerp(bendingSegment.angleV, f2, Time.deltaTime * bendingSegment.responsiveness);
			vector = Quaternion.AngleAxis(bendingSegment.angleH, bendingSegment.referenceUpDir) * Quaternion.AngleAxis(bendingSegment.angleV, axis2) * bendingSegment.referenceLookDir;
			Vector3 tangent = bendingSegment.referenceUpDir;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			Vector3 normal = vector;
			bendingSegment.dirUp = Vector3.Slerp(bendingSegment.dirUp, tangent, Time.deltaTime * 5f);
			Vector3.OrthoNormalize(ref normal, ref bendingSegment.dirUp);
			Quaternion b = rotation * Quaternion.LookRotation(normal, bendingSegment.dirUp) * Quaternion.Inverse(rotation * Quaternion.LookRotation(bendingSegment.referenceLookDir, bendingSegment.referenceUpDir));
			Quaternion quaternion2 = Quaternion.Slerp(Quaternion.identity, b, effect / (float)bendingSegment.chainLength);
			transform2 = bendingSegment.lastTransform;
			for (int k = 0; k < bendingSegment.chainLength; k++)
			{
				transform2.rotation = quaternion2 * transform2.rotation;
				transform2 = transform2.parent;
			}
		}
		for (int l = 0; l < nonAffectedJoints.Length; l++)
		{
			Vector3 vector2 = Vector3.zero;
			{
				IEnumerator enumerator = nonAffectedJoints[l].joint.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						vector2 = ((Transform)enumerator.Current).position - nonAffectedJoints[l].joint.position;
					}
				}
				finally
				{
					IDisposable disposable2 = enumerator as IDisposable;
					if (disposable2 != null)
					{
						disposable2.Dispose();
					}
				}
			}
			Vector3 toDirection = Vector3.Slerp(array[l], vector2, nonAffectedJoints[l].effect);
			nonAffectedJoints[l].joint.rotation = Quaternion.FromToRotation(vector2, toDirection) * nonAffectedJoints[l].joint.rotation;
		}
	}

	public static float AngleAroundAxis(Vector3 dirA, Vector3 dirB, Vector3 axis)
	{
		dirA -= Vector3.Project(dirA, axis);
		dirB -= Vector3.Project(dirB, axis);
		return Vector3.Angle(dirA, dirB) * (float)((!(Vector3.Dot(axis, Vector3.Cross(dirA, dirB)) < 0f)) ? 1 : (-1));
	}
}
public class HelpText : MonoBehaviour
{
	private void OnGUI()
	{
		GUILayout.Label("Move mouse to move look-at point");
		GUILayout.Label("Use up and down arrows to change height");
		GUILayout.Label("Left-drag to orbit camera");
		GUILayout.Label("Right-drag to zoom camera");
	}
}
public class OrbitCamera : MonoBehaviour
{
	public Transform target;

	public Transform cam;

	public Vector3 offset = Vector3.zero;

	private float cameraRotSide;

	private float cameraRotUp;

	private float cameraRotSideCur;

	private float cameraRotUpCur;

	private float distance;

	private void Start()
	{
		cameraRotSide = base.transform.eulerAngles.y;
		cameraRotSideCur = base.transform.eulerAngles.y;
		cameraRotUp = base.transform.eulerAngles.x;
		cameraRotUpCur = base.transform.eulerAngles.x;
		distance = 0f - cam.localPosition.z;
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			cameraRotSide += Input.GetAxis("Mouse X") * 5f;
			cameraRotUp -= Input.GetAxis("Mouse Y") * 5f;
		}
		cameraRotSideCur = Mathf.LerpAngle(cameraRotSideCur, cameraRotSide, Time.deltaTime * 5f);
		cameraRotUpCur = Mathf.Lerp(cameraRotUpCur, cameraRotUp, Time.deltaTime * 5f);
		if (Input.GetMouseButton(1))
		{
			distance *= 1f - 0.1f * Input.GetAxis("Mouse Y");
		}
		distance *= 1f - 1f * Input.GetAxis("Mouse ScrollWheel");
		Vector3 position = target.position;
		base.transform.position = Vector3.Lerp(base.transform.position, position + offset, Time.deltaTime);
		base.transform.rotation = Quaternion.Euler(cameraRotUpCur, cameraRotSideCur, 0f);
		float num = Mathf.Lerp(0f - cam.transform.localPosition.z, distance, Time.deltaTime * 5f);
		cam.localPosition = -Vector3.forward * num;
	}
}
