using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Text score;
	public Text death;
	public PlayerInfo info;

	void Update () {
		score.text = info.score.ToString();
		death.text = info.killer;
	}
}
