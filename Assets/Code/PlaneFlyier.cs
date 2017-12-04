using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFlyier : MonoBehaviour {
	public float speed;

	public Vector3 direction;
	public float swing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * swing);

		transform.position += transform.TransformDirection(direction) * speed * Time.deltaTime;
	}
}
