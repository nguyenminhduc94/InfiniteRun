using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {
	public float forceX;

	// Use this for initialization
	void Start () {
		Vector3 vc3 = transform.localScale;
		vc3.x = Random.Range (1.3f,2.5f);
		transform.localScale = vc3;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vc3 = transform.position;
		vc3.x -= forceX * Time.deltaTime;
		transform.position = vc3;
	}
}
