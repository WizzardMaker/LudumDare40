using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	public bool xLock, zLock;

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;
		transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * speed);

		Vector3 t = transform.position;
		t.x = xLock ? 0 : t.x;
		t.z = zLock ? 0 : t.z;
		transform.position = t;
	}
}
