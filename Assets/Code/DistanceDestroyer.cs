using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDestroyer : MonoBehaviour {
	public float distance;

	Transform player;

	private void Start() {
		PlayerController p = FindObjectOfType<PlayerController>();
		if (p != null)
			player = p.transform;
	}

	// Update is called once per frame
	void Update () {
		if (player == null)
			return;
		if (Vector3.Distance(transform.position, player.position) > distance)
			Destroy(gameObject);
	}
}
