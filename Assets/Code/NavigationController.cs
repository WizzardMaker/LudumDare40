using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationController : MonoBehaviour {

	public PlayerInfo info;

	// Use this for initialization
	public void StartGame () {
		info.Reset();
		SceneManager.LoadScene("test");
	}

	public void HowToPlay() {
		SceneManager.LoadScene("HTP");
	}

	public void Exit(){
		Application.Quit();
	}
}
