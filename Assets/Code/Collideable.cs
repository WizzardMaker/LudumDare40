using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Collideable : MonoBehaviour {
	private void OnCollisionEnter(Collision collision) {
		PlayerController p = collision.collider.GetComponentInParent<PlayerController>();
		if(p != null) {
			p.Kill(this);
		}
	}
}
