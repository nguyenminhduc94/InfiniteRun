using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Score")
			Destroy (target.gameObject);
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Ground")
			Destroy (target.gameObject);
	}
}
