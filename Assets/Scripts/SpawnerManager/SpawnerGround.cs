using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGround : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private GameObject ground;

	void Start () {
		StartCoroutine (Clone());
	}
	
	// Update is called once per frame

	IEnumerator Clone(){
		yield return new WaitForSeconds (1);
		Vector3 vc3 = transform.position;
		vc3.y = Random.Range (-3f,2f);
		transform.position = vc3;
		Instantiate (ground, transform.position, Quaternion.identity);
		StartCoroutine (Clone());
	}
}
