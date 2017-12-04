using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public PlayerInfo info;


	public float startTime;

	public float speed, boostSpeed, boostAcc;
	float boosted;

	public float turnAmount, turnSpeed;
	public float deathAngle = 80;
	float turned;

	public float crashSpeed;

	bool hasStarted;

	Rigidbody rig;

	public float weightMultiplier;

	List<Collector> collector = new List<Collector>();

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();

		collector.AddRange(GetComponentsInChildren<Collector>());

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		info.height = transform.position.y;

		float extraTurn = 0;
		foreach (Collector c in collector){
			float sign = Vector3.Dot(transform.right, transform.position - c.transform.position);

			extraTurn += c.weight * weightMultiplier * sign;
		}

		if(turned > deathAngle || turned < -deathAngle){
			Kill("Self Destruction Sequence - Angle too steep");
		}

		if (hasStarted) {
			//Vector3 turn = Vector3.right * //Input.GetAxis("Horizontal");

			turned += Input.GetAxis("Horizontal") * turnSpeed + extraTurn;

			float crashAcc = 0;
			if (turned > 45 || turned < -45) {
				turned += crashSpeed * (turned * 0.15f);
				crashAcc = crashSpeed * ((turned -20) * 1) * Mathf.Sign(turned);
			}

			turned = Mathf.Clamp(turned * Mathf.Sign(turned), 0, 180) * Mathf.Sign(turned);
			//turned = Mathf.Lerp(turned, !Input.GetButton("Horizontal") ? 0 : turnAmount * -Input.GetAxis("Horizontal"), Time.deltaTime * turnSpeed);
			Vector3 turn = Vector3.forward * turned;//Input.GetAxis("Horizontal");
			transform.rotation = Quaternion.Euler(turn);

			boosted = Mathf.Lerp(boosted, !Input.GetButton("Vertical") ? 1 : boostSpeed, Time.deltaTime * (!Input.GetButton("Vertical") ? 2 : boostAcc));

			rig.MovePosition(transform.position + (transform.up * (speed + crashAcc) * boosted * Time.deltaTime));
			//cc.Move(transform.up * speed * boosted * Time.deltaTime);

			info.speed = rig.velocity.magnitude;
		}else{
			hasStarted = Input.GetButton("Start");

			if (hasStarted) {
				GetComponent<AudioSource>().Play();
				startTime = Time.time;
			}
		}
	}

	public void Kill(Collideable killer) {
		PrepareGameOver();

		info.killer = killer.name;
		UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver");
	}

	private void PrepareGameOver() {
		Debug.LogError("Dead!");

		info.score = Mathf.Max(info.score, 1);
		info.score *= info.height;
		info.score -= (Time.time - startTime) * 0.5f;
		info.score = Mathf.Round(info.score);

		Destroy(gameObject);

	}

	public void Kill(string killer) {
		PrepareGameOver();

		info.killer = killer;
		UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver");
	}
}
