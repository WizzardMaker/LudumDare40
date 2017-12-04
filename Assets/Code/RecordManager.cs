using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Cooper Hewitt: The Typeface created by Chester Jenkins
public class RecordManager : MonoBehaviour {

	//public float distance;
	public GameObject recordMarker;

	public PlayerInfo info;

	public float distanceNeeded;
	public int steps = 1;
	public float stepSize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log((info.height-1) % (stepSize * (steps)));

		if(info.height > stepSize * steps){
			info.score += info.gold;//Mathf.Max(info.score, info.gold);
			steps++;
			Debug.Log("!");
			CreateMarker(steps * stepSize);
		}
	}

	void CreateMarker(float distance){
		GameObject m = Instantiate(recordMarker);
		m.GetComponentInChildren<TextMesh>().text = distance + "m";
		m.transform.position = Vector3.up * distance;
	}
}
