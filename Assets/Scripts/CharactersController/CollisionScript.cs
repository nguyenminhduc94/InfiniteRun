using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Ground" && RobotBoyRun.instance != null)
			RobotBoyRun.instance.anim.Play ("Jump");
	}
}
