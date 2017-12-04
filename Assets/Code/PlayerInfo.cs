using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Info")]
public class PlayerInfo : ScriptableObject{
	public float gold;
	public float score;
	public float height;

	public float speed;
	public string killer;

	public float fuel, maxFuel;

	public void Reset(){
		gold = 0;
		score = 0;

		fuel = maxFuel;
	}

	private void OnEnable() {
		Reset();
	}
}