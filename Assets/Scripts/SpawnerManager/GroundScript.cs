using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {
	public float forceX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vc3 = transform.position;
		vc3.x -= forceX * Time.deltaTime;
		transform.position = vc3;
	}
}
