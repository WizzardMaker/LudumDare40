using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	public BaseObject objectType;

	Rigidbody rig;

	private void Start() {
		rig = GetComponent<Rigidbody>();
		rig.useGravity = false;
	}

	private void OnCollisionEnter(Collision collision) {
		rig.useGravity = true;
	}

	public void WhileInPossesion(){
		objectType.WhileInPossesion();
	}
	public void EndPossesion() {
		objectType.EndPossesion();
	}

	public void StartPossesion() {
		objectType.StartPossesion();
	}
}
