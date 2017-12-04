using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

	public float weight;
	List<Collectable> inside = new List<Collectable>();
	public string pushButton;

	public void PushOut(){
		foreach(Collectable c in inside){
			c.GetComponent<Rigidbody>().AddForce(transform.up * 10, ForceMode.VelocityChange);
		}
	}

	public void Update() {
		if (Input.GetKeyDown(pushButton))
			PushOut();
	}

	private void OnTriggerEnter(Collider other) {
		Collectable c = other.GetComponentInParent<Collectable>();
		if (c != null){
			c.StartPossesion();

			inside.Add(c);

			weight += c.objectType.weight;
		}
	}
	private void OnTriggerExit(Collider other) {
		Collectable c = other.GetComponentInParent<Collectable>();
		if (c != null) {
			c.EndPossesion();

			inside.Remove(c);

			weight -= c.objectType.weight;
		}
	}
	private void OnTriggerStay(Collider other) {
		Collectable c = other.GetComponentInParent<Collectable>();
		if (c != null) {
			c.WhileInPossesion();
		}
	}
}
