using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "SpawnerInfo.asset", menuName = "Spawner Info")]
public class SpawnerInfo : ScriptableObject {
	public float distanceAmount = 1;
	public float minimumDistance = 5;
	public float distance;

	public Vector3 spawnOffset;
	public float spawnWidth;
	public float spawnHeight;
	public GameObject[] objects;

	public void OnEnable() {
		distance = Random.Range(minimumDistance, distanceAmount);
	}

	public void Spawn(Transform player) {
		distance = Random.Range(player.position.y + minimumDistance, player.position.y + distanceAmount);

		Vector3 offset = new Vector3(Random.Range(-spawnWidth, spawnWidth), Random.Range(-spawnHeight, spawnHeight));

		int pos = Random.Range(0, objects.Length);
		GameObject g = Instantiate(objects[pos]);
		g.transform.position = player.position + spawnOffset + offset;
		g.name = objects[pos].name;
	}
}
