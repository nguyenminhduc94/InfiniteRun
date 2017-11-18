using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	// Use this for initialization
	public float forceX;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vc3 = transform.position;
		vc3.x -= forceX * Time.deltaTime;
		transform.position = vc3;
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player" && RobotBoyRun.instance != null){
			Destroy (gameObject);
			RobotBoyRun.instance.score++;
		}
	}
}
