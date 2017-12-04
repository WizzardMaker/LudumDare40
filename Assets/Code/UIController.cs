using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public Text height;
	public Text gold;
	public PlayerInfo info;

	// Update is called once per frame
	void Update () {
		height.text = info.height.ToString();
		gold.text = info.score.ToString();
	}
}
