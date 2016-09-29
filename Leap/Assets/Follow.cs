using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	GameObject parent;
	public float x,y,z;

	// Use this for initialization
	void Start () {
		parent = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		// TODO: nur unter Bedingung: Component "fixed" attached

		this.transform.parent = parent.transform;
		this.transform.localPosition = new Vector3 (x, y, z);
	}
}
