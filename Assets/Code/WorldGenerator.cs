using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {
	/*
		public GameObject[] clouds;
		public float distanceAmount = 1;
		float distance;

		public GameObject[] collectables;
		public float distanceAmountCollectable = 1;
		float distanceCollectable;

		public Vector3 spawnOffset;
		public Vector3 spawnOffsetCollectables;
		public float spawnWidth;
		public float spawnHeight;
		*/
	public Transform player;

	public SpawnerInfo[] spawner;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		foreach(SpawnerInfo s in spawner){
			if (s.distance < player.position.y) {
				s.Spawn(player);
			}
		}	
	/*
		if(distance < player.position.y){
			distance = Random.Range(player.position.y, player.position.y+ distanceAmount);

			Vector3 offset = new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(-spawnHeight, spawnHeight));

			GameObject g = Instantiate(clouds[Random.Range(0, clouds.Length)]);
			g.transform.position = player.position + spawnOffset + offset;
		}
		if (distanceCollectable < player.position.y) {
			distanceCollectable = Random.Range(player.position.y, player.position.y+ distanceAmountCollectable);

			Vector3 offset = new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(-spawnHeight, spawnHeight));

			GameObject g = Instantiate(collectables[Random.Range(0, collectables.Length)]);
			g.transform.position = player.position + spawnOffsetCollectables + offset;
		}*/
	}
}
