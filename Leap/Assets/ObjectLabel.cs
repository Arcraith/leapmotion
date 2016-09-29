using UnityEngine;
using System.Collections;


[RequireComponent (typeof (GUIText))]
public class ObjectLabel : MonoBehaviour {
	public Transform target;
	public Vector3 offset = Vector3.up;
	public bool clampToScreen = false;
	public float clampBorderSize = 0.05f;
	public bool useMainCamera = true;
	public Camera cameraToUse;
	Camera cam;
	Transform thisTransform;
	Transform camTransform;

	void Start(){
		thisTransform = transform;
		if (useMainCamera)
			cam = Camera.main;
		else
			cam = cameraToUse;

		camTransform = cam.transform;
	}

	void Update(){
		if (clampToScreen) {
			Vector3 relativePosition = camTransform.InverseTransformPoint (target.position + offset);
			relativePosition.z = Mathf.Max (relativePosition.z, 1.0f);
			thisTransform.position = cam.WorldToViewportPoint (camTransform.TransformPoint (relativePosition));
			thisTransform.position = new Vector3 (Mathf.Clamp (thisTransform.position.x, clampBorderSize, 1.0f - clampBorderSize), Mathf.Clamp (thisTransform.position.y, clampBorderSize, 1.0f - clampBorderSize), thisTransform.position.z);

		} else {
			thisTransform.position = cam.WorldToViewportPoint (target.position + offset);
		}
	}
}
